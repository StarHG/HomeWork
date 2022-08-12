using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1MiddleStr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(StrToNumber("1 5 4 14 81 6 3"));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int StrToNumber(string strNumber)
    {
        int tmp, maxNumber = 0;
        string[] number = strNumber.Split(' ');
        foreach (var num in number)
        {
            int.TryParse(num, out tmp);
            if (tmp > maxNumber)
                maxNumber = tmp;
        }
        return maxNumber;
    }
}
