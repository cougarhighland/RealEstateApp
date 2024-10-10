using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RealEstateDAL
{
    ///<summary>
    /// Interface for implementation by manager classes hosting a collection
    /// of the type List<T> where T can be any object type. In this documentation,
    /// the collection is referred to as objectList.
    /// IListManager can be implemented by different classes passing any type <T> at
    /// declaration but then T MUST HAVE THE SAME TYPE IN ALL METHODS INCLUDED IN THIS
    /// INTERFACE.
    ///</summary>
    ///<typeparam name="T">object type</typeparam>
    public interface IListManager<T>
    {
        /// <summary>
        /// Gets the number of elements in the list.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Adds an element to the end of the list.
        /// </summary>
        /// <param name="type">The element to add.</param>
        /// <returns>True if the element was added successfully, false otherwise.</returns>
        bool Add(T type);

        /// <summary>
        /// Changes the element at the specified index.
        /// </summary>
        /// <param name="type">The new element to replace the existing element.</param>
        /// <param name="index">The index of the element to replace.</param>
        /// <returns>True if the element was changed successfully, false otherwise.</returns>
        bool ChangeAt(T type, int index);

        /// <summary>
        /// Checks if the specified index is valid for the list.
        /// </summary>
        /// <param name="index">The index to check.</param>
        /// <returns>True if the index is valid, false otherwise.</returns>
        bool CheckIndex(int index);

        /// <summary>
        /// Removes all elements from the list.
        /// </summary>
        void DeleteAll();

        /// <summary>
        /// Removes the element at the specified index.
        /// </summary>
        /// <param name="index">The index of the element to remove.</param>
        /// <returns>True if the element was removed successfully, false otherwise.</returns>
        bool DeleteAt(int index);

        /// <summary>
        /// Converts the elements in the list to a string array.
        /// </summary>
        /// <returns>A string array containing the elements of the list.</returns>
        string[] ToStringArray();

        /// <summary>
        /// Converts the elements in the list to a list of strings.
        /// </summary>
        /// <returns>A list of strings containing the elements of the list.</returns>
        List<string> ToStringList();
    }
}
