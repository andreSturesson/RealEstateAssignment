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
using System.IO;
using System.IO.Pipes;
using System.Collections;

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
            FileStream fs = new FileStream(fileName, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                estates = (Dictionary<String,Estate>)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                return false;
                throw;
            }
            finally
            {
                fs.Close();
            }
            return true;
        }

        public bool BinarySerialize(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, graph: estates);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
            return true;
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