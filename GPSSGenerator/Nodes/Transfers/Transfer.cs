using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.StreamDimension;

namespace GPSSGenerator.Nodes.Transfers
{
	class Transfer : Node
	{
		private List<float> probabilities;
		private List<StreamNode> nodes;

		

		public Transfer(string id, List<float> probabilities, List<StreamNode> nodes) : base(id)
		{
			this.probabilities = probabilities;
			this.nodes = nodes;
		}

		public override List<string> buildDescription(string idOfStream)
		{
			List<string> description = new List<string>();
			if(probabilities.Count == 1 && probabilities[0] == 1f)
			{
				description.Add(string.Format("TRANSFER ,{0}", nodes[0].Label));
			}
			else if(probabilities.Count == 2)
			{
				description.Add(string.Format("TRANSFER {0},{1},{2}", probabilities[0], nodes[1].Label, nodes[0].Label));
			}
			else
			{
				float remainingPersents = 1f;
				int i = 0;
				for (; i < (probabilities.Count - 2); i++)
				{
					float currPersent = probabilities[i] / remainingPersents;
					description.Add(string.Format("TRANSFER {0},,{1}", currPersent, nodes[i].Label));
					remainingPersents = remainingPersents - probabilities[i];
				}

				float lastPersent = probabilities[i] / remainingPersents;
				description.Add(string.Format("TRANSFER {0},{1},{2}", lastPersent, nodes[i+1].Label, nodes[i].Label));
				remainingPersents = remainingPersents - probabilities[i];
			}
			return description;
		}
	}
}
