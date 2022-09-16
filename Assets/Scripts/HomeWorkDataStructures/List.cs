using System;
using UnityEngine;

namespace HomeWorkDataStructures
{
    public class List : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            ListRealization listReal = new ListRealization(new[] { "1", "2" });


            foreach (string s in listReal.Get_listArray())
                Debug.Log(s);
            listReal.ListAdd("3");
            foreach (string s in listReal.Get_listArray())
                Debug.Log(s);
        }
    }
    class ListRealization
    {
        string[] _listArray;
        public ListRealization(string[] listArray)
        {
            _listArray = new string[listArray.Length];
            _listArray = listArray;
        }
        internal string[] Get_listArray()
        {
            return _listArray;
        }
        internal void ListAdd(string valueAdd)
        {
            try
            {
                if (_listArray[_listArray.Length - 1] != null)
                {
                    Array.Resize(ref _listArray, _listArray.Length + 1);
                    _listArray[_listArray.Length - 1] = valueAdd;
                }
                else
                {
                    _listArray[_listArray.Length - 1] = valueAdd;
                }
            }
            catch (Exception e)
            {
                Debug.Log(e);
                throw;
            }
        }
    }
}