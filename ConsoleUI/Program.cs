using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.Name = "Gillian";
            owner.SecondName = "Anderson";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Find Mulder";
            chore.Owner = owner;
            chore.PerformWork(3);
            chore.CompletemChore();

            Console.ReadLine();
        }
    }
}
