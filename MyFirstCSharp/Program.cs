using System;
using System.Collections.Generic;

namespace GameStudy {
    // 부모 클래스
    public class Unit {
        public string name;
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
        }
    }
}