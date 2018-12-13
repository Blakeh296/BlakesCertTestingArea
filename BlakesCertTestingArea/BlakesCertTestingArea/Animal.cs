using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlakesCertTestingArea
{
    public class Animal
    {
        public virtual string talk() { return "Hi"; }
        public string sing() { return "lalala"; }
    }

    public class Cat : Animal
    {
        public override string talk()
        {
            return "Meow!";
        }
    }

    public class Dog : Animal
    {
        public override string talk() {return "Woof!" ;}
        public new string sing() { return "woofa woofa woof"; }
    }
}
