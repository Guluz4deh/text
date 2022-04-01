using System;
using System.Collections.Generic;
using System.Text;
using _30_03_2022.Interfaces;
using _28_03_2022_ConsoleApp.Helpers;
using System.Collections;

namespace ConsoleApp1_04_22.Models
{
    class User : IAccount, IEnumerable
    {
        #region values
        public string ShowInfo() {return $"{id} - {name} {surname} {email} {password}";}

        private static int _idCounter;
        private static User[] _user;

        #endregion
        private int id;
        private string name;
        private string surname;
        private string email;
        private string password;

        public bool PasswordChecker()
        {
            throw new NotImplementedException();
        }

        //public string ShowInfo()
        //{
        //    throw new NotImplementedException();
        //}
        static User()
        {
            _idCounter = 0;
            _user = new User[0];
        }
        public static void AddUser()
        {
            string name = null;
            name = name.StringInputExtension("User Name");

            string surname = null;
            surname = surname.StringInputExtension("User Surname");

            string email = null;
            email = email.StringInputExtension("User Email");

            string password = null;
            password = password.StringPassWordInputExtension("User Password");

            _ = new User(name, surname, email, password);
            Console.Clear();
            Console.WriteLine("Employe Successfully created!");
        }

        private User()
        {
            this.id = ++_idCounter;
            Array.Resize(ref _user, _user.Length + 1);
            _user[_user.Length - 1] = this;
        }
        public User(string name, string surname, string email, string password) : this()
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
        }
        public static void PrintUsers()
        {
            foreach (var user in _user)
            {
                Console.WriteLine(user.ToString());
            }
        }
        public static void SearchForId()
        {
            int? id = null;
            id = id.IntAgeInputExtension("User Id for Search");
            --id;
            Console.WriteLine(_user[(int)id]);
        }
        public override string ToString()
        {
            return $"{id} - {name} {surname} {email} {password}"; ;
        }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
