using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;


namespace MathTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSquareRoot()
        {
            var assembly = Assembly.LoadFrom("ReflectionDemo.dll");
            var type = assembly.GetType("ReflectionDemo.Math");
            var methods = type.GetMethods(BindingFlags.NonPublic|BindingFlags.Instance);
            var constructor = type.GetConstructor(new Type[0]);
            var obj = constructor.Invoke(new Object[0]);
            double result = -1;
            foreach (var method in methods)
            {
                if (method.Name == "QubeRoot")
                {
                    var response = method.Invoke(obj, new Object[] { 64 });
                    result = (double)response;
                }
            }
            Assert.AreEqual(result,4,1);
        }
    }
}
