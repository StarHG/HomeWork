using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3MiddleEvenSum : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(EvenSum(new int[] { 1, 3, 4, 6 }));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /* Написать метод, который будет получать массив положительных целых чисел, а возвращать сумму всех чётных цифр.Если подходящих цифр в массиве нет,
         или массив пуст возвращать -1
         Пример:
         EvenSum(new int { 1, 3, 4, 6 })-> 10
         EvenSum(new int { 1, 2, 3, 3 })-> 2
         EvenSum(new int { 1, 3, 1, 7 })-> - 1
         EvenSum(new int { })-> - 1  */
    public int EvenSum(int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            if (n % 2 == 0)
            {
                sum += n;
            }
        }
        if (sum == 0)
            return -1;
        else
            return sum;
    }
}
