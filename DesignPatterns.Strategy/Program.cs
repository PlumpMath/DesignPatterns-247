using DesignPatterns.Strategy.Model;
using System;

namespace DesignPatterns.Strategy {
    class Program {
        static void Main(string[] args) {
            Robot robot = new Robot("Robby", new DefensiveStance());
            TakeActions(robot);

            robot.Stance = new PassiveStance();
            TakeActions(robot);

            robot.Stance = new AggressiveStance();
            TakeActions(robot);

            Console.ReadLine();
        }

        private static void TakeActions(Robot robot) {
            Console.WriteLine(robot.Attack());
            Console.WriteLine(robot.Defend());
            Console.WriteLine(robot.Move());
        }
    }
}