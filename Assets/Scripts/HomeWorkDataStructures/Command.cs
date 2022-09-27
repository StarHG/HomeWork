using UnityEngine;

namespace HomeWorkDataStructures
{
    public class Command : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Player newPlayer = new Player();
            Character newChar = new Character();
            newPlayer.SetCommand(new CharCommand(newChar));
            newPlayer.PressButton();
            newPlayer.PressUndo();
            Car car = new Car();
            newPlayer.SetCommand(new CarCommand(car));
            newPlayer.PressButton();
            newPlayer.PressUndo();
        }
    }


    interface ICommand
    {
        void Execute();
        void Undo();
    }

// Receiver - Получатель
    class Character
    {
        public void Go()
        {
            Debug.Log("Иди!");
        }

        public void Stop()
        {
            Debug.Log("Стой!");
        }
    }

    class Car
    {
        public void Drive()
        {
            Debug.Log("Едь!");
        }

        public void Brake()
        {
            Debug.Log("Тормози!");
        }

    }

    class CarCommand : ICommand
    {
        Car _car;

        public CarCommand(Car setCar)
        {
            _car = setCar;
        }

        public void Execute()
        {
            _car.Drive();
        }

        public void Undo()
        {
            _car.Brake();
        }
    }

    class CharCommand : ICommand
    {
        Character _character;

        public CharCommand(Character setCharacter)
        {
            _character = setCharacter;
        }

        public void Execute()
        {
            _character.Go();
        }

        public void Undo()
        {
            _character.Stop();
        }
    }

// Invoker - инициатор
    class Player
    {
        ICommand _command;

        public void SetCommand(ICommand com)
        {
            _command = com;
        }

        public void PressButton()
        {
            _command.Execute();
        }

        public void PressUndo()
        {
            _command.Undo();
        }
    }
}