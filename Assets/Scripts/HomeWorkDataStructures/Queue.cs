using System;
using UnityEngine;

namespace HomeWorkDataStructures
{
    public class Queue : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            QueueRealization queueRealization = new QueueRealization(new [] { "0"});

            queueRealization.Enqueue("1");
            queueRealization.Enqueue("2");
            queueRealization.Enqueue("3");
            Debug.Log(queueRealization.Dequeue());
            Debug.Log(queueRealization.Dequeue());
            Debug.Log(queueRealization.Dequeue());
            Debug.Log(queueRealization.Dequeue());
        }

    }

    class QueueRealization
    {
        string[] _queueArray;
        public QueueRealization(string[] queueArray)
        {
            _queueArray = new string[queueArray.Length];
            _queueArray = queueArray;
        }

        internal string QueuePeek()
        {
            try
            {
                return _queueArray[0];
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        internal string Dequeue()
        {
            try
            {
                string value = _queueArray[0];
                Array.Reverse(_queueArray);
                Array.Resize(ref _queueArray, _queueArray.Length - 1);
                Array.Reverse(_queueArray);
                return value;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        internal void Enqueue(string valueAdd)
        {
            if (_queueArray.Length == 0 || _queueArray[_queueArray.Length - 1] != null)
            {
                Array.Resize(ref _queueArray, _queueArray.Length + 1);
                _queueArray[_queueArray.Length - 1] = valueAdd;
            }

        }
    }
}