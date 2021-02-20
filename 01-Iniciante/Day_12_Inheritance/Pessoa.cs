using System;

namespace Day_12_Inheritance
{
    class Pessoa
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Pessoa( ) { }

        public Pessoa( string firstName, string lastName, int id )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }

        public void printPessoa( )
        {
            Console.WriteLine($"Name: {lastName}, {firstName}" +
                              $"\nID: {id}");
        }
    }
}
