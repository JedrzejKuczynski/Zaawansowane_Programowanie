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

        DataTable Instance;
        BindingSource SBind;
        List<Tuple<int, int>> Errors;

        public Form1()
        {
            InitializeComponent();
            ((Control)tabPage2).Enabled = false; // wylaczenie zakladki podczas startu programu
            GeneratorButton.Enabled = false; // zabezpieczenie przed pustymi wartosciami
            GenAndSaveButton.Enabled = false; // zabezpieczenie przed pustymi wartosciami
            ContinueButton1.Enabled = false; // zabezpieczenie przed pustymi wartosciami
            ModifyButton.Enabled = false;
            SaveButton.Enabled = false;
            InstanceGridView.Enabled = false; // zabezpieczenie przed grzebaniem w instancji
        }

        private void ContinueButton1_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabPage2; // zmienienie zakladki
            GenParameters.Enabled = false; // wylaczenie poprzedniej
            InstanceGridView.Enabled = false; // wylaczenie DataGridView
            ((Control)tabPage2).Enabled = true; // wlaczenie aktualnej
        }

        private void ContinueButton2_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabPage1; // powrot do pierwszej zakladki
            GenParameters.Enabled = true; // wlaczenie jej
            ((Control)tabPage2).Enabled = false; // wylaczenie nastepnej
            ContinueButton1.Enabled = false; // zabezpieczenie przed brakiem instancji

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

            Instance.Reset(); // czyszczenie DataTable z instancja
            ModifyButton.Enabled = false;
            GenAndSaveButton.Enabled = false;
            SaveButton.Enabled = false;
            InstanceGridView.Enabled = false;
            GeneratorButton.Enabled = false;

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
            if (!int.TryParse(SampleBox.Text, out value) || SampleBox.Text == "")
            {
                MessageBox.Show("Wpisana wartość nie jest liczbą całkowitą lub zostawiłeś puste pole!!!");
                SampleBox.Focus();
            }
        }

        private void ErrorBox_Leave(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(ErrorBox.Text, out value) || ErrorBox.Text == "")
            {
                MessageBox.Show("Wpisana wartość nie jest liczbą całkowitą lub zostawiłeś puste pole!!!");
                ErrorBox.Focus();
            }
        }

        private void FragmentBox_Enter(object sender, EventArgs e)
        {
            GeneratorButton.Enabled = true; // zabezpieczenie przed pustymi wartosciami
            GenAndSaveButton.Enabled = true;
        }

        private void SampleBox_Enter(object sender, EventArgs e)
        {
            GeneratorButton.Enabled = true; // zabezpieczenie przed pustymi wartosciami
            GenAndSaveButton.Enabled = true;
        }

        private void ErrorBox_Enter(object sender, EventArgs e)
        {
            GeneratorButton.Enabled = true; // zabezpieczenie przed pustymi wartosciami
            GenAndSaveButton.Enabled = true;
        }

        private void GeneratorButton_Click(object sender, EventArgs e)
        {
            int fragments = Int32.Parse(FragmentBox.Text);
            int samples = Int32.Parse(SampleBox.Text);
            double fill = Convert.ToDouble(Math.Round(FillNumeric.Value, 0)) / 100;
            int errors = Int32.Parse(ErrorBox.Text);
            Generator new_instance = new Generator(fragments, samples, fill, errors);

            Instance = new_instance.Instance.Copy();
            SBind = new BindingSource();
            SBind.DataSource = Instance;
            InstanceGridView.DataSource = SBind;

            // Kolorowanie tam gdzie bledy
            Errors = new_instance.Indices;
            foreach(Tuple<int, int> pair in Errors)
                InstanceGridView.Rows[pair.Item1].Cells[pair.Item2].Style.BackColor = Color.Red;

            ContinueButton1.Enabled = true; // zabezpieczenie przed brakiem instancji
            ModifyButton.Enabled = true; // umozliwienie zmian
            SaveButton.Enabled = true;
        }

        private void InstanceGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Wprowadziłeś złą wartość!!!");
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            InstanceGridView.Enabled = true;
        }
    }
}
