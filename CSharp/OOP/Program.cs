using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        //객체 (OOP Object Oriented Programming)

        // Knight
        // 
        // 속성: HP, Attack, pos
        // 기능: Move, Attack, Die

        class Knight
        {
            public int hp;
            public int attack;

            public void Move()
            {
                Console.WriteLine("Knight Move");
            }

            public void Attack()
            {
                Console.WriteLine("Knight Attack");
            }

        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;

            knight.Move();
            knight.Attack();
        }
    }
}
