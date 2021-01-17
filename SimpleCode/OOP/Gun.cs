using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Gun
    {
        private bool isLoaded;

        private void Reload() 
        {
            Console.WriteLine("Заряжаю...");

            isLoaded = true;

            Console.WriteLine("Заряжено!");
        }

        public void Shoot() 
        {
            if (!isLoaded)
            {
                Console.WriteLine("Орудие не заряжено!");
                Reload();
            }
            Console.WriteLine("Выстрел!");
            isLoaded = false;
        }
    }
}
