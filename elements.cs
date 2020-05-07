using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NUnitTestProject1
{
    public class elements
    {
        public static object [] Cases
        {
            get
            {
                var list = new List<object>();
                for(var a = 1; a<=20; a++)
                {
                    for(var b = 1; b<=20; b++)
                    {
                        list.Add(new object [] {a, b});
                    }
                }
                return list.ToArray();
            }
        }
    }
}
