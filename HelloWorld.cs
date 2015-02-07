using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace intro
{
    public class HelloWorld
    {
        public HelloWorld()
        {
            var _legacyLoader = LegacyCodeDoTheThing();
        }
        public string DoTheThing()
        {
            return "Hello World!";
        }

        public string DoTheThingWithTheStuff(string stuff)
        {
            return string.Format("Hello World! {0}", stuff);
        }

        public string SlightlyMoreComplicatedThing(int value)
        {
            var moddedValue = value % 3;
            switch (moddedValue)
            {
                case 0: return "Hello";
                case 1: return " ";
                case 2: return "World!";
                default:
                    throw new ArgumentOutOfRangeException(string.Format("Modded value {0} was not catered for. Don't you just hate using a switch statement?", moddedValue));
            }
        }

        [Obsolete]
        public string LegacyCodeDoTheThing()
        {
            return "World!Hello";
        }
    }
}