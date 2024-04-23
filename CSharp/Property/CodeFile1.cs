using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property2
{
    // 객체지향 > 은닉성
    class Knight
    {

        public int Hp { get; set; }
        //위와 같이 선언 하면 아래 3줄를 한 번에 만드는 효과를 낸다.


        private int _hp;
        public int GetHp() { return _hp; }
        public void SetHp(int value) { _hp = value; }

        //protected int hp;

        //public int Hp
        //{
        //    get { return hp; }
        //    private set { hp = value; }
        //}


        // 아래는 이전에 쓰던 방식.
        //public int GetHp() { return hp; }
        //public void SetHp(int hp) { this.hp = hp; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Hp = 100;
            Console.WriteLine("test");
        }
    }
}
