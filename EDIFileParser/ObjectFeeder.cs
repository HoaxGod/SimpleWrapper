using EDI_Entites._999Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace EDIFileParser
{
    public class ObjectFeeder
    {
        //Feed Object Trail Run
        public object FeedObject<T>(SegmentSeprator oSegment, ISAHolder Interchange_999_Input, Delimiter _Delimiter)
        {

            Type ObjType = typeof(T);
            object obj = Activator.CreateInstance(ObjType);
            IList<PropertyInfo> Properties = new List<PropertyInfo>(obj.GetType().GetProperties());
            int index = 0;
            foreach (string item in oSegment.ElementValue)
            {
                if (item.Contains(_Delimiter.subElementSeparator) && oSegment.SegmentName != "ISA")
                {
                    int SubElemrntIndex = 0;
                    foreach (string SubElement in item.Split(_Delimiter.subElementSeparator))
                    {
                        string PartialSegmentName = oSegment.SegmentName + ((index + 1).ToString().Length == 1 ? "0" + (index + 1).ToString() + "_0" + SubElemrntIndex : (index + 1).ToString() + "_0" + SubElemrntIndex);
                        Properties.Where(x => x.Name.Contains(PartialSegmentName)).ToList().First().SetValue(obj, item);
                        SubElemrntIndex++;
                    }
                }
                else
                {
                    string PartialSegmentName = oSegment.SegmentName + ((index + 1).ToString().Length == 1 ? "0" + (index + 1).ToString() : (index + 1).ToString());
                    Properties.Where(x => x.Name.Contains(PartialSegmentName)).ToList().First().SetValue(obj, item);
                    index++;
                }
            }
            return obj;


        }

        //Get all the Nested Objects
        public static void ReadPropertiesRecursive(Type ObjectType)
        {
            foreach (PropertyInfo SubProperty in ObjectType.GetProperties())
            {
                if (SubProperty.PropertyType.IsClass && SubProperty.PropertyType.Name == "")
                {
                    break;
                }
                else if (SubProperty.PropertyType.IsClass && SubProperty.PropertyType.Name != "")
                {
                    ReadPropertiesRecursive(SubProperty.PropertyType);
                }

            }
        }
        

        //Freezed Format
        public object FeedObject(object obj,Delimiter _Delimiter, SegmentSeprator oSegment)
        {
            IList<PropertyInfo> Properties = new List<PropertyInfo>(obj.GetType().GetProperties());
            int index = 0;
            foreach (string item in oSegment.ElementValue)
            {
                if (item.Contains(_Delimiter.subElementSeparator) && oSegment.SegmentName != "ISA")
                {
                    int SubElemrntIndex = 1;
                    foreach (string SubElement in item.Split(_Delimiter.subElementSeparator))
                    {
                        string PartialSegmentName = oSegment.SegmentName + ((index + 1).ToString().Length == 1 ? "0" + (index + 1).ToString() + "_0" + SubElemrntIndex : (index + 1).ToString() + "_0" + SubElemrntIndex);
                        Properties.Where(x => x.Name.Contains(PartialSegmentName)).ToList().First().SetValue(obj, SubElement);
                        SubElemrntIndex++;
                    }
                }
                else
                {
                    string PartialSegmentName = oSegment.SegmentName + ((index + 1).ToString().Length == 1 ? "0" + (index + 1).ToString() : (index + 1).ToString());
                    Properties.Where(x => x.Name.Contains(PartialSegmentName)).ToList().First().SetValue(obj, item);
                    index++;
                }
            }
            return obj;
        }


        //Get all the Nested Objects
        public object  FeedObject(object obj)
        {
            foreach (Type t in obj.GetType().GetNestedTypes())
            {
                Console.WriteLine(t.Name);
                FeedObject(t);
            }

            return obj;
        }
    }
}
