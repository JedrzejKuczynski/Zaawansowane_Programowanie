using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZP_GA
{
    public partial class Form1 : Form
    {

        DataTable Instance;
        DataTable Solution;
        BindingSource SBind;
        BindingSource SolutionBind;
        List<Tuple<int, int>> Errors;

        bool pause = false;
        bool stop = false;

        GA genetic_algorithm;
        BackgroundWorker bw;

        private Tuple<bool, bool> update_form(int current_gen, int current_value)
        {
            if (!pause)
            {
                base.Invoke((Action)delegate
               {
                   progressBar1.Value = current_gen;

                   ProgressChart.Series["Funkcja celu"].Points.AddY(current_value);
               });

                Tuple<bool, bool> pause_stop = new Tuple<bool, bool>(false, stop);

                return pause_stop;
            }
            else
            {
                Tuple<bool, bool> pause_stop = new Tuple<bool, bool>(true, stop);

                return pause_stop;
            }
        }


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
            ((Control)tabPage3).Enabled = false;
            ContinueButton2.Enabled = false;
            ContinueButton3.Enabled = false;
            PauseButton.Enabled = false;
            TournamentBox.Enabled = false;
            TimeBox.Enabled = false;
            ImprovementBox.Enabled = false;
            CreateButton.Enabled = false;
            StopButton.Enabled = false;

            Tests tests = new Tests();
            tests.run_tests();
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
        }

        private void ContinueButton2_Click(object sender, EventArgs e)
        {
            PopSizeBox.Enabled = false;
            GenNumberBox.Enabled = false;

            if (AdditionalRadioButton.Checked == true)
            {
                TimeBox.Enabled = false;
                ImprovementBox.Enabled = false;
            }

            CrossingNumeric.Enabled = false;
            MutProbNumeric.Enabled = false;

            ContinueButton2.Enabled = false;
            ContinueButton3.Enabled = false;
            ReturnButton1.Enabled = false;

            int pop_size = Int32.Parse(PopSizeBox.Text);
            int gens = Int32.Parse(GenNumberBox.Text);
            int time = 0;

            if (TimeBox.Text != "" || TimeBox.Text != "0")
                time = Int32.Parse(TimeBox.Text);

            int iterations = 0;

            if (ImprovementBox.Text != "" || ImprovementBox.Text != "0")
                iterations = Int32.Parse(ImprovementBox.Text);

            int tournament_size = Int32.Parse(TournamentBox.Text);
            double cross_prob = Convert.ToDouble(Math.Round(CrossingNumeric.Value, 0)) / 100;
            double mut_prob = Convert.ToDouble(Math.Round(MutProbNumeric.Value, 0)) / 100;

            genetic_algorithm = new GA(Instance.Copy(), pop_size, gens, time, iterations, tournament_size, cross_prob, mut_prob);

            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            progressBar1.Maximum = gens - 1;

            ProgressChart.Series["Funkcja celu"].Points.Clear();

            genetic_algorithm.OnProgressUpdate += update_form;

            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;

            bw.DoWork += new DoWorkEventHandler(
            delegate (object o, DoWorkEventArgs args)
            {
                BackgroundWorker b = o as BackgroundWorker;

                GA ga = args.Argument as GA;

                ga.life_uh_finds_a_way();
            }
            );


            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
            delegate (object o, RunWorkerCompletedEventArgs args)
            {
                MessageBox.Show("Skończone!!! NAJLEPSZE ROZWIĄZANIE: " + genetic_algorithm.Best.Fitness);


                ContinueButton3.Enabled = true;
                ReturnButton1.Enabled = true;

                PopSizeBox.Enabled = true;
                GenNumberBox.Enabled = true;

                if (AdditionalRadioButton.Checked == true)
                {
                    TimeBox.Enabled = true;
                    ImprovementBox.Enabled = true;
                }

                CrossingNumeric.Enabled = true;
                MutProbNumeric.Enabled = true;

                ContinueButton2.Enabled = true;

                pause = false;
                PauseButton.Text = "Pauza";
                stop = false;
            });

            bw.RunWorkerAsync(genetic_algorithm);

            PauseButton.Enabled = true;
            StopButton.Enabled = true;
        }

        private void FragmentBox_Leave(object sender, EventArgs e)
        {
            int value = 0;
            bool parsed = int.TryParse(FragmentBox.Text, out value);
            if (!parsed || FragmentBox.Text == "" || value <= 0)
            {
                MessageBox.Show("Wpisana wartość nie jest liczbą całkowitą, jest mniejsza lub równa zero albo zostawiłeś puste pole!!!");
                FragmentBox.Focus();
            }
        }

        private void SampleBox_Leave(object sender, EventArgs e)
        {
            int value = 0;
            bool parsed = int.TryParse(SampleBox.Text, out value);
            if (!parsed || SampleBox.Text == "" || value <= 0)
            {
                MessageBox.Show("Wpisana wartość nie jest liczbą całkowitą, jest mniejsza lub równa zero albo zostawiłeś puste pole!!!");
                SampleBox.Focus();
            }
        }

        private void ErrorBox_Leave(object sender, EventArgs e)
        {
            int value = 0;
            bool parsed = int.TryParse(ErrorBox.Text, out value);
            if (!parsed || ErrorBox.Text == "" || value < 0)
            {
                MessageBox.Show("Wpisana wartość nie jest liczbą całkowitą, jest mniejsza od zera albo zostawiłeś puste pole!!!");
                ErrorBox.Focus();
            }
        }

        private void FragmentBox_Enter(object sender, EventArgs e)
        {
            GeneratorButton.Enabled = true; // zabezpieczenie przed pustymi wartosciami
            CreateButton.Enabled = true;
            GenAndSaveButton.Enabled = true;
        }

        private void SampleBox_Enter(object sender, EventArgs e)
        {
            GeneratorButton.Enabled = true; // zabezpieczenie przed pustymi wartosciami
            CreateButton.Enabled = true;
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
            MessageBox.Show("Wprowadziłeś zły typ wartości do macierzy!!!");
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            InstanceGridView.Enabled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML DataTable|*.xml";
            saveFileDialog1.Title = "Zapisz macierz";
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
            openFileDialog1.Title = "Wczytaj macierz";

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

        private void ContinueButton3_Click(object sender, EventArgs e)
        {
            SolutionGridView.DataSource = null;
            SolutionBind = new BindingSource();
            Solution = genetic_algorithm.Best.Solution.Copy();
            SolutionBind.DataSource = Solution;
            SolutionGridView.DataSource = SolutionBind;

            SolutionValueBox.Text = genetic_algorithm.Best.Fitness.ToString();

            ((Control)tabPage2).Enabled = false;

            ((Control)tabPage3).Enabled = true;
            TabControl1.SelectedTab = tabPage3;
        }

        private void ReturnButton1_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabPage1;
            GenParameters.Enabled = true;
            InstanceGridView.Enabled = false;
            AdditionalRadioButton.Checked = false;
            TimeBox.Text = "0";
            ImprovementBox.Text = "0";
            ContinueButton2.Enabled = false;
            ((Control)tabPage1).Enabled = true;
            ((Control)tabPage2).Enabled = false;
        }

        private void PopSizeBox_Enter(object sender, EventArgs e)
        {
            ContinueButton2.Enabled = true;
            TournamentBox.Enabled = true;
        }

        private void PopSizeBox_Leave(object sender, EventArgs e)
        {
            int value = 0;
            bool parsed = int.TryParse(PopSizeBox.Text, out value);
            if (!parsed || PopSizeBox.Text == "" || value <= 0 || value % 2 != 0)
            {
                MessageBox.Show("Wpisana wartość nie jest liczbą całkowitą lub parzystą, jest mniejsza lub równa zero albo zostawiłeś puste pole!!!");
                PopSizeBox.Focus();
            }
        }

        private void GenNumberBox_Leave(object sender, EventArgs e)
        {
            int value = 0;
            bool parsed = int.TryParse(GenNumberBox.Text, out value);
            if (!parsed || GenNumberBox.Text == "" || value <= 0)
            {
                MessageBox.Show("Wpisana wartość nie jest liczbą całkowitą, jest mniejsza lub równa zero albo zostawiłeś puste pole!!!");
                GenNumberBox.Focus();
            }
        }

        private void TournamentBox_Leave(object sender, EventArgs e)
        {
            int value = 0;
            bool parsed = int.TryParse(TournamentBox.Text, out value);
            if (!parsed || TournamentBox.Text == "" || value <= 0 || value > Int32.Parse(PopSizeBox.Text))
            {
                MessageBox.Show("Wpisana wartość nie jest liczbą całkowitą, jest mniejsza lub równa zero, jest większa od wielkości populacji albo zostawiłeś puste pole!!!");
                TournamentBox.Focus();
            }
        }

        private void TimeBox_Leave(object sender, EventArgs e)
        {
            int value = 0;
            bool parsed = int.TryParse(TimeBox.Text, out value);
            if (!parsed || value < 0)
            {
                MessageBox.Show("Wpisana wartość nie jest liczbą całkowitą, jest mniejsza od zera lub zostawiłeś puste pole!!! POZOSTAW ZERO, ABY NIE UŻYWAĆ PARAMETRU.");
                TimeBox.Focus();
            }
        }

        private void ImprovementBox_Leave(object sender, EventArgs e)
        {
            int value = 0;
            bool parsed = int.TryParse(ImprovementBox.Text, out value);
            if (!parsed || value < 0)
            {
                MessageBox.Show("Wpisana wartość nie jest liczbą całkowitą, jest mniejsza od zera lub zostawiłeś puste pole!!! POZOSTAW ZERO, ABY NIE UŻYWAĆ PARAMETRU.");
                ImprovementBox.Focus();
            }
        }

        private void ReturnButton2_Click(object sender, EventArgs e)
        {
            ((Control)tabPage2).Enabled = true;
            TabControl1.SelectedTab = tabPage2;
            ((Control)tabPage3).Enabled = false;
        }

        private void SaveSolutionButton_Click(object sender, EventArgs e)
        {
            SaveButton_Click(sender, e);
        }

        private void ContinueButton4_Click(object sender, EventArgs e)
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
            ErrorBox.Text = "0";

            ContinueButton1.Enabled = false;
            ((Control)tabPage3).Enabled = false;
            ContinueButton2.Enabled = false;
            ContinueButton3.Enabled = false;
            PauseButton.Enabled = false;
            TournamentBox.Enabled = false;
            TimeBox.Enabled = false;
            ImprovementBox.Enabled = false;
            TimeBox.Text = "0";
            ImprovementBox.Text = "0";
            progressBar1.Value = 0;
            ProgressChart.Series["Funkcja celu"].Points.Clear();
            Solution.Reset();
            CreateButton.Enabled = false;
            StopButton.Enabled = false;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            int fragments = Int32.Parse(FragmentBox.Text);
            int samples = Int32.Parse(SampleBox.Text);

            Generator new_instance = new Generator(fragments, samples);

            if (new_instance != null)
            {
                Instance = new_instance.Instance.Copy();
                SBind = new BindingSource();
                SBind.DataSource = Instance;
                InstanceGridView.DataSource = SBind;

                ContinueButton1.Enabled = true; // zabezpieczenie przed brakiem instancji
                ModifyButton.Enabled = true; // umozliwienie zmian
                SaveButton.Enabled = true;
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if(!pause)
            {
                PauseButton.Text = "Wznów";
                pause = true;
            }
            else
            {
                PauseButton.Text = "Pauza";
                pause = false;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void GenNumberBox_Enter(object sender, EventArgs e)
        {
            ContinueButton2.Enabled = true;
        }

        private void CrossingNumeric_Enter(object sender, EventArgs e)
        {
            ContinueButton2.Enabled = true;
        }

        private void MutProbNumeric_Enter(object sender, EventArgs e)
        {
            ContinueButton2.Enabled = true;
        }
    }
}
