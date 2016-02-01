using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonGenerator
{
    public class Data
    {

    }

    public class Tag
    {
        public string group { get; set; }
        public string tagName { get; set; }
        public string dryBulbTag { get; set; }
        public string absoluteHumidityTag { get; set; }
        public double dryBulbValue { get; set; }
        public double absoluteHumidityValue { get; set; }
        public bool showTagName { get; set; }

        public override string ToString()
        {
            return group + "-" + tagName;
        }
    }

    public class Process
    {
        public string name { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    public class RootObject
    {
        public List<Tag> tags { get; set; }
        public List<Process> process { get; set; }
    }

}
