using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Toys;

namespace MilitaryTechnics
{
    public class BSON
    {
        List<long> PositionSeek = new List<long>();
        public void Serialize(MainToy Obj, string filepath)
        {
            JsonSerializer json = new JsonSerializer();
            json.Formatting = Formatting.Indented;
            json.PreserveReferencesHandling = PreserveReferencesHandling.Objects;


            Stream output = new FileStream(filepath, FileMode.Append);
            PositionSeek.Add(output.Position);
            BinaryWriter binary = new BinaryWriter(output, Encoding.Unicode);
            JsonWriter bwriter = new BsonWriter(binary);
            json.Serialize(bwriter, Obj);
            bwriter.Close();
            output.Close();
        }


        public List<MainToy> Deserialize(string filepath, List<ToyCreator> list)
        {
            List<MainToy> listObj = new List<MainToy>();
            int j = 0;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                JsonSerializer json = new JsonSerializer();
                Stream input = new FileStream(filepath, FileMode.Open);
                if (j != 0)
                    input.Seek(PositionSeek[j], SeekOrigin.Begin);
                j++;
                BinaryReader reader = new BinaryReader(input, Encoding.Unicode);
                JsonReader breader = new BsonReader(reader);
                listObj.Add(list[i].FactoryMethodDeserialiaze(ref json, ref breader));
                breader.Close();
                input.Close();
            }

            return CopyList(listObj);
        }
        public List<MainToy> CopyList(List<MainToy> technic)
        {
            List<MainToy> list = new List<MainToy>();
            for (int i = technic.Count - 1; i >= 0; i--)
                list.Add(technic[i]);
            return list;
        }


    }
}
