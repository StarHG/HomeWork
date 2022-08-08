using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task4MiddleArena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Arena arena = new Arena();
        arena.StartBattle();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

class Warior
{
    public string _name { get; set; }
    public int _health { get; set; }
    private int _minDamage, _maxDamage, _attackDamage;
    private int health;

    public Warior(string name, int health, int minDamage, int maxDamage)
    {
        _name = name;
        _health = health;
        _minDamage = minDamage;
        _maxDamage = maxDamage;
    }

    public int Attack()
    {
        System.Random random = new System.Random();
        _attackDamage = random.Next(_minDamage, _maxDamage);
        return _attackDamage;
    }

    public void SayHello()
    {
        Debug.Log($"Hello, my name is {_name}");
    }
}
class Arena
{
    Warior firstEnemy = new Warior("Oleg", 500, 20, 30);
    Warior secondEnemy = new Warior("Jack Vorobey", 400, 30, 40);


    public void StartBattle()
    {
        firstEnemy.SayHello();
        secondEnemy.SayHello();
       
        while (firstEnemy._health > 0 || secondEnemy._health > 0)
        {
            int tmpDamageFirst = firstEnemy.Attack();
            secondEnemy._health -= tmpDamageFirst;
            Debug.Log($"{firstEnemy._name} attack {secondEnemy._name}, he received a {tmpDamageFirst} damage, and his health is {secondEnemy._health}");
            int tmpDamageSecond = secondEnemy.Attack();
            firstEnemy._health -= tmpDamageSecond;
            Debug.Log($"{secondEnemy._name} attack {firstEnemy._name}, he received a {tmpDamageSecond} damage, and his health is {firstEnemy._health}");

        }
        if (firstEnemy._health > 0)
            Debug.Log($"{firstEnemy._name} Win!!!");
        else
            Debug.Log($"{secondEnemy._name} Win!!!");

    }
}
