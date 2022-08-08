using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Task1HardSecretCode1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Task1HardSecretCode task31 = new Task1HardSecretCode();
        string words = task31.Decode("2World1Hello");
        Debug.Log($"Tas1 Hard: {words}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
class Task1HardSecretCode
{
    public string Decode(string secretCode)
    {
        string[] words = new string[secretCode.Length];

        //string[] _words = _secretCode.Split(_separatingNumb, System.StringSplitOptions.None);
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
                int tmp2 = int.Parse(Convert.ToString(secretCode[i]));
                words[tmp2 - 1] = tmp;
            }
        }
        secretCode = String.Join(" ", words);
        return secretCode;
    }
}

