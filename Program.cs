using System;

namespace ISP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Drive(10);
            SpaceShip spaceship = new SpaceShip();
            spaceship.Drive(10);
            spaceship.LaunchRocket();
            spaceship.Drive(10);
            FlyingCar flyingCar = new FlyingCar();
            flyingCar.Drive(10);
            flyingCar.LaunchRocket();
            flyingCar.Drive(10);
        }
    }

    interface IDrivable
    {
        void Drive(long miles);
    }
    interface ICanLaunchRockets
    {
        bool _isRocketLaunched { get; set; }
        void LaunchRocket();
    }

    class Car : IDrivable
    {
        public void Drive(long miles)
        {
            Console.WriteLine("I am driven to {0} miles away ...", miles);
        }
    }

    class FlyingCar : IDrivable, ICanLaunchRockets
    {
        public bool _isRocketLaunched { get; set; } = false;
        public void Drive(long miles)
        {
            if (!_isRocketLaunched)
            {
                Console.WriteLine("Launch the rocket first or this flying car can not get driven.");
            }
            else
            {
                Console.WriteLine("I am flying to {0} miles away ...", miles);
            }
        }

        public void LaunchRocket()
        {
            _isRocketLaunched = true;
        }
    }

    class SpaceShip : IDrivable, ICanLaunchRockets
    {
        public bool _isRocketLaunched { get; set; } = false;
        public void Drive(long miles)
        {
            if (!_isRocketLaunched)
            {
                Console.WriteLine("Spaceship can't leave Earth if its rocket is not launched !");
            }
            else
            {
                Console.WriteLine("The spaceship is going {0} miles away", miles);
            }
        }

        public void LaunchRocket()
        {
            _isRocketLaunched = true;
        }
    }
}
