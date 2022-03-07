using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    [TestFixture]
     class MyTestCase
    {
        [TestCase]
        public void Add()
        {
            Shahad TestingPass = new Shahad();
            Assert.AreEqual(31, TestingPass.Add(20, 11));
        }
        [TestCase]

        public void Sub()
        {
            Shahad TestingPass = new Shahad();
            Assert.AreEqual(10, TestingPass.Sub(20, 10));
        }


    }
}