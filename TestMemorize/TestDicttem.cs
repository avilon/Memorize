using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Memorize.Model;

namespace TestMemorize
{
    [TestClass]
    public class TestDicttem
    {
        [TestMethod]
        public void TestCreate()
        {
            DictItem di = new DictItem();
            Assert.IsNotNull(di);
        }

        [TestMethod]
        public void TestReadValues()
        {
            DictItem di = new DictItem();
            di.Read("mismatch=несоответствие/несовпадение=choice;0;0#write;0;0#line;0;0");
            Assert.AreEqual(2, di.ValuesCount);
        }
    }
}
