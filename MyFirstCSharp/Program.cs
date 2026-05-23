using System;
using System.Collections.Generic;

namespace GameStudy {
    // 부모 클래스
    public class Unit {
        public string name = string.Empty;
        public virtual void Action() { Console.WriteLine("대기 중..."); }
    }

    // 상속받은 자식 클래스
    public class Warrior : Unit {
        public Warrior(string name) { this.name = name; }
        public override void Action() { Console.WriteLine($"{name}이 칼을 휘두릅니다!"); }
    }

    class Program {
        static void Main() {
            // List (파이썬의 리스트와 비슷)
            List<Unit> party = new List<Unit>();
            party.Add(new Warrior("전사1"));
            party.Add(new Warrior("전사2"));

            // foreach 사용
            foreach (Unit u in party) {
                u.Action(); // 다형성: 실제 객체가 Warrior이므로 Warrior의 Action 실행
            }

            int n1 = 10, n2 = 20;
            GenericStudy.Program.Swap<int>(ref n1, ref n2); // 숫자를 바꿈
            Console.WriteLine($"n1: {n1}, n2: {n2}");

            string s1 = "Hello", s2 = "World";
            GenericStudy.Program.Swap<string>(ref s1, ref s2); // 문자열을 바꿈
            Console.WriteLine($"s1: {s1}, s2: {s2}");
        }
    }
}

namespace GenericStudy {
    class Program {
        // <T>를 붙여서 어떤 타입이든 받을 수 있는 제네릭 함수를 만듦
        public static void Swap<T>(ref T a, ref T b) {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}