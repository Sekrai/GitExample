using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Player
    {
        public void Init()
        {
            myHealth = 100;

            AttackAction = (aValue) =>
            {
                Attack(aValue);
            };
        }

        public void Update()
        {
            Console.WriteLine(myHealth);
        }

        private void Attack(int aValue)
        {
            myHealth -= aValue;
        }

        public Action<int> AttackAction;
        int myHealth;
    }
}
