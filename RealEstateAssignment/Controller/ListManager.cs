using RealEstateAssignment.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment.Controller
{

    //Will later contain a collection of estates
    class ListManager : IListManager<Estate> {

        private Dictionary<String, Estate> estates;

        public ListManager()
        {
            estates = new Dictionary<String, Estate>();
        }

        public int Count => throw new NotImplementedException();

        public bool Add(Estate aType)
        {
            estates.Add(aType.Id, aType);
            return true;
        }

        public bool BinaryDeSerialize(string fileName)
        {
            throw new NotImplementedException();
        }

        public bool BinarySerialize(string fileName)
        {
            throw new NotImplementedException();
        }

        public bool ChangeAt(Estate aType, String id)
        {
            estates[id].Change(aType);
            return true;
        }

        public bool CheckId(String id)
        {
            return estates.TryGetValue(id, out _);
        }

        public void DeleteAll()
        {
            estates = new Dictionary<String,Estate>();
        }

        public bool DeleteAt(String id)
        {
            estates.Remove(id);
            return true;
        }

        public Estate GetAt(String id)
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

            foreach (Estate obj in this.estates.Values)
            {
                strArray[i] += " " + obj.Address.Street;
                strArray[i] += " " + obj.Address.City;
                strArray[i] += "                                             " +
                    "                                                        " +
                    "                                                        " +
                    "                                                        " +
                    "                                                        " +
                    obj.Id.ToString();
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