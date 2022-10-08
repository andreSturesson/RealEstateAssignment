using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAssignment.Controller
{
    interface IListManager<T>
    {
        #region All method definitions
        /// <summary>
        /// Return the number of items in the collection m_list
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Add an object to the collecdtion m_list.
        /// </summary>
        /// <param name="aType">A type.</param>
        /// <returns>True if successful, false otherwise.</returns>
        bool Add(T aType);

        /// <summary>
        /// Remove an object from the collection m_list at
        /// a given position.
        /// </summary>
        /// <param name="anIndex">Index to object that is to be removed.</param>
        /// <returns>True if successful, false otherwise.</returns>
        bool DeleteAt(String id);

        /// <summary>
        /// Replace an object from the collection at a given index by a new object.
        /// </summary>
        /// <param name="aType">Object to be replaced.</param>
        /// <param name="anIndex">index to element to be replaced by a new object.</param>
        /// <returns>True if successful, false otherwise.</returns>
        bool ChangeAt(T aType, String id);

        /// <summary>
        /// Return an object at a given position from the collection m_list.
        /// </summary>
        /// <param name="anIndex">.</param>
        /// <returns></returns>
        T GetAt(String id);

        /// <summary>
        /// Control that a given index is >= 0 and less than the number of items in 
        /// the collection.
        /// </summary>
        /// <returns>True if successful, false otherwise.</returns>
        bool CheckId(String id);
        /// <summary>
        /// Deletes all object of the collection and set the collection to null.
        /// </summary>
        void DeleteAll();

        /// <summary>
        /// Prepare a list of strings where each string represents info
        /// about an object in the collection. The info can typically come
        /// from the object's ToString method.
        /// </summary>
        /// <returns>The collection containing strings representing an object in
        /// the collection.</returns>
        List<string> ToStringList();
        /// <summary>
        /// Same as as ToStringList but returning a array of strings.
        /// </summary>
        /// <returns></returns>
        string[] ToStringArray();
        #endregion

        bool BinarySerialize(string fileName);
        bool BinaryDeSerialize(string fileName);
        bool XMLSerialize(string fileName);
        bool Add(Estate aType);
    }
}
