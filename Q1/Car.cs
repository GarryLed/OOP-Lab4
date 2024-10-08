 


using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Car
    {
        // attributes 
        private string _make; 
        private string _model;
        private int _currentSpeed = 0;
        private double _engineSize;


        // properties 
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int CurrentSpeed
        {
            get { return _currentSpeed; }
            set { _currentSpeed = value; }
        }
        public double EngineSize
        {
            get { return _engineSize; }
            set { _engineSize = value; }
        }

        // default constructor 
        public Car()
        {

        }
 
        // Remove this from Q1 
        // parameterized constructor 
        public Car(string make, string model, int currentSpeed, double engineSize)
        {
            Make = make;
            Model = model;
            CurrentSpeed = currentSpeed;
            EngineSize = engineSize;
        }

        // instance methods:
        // 
        //DisplayCarInfo method 
        public void DisplayCarInfo()
        {
            Console.WriteLine($"The {Make} {Model}, engine size {EngineSize}l is currently travelling at {CurrentSpeed} km/h");
        }

        // Accelerate method 
        public void Accelerate()
        {
            CurrentSpeed += 10; // will increment current speed by 10 each time the method is calle on an object 
            Console.WriteLine($"The current speed is {CurrentSpeed}");
        }
        
        // ToString method 
        public override string ToString()
        {
            return string.Format($"Make: {Make}, " + $"Model: {Model}, " + $"Current speed: {CurrentSpeed}, " + $"Engine size: {EngineSize}l");
        }
    }
}
