﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCollectionProject
{
    public class Person : IPerson
    {
        public DateTime DateOfBirth { get; }
        public string FirstName { get; }
        public int Height { get; }
        public int id { get; }
        public string LastName { get; }

        public Person(string FirstName, string lastName, int id)
        {
            this.FirstName = FirstName;
            this.LastName = lastName;
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public DateTime GetDateOfBirth()
        {
            return DateOfBirth;
        }

        public int GetHeight()
        {
            return Height;
        }
    }
}
