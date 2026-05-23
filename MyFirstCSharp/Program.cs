using System;

namespace MyFirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 여기에 코드를 작성합니다.
            string name = "상4";
            int level = 1;
            int hp = 100;

            Console.WriteLine("안녕하세요! 유니티 공부를 시작합니다.");
            Console.WriteLine("나의 이름은: " + name);
            Console.WriteLine("현재 레벨은: " + level);
            Console.WriteLine("현재 체력은 " + hp + "입니다.");

            hp = hp - 20;
            Console.WriteLine("데미지 20. 현재 체력은 " + hp + "입니다.");
        }
    }
}