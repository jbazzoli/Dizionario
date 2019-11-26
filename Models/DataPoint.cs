using System;
using System.Runtime.Serialization;

namespace NeperiaDizionarioV2.Models
{
    public class DataPoint
    {
        public DataPoint(string label, double y)
		{
			this.label = label;
			this.y = y;
		}
 
		//Explicitly setting the name to be used while serializing to JSON.
		[DataMember(Name = "label")]
		public string label = null;
 
		//Explicitly setting the name to be used while serializing to JSON.
		[DataMember(Name = "y")]
		public Nullable<double> y = null;
    }
}