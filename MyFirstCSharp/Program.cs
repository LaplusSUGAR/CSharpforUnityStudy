using System;
using System.Collections.Generic;

namespace SharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 파이썬과 다른 리스트 사용법 (Generic)
            List<string> inventory = new List<string>();
            inventory.Add("단검");
            inventory.Add("물약");

            // 2. 엄격한 형변환 (float 뒤에 f를 안 붙이면 에러!)
            float moveSpeed = 5.5f;
            int roundedSpeed = (int)moveSpeed; // 소수점 버림

            // 3. 배열 선언 (크기 고정)
            string[] skills = new string[3] {"베기", "찌르기", "방어"};

            Console.WriteLine($"캐릭터 정보: 속도 {roundedSpeed}, 첫번째 스킬 {skills[0]}");

            // 4. 반복문 (파이썬의 for item in list와 비교)
            foreach (string item in inventory)
            {
                Console.WriteLine($"인벤토리 아이템: {item}");
            }
        }
    }
}