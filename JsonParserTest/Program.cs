using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JsonParser;

namespace JsonParserTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            JSonFileParser j = new JSonFileParser();

            if (j.Load(@"C:\FrontEndConfig.json"))
            {
                Dictionary<string, List<OPCTag>> d = new Dictionary<string, List<OPCTag>>();
                d = j.GetTagsTable();
                foreach (string s in d.Keys)
                {
                    Console.WriteLine(s);
                    List<OPCTag> value = new List<OPCTag>();
                    if (d.TryGetValue(s, out value))
                    {
                        foreach (OPCTag o in value)
                        {
                            Console.WriteLine(o);
                        }
                    }
                }

                List<string> aliveTags = new List<string>();
                aliveTags = j.GetAliveTags();
                foreach (string s in aliveTags)
                {
                    Console.WriteLine(s);
                }
            }
            
            
            Console.ReadKey();
        }
    }
}
