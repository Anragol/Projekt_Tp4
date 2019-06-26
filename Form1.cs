using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektTp4
{
    public partial class Form1 : Form
    {
        Queue<int> elev_que = new Queue<int>();
        int y = 200;
        int deltay = 0;
        int curr_flor = 0;
        int next_flor = 0;
        int pass_in = 0;
        int pass_out = 0;
        int pass = 0;
        int test1 = 0;
        int test2 = 0;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //guzik do sprawdzania i inicjalizowania

            try
            {
                pass_in = Convert.ToInt32(textBox1.Text);
                if (pass_in < 0) { pass_in = pass_in * (-1); }
                test1 = 1;
            }
            catch (System.FormatException)
            {

                //MessageBox.Show("Zly format w pasazerach whodzacych");
                pass_in = 0;
                test1 = 1;
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Za duza liczba przy pasazerach wchodzacych");
                pass_in = 0;
                test1 = 0;
            }

            try
            {
                pass_out = Convert.ToInt32(textBox2.Text);
                if (pass_out < 0) { pass_out = pass_out * (-1); }
                test2 = 1;
            }
            catch (System.FormatException)
            {

                //MessageBox.Show("Zly format w pasazerach wyhodzacych");
                pass_in = 0;
                test2 = 1;
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Za duza liczba przy pasazerach wychodzacych");
                pass_in = 0;
                test2 = 0;
            }

            if(test1 == 1 && test2 == 1)
            {   if (elev_que.Count == 0) elev_que.Enqueue(0);
                next_flor = elev_que.Peek();
                elev_que.Dequeue();
                deltay = next_flor - curr_flor;
                curr_flor = next_flor;
                timer1.Enabled = true; //THE WORLD!!!
            }
        }

        private void Button2_Click(object sender, EventArgs e)//guziki w windzie
        {
            elev_que.Enqueue(0);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            elev_que.Enqueue(1);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            elev_que.Enqueue(2);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            elev_que.Enqueue(3);
        }

        private void Parter_prz_Click(object sender, EventArgs e)//guziki na poszcz pietrach
        {
            elev_que.Enqueue(0);
        }

        private void Prz_1_ptr_Click(object sender, EventArgs e)
        {
            elev_que.Enqueue(1);
        }

        private void Prz_2_ptr_Click(object sender, EventArgs e)
        {
            elev_que.Enqueue(2);
        }

        private void Prz_3_ptr_Click(object sender, EventArgs e)
        {
            elev_que.Enqueue(3);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)//rysowanie 
        {
            e.Graphics.FillRectangle(Brushes.Black, 50, y, 50, 75);//nasza winda
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int test = Math.Abs(deltay);
            if (test == 0) test = 1;
            int znak = deltay / test;
            y = y + 10 * -znak;
            i++;
            Invalidate();

            if (i == 5*test)
            {
                timer1.Enabled = false; //THE WORLD!!!
                i = 0;
            }
        }
    }
}
