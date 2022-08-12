using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Task2MiddleCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(CounterMethod(10, 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public string CounterMethod(int numN, int numX)
    {
        string stringNumbers;
        numN /= numX;
        int[] arrayNumbers = new int[numN + 1];
        for (int i = 0; i <= numN; i++)
        {
            arrayNumbers[i] = i * numX;
        }
        stringNumbers = String.Join(" ", arrayNumbers);
        return stringNumbers;
    }
}
