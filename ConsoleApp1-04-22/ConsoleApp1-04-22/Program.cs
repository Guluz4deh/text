using System;
using _28_03_2022_ConsoleApp.Helpers;
using ConsoleApp1_04_22.Models;
using _30_03_2022.Interfaces;

namespace ConsoleApp1_04_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        public static void Menu()
        {
            Console.WriteLine(@" _      _____  _      ____   ____    _        _____
/ \  /|/ __/  / \    /   _\ /  _  \ / \__/|  /  __/
| |  |||  \   | |    |  /   | / \ | | |\/||  |  \  
| |/\|||  / _ | |_ /\|  \__ | \_/ | | |  ||  |  /_ 
\_ /  \|\____\\____ /\____ /\____ / \_ / \|  \____\
                                            ");
        Menu:
            Console.WriteLine(" 1 - Add User:\n " +
                              "2 - Enter the Department Id for Search Employe:\n " +
                              "3 - See the Department name:\n " +
                              "4 - See all Employes in Department:\n " +
                              "0 - Exit.");
            string input = null;
            input = input.StringInputExtension("Input");

            switch (input)
            {
                case "1":
                    Console.Clear();
                    ConsoleDesign();
                    User.AddUser();
                    ConsoleDesign();
                    goto Menu;
                case "2":
                    //Console.Clear();
                    ConsoleDesign();
                    User.PrintUsers();
                    ConsoleDesign();
                    goto Menu;
                case "3":
                    Console.Clear();
                    ConsoleDesign();
                    User.SearchForId();
                    ConsoleDesign();
                    goto Menu;
                case "4":
                    Console.Clear();
                    ConsoleDesign();

                    ConsoleDesign();
                    goto Menu;
                case "5":
                    ConsoleDesign();
                    goto Menu;
                case "0":
                    Console.WriteLine("=== THANKS ===");
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input.Please try again.");
                    goto Menu;
            }
        }
        public static void ConsoleDesign()
        {

            Console.WriteLine("=================================");
        }


    }
}
