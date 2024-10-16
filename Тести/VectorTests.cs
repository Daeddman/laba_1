using NUnit;
using NUnit.Framework;
using VectorLibrary ;

namespace VectorTests
{
    [TestFixture]
    public class UnitTestVectors
    {
        [Test]
        public void TestConstructorWithoutParams()
        {
            var vector = new TVector2D();
            Assert.AreEqual(0, vector.X);  // Перевірка рівності
            Assert.AreEqual(0, vector.Y);
        }

        [Test]
        public void TestConstructorWithParams()
        {
            var vector = new TVector2D(-3, 4);
            Assert.AreEqual(3, vector.X);
            Assert.AreEqual(4, vector.Y);
        }

        [Test]
        public void TestLength()
        {
            var vector = new TVector2D(3, 4);
            Assert.AreEqual(5, vector.Length(), 0.0001);  // Перевірка з точністю
        }

        [Test]
        public void TestNormalize()
        {
            var vector = new TVector2D(3, 4);
            vector.Normalize();
            Assert.AreEqual(1, vector.Length(), 0.0001);  // Тест нормалізації
        }

        [Test]
        public void TestAddition()
        {
            var v1 = new TVector2D(1, 2);
            var v2 = new TVector2D(3, 4);
            var result = v1 + v2;
            Assert.AreEqual(4, result.X);
            Assert.AreEqual(6, result.Y);
        }

        [Test]
        public void TestSubtraction()
        {
            var v1 = new TVector2D(3, 4);
            var v2 = new TVector2D(1, 2);
            var result = v1 - v2;
            Assert.AreEqual(2, result.X);
            Assert.AreEqual(2, result.Y);
        }

        [Test]
        public void TestDotProduct()
        {
            var v1 = new TVector2D(1, 2);
            var v2 = new TVector2D(3, 4);
            var result = v1 * v2;
            Assert.AreEqual(11, result);
        }

        [Test]
        public void TestTVector3DConstructor()
        {
            var vector = new TVector3D(1, 2, 3);
            Assert.AreEqual(1, vector.X);
            Assert.AreEqual(2, vector.Y);
            Assert.AreEqual(3, vector.Z);
        }
    }
}
