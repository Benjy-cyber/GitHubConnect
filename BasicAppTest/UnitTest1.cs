using BA_Basic_App_GitHub;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BasicAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 tp = new Class1();
            Assert.AreEqual(tp.Name, "[Benjy Adolphe] - The Code LookerUpper");
            //Useless Comment 1fdsafds
        }
    }
}
