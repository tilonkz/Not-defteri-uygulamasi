using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotDefteriUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kaydedilecek = "";
        private void yazıFontuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if(font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = font.Font;
            }
        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog.Color;
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ac();
        }

        private void ac()
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                kaydedilecek = open.FileName;
                string oku = File.ReadAllText(open.FileName);
                richTextBox1.Text = oku;
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        private void kaydet()
        {
            if(kaydedilecek == "")
            {
                farkliKaydet();
            }
            else
            {
                File.WriteAllText(kaydedilecek, richTextBox1.Text);
            }
        }
        private void farkliKaydet()
        {
            SaveFileDialog save = new SaveFileDialog();
            if(save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, richTextBox1.Text);
                kaydedilecek = save.FileName;
            }
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farkliKaydet();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by @tilonkz (Muhammet Ali Can Herdem)", "Hakkında");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
