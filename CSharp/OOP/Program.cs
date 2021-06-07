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

        // Ref, 참조
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

        // Copy 복사
        struct Mage
        {
            public int hp;
            public int attack;
        }

        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }

        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }

        static void Main(string[] args)
        {
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;
            KillMage(mage);

            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10; 
            KillKnight(knight); 

            knight.Move();
            knight.Attack();
        }
    }
}
