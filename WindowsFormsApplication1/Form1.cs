
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form

    {
        Tablero t;
        public Form1()
        {
            InitializeComponent();
            t = new Tablero(10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
               
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            t.next();
            t.update();
            this.Invalidate();
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            t.Dibuja(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = ("Cada célula que tenga dos o tres fichas vecinas sobrevive.                                     Cada ficha que tenga cuatro o más vecinas muere.                                              Cada casilla vacía, adyacente a exactamente tres cifras vecinas es casilla generatriz.");
           
           
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Reiniciar programa
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
