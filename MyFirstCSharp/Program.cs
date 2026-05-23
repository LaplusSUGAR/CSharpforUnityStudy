using System;

namespace MyFirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 변수 선언과 초기화
            string characterName = "Gaurdian";
            int level = 11;
            float speed = 4.5f;
            bool isGrounded = true;

            // 2. 출력 (데이터 확인)
            Console.WriteLine("==Character Info==");
            Console.WriteLine("Name: "+characterName);
            Console.WriteLine("Level: "+level);
            Console.WriteLine("Moving Speed: "+speed);
            Console.WriteLine("Is It Grounded? "+isGrounded);

            // 3. 데이터 변경
            level = level + 1;
            Console.WriteLine("Congratulation! Level UP to "+level);
        }
    }
}