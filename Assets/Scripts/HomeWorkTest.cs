using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HomeWork
{
    public class HomeWork : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Task1EasyPerimetr task1 = new Task1EasyPerimetr();
            double perimetr = task1.PerimetrTriangl(5, 4.8);
            Debug.Log($"Tas1 Easy: {perimetr}");

            Task2EasyDivisor task2 = new Task2EasyDivisor();
            bool div = task2.IsDivisor(2,10);
            Debug.Log($"Tas2 Easy: {div}");

            Task3EasyWhatIsDayToday task3 = new Task3EasyWhatIsDayToday();
            string day = task3.WhatIsDayNow(5);
            Debug.Log($"Tas3 Easy: {day}");

            Task4EasyWeight task4 = new Task4EasyWeight();
            float weight = task4.PoundToKillogram(5);
            Debug.Log($"Tas4 Easy: {weight}");

            Task5EasyMoreOrLess task5 = new Task5EasyMoreOrLess();
            task5.MoreLess(100, 58);

            Task6EasyYear task6EasyYear = new Task6EasyYear();
            int century = task6EasyYear.YearToCentury(2025);
            Debug.Log($"Tas6 Easy: {century}");

           

            

        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}