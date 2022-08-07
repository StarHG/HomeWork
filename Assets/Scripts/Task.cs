using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace HomeWork

{
    internal class Task1EasyPerimetr
    {
        
        // Написать метод, который принимает на вход длины катетов прямоугольного треугольника, а возвращает его периметр.

        public double PerimetrTriangl(double cathetB, double cathetC)
        {
           
            double perimetrTriangl = Math.Sqrt(Math.Pow(cathetB, 2) + Math.Pow(cathetC, 2)) + cathetC + cathetB;
            return perimetrTriangl;
        }
    }
    class Task2EasyDivisor
    {
        //Написать метод, который возвращает true, если число x является делителем числа y?
       
        
        public bool IsDivisor(int numX, int numY)
        {
            
            
            if (numY % numX == 0) 
                return true;
            else 
                return false;
            
        }
    }
    //Составить программу, которая в зависимости от порядкового номера дня недели (1, 2, …, 7) возвращает день недели в виде члена enum(вам нужно будет самим его создать)
    //и выводит на экран название этого дня недели (понедельник, вторник, …, воскресенье) (обязательно использовать ператор switch).
    class Task3EasyWhatIsDayToday
    {
        
        private string _dayOfWeek;

        public string WhatIsDayNow(int numDay)
        {          
            
            switch (numDay)
            {
                case 1:
                    _dayOfWeek = Convert.ToString(DayOfWeek.Monday);
                    break;
                case 2:
                    _dayOfWeek = Convert.ToString(DayOfWeek.Tuesday);
                    break;
                case 3:
                    _dayOfWeek = Convert.ToString(DayOfWeek.Wednesday);
                    break;
                case 4:
                    _dayOfWeek = Convert.ToString(DayOfWeek.Thuesday);
                    break;
                case 5:
                    _dayOfWeek = Convert.ToString(DayOfWeek.Friday);
                    break;
                case 6:
                    _dayOfWeek = Convert.ToString(DayOfWeek.Satuday);
                    break;
                case 7:
                    _dayOfWeek = Convert.ToString(DayOfWeek.Sunday);
                    break;
                default:
                    _dayOfWeek = "Error!, input correct day!";
                    break;
            }
            return _dayOfWeek;
        }
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thuesday = 4,
            Friday = 5,
            Satuday = 6,
            Sunday = 7
        }
    }
    class Task4EasyWeight
    {
        // Напечатать 2 метода, которые переводят фунты в килограммы и обратно (1 фунт = 453 г).
        
        public float PoundToKillogram(float pound)
        {
            float killogram = pound * 0.453f;
            return killogram;
        }
        public double KillogramToPound(float killogram)
        {
            float pound = killogram / 0.453f;
            return pound;
        }
    }
    class Task5EasyMoreOrLess
    {
        //Написать метод, который принимает на вход два различных десятичных числа. Метод должен вывести какое из них больше и какое меньше.
        
        public void MoreLess(int number1, int number2)
        {
            
            if (number1 == number2)
                Debug.Log($"Число {number1} равно {number2}");
            else if (number1 - number2 > 0)
                Debug.Log($"Число {number1} больше {number2}");
            else
                Debug.Log($"Число {number1} меньше {number2}");
        }
    }
    class Task6EasyYear
    {
        //Сделать метод, который будет принимать текущий год, а возвращать текущий век
        public int YearToCentury(int year)
        {
            int century;
            
            if (year % 100 == 0)
                century = year / 100;
            else
                century = year / 100 + 1;
            return century;
        }
    }
    class Task1MiddleStr
    {
        // Написать метод, который будет принимать строку с числами, разделёнными пробелами и возвращать самое большое число
        private int maxNumber = 0, tmp = 0;
        private string strNumber;
        public int StrToNumber(string strNumber)
        {
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

    class Task2MiddleCounter
    {
        /* Написать метод, который будет возвращать строку со всеми числами от 0 до числа n, с шагом x. Число n и x всегда положительные и больше 0.
         Примеры: CounterMethod(n: 5, x: 1)-> “0 1 2 3 4 5”
        CounterMethod(n: 10, x: 2)-> “0 2 4 6 8 10”
        CounterMethod(n: 10, x: 3)-> “0 3 6 9” */
        private string _stringNumbers;

        public string CounterMethod(int numN, int numX)
        {
            numN /= numX;            
            int[] arrayNumbers = new int[numN + 1];
            for (int i = 0; i <= numN; i++)
            {
                arrayNumbers[i] = i * numX;
            }
            _stringNumbers = String.Join(" ", arrayNumbers);
            return _stringNumbers;
        }
    }

    class Task3MiddleEvenSum
    {
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
    class Task1HardSecretCode
    {
        /* Hard:
    Секретное сообщение представляет собой набор пар чисел и слова, число указывает на номер слова в предложении, например:
    “2like1I4games3play” является закодированной фразой “I like play games”
    Напишите валидатор для таких сообщений. Метод должен принимать строку с секретным кодом и возвращать строку с фразой.
    Например: Decode(“2like1I4games3play”)-> “I like play games” */

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
    
}
