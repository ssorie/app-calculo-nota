//Nota sala

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double trabalho, projeto, prova, media;
            trabalho = Convert.ToDouble(txttrabalho.Text);
            projeto = Convert.ToDouble(txtprojeto.Text);
            prova = Convert.ToDouble(txtprova.Text);
            media = (trabalho + projeto + prova) / 3;
            if (media >= 6)
            {
                listBox1.Items.Add(txtnome.Text+ " - " +media.ToString("0.00"));
            }
            else if (media < 3)
            {
                listBox2.Items.Add(txtnome.Text+ " - " +media.ToString("0.00"));
            }
           else
            {
                listBox3.Items.Add(txtnome.Text+ " - " +media.ToString("0.00"));
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtra.Clear();
            txtnome.Clear();
            txtprojeto.Clear();     
            txtprova.Clear();   
            txttrabalho.Clear();
            cboturma.Text = "selecione...";
            txtra.Focus();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = "Data: " + DateTime.Now.ToString("dd/mm/yyyy");
            statusStrip1.Items[1].Text = "Hora: " + DateTime.Now.ToString("dd/mm/yyyy");
            statusStrip1.Items[2].Text = "Programador: kkj ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void lblrecuperacao_Click(object sender, EventArgs e)
        {

        }
    }
}
