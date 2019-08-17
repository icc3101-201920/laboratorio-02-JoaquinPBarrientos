using System;
using System.Collections.Generic;
using System.Text;
namespace Laboratorio_1_OOP_201902.Card
{
    public class Card
    {
        protected string name;
        protected string type;

    public Card(string name,string type)
        {
            Name = name;
            Type = type;
        }
        
    public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }



    }
}

