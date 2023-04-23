using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int num=Convert.ToInt32(textBox1.Text);
            string op=comboBox1.Text;
            if (op == "Números Primos") 
            {
                int aux = 2;
                while (num > 0)
                {
                    bool sw = true;
                    for (int i = 2; i <= Math.Sqrt(aux); i++)
                    {
                        if (aux % i == 0)
                        {
                            sw = false;
                            break;
                        }
                    }
                    if (sw)
                    {
                        listBox1.Items.Add(aux);                        
                        num--;
                    }
                    aux++;
                }
            }
            if (op == "Números Perfectos")
            {
                long aux = 2;
                while (num > 0)
                {
                    int divisores = 0;
                    for (int i = 1; i < aux; i++)
                        if (aux % i == 0) 
                            divisores += i;
                    if (divisores == aux)
                    {
                        listBox1.Items.Add(aux);
                        num--;
                    }
                    aux++;
                }
            }
            if (op == "Serie Fibonacci")
            {
                int anterior = 0;
                int actual = 1;
                for (int i = 0; i < num; i++) 
                {
                    listBox1.Items.Add(anterior);
                    int aux = anterior + actual;
                    anterior = actual;
                    actual = aux;
                }
            }
        }
    }
}
