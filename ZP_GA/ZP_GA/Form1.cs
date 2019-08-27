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
            List<int> allowed = new List<int> {0, 1};

            for (int i = 0; i < Instance.Rows.Count; i++)
                for (int j = 0; j < Instance.Columns.Count; j++)
                    if (!allowed.Contains(Convert.ToInt32(Instance.Rows[i][j])))
                    {
                        MessageBox.Show("Instancja jest niepoprawna!!! Znajdują się w niej cyfry inne od 0 i 1!!! Wiersz: " + (i+1) + " Kolumna: " + (j+1));
                        return;
                    }else
                    {

                    }

            TabControl1.SelectedTab = tabPage2; // zmienienie zakladki
            GenParameters.Enabled = false; // wylaczenie poprzedniej
            InstanceGridView.Enabled = false; // wylaczenie DataGridView
            ((Control)tabPage2).Enabled = true; // wlaczenie aktualnej
            TimeBox.Enabled = false;
            ImprovementBox.Enabled = false;
            // ContinueButton2.Enabled = false;
        }

        private void ContinueButton2_Click(object sender, EventArgs e)
        {

            int pop_size = Int32.Parse(PopSizeBox.Text);
            int gens = Int32.Parse(GenNumberBox.Text);
            int time = 0;

            if (TimeBox.Text != "" || TimeBox.Text != "0")
                time = Int32.Parse(TimeBox.Text);

            int iterations = 0;

            if (ImprovementBox.Text != "" || ImprovementBox.Text != "0")
                iterations = Int32.Parse(TimeBox.Text);

            int tournament_size = Int32.Parse(TournamentBox.Text);
            double cross_prob = Convert.ToDouble(Math.Round(CrossingNumeric.Value, 0)) / 100;
            double mut_prob = Convert.ToDouble(Math.Round(MutProbNumeric.Value, 0)) / 100;

            GA genetic_algorithm = new GA(Instance.Copy(), pop_size, gens, time, iterations, tournament_size, cross_prob, mut_prob);
            genetic_algorithm.life_uh_finds_a_way();
            MessageBox.Show("FINISHED!!! NAJLEPSZE ROZWIĄZANIE: " + genetic_algorithm.Best.Fitness);

            // KOD CZYSZCZĄCY!!! TRZA PRZENIEŚĆ DO TRZECIEJ ZAKŁADKI

            /* TabControl1.SelectedTab = tabPage1; // powrot do pierwszej zakladki
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
                        RadioButton r = (c as RadioButton);

                        if (t != null)
                            t.Text = "";

                        if (n != null)
                            n.Value = n.Minimum;

                        if (r != null)
                            r.Checked = false;
                    }
                }
            }

            Instance.Reset(); // czyszczenie DataTable z instancja
            ModifyButton.Enabled = false;
            GenAndSaveButton.Enabled = false;
            SaveButton.Enabled = false;
            InstanceGridView.Enabled = false;
            GeneratorButton.Enabled = false;
            ErrorBox.Text = "0"; */

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
            InstanceGridView.Enabled = false;

            int fragments = Int32.Parse(FragmentBox.Text);
            int samples = Int32.Parse(SampleBox.Text);
            double fill = Convert.ToDouble(Math.Round(FillNumeric.Value, 0)) / 100;
            int errors = Int32.Parse(ErrorBox.Text);
            Generator new_instance = Generator.Create(fragments, samples, fill, errors);

            if (new_instance != null)
            {
                Instance = new_instance.Instance.Copy();
                SBind = new BindingSource();
                SBind.DataSource = Instance;
                InstanceGridView.DataSource = SBind;

                // Kolorowanie tam gdzie bledy
                Errors = new_instance.Indices;
                foreach (Tuple<int, int> pair in Errors)
                    InstanceGridView.Rows[pair.Item1].Cells[pair.Item2].Style.BackColor = Color.Red;

                ContinueButton1.Enabled = true; // zabezpieczenie przed brakiem instancji
                ModifyButton.Enabled = true; // umozliwienie zmian
                SaveButton.Enabled = true;
            }
        }

        private void InstanceGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Wprowadziłeś złą wartość!!!");
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            InstanceGridView.Enabled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML DataTable|*.xml";
            saveFileDialog1.Title = "Zapisz instancję";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                Instance.WriteXml(saveFileDialog1.FileName, XmlWriteMode.WriteSchema);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "XML DataTable|*.xml";
            openFileDialog1.Title = "Wczytaj instancję";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Instance = new DataTable();
                Instance.ReadXml(openFileDialog1.FileName);

                SBind = new BindingSource();
                SBind.DataSource = Instance;
                InstanceGridView.DataSource = SBind;

                ContinueButton1.Enabled = true; // zabezpieczenie przed brakiem instancji
                ModifyButton.Enabled = true; // umozliwienie zmian
                SaveButton.Enabled = true;
            }
        }

        private void GenAndSaveButton_Click(object sender, EventArgs e)
        {
            GeneratorButton_Click(sender, e);
            SaveButton_Click(sender, e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TimeBox.Enabled = true;
            ImprovementBox.Enabled = true;
        }
    }
}
