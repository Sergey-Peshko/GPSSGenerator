using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.GlobalDimension;
using GPSSGenerator.StreamDimension;
using GPSSGenerator.Nodes.Facilities;
using GPSSGenerator.Nodes.Generators;
using GPSSGenerator.Nodes.Statistics;
using GPSSGenerator.Nodes.Terminates;
using GPSSGenerator.Nodes.Transfers;
using GPSSGenerator.Nodes;
using GPSSGenerator.Distributions;
using System.Xml;

namespace GPSSGenerator.ModelReaders
{
	public class XmlModelReader
	{
		static public GlobalModel Read(string path)
		{
			GlobalModel model = new GlobalModel();

			XmlDocument doc = new XmlDocument();
			doc.Load(path);

			XmlNode settings = doc.DocumentElement.SelectSingleNode("Settings");
			
			if (settings.Attributes["measure-lifecycle-by"]?.InnerText == "AmountOfTime")
			{
				model.Settings.AmountOfTime = Convert.ToInt32(settings.Attributes["value"]?.Value);
			}
			else if(settings.Attributes["measure-lifecycle-by"]?.InnerText == "NumberOfTransactions")
			{
				model.Settings.NumberOfTransactions = Convert.ToInt32(settings.Attributes["value"]?.Value);
			}
			else
			{
				throw new Exception("something wrong with settings of model");
			}

			XmlNodeList xmlEntities = doc.DocumentElement.SelectSingleNode("Entities").SelectNodes("Entity");
			XmlNodeList xmlDistributions = doc.DocumentElement.SelectSingleNode("Distributions").SelectNodes("Distribution");


			model.Nodes = CreateEntities(xmlEntities, xmlDistributions, model.Settings);

			XmlNodeList xmlStreams = doc.DocumentElement.SelectSingleNode("Streams").SelectNodes("Stream");

			model.StreamModels = CreateStreamModels(xmlStreams, model.Nodes);

			return model;
		}

		static private StreamModel[] CreateStreamModels(XmlNodeList xmlStreams, Entity[] allOriginalEntities)
		{
			StreamModel[] streamModels = new StreamModel[xmlStreams.Count];
			for(int i=0;i< xmlStreams.Count; i++)
			{
				streamModels[i] = CreateStreamModel(xmlStreams[i], allOriginalEntities);
			}
			return streamModels;
		}

		static private StreamModel CreateStreamModel(XmlNode xmlStream, Entity[] allOriginalEntities)
		{
			List<Node> streamNodes = new List<Node>();

			XmlNodeList movements = xmlStream.SelectNodes("movement");

			for (int i = 0; i < movements.Count; i++) 
			{
				string from = movements[i].Attributes["from"]?.Value;
				string to = movements[i].Attributes["to"]?.Value;

				if(!streamNodes.Exists(delegate (Node e) { return e.Id == from; }))
				{
					streamNodes.Add((Node)Array.Find(allOriginalEntities, delegate (Entity e) { return e.Id == from; }));
				}
				if (!streamNodes.Exists(delegate (Node e) { return e.Id == to; }))
				{
					streamNodes.Add((Node)Array.Find(allOriginalEntities, delegate (Entity e) { return e.Id == to; }));
				}
			}

			float[,] graph = new float[streamNodes.Count, streamNodes.Count];

			for (int i = 0; i < movements.Count; i++)
			{
				string from = movements[i].Attributes["from"]?.Value;
				string to = movements[i].Attributes["to"]?.Value;

				int index1 = streamNodes.FindIndex(delegate (Node e) { return e.Id == from; });
				int index2 = streamNodes.FindIndex(delegate (Node e) { return e.Id == to; });

				graph[index1, index2] = (float)Convert.ToDouble(movements[i].InnerText);
			}

			return new StreamModel(
				xmlStream.Attributes["id"]?.Value,
				streamNodes.ToArray(),
				graph
				);
		}

		static private Entity[] CreateEntities(XmlNodeList xmlEntities, XmlNodeList xmlDistributions, NetSettings settings)
		{
			IntervalStatistic netLevel = new IntervalStatistic("net_stat", "net");

			Entity[] entities = new Entity[xmlEntities.Count];

			for (int i = 0; i < xmlEntities.Count; i++)
			{
				entities[i] = CreateEntity(xmlEntities[i], netLevel, xmlDistributions, settings);
			}

			return entities;
		}

		static private Entity CreateEntity(XmlNode xmlEntity, IntervalStatistic netLevel, XmlNodeList xmlDistributions, NetSettings settings)
		{
			if (xmlEntity.Attributes["type"]?.Value == "ZGENERATOR")
			{

				return new ClosedGenerator(
					xmlEntity.Attributes["id"]?.Value,
					netLevel,
					Convert.ToInt32(findPropertyByAtribyteName(xmlEntity, "NumberOfTransactions").Attributes["value"]?.Value));
			}
			else if (xmlEntity.Attributes["type"]?.Value == "GENERATOR")
			{
				return new OpenGenerator(
					xmlEntity.Attributes["id"]?.Value,
					netLevel,
					CreateDistribution(
						findByIdInAttributes(
							xmlDistributions, 
							findPropertyByAtribyteName(xmlEntity, "Distribution").Attributes["ref"]?.Value))
							);
			}
			else if(xmlEntity.Attributes["type"]?.Value == "RECEIVER")
			{
				int count = Convert.ToInt32(findPropertyByAtribyteName(xmlEntity, "NumberOfTransactionsToBeDeleted").Attributes["value"]?.Value);
							
				if(settings.IsTime && count != 0)
				{
					throw new Exception("when you use time you can't put in receiver any value except 0");
				}

				return new Terminate(xmlEntity.Attributes["id"]?.Value,
					count,
					netLevel);
			}
			else if (xmlEntity.Attributes["type"]?.Value == "ONECHANNEL_FACILITY")
			{
				return new OneChannelFacility(
					xmlEntity.Attributes["id"]?.Value,
					CreateDistribution(
						findByIdInAttributes(
							xmlDistributions,
							findPropertyByAtribyteName(xmlEntity, "Distribution").Attributes["ref"]?.Value))
					);

			}
			else if (xmlEntity.Attributes["type"]?.Value == "MULTYCHANNEL_FACILITY")
			{
				return new MultyChannelFacility(
					xmlEntity.Attributes["id"]?.Value,
					CreateDistribution(
						findByIdInAttributes(
							xmlDistributions,
							findPropertyByAtribyteName(xmlEntity, "Distribution").Attributes["ref"]?.Value)),
					Convert.ToInt32(findPropertyByAtribyteName(xmlEntity, "Capacity").Attributes["value"]?.Value)
					);
			}
			else if (xmlEntity.Attributes["type"]?.Value == "INTERNAL_STATISTIC")
			{
				return new IntervalStatistic(
					xmlEntity.Attributes["id"]?.Value,
					findPropertyByAtribyteName(xmlEntity, "NameOfStatistic").Attributes["value"]?.Value
					);
			}

			else
				throw new Exception("can't create Node");
		}

		static private IDistribution CreateDistribution(XmlNode xmlDistribution)
		{
			if (xmlDistribution.Attributes["type"]?.Value == "EXPONENTIAL")
			{
				ExponentialDistribution ed = new ExponentialDistribution(
					Convert.ToInt32(findPropertyByAtribyteName(xmlDistribution, "GeneratorNumber").Attributes["value"]?.Value),
					(float)Convert.ToDouble(findPropertyByAtribyteName(xmlDistribution, "MathematicalExpectation").Attributes["value"]?.Value));
				return ed;
			}
			if (xmlDistribution.Attributes["type"]?.Value == "UNIFORM")
			{
				UniformDistribution d = new UniformDistribution(
					Convert.ToInt32(findPropertyByAtribyteName(xmlDistribution, "GeneratorNumber").Attributes["value"]?.Value),
					(float)Convert.ToDouble(findPropertyByAtribyteName(xmlDistribution, "A").Attributes["value"]?.Value),
					(float)Convert.ToDouble(findPropertyByAtribyteName(xmlDistribution, "B").Attributes["value"]?.Value));
				return d;
			}
			else
			{
				throw new Exception("can't create Distribution");
			}

		}

		static private XmlNode findByIdInAttributes(XmlNodeList list, string id)
		{
			for(int i = 0; i < list.Count; i++)
			{
				if(list[i].Attributes["id"]?.Value == id)
				{
					return list[i];
				}
			}
			return null;
		}

		static private XmlNode findPropertyByAtribyteName(XmlNode xmlEntity, string name)
		{
			XmlNodeList list = xmlEntity.SelectNodes("property");
			for (int i = 0; i < list.Count; i++)
			{
				if(list[i].Attributes["name"]?.Value == name)
				{
					return list[i];
				}
			}
			return null;
		}
	}
}
