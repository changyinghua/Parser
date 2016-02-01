using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace JsonGenerator
{
    public class Generator
    {
        public string T()
        {
            JArray array = new JArray();
            JValue text = new JValue("Manual text");
            JValue date = new JValue(new DateTime(2000, 5, 23));
 
            array.Add(text);
            array.Add(date);
 
            string json = array.ToString();
            return json;
        }

        public string B()
        {
            string group = "HeatingByMotor";
            string tagName = "SA";
            string dryBulbTag = "FIX.SA_DBT.F_CV";
            string absoluteHumidityTag= "FIX.SA_AH.F_CV";
            double dryBulbValue = 0;
            double absoluteHumidityValue = 0;
            bool showTagName= false;

            string process = "HeatingByMotor";

            RootObject root = new RootObject();
            Tag t = new Tag();
            t.group = group;
            t.tagName = tagName;
            t.dryBulbTag = dryBulbTag;
            t.dryBulbValue = dryBulbValue;
            t.absoluteHumidityTag = absoluteHumidityTag;
            t.absoluteHumidityValue = absoluteHumidityValue;
            t.showTagName = showTagName;
            List<Tag> tl = new List<Tag>();
            tl.Add(t);
            Process p = new Process();
            p.name = process;
            List<Process> pl = new List<Process>();
            pl.Add(p);
            root.tags = tl;
            root.process = pl;
            string strJson = JsonConvert.SerializeObject(root, Formatting.Indented);
            System.IO.File.WriteAllText(@"C:\WriteText.json", strJson);
            return strJson;
        }
    }
}
