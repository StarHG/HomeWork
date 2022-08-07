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
        public bool IsDivisor(int numX, int numY)
        {
            return numY % numX == 0;
        }
    }
    //Составить программу, которая в зависимости от порядкового номера дня недели (1, 2, …, 7) возвращает день недели в виде члена enum(вам нужно будет самим его создать)
    //и выводит на экран название этого дня недели (понедельник, вторник, …, воскресенье) (обязательно использовать ператор switch).
    class Task3EasyWhatIsDayToday
    {
        public string WhatIsDayNow(int numDay)
        {            
            switch (numDay)
            {
                case 1:
                    _dayOfWeek = Convert.ToString(DayOfWeek.Понедельник);
                    break;
                case 2:
                    _dayOfWeek = Convert.ToString(DayOfWeek.Вторник);
                    break;
                case 3:
                    _dayOfWeek = Convert.ToString(DayOfWeek.Среда);
                    break;
                case 4:
                    _dayOfWeek = Convert.ToString(DayOfWeek.Четверг);
                    break;
                case 5:
                    _dayOfWeek = Convert.ToString(DayOfWeek.Пятница);
                    break;
                case 6:
                    _dayOfWeek = Convert.ToString(DayOfWeek.Суббота);
                    break;
                case 7:
                    _dayOfWeek = Convert.ToString(DayOfWeek.Воскресенье);
                    break;
                default:
                    _dayOfWeek = "Error!, input correct day!";
                    break;
            }
            return _dayOfWeek;
        }
        enum DayOfWeek
        {
            Понедельник = 1,
            Вторник = 2,
            Среда = 3,
            Четверг = 4,
            Пятница = 5,
            Суббота = 6,
            Воскресенье = 7
        }
    }
    class Task4EasyWeight
    {
        // Напечатать 2 метода, которые переводят фунты в килограммы и обратно (1 фунт = 453 г).

        public float PoundToKillogram(float pound)
        {
            return pound * 453 / 1000;
        }
        public double KillogramToPound(float killogramm)
        {
            return killogram * 1000 / 453;
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
            int century = -1;
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
        private int _maxNumber = 0, _tmp = 0;
        private string _strNumber;
        public int StrToNumber(string strNumber)
        {
            string _strNumber = strNumber;
            
            string[] _number = _strNumber.Split(' ');
            foreach (var num in _number)
            {
                int.TryParse(num, out _tmp);
                if (_tmp > _maxNumber)
                    _maxNumber = _tmp;
            }
            return _maxNumber;
        }
    }

    class Task2MiddleCounter
    {
        /* Написать метод, который будет возвращать строку со всеми числами от 0 до числа n, с шагом x. Число n и x всегда положительные и больше 0.
         Примеры: CounterMethod(n: 5, x: 1)-> “0 1 2 3 4 5”
        CounterMethod(n: 10, x: 2)-> “0 2 4 6 8 10”
        CounterMethod(n: 10, x: 3)-> “0 3 6 9” */
        private int _numN, _numX;
        private string _stringNumbers;

        public string CounterMethod(int n, int x)
        {
            _numN = n / x;
            _numX = x;
            int[] _arrayNumbers = new int[_numN + 1];
            for (int i = 0; i <= _numN; i++)
            {
                _arrayNumbers[i] = i * _numX;
            }
            _stringNumbers = String.Join(" ", _arrayNumbers);


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
            int[] _numbers = numbers;
            int _sum = 0;
            foreach (int n in _numbers)
            {
                if (n % 2 == 0)
                {
                    _sum += n;
                }
            }
            if (_sum == 0)
                return -1;
            else
                return _sum;
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
            string _secretCode = secretCode;
            string[] _words = new string[_secretCode.Length];

            //string[] _words = _secretCode.Split(_separatingNumb, System.StringSplitOptions.None);
            for (int i = 0; i < _secretCode.Length; i++)
            {
                if (char.IsDigit(_secretCode[i]))
                {
                    string _tmp = null;
                    int j = i + 1;
                    while (j != _secretCode.Length && char.IsLetter(_secretCode[j]))
                    {
                        _tmp += _secretCode[j];
                        j++;
                    }
                    int tmp = int.Parse(Convert.ToString(_secretCode[i]));
                    _words[tmp - 1] = _tmp;
                }
            }
            _secretCode = String.Join(" ", _words);
            return _secretCode;
        }
    }   
}
/*
Написать небольшую мини-игру для лога. 
Ниже приведен минимальный набор классов и членов, нужных для игры:

Класс Воин.
Поля: имя, здоровье, минимальный урон, максимальный урон.
Публичные методы: Атаковать, Представиться.

Класс Арена.
Поля: первый противник, второй противник.
Публичные методы: Начать сражение.

В метода Start скрипта Unity нужно вызвать метод Начать сражение класса Арена запустив
битву двух воинов. Битва должна выглядеть как поочередная атака друг друга.
Причем урон, который должен быть нанесен противнику выбирается случайно из диапазона
(минимальный урон, максимальный урон). Как только один из воинов потеряет всё здоровье,
битвы должна закончится.
Логи битвы ограничены вашей фантазией, главное чтобы было информативно.*/
