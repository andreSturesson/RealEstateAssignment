using RealEstateAssignment.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment.Controller
{

    //Will later contain a collection of estates
    class ListManager : IListManager<Estate> {

        private List<Estate> estates;

        public ListManager()
        {
            estates = new List<Estate>();
        }

        public int Count => throw new NotImplementedException();

        public bool Add(Estate aType)
        {
            estates.Add(aType);
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

        public bool ChangeAt(Estate aType, int anIndex)
        {
            estates[anIndex].Change(aType);
            return true;
        }

        public bool CheckIndex(int index)
        {
            return index <= estates.Count;
        }

        public void DeleteAll()
        {
            estates = new List<Estate>();
        }

        public bool DeleteAt(int anIndex)
        {
            estates.RemoveAt(anIndex);
            return true;
        }

        public Estate GetAt(int anIndex)
        {
            return estates[anIndex];
        }

        public string[] ToStringArray()
        {
            string[] strArray = new string[estates.Count];
            int i = 0;

            foreach (Estate obj in this.estates)
            {
                strArray[i] += obj.ToString();
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