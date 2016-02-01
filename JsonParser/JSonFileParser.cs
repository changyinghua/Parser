using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace JsonParser
{
    public class JSonFileParser
    {
        private Dictionary<string, List<OPCTag>> tagsTable;

        private List<OPCTag> tagList;

        private List<string> aliveTagList;

        public JSonFileParser()
        {
            this.tagList = new List<OPCTag>();
            this.aliveTagList = new List<string>();
            this.tagsTable = new Dictionary<string, List<OPCTag>>();
        }

        public bool Load(string mdf)
        {
            try
            {
                this.tagList.Clear();
                this.aliveTagList.Clear();
                this.tagsTable.Clear();
                // load model definition file
                var serializer = new JsonSerializer();
                using (var re = File.OpenText(mdf))
                using (var reader = new JsonTextReader(re))
                {
                    dynamic modelDefinition = serializer.Deserialize(reader);
                    // tags
                    foreach (dynamic s in modelDefinition.tags)
                    {
                        string group = s.group;
                        string tagName = s.tagName;
                        string dryBulbTag = s.dryBulbTag;
                        string absoluteHumidityTag = s.absoluteHumidityTag;
                        double dryBulbValue = s.dryBulbValue;
                        double absoluteHumidityValue = s.absoluteHumidityValue;
                        bool showTagName = s.showTagName;
                        AddTag(group, tagName, dryBulbTag, absoluteHumidityTag, dryBulbValue, absoluteHumidityValue, showTagName);
                    }
                    // process
                    foreach (dynamic s in modelDefinition.process)
                    {
                        string name = s.name;

                        List<OPCTag> tags = new List<OPCTag>();
                        tags = this.tagList.Where(T => T.Group.Equals(name)).ToList();
                        this.tagsTable[name] = tags;
                    }
                    //// aliveTags
                    //foreach (dynamic s in modelDefinition.alivetags)
                    //{
                    //    string tagName = s.tagName;
                    //    AddAliveTag(tagName);
                    //}
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void AddTag(string group,string tagName,string dryBulbTag,string absoluteHumidityTag,double dryBulbValue,double absoluteHumidityValue,bool showTagName)
        {
            try
            {
                OPCTag tag = new OPCTag();
                tag.Group=group;
                tag.TagName=tagName;
                tag.DryBulbTag=dryBulbTag;
                tag.AbsoluteHumidityTag=absoluteHumidityTag;
                tag.DryBulbValue=dryBulbValue;
                tag.AbsoluteHumidityValue=absoluteHumidityValue;
                tag.ShowTagName=showTagName;
                if (this.tagList.Contains(tag))
                {
                    
                }
                else
                {
                    this.tagList.Add(tag);
                }
            }
            catch (ArgumentException e)
            {

            }
        }

        public void AddAliveTag(string tagName)
        {
            this.aliveTagList.Add(tagName);
        }

        public Dictionary<string, List<OPCTag>> GetTagsTable()
        {
            return this.tagsTable;
        }

        public List<string> GetAliveTags()
        {
            return this.aliveTagList;
        }
    }
}
