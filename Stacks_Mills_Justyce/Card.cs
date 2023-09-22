using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Mills_Justyce
{
    class Card//class called Card
    {
        public string Number { get; }//string data type with automatic getter

        public string Suit { get; }//string data type with automatic getter

        public Card(string numParam, string suitParam)//constructor that has two parameters
        {
            Number = numParam;//Assign number to Number
            Suit = suitParam;//Assign suit to Suit
        }
    }
}
