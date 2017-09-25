using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSystemDLLUnittests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLLUnittests.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void BilPrisTest()
        {
            //arrange
            Billet bil = new Billet();
            //act
            int minint = bil.BilPris();
            //assert
            Assert.AreEqual(bil.BilPris(), minint);
        }

        [TestMethod]
        public void LULTESTFORPUSH()
        {
            
        }

        [TestMethod()]
        public void BilPrisMedBizzTest()
        {
            //arrange
            Billet bil = new Billet();
            //act
            int minint = bil.BilPrisØresundBizz();
            //assert
            Assert.AreEqual(bil.BilPrisØresundBizz(), minint);
        }

        [TestMethod()]
        public void BilPrisØresundTest()
        {
            //arrange
            Billet bil = new Billet();
            //act
            int minint = bil.BilPrisØresund();
            //assert
            Assert.AreEqual(bil.BilPrisØresund(), minint);
        }

        [TestMethod()]
        public void BilPrisØresundBizzTest()
        {
            //arrange
            Billet bil = new Billet();
            //act
            int minint = bil.BilPrisØresundBizz();
            //assert
            Assert.AreEqual(bil.BilPrisØresundBizz(), minint);
        }

        [TestMethod()]
        public void MCPrisTest()
        {
            //arrange
            Billet bil = new Billet();
            //act
            int minint = bil.MCPris();
            //assert
            Assert.AreEqual(bil.MCPris(), minint);
        }

        [TestMethod()]
        public void MCØresundTest()
        {
            //arrange
            Billet bil = new Billet();
            //act
            int minint = bil.MCØresund();
            //assert
            Assert.AreEqual(bil.MCØresund(), minint);
        }

        [TestMethod()]
        public void MCPrisØresunBIzzTest()
        {
            //arrange
            Billet bil = new Billet();
            //act
            int minint = bil.MCPrisØresunBIzz();
            //assert
            Assert.AreEqual(bil.MCPrisØresunBIzz(), minint);
        }

        [TestMethod()]
        public void MCBrobizTest()
        {
            //arrange
            Billet bil = new Billet();
            //act
            int minint = bil.MCBrobiz();
            //assert
            Assert.AreEqual(bil.MCBrobiz(), minint);
        }
    }
}