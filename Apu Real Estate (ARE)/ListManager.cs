using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_
{
    public class ListManager<T> : IListManager<T>
    {
        //field
        private List<T> m_List;
        //constructor
        public ListManager() 
        { 
            m_List = new List<T>(); 
        }
        //property
        public int Count
        {
            get{return m_List.Count;}
        }
        //func to add an object to the list
        public bool Add(T type) 
        {
            if (type != null)
            {
                m_List.Add(type);
                return true;
            }
            return false;
        }
        // func to change an object at an index in the list
        public bool ChangeAt(T type, int index) 
        {
            if (CheckIndex(index))
            {
                m_List[index] = type;
                return true;
            }
            return false;
        }
        //func that check if index is in valid range
        public bool CheckIndex(int index) 
        { 
            return index >= 0 && index < m_List.Count;
        }
        //func to delete all objects in the list
        public void DeleteAll() 
        {
            m_List.Clear();
        }
        //func to delete object at an index in the list
        public bool DeleteAt(int index) 
        {
            if (CheckIndex(index)) 
            {
                m_List.RemoveAt(index);
            }
            return false; 
        }
        //func to get an object at an index in the list
        public T GetAt(int index) 
        {
            return m_List[index];
        }
        //func to converts m_List to a string array
        public string[] ToStringArray() 
        {
            string[] infoString = new string[m_List.Count];
            for (int i = 0; i < m_List.Count; i++)
            {
                infoString[i] = m_List[i].ToString();
            }
            return infoString;
        }
        //func to converts m_List to a string list
        public List<string> ToStringList() 
        {
            List<string> infoStringList = new List<string>();
            for (int i = 0; i < m_List.Count; i++)
            {
                infoStringList.Add(m_List[i].ToString());
            }
            return infoStringList;
        }

    }
}
