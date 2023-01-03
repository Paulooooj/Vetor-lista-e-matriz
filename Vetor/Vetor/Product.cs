using System;
using System.Globalization;

namespace Vetor
{
    internal class Product
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Product(string nome, string email)
        {
            Nome = nome;
            Email = email;  
        }

        public override string ToString()
        {
            return "Nome: " + Nome
                + "\nEmail: " + Email;
        }


    }
}
