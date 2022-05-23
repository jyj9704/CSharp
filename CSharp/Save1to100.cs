using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Save1to100
    {
        static void Main(string[] args)
        {
            // 1부터 100까지를 변수에 저장
            /* n[0] = 1;
               n[1] = 2;
               // ...
               n[99] = 100; // 반복문 사용시 단순화 가능
            */

            int[] n = new int[100];
            for (int i = 0; i < n.Length; i++) // 100미만시 이 루프 계속 돎
            {
                n[i] = i + 1;
            }

            int x = n[10]; // x에11번째에 숫자 할당!

            // 배열을 함수(메서드)에 전달
            PrintArray(n);
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}