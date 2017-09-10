using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.GlobalDimension;
using GPSSGenerator.StreamDimension;
using GPSSGenerator.Nodes.Facilities;
using GPSSGenerator.Nodes.Generators;
using GPSSGenerator.Nodes.Terminates;
using GPSSGenerator.Nodes.Transfers;
using GPSSGenerator.Nodes;
using GPSSGenerator.Nodes.Statistics;
using GPSSGenerator.Distributions;
using System.Xml;
using GPSSGenerator.Statistics;
using GPSSGenerator.DTO;

namespace GPSSGenerator.ModelReaders
{
	public class XmlModelReader
	{
		static public GlobalModel Read(XmlDocument doc)
		{
			GlobalModel model = new GlobalModel();

			XmlNode settings = doc.DocumentElement.SelectSingleNode("Settings");

			if (settings.Attributes["measure-lifecycle-by"]?.InnerText == "AmountOfTime")
			{
				model.Settings.AmountOfTime = Convert.ToInt32(settings.Attributes["value"]?.Value);
			}
			else if (settings.Attributes["measure-lifecycle-by"]?.InnerText == "NumberOfTransactions")
			{
				model.Settings.NumberOfTransactions = Convert.ToInt32(settings.Attributes["value"]?.Value);
			}
			else
			{
				throw new Exception("something wrong with settings of model");
			}

			XmlNodeList xmlEntities = doc.DocumentElement.SelectSingleNode("Entities").SelectNodes("Entity");

			model.Nodes = CreateEntities(xmlEntities, model.Settings);

			XmlNodeList xmlStats = doc.DocumentElement.SelectSingleNode("Statistics").SelectNodes("Statistic");

			model.Statistics = CreateStatistics(xmlStats);

			XmlNodeList xmlStreams = doc.DocumentElement.SelectSingleNode("Streams").SelectNodes("Stream");

			model.StreamModels = CreateStreamModels(xmlStreams, model.Nodes, model.Statistics);

			return model;
		}
		static public GlobalModel Read(string path)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(path);

			return Read(doc);
		}

		static private Statistic[] CreateStatistics(XmlNodeList xmlStats)
		{
			Statistic[] statistics = new Statistic[xmlStats.Count];

			for(int i = 0; i < xmlStats.Count; i++)
			{
				if(xmlStats[i].Attributes["type"]?.Value == GlobalVariables.INTERVAL_STATISTIC)
				{
					IntervalStatistic stat = new IntervalStatistic(xmlStats[i].Attributes["name"]?.Value);

					XmlNode tableParam = xmlStats[i].SelectSingleNode("TableParam");

					if (tableParam != null)
					{
						stat.TableParam = new TableParam();

						stat.TableParam.UpperBoundOfLowerFrequencyInterval = 
							Convert.ToInt32(tableParam.Attributes["UpperBoundOfLowerFrequencyInterval"]?.Value);
						stat.TableParam.IntervalWidth =
							Convert.ToInt32(tableParam.Attributes["IntervalWidth"]?.Value);
						stat.TableParam.NumberOfIntervals =
							Convert.ToInt32(tableParam.Attributes["NumberOfIntervals"]?.Value);

					}

					statistics[i] = stat;
				}
				else if(xmlStats[i].Attributes["type"]?.Value == GlobalVariables.ONEPOINT_STATISTIC)
				{
					OnePointStatistic stat = new OnePointStatistic(xmlStats[i].Attributes["name"]?.Value);

					XmlNode tableParam = xmlStats[i].SelectSingleNode("TableParam");

					if (tableParam != null)
					{
						stat.TableParam = new TableParam();

						stat.TableParam.UpperBoundOfLowerFrequencyInterval =
							Convert.ToInt32(tableParam.Attributes["UpperBoundOfLowerFrequencyInterval"]?.Value);
						stat.TableParam.IntervalWidth =
							Convert.ToInt32(tableParam.Attributes["IntervalWidth"]?.Value);
						stat.TableParam.NumberOfIntervals =
							Convert.ToInt32(tableParam.Attributes["NumberOfIntervals"]?.Value);

					}

					statistics[i] = stat;
				}
				else
				{
					throw new Exception("cant create statistic, unkonown type of statistic");
				}
			}

			return statistics;
		}
		static private StreamModel[] CreateStreamModels(XmlNodeList xmlStreams, Entity[] allOriginalEntities, Statistic[] allOriginalStatistics)
		{
			StreamModel[] streamModels = new StreamModel[xmlStreams.Count];

			for (int i=0;i< xmlStreams.Count; i++)
			{
				streamModels[i] = CreateStreamModel(xmlStreams[i], allOriginalEntities, allOriginalStatistics);
			}
			return streamModels;
		}

		static private StreamModel CreateStreamModel(XmlNode xmlStream, Entity[] allOriginalEntities, Statistic[] allOriginalStatistics)
		{
			List<Node> streamNodes = new List<Node>();

			XmlNodeList movements = xmlStream.SelectSingleNode("movements").SelectNodes("movement");

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

				XmlNodeList statistics = movements[i].SelectNodes("statistic");
				if (statistics.Count != 0)
				{
					for (int j = 0; j < statistics.Count; j++)
					{
						string refName = statistics[j].Attributes["ref"]?.Value;

						Statistic stat = Array.Find(allOriginalStatistics, delegate (Statistic s) { return s.NameOfStatistic == refName; });

						streamNodes.Add(CreateStreamStatisticNodeWrapper(
							String.Format(statistics[j].Attributes["id"]?.Value, stat.NameOfStatistic),
							stat
							));
					}
				}
			}

			float[,] graph = new float[streamNodes.Count, streamNodes.Count];

			for (int i = 0; i < movements.Count; i++)
			{
				string from = movements[i].Attributes["from"]?.Value;
				string to = movements[i].Attributes["to"]?.Value;

				XmlNodeList statistics = movements[i].SelectNodes("statistic");
				if (statistics.Count != 0)
				{
					int fromIndex = streamNodes.FindIndex(delegate (Node e) { return e.Id == from; });
					int firstStat = streamNodes.FindIndex(delegate (Node e) { return e.Id == statistics[0].Attributes["id"]?.Value; });

					graph[fromIndex, firstStat] = (float)Convert.ToDouble(movements[i].Attributes["value"]?.Value);

					int j = 0;
					for (; j < (statistics.Count - 1); j++) 
					{
						int index1 = streamNodes.FindIndex(delegate (Node e) { return e.Id == statistics[j].Attributes["id"]?.Value; });
						int index2 = streamNodes.FindIndex(delegate (Node e) { return e.Id == statistics[j+1].Attributes["id"]?.Value; });

						graph[index1, index2] = 1f;
					}

					int lastStat = streamNodes.FindIndex(delegate (Node e) { return e.Id == statistics[j].Attributes["id"]?.Value;  });
					int toIndex = streamNodes.FindIndex(delegate (Node e) { return e.Id == to; });

					graph[lastStat, toIndex] = 1f;

				}
				else
				{
					int index1 = streamNodes.FindIndex(delegate (Node e) { return e.Id == from; });
					int index2 = streamNodes.FindIndex(delegate (Node e) { return e.Id == to; });

					graph[index1, index2] = (float)Convert.ToDouble(movements[i].Attributes["value"]?.Value);
				}
			}

			ContainerForBeforAfterStatistic[] beforAfterStatistics = CreateBeforAfterStatisticArray(streamNodes, allOriginalStatistics.ToList(), xmlStream.SelectSingleNode("statistics"));

			return new StreamModel(
				xmlStream.Attributes["id"]?.Value,
				streamNodes.ToArray(),
				graph,
				beforAfterStatistics);
		}

		static private Entity[] CreateEntities(XmlNodeList xmlEntities, NetSettings settings)
		{
			IntervalStatistic netLevel = new IntervalStatistic("net");

			Entity[] entities = new Entity[xmlEntities.Count];

			for (int i = 0; i < xmlEntities.Count; i++)
			{
				entities[i] = CreateEntity(xmlEntities[i], netLevel, settings);
			}

			return entities;
		}

		static private Entity CreateEntity(XmlNode xmlEntity, IntervalStatistic netLevel, NetSettings settings)
		{
			if (xmlEntity.Attributes["type"]?.Value == GlobalVariables.ZGENERATOR)
			{

				return new ClosedGenerator(
					xmlEntity.Attributes["id"]?.Value,
					netLevel,
					Convert.ToInt32(getPropertyValueByName(xmlEntity, "NumberOfTransactions")));
			}
			else if (xmlEntity.Attributes["type"]?.Value == GlobalVariables.GENERATOR)
			{
				return new OpenGenerator(
					xmlEntity.Attributes["id"]?.Value,
					netLevel,
					CreateDistribution(xmlEntity.SelectSingleNode("Distribution")));
			}
			else if(xmlEntity.Attributes["type"]?.Value == GlobalVariables.RECEIVER)
			{
				int count = Convert.ToInt32(getPropertyValueByName(xmlEntity, "NumberOfTransactionsToBeDeleted"));
							
				if(settings.IsTime && count != 0)
				{
					throw new Exception("when you use time you can't put in receiver any value except 0");
				}

				return new Terminate(xmlEntity.Attributes["id"]?.Value,
					count,
					netLevel);
			}
			else if (xmlEntity.Attributes["type"]?.Value == GlobalVariables.ONECHANNEL_FACILITY)
			{
				return new OneChannelFacility(
					xmlEntity.Attributes["id"]?.Value,
					CreateDistribution(xmlEntity.SelectSingleNode("Distribution")));

			}
			else if (xmlEntity.Attributes["type"]?.Value == GlobalVariables.MULTYCHANNEL_FACILITY)
			{
				return new MultyChannelFacility(
					xmlEntity.Attributes["id"]?.Value,
					CreateDistribution(xmlEntity.SelectSingleNode("Distribution")),
					Convert.ToInt32(getPropertyValueByName(xmlEntity, "Capacity"))
					);
			}

			else
				throw new Exception("can't create Node");
		}

		static private IDistribution CreateDistribution(XmlNode xmlDistribution)
		{
			if (xmlDistribution.Attributes["type"]?.Value == GlobalVariables.EXPONENTIAL)
			{
				ExponentialDistribution ed = new ExponentialDistribution(
					Convert.ToInt32(getPropertyValueByName(xmlDistribution, "GeneratorNumber")),
					(float)Convert.ToDouble(getPropertyValueByName(xmlDistribution, "MathematicalExpectation")));
				return ed;
			}
			if (xmlDistribution.Attributes["type"]?.Value == GlobalVariables.UNIFORM)
			{
				UniformDistribution d = new UniformDistribution(
					Convert.ToInt32(getPropertyValueByName(xmlDistribution, "GeneratorNumber")),
					(float)Convert.ToDouble(getPropertyValueByName(xmlDistribution, "LowerBound")),
					(float)Convert.ToDouble(getPropertyValueByName(xmlDistribution, "UpperBound")));
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

		static private string getPropertyValueByName(XmlNode xmlEntity, string name)
		{
			return xmlEntity.SelectSingleNode(name).Attributes["value"]?.Value;
		}

		static private ContainerForBeforAfterStatistic[] CreateBeforAfterStatisticArray(List<Node>streamNodes, List<Statistic> allOriginalStatistics, XmlNode xmlStatistics)
		{
			List<ContainerForBeforAfterStatistic> list = new List<ContainerForBeforAfterStatistic>();

			XmlNodeList xmlStatisticList = xmlStatistics.SelectNodes("statistic");

			for (int i = 0; i < xmlStatisticList.Count; i++) 
			{
				if(!list.Exists(
					delegate (ContainerForBeforAfterStatistic obj) 
					{
						return (obj.Node.Id == xmlStatisticList[i].Attributes["after"]?.Value) || (obj.Node.Id == xmlStatisticList[i].Attributes["before"]?.Value);
					}))
				{
					ContainerForBeforAfterStatistic wrapper = new ContainerForBeforAfterStatistic();

					if (xmlStatisticList[i].Attributes["after"]?.Value != null)
					{
						wrapper.Node = streamNodes.Find(delegate (Node node) { return node.Id == xmlStatisticList[i].Attributes["after"]?.Value; });
						wrapper.After.Add(
							CreateStreamStatisticNodeWrapper(
								xmlStatisticList[i].Attributes["id"]?.Value,
								allOriginalStatistics.Find(
									delegate (Statistic obj)
									{
										return obj.NameOfStatistic == xmlStatisticList[i].Attributes["ref"]?.Value;
									})
								));
					}

					if (xmlStatisticList[i].Attributes["before"]?.Value != null)
					{
						wrapper.Node = streamNodes.Find(delegate (Node node) { return node.Id == xmlStatisticList[i].Attributes["before"]?.Value; });
						wrapper.Before.Add(
							CreateStreamStatisticNodeWrapper(
								xmlStatisticList[i].Attributes["id"]?.Value,
								allOriginalStatistics.Find(
									delegate (Statistic obj)
									{
										return obj.NameOfStatistic == xmlStatisticList[i].Attributes["ref"]?.Value;
									})));
					}

					list.Add(wrapper);
				}
				else
				{
					ContainerForBeforAfterStatistic wrapper; 

					if (xmlStatisticList[i].Attributes["after"]?.Value != "")
					{
						wrapper = list.Find(delegate (ContainerForBeforAfterStatistic obj) { return obj.Node.Id == xmlStatisticList[i].Attributes["after"]?.Value; });
						wrapper.After.Add(
							CreateStreamStatisticNodeWrapper(
								xmlStatisticList[i].Attributes["id"]?.Value,
								allOriginalStatistics.Find(
									delegate (Statistic obj) 
									{
										return obj.NameOfStatistic == xmlStatisticList[i].Attributes["ref"]?.Value;
									})));
					}

					if (xmlStatisticList[i].Attributes["before"]?.Value != "")
					{
						wrapper = list.Find(delegate (ContainerForBeforAfterStatistic obj) { return obj.Node.Id == xmlStatisticList[i].Attributes["after"]?.Value; });
						wrapper.Before.Add(
							CreateStreamStatisticNodeWrapper(
								xmlStatisticList[i].Attributes["id"]?.Value,
								allOriginalStatistics.Find(
									delegate (Statistic obj)
									{
										return obj.NameOfStatistic == xmlStatisticList[i].Attributes["ref"]?.Value;
									})));
					}
				}
			}

			return list.ToArray();
		}

		static private Node CreateStreamStatisticNodeWrapper(string id, Statistic stat)
		{
			if (stat is IntervalStatistic)
			{

				return (new IntervalStatisticNode(
					id,
					(IntervalStatistic)stat));

			}
			else if (stat is OnePointStatistic)
			{
				return (new OnePointStatisticNode(
					id,
					(OnePointStatistic)stat));
			}
			else
			{
				throw new Exception("error in stream stat description");
			}
		}

	}
}
