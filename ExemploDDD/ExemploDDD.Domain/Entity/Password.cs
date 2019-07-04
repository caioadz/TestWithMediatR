using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploDDD.Domain.Entity
{
    public class Password
    {
        public string Hash { get; }

        public Password(string value)
        {
            Hash = Encrypt(value);
        }

        private string Encrypt(string value)
        {
            //Simulando um algoritmo de criptografia de senha (BCrypt, por exemplo)
            return value.GetHashCode().ToString();
        }
    }
}
