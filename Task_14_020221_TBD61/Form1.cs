using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_14_020221_TBD61
{
    public partial class Form1 : Form
    {
        private List<BOX> boxes = new List<BOX>();
        public Form1()
        {
            InitializeComponent();
            
            BOX box1 = new BOX();
            BOX box2 = new BOX(5, 13.4f, 7.1f, 5.6f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            float wdt = Convert.ToSingle(textBox2.Text);
            float weig = Convert.ToSingle(textBox3.Text);
            float len = Convert.ToSingle(textBox4.Text);

            if (num > 0 || wdt > 0 || weig > 0 || len > 0 )
            {
                boxes.Add(new BOX(num, wdt, weig, len));

                Console.WriteLine("Коробка добавлена в коллекцию");
            }
        }
    }
}
