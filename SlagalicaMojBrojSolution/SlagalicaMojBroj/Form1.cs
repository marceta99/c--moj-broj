using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlagalicaMojBroj
{
    public partial class Form1 : Form
    {

        Random ran = new Random();
        int a, b, c, d,g,f, trazeniBroj;

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string izraz = textBox8.Text;

                
                
                
                
                
                DataTable t = new DataTable();

                label1.Text = (t.Compute(izraz, "")).ToString();
                

            }
            catch
            {
                label1.Text = "MISTAKE"; 
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = ran.Next(1, 10);//jednocifreni brojevi :  
            b = ran.Next(1, 10);
            c = ran.Next(1, 10);
            d = ran.Next(1, 10);

            textBox1.Text = a.ToString();
            textBox2.Text = b.ToString();
            textBox3.Text = c.ToString();
            textBox4.Text = d.ToString();

            int[] niz1 = new int[3] { 10, 15, 20 };  //ovo su dvocifreni 

            g = niz1[(ran.Next(0, 3))]; //g je random broj od 10,15,20 

            int[] niz2 = { 25, 50, 75, 100 };

            f = niz2[ran.Next(0, 4)];

            textBox5.Text = g.ToString();
            textBox6.Text = f.ToString();

            trazeniBroj = ran.Next(1, 1000);

            textBox7.Text = trazeniBroj.ToString();  



        }

         

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
    }
}
