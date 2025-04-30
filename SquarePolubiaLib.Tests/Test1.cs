using SquarePolybiaLib;

namespace SquarePolubiaLib.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PolybiusSquare ps = new PolybiusSquare();

            string text = "cat";
            string expected = "131144";

            string actual = ps.Encrypt(text);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            PolybiusSquare ps = new PolybiusSquare();

            string text = "aboba";
            string expected = "1112341211";

            string actual = ps.Encrypt(text);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            PolybiusSquare ps = new PolybiusSquare();

            string text = "hello";
            string expected = "2315313134";

            string actual = ps.Encrypt(text);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            PolybiusSquare ps = new PolybiusSquare();

            string text = "131144";
            string expected = "cat";

            string actual = ps.Decrypt(text);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            PolybiusSquare ps = new PolybiusSquare();

            string text = "2315313134";
            string expected = "hello";

            string actual = ps.Decrypt(text);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            PolybiusSquare ps = new PolybiusSquare();
            bool result = false;
            string text = "9999";
            string expected = "";
            try
            {
                string actual = ps.Decrypt(text);
            }
            catch (Exception ex)
            {
                 result = true;
            }
            Assert.IsTrue(result);
            
        }

        [TestMethod]
        public void TestMethod7()
        {
            PolybiusSquare ps = new PolybiusSquare();

            string text = "";
            string expected = "";

            string actual = ps.Encrypt(text);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod8()
        {
            PolybiusSquare ps = new PolybiusSquare();

            string text = "";
            string expected = "";

            string actual = ps.Decrypt(text);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod9()
        {
            PolybiusSquare ps = new PolybiusSquare();

            string text = "ice";
            string expected = "241315";

            string actual = ps.Encrypt(text);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod10()
        {
            PolybiusSquare ps = new PolybiusSquare();

            string text = "joke";
            string expected = "24342515";

            string actual = ps.Encrypt(text);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod11()
        {
            PolybiusSquare ps = new PolybiusSquare();

            string text = "Кот";
            string expected = "243236";

            string actual = ps.EncryptRu(text);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod12()
        {
            PolybiusSquare ps = new PolybiusSquare();

            string text = "память";
            string expected = "331126563652";

            string actual = ps.EncryptRu(text);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod13()
        {
            PolybiusSquare ps = new PolybiusSquare();

            string text = "46234234";
            string expected = "шифр";

            string actual = ps.DecryptRu(text);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod14()
        {
            PolybiusSquare ps = new PolybiusSquare();

            string text = "1352162215";
            string expected = "въезд";

            string actual = ps.DecryptRu(text);
            Assert.AreEqual(expected, actual);
        }
    }
}
