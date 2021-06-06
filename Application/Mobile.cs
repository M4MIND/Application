using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Mobile
    {
        private string title;
        private string manufacturer;
        private int price;
        private int cpu;
        private int ozu;
        private bool sale;
        private int pzu;

        public Mobile(string title, string manufacturer, int price, int cpu, int ozu, int pzu, bool sale)
        {
            this.Title = title;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Cpu = cpu;
            this.Ozu = ozu;
            this.Sale = sale;
            this.Pzu = pzu;
        }

        public int Ozu { get => ozu; set => ozu = value; }
        public int Cpu { get => cpu; set => cpu = value; }
        public int Price { get => price; set => price = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string Title { get => title; set => title = value; }
        public bool Sale { get => sale; set => sale = value; }
        public int Pzu { get => pzu; set => pzu = value; }
    }
}
