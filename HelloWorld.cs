using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace intro
{
    public class HelloWorld
    {
        public string DoTheThing()
        {
            return "Hello World!";
        }

        public string DoTheThingWithTheStuff(string stuff)
        {
            return string.Format("Hello World! {0}", stuff);
        }

    }
}