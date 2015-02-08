using System;
using intro;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class SomeExampleTests
    {
        [TestMethod]
        public void Ensure1equals1()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void EnsureHelloWorldIsEqual()
        {
            var helloWorld = new HelloWorld();
            StringAssert.Equals("Hello World!", helloWorld.DoTheThing());
        }

        [TestMethod]
        public void EnsureHelloWorldIsEqualAndStuff()
        {
            var helloWorld = new HelloWorld();
            var stuff = "potato1";
            StringAssert.Equals(string.Format("Hello World!{0}", stuff), helloWorld.DoTheThingWithTheStuff(stuff));
        }
    }
}
