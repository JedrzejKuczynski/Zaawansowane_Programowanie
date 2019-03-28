using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZP_GA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ((Control)tabPage2).Enabled = false; // wylaczenie zakladki podczas startu programu
        }

        private void FragmentLabel_Click(object sender, EventArgs e)
        {

        }

        private void SampleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContinueButton1_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabPage2; // zmienienie zakladki
            GenParameters.Enabled = false; // wylaczenie poprzedniej
            ((Control)tabPage2).Enabled = true; // wlaczenie aktualnej
        }

        private void ContinueButton2_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabPage1; // powrot do pierwszej zakladki
            GenParameters.Enabled = true; // wlaczenie jej
            ((Control)tabPage2).Enabled = false; // wylaczenie nastepnej

            foreach (TabPage tp in TabControl1.TabPages) // czyszczenie wartosci
            {
                foreach (Panel p in tp.Controls)
                {
                    foreach (Control c in p.Controls)
                    {
                        TextBox t = (c as TextBox);
                        NumericUpDown n = (c as NumericUpDown);

                        if (t != null)
                            t.Text = "";

                        if (n != null)
                            n.Value = n.Minimum;
                    }
                }
            }

        }

        private void FragmentBox_Leave(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(FragmentBox.Text, out value) || FragmentBox.Text == "")
            {
                MessageBox.Show("Wpisana wartość nie jest liczbą całkowitą lub zostawiłeś puste pole!!!");
                FragmentBox.Focus();
            }
        }

        private void SampleBox_Leave(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(FragmentBox.Text, out value) || FragmentBox.Text == "")
            {
                MessageBox.Show("Wpisana wartość nie jest liczbą całkowitą lub zostawiłeś puste pole!!!");
                FragmentBox.Focus();
            }
        }

        private void ErrorBox_Leave(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(FragmentBox.Text, out value) || FragmentBox.Text == "")
            {
                MessageBox.Show("Wpisana wartość nie jest liczbą całkowitą lub zostawiłeś puste pole!!!");
                FragmentBox.Focus();
            }
        }
    }
}
