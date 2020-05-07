using NUnit.Framework;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
/* При первом слогаемом "1" ошибка.
 * При втором слагаемом "4" ошибка.
 * При первом множителе "15" ошибка.
 * При втором множителе "13" ошибка.
 * При уменьшаемом "8" ошибка.
 * При вычитаемом "10" ошибка.
 * При делимом "19" ошибка.
 * При делителе "11" ошибка.
 */
namespace NUnitTestProject1
{
    public class Tests
    {
        Calculator.Methods a = new Calculator.Methods();
        
        [TestCaseSource(typeof(elements), "Cases")]
        [Test]
        public void Test1(double x, double y)
        {  
            Assert.AreEqual(x + y, a.addition(x, y), "сумма");
        }
        [TestCaseSource(typeof(elements), "Cases")]
        [Test]
        public void Test2(double x, double y)
        {
            Assert.AreEqual(x * y, a.multiplication(x, y), "произведение");
        }
        [TestCaseSource(typeof(elements), "Cases")]
        [Test]
        public void Test3(double x, double y)
        {
            Assert.AreEqual(x - y, a.difference(x, y), "разность");
        }
        [TestCaseSource(typeof(elements), "Cases")]
        [Test]
        public void Test4(double x, double y)
        {
            Assert.AreEqual(x / y, a.division(x, y), "частное");
        }
    }
}