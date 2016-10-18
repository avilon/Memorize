using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Memorize.Model;

namespace TestMemorize
{
    [TestClass]
    public class TestWordPack
    {
        [TestMethod]
        public void TestCreate()
        {
            WordPack wp = new WordPack();
            Assert.IsNotNull(wp);
        }
    }
}
