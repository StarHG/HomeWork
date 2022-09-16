using System;
using UnityEngine;

namespace HomeWorkDataStructures
{
    public class Stack : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            StackRealization listReal = new StackRealization(new string[] {});

            listReal.StackPush("Stack - 1");
            listReal.StackPush("Stack - 2");
            listReal.StackPush("Stack - 3");
            Debug.Log(listReal.StackPop());
            Debug.Log(listReal.StackPop());
            Debug.Log(listReal.StackPop());
        }
    }

    class StackRealization
    {
        string[] _stackArray;
        public StackRealization(string[] stackArray)
        {
            _stackArray = new string[stackArray.Length];
            _stackArray = stackArray;
        }

        internal string StackPeek()
        {
            try
            {
                return _stackArray[_stackArray.Length - 1];
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        internal string StackPop()
        {
            try
            {
                string value = _stackArray[_stackArray.Length - 1];
                Array.Resize(ref _stackArray, _stackArray.Length - 1);
                return value;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        internal void StackPush(string valueAdd)
        {
            if (_stackArray.Length == 0 || _stackArray[_stackArray.Length - 1] != null)
            {
                Array.Resize(ref _stackArray, _stackArray.Length + 1);
                _stackArray[_stackArray.Length - 1] = valueAdd;            
            }
        }
    }
}