using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Collections;
using RealEstateDAL;
namespace RealEstateBLL.Model
{

    public class ListManager : IListManager<Estate>
    {

        private Dictionary<string, Estate> estates;
        private string path;

        public ListManager()
        {
            estates = new Dictionary<string, Estate>();
        }

        public int Count => estates.Count;

        public string Path { get => path; set => path = value; }

        public bool Add(Estate aType)
        {
            estates.Add(aType.Id, aType);
            return true;
        }

        public bool BinaryDeSerialize(string fileName)
        {
            RealEstateDAL.Serialize se = new Serialize();
            List<Object> list = new List<Object>();
            list = se.BinaryDeSerialize(fileName);

            foreach (Object o in list)
            {
                Estate temp = (((Estate)o));
                estates.Add(((Estate)temp).Id, temp);
            }

            return true;
        }

        public bool BinarySerialize(string fileName)
        {
            RealEstateDAL.Serialize se = new Serialize();
            List<Object> temp = new List<Object>();
            foreach (Estate aType in estates.Values)
            {
                temp.Add((Object)aType);
            }
            se.BinarySerialize(fileName, temp);
            return true;
        }


        public bool ChangeAt(Estate aType, string id)
        {
            estates[id].Change(aType);
            return true;
        }

        public bool CheckId(string id)
        {
            return estates.TryGetValue(id, out _);
        }

        public void DeleteAll()
        {
            estates = new Dictionary<string, Estate>();
        }

        public bool DeleteAt(string id)
        {
            estates.Remove(id);
            return true;
        }

        public Estate GetAt(string id)
        {
            if (CheckId(id))
            {
                return estates[id];
            }
            else
            {
                //Throw error maybe ?
                return null;
            }
        }

        public string[] ToStringArray()
        {
            string[] strArray = new string[estates.Count];
            int i = 0;

            foreach (Estate obj in estates.Values)
            {
                strArray[i] = " " + obj.toString();
                i += 1;
            }
            return strArray;
        }

        public List<string> ToStringList()
        {
            throw new NotImplementedException();
        }

        public bool XMLSerialize(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}