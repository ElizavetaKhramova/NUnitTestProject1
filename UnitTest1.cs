using NUnit.Framework;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
/* ��� ������ ��������� "1" ������.
 * ��� ������ ��������� "4" ������.
 * ��� ������ ��������� "15" ������.
 * ��� ������ ��������� "13" ������.
 * ��� ����������� "8" ������.
 * ��� ���������� "10" ������.
 * ��� ������� "19" ������.
 * ��� �������� "11" ������.
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
            Assert.AreEqual(x + y, a.addition(x, y), "�����");
        }
        [TestCaseSource(typeof(elements), "Cases")]
        [Test]
        public void Test2(double x, double y)
        {
            Assert.AreEqual(x * y, a.multiplication(x, y), "������������");
        }
        [TestCaseSource(typeof(elements), "Cases")]
        [Test]
        public void Test3(double x, double y)
        {
            Assert.AreEqual(x - y, a.difference(x, y), "��������");
        }
        [TestCaseSource(typeof(elements), "Cases")]
        [Test]
        public void Test4(double x, double y)
        {
            Assert.AreEqual(x / y, a.division(x, y), "�������");
        }
    }
}