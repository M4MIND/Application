using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application
{
    public partial class Form1 : Form
    {

        private Mobile[] list = {
            new Mobile("Samsung S21", "Samsung", 60000, 8, 8, 128, false),
            new Mobile("Samsung S20", "Samsung", 50000, 8, 8,128, false),
            new Mobile("Samsung S10", "Samsung", 40000, 4, 8, 64, false),
            new Mobile("Samsung A21", "Samsung", 30000, 2, 8, 32, true),
            new Mobile("Samsung A31", "Samsung", 20000, 4, 8, 32, false),
            new Mobile("Samsung A80", "Samsung", 10000, 6, 8, 32, false),
            new Mobile("Samsung S9", "Samsung", 35000, 6, 8, 64, false),
            new Mobile("Xiaomi 10", "Xiaomi", 29000, 6, 8, 16, true),
            new Mobile("Xiaomi 10", "Xiaomi", 23000, 6, 8, 32, false),
            new Mobile("Xiaomi 8", "Xiaomi", 25000, 6, 8, 32, false),
            new Mobile("Xiaomi 4", "Xiaomi", 12000, 6, 8, 32, true),
            new Mobile("Xiaomi 12", "Xiaomi", 34890, 6, 8, 64, false),
            new Mobile("Xiaomi 8", "Xiaomi", 28999, 6, 8, 128, false),
            new Mobile("Xiaomi A34", "Xiaomi",13000, 6, 8, 32, false),
            new Mobile("Yota L10", "Yota", 13000, 6, 8, 32, true),
            new Mobile("Yota L12", "Yota", 14000, 6, 8, 64, false),
            new Mobile("Yota L14", "Yota", 19000, 6, 8, 64, true),
            new Mobile("Yota L9", "Yota", 80000, 6, 8, 32, false),
        };

        public Form1()
        {
            InitializeComponent();
            Maker.Items.AddRange(new object[] { 
                "Samsung",
                "Xiaomi",
                "Nokia",
                "Motorola",
                "Yota"
            });
            ValueOZU.Items.AddRange(new object[] { 
                "1",
                "2",
                "4",
                "8",
                "16"
            });
            ValuePZU.Items.AddRange(new object[] { 
                "16",
                "32",
                "64",
                "128",
                "256",
                "512",
            });

            CountCPU.Items.AddRange(new object[] {
                "1",
                "2",
                "4",
                "8"
            });


            Maker.SelectedIndex = 0;
            ValueOZU.SelectedIndex = 0;
            ValuePZU.SelectedIndex = 0;
            CountCPU.SelectedIndex = 0;

            PriceFrom.Text = "0";
            PriceTo.Text = "0";

            foreach(Mobile item in this.list) {
                Result.Items.Add($"{item.Title} - Цена {item.Price} - CPU {item.Cpu} - ОЗУ {item.Ozu} - ПЗУ {item.Pzu}");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void Search_Click_1(object sender, EventArgs e)
        {
            string manufacturer = Maker.Text;
            int priceFrom = int.Parse(PriceFrom.Text);
            int priceTo = int.Parse(PriceTo.Text);
            int ozu = int.Parse(ValueOZU.Text);
            int pzu = int.Parse(ValuePZU.Text);
            int cpu = int.Parse(CountCPU.Text);
            bool sale = Sale.Checked;

            List<Mobile> result = new List<Mobile> ();

            Result.Items.Clear();

            foreach (Mobile item in this.list)
            {
                if (manufacturer.Length > 0 && manufacturer != item.Manufacturer)
                {
                    continue;
                }

                if (priceFrom > 0 && priceTo > 0 && (!(item.Price >= priceFrom) || !(item.Price <= priceTo)))
                {
                    continue;
                }

                if (ozu != item.Ozu)
                {
                    continue;
                }

                if (pzu != item.Pzu)
                {
                    continue;
                }

                if (cpu != item.Cpu)
                {
                    continue;
                }

                if (sale != item.Sale)
                {
                    continue;
                }

                result.Add(item);
            }

            result.ForEach(item =>
            {
                Result.Items.Add($"{item.Title} - Цена {item.Price} - CPU {item.Cpu} - ОЗУ {item.Ozu} - ПЗУ {item.Pzu}");
            });
        }
    }
}
