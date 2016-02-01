using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonParser
{
    public class OPCTag
    {
        public string Group { get; set; }

        public string TagName { get; set; }

        public string DryBulbTag { get; set; }

        public string AbsoluteHumidityTag { get; set; }

        public double DryBulbValue { get; set; }

        public double AbsoluteHumidityValue { get; set; }

        public bool ShowTagName { get; set; }

        public override string ToString()
        {
            return Group + " " + TagName + " " + DryBulbTag + " " + AbsoluteHumidityTag + " " + DryBulbValue + " " + AbsoluteHumidityValue + " " + ShowTagName;
        }
    }
}
