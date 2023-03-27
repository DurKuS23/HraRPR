using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Hra
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NameLenghtFalse()
        {
            string name = "Ahojkarle123";
            Assert.IsFalse(name.Length > 10);
        }
        [TestMethod]
        public void NameLenghtTrue()
        {
            string name = "Ahojkarle123";
            Assert.IsTrue(name.Length > 10);
        }

        [TestMethod]
        public void InicializaceLVLFalse()
        {
            int level = 2;
            Assert.AreEqual(1, level);
        }
        [TestMethod]
        public void InicializaceLVLTrue()
        {
            int level = 2;
            Assert.AreNotEqual(1, level);
        }

        [TestMethod]
        public void ContainsTrue()
        {
            string[] Specializations = { "Kouzelník", "Berserker", "Inženýr", "Čízák" };
            string Specialization = "Kouzelník";

            Assert.IsTrue(Specializations.Contains(Specialization));
        }

        [TestMethod]
        public void ContainsFalse()
        {
            string[] Specializations = { "Kouzelník", "Berserker", "Inženýr", "Čízák" };
            string Specialization = "Kouzelník";

            Assert.IsFalse(Specializations.Contains(Specialization));
        }

        [TestMethod]
        public void PositionXTrue()
        {
            int positionX = 1;
            Assert.AreEqual(0, positionX);
        }
        [TestMethod]
        public void PositionXFalse()
        {
            int positionX = 1;
            Assert.AreNotEqual(0, positionX);
        }
        [TestMethod]
        public void PositionYTrue()
        {
            int positionY = 0;
            Assert.AreEqual(0, positionY);
        }
        [TestMethod]
        public void PositionYFalse()
        {
            int positionY = 0;
            Assert.AreNotEqual(0, positionY);
        }

        enum Face
        {
            velkýnos,
            ušoplesk,
            makeup
        }

        [TestMethod]
        public void FaceInicializationTrue()
        {
            string face = "makeup";

            Assert.IsTrue(Convert.ToString(Face.velkýnos) == face || Convert.ToString(Face.ušoplesk) == face || Convert.ToString(Face.makeup) == face);
        }

        [TestMethod]
        public void FaceInicializationFalse()
        {
            string face = "makeup";

            Assert.IsFalse(Convert.ToString(Face.velkýnos) == face || Convert.ToString(Face.ušoplesk) == face || Convert.ToString(Face.makeup) == face);
        }

        enum Hair
        {
            drdol,
            culík,
            pleška
        }
        [TestMethod]
        public void HairInicializationTrue()
        {
            string hair = "drdol";

            Assert.IsTrue(Convert.ToString(Hair.drdol) == hair || Convert.ToString(Hair.pleška) == hair || Convert.ToString(Hair.culík) == hair);
        }
        [TestMethod]
        public void HairInicializationFalse()
        {
            string hair = "drdol";

            Assert.IsFalse(Convert.ToString(Hair.drdol) == hair || Convert.ToString(Hair.pleška) == hair || Convert.ToString(Hair.culík) == hair);
        }
    }
}
