using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Task1HardSecretCode1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Tas1 Hard: " + Decode("2World1Hello3Unity"));
    }

    // Update is called once per frame
    void Update()
    {

    }
    public string Decode(string secretCode)
    {
        int countOfNum = 0;
        for (int i = 0; i < secretCode.Length; i++)
        {
            if (char.IsDigit(secretCode[i]))
            {
                countOfNum++;
            }
        }
        string[] words = new string[countOfNum];

        for (int i = 0; i < secretCode.Length; i++)
        {
            if (char.IsDigit(secretCode[i]))
            {
                string tmp = null;
                int j = i + 1;
                while (j != secretCode.Length && char.IsLetter(secretCode[j]))
                {
                    tmp += secretCode[j];
                    j++;
                }
                int indexWordsTmp = int.Parse(Convert.ToString(secretCode[i]));
                words[indexWordsTmp - 1] = tmp;
            }
        }
        secretCode = String.Join(" ", words);
        return secretCode;
    }
}



