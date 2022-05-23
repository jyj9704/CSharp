using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            bool b = true;

            // Value타입 - 숫자, boolean, 문자타입, null지정 불가능
            short sh = 100;
            int i = 100;
            long l = 10000L; // 부호가 있는 정수
            ushort us = 111;
            uint ui = 110U;
            ulong ul = 1000UL; // 부호가 없는 정수 앞에 u사용

            float f = 3.14f; // 32bit
            double d = 3.141592d; // 64bit
            decimal dd = 3.14m; // 128bit 

            // Reference타입 - 문자열, null지정 가능 
            string s = "Hello";

            char ch = 'A'; // 문자 한개

            byte by = 0 * 46;

            object o = 123; //모든 데이타를 포함할 수 있는 타입

            int? ix = null; // int? 사용ix가 null값을 가질 수 있음
            if (ix == null)
            {
                Console.WriteLine("ix is null");
            }
            else
            {
                Console.WriteLine(ix.Value);
            }

        }
    }
}