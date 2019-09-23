namespace ZP_GA
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.InstanceView = new System.Windows.Forms.Panel();
            this.InstanceGridView = new System.Windows.Forms.DataGridView();
            this.GenParameters = new System.Windows.Forms.Panel();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.GenAndSaveButton = new System.Windows.Forms.Button();
            this.GeneratorButton = new System.Windows.Forms.Button();
            this.ContinueButton1 = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.FillLabel = new System.Windows.Forms.Label();
            this.FillNumeric = new System.Windows.Forms.NumericUpDown();
            this.SampleLabel = new System.Windows.Forms.Label();
            this.SampleBox = new System.Windows.Forms.TextBox();
            this.FragmentLabel = new System.Windows.Forms.Label();
            this.FragmentBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.HeurParameters = new System.Windows.Forms.Panel();
            this.StopButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ReturnButton1 = new System.Windows.Forms.Button();
            this.ContinueButton3 = new System.Windows.Forms.Button();
            this.ProgressChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.MutProbNumeric = new System.Windows.Forms.NumericUpDown();
            this.PopSizeLabel = new System.Windows.Forms.Label();
            this.MutProbLabel = new System.Windows.Forms.Label();
            this.CrossingNumeric = new System.Windows.Forms.NumericUpDown();
            this.GenNumberLabel = new System.Windows.Forms.Label();
            this.CrossingLabel = new System.Windows.Forms.Label();
            this.ContinueButton2 = new System.Windows.Forms.Button();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.TournamentBox = new System.Windows.Forms.TextBox();
            this.ImprovementBox = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.AdditionalRadioButton = new System.Windows.Forms.RadioButton();
            this.TournamentLabel = new System.Windows.Forms.Label();
            this.PopSizeBox = new System.Windows.Forms.TextBox();
            this.ImprovementLabel = new System.Windows.Forms.Label();
            this.GenNumberBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ResultsPanel = new System.Windows.Forms.Panel();
            this.SolutionGridView = new System.Windows.Forms.DataGridView();
            this.SaveSolutionButton = new System.Windows.Forms.Button();
            this.ReturnButton2 = new System.Windows.Forms.Button();
            this.SolutionValueLabel = new System.Windows.Forms.Label();
            this.ContinueButton4 = new System.Windows.Forms.Button();
            this.SolutionValueBox = new System.Windows.Forms.TextBox();
            this.LoadSolutionButton = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.InstanceView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InstanceGridView)).BeginInit();
            this.GenParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FillNumeric)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.HeurParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutProbNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossingNumeric)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.ResultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Controls.Add(this.tabPage3);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(800, 450);
            this.TabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.InstanceView);
            this.tabPage1.Controls.Add(this.GenParameters);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // InstanceView
            // 
            this.InstanceView.Controls.Add(this.InstanceGridView);
            this.InstanceView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstanceView.Location = new System.Drawing.Point(3, 280);
            this.InstanceView.Name = "InstanceView";
            this.InstanceView.Size = new System.Drawing.Size(786, 141);
            this.InstanceView.TabIndex = 1;
            // 
            // InstanceGridView
            // 
            this.InstanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InstanceGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstanceGridView.Location = new System.Drawing.Point(0, 0);
            this.InstanceGridView.Name = "InstanceGridView";
            this.InstanceGridView.Size = new System.Drawing.Size(786, 141);
            this.InstanceGridView.TabIndex = 0;
            this.InstanceGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.InstanceGridView_DataError);
            // 
            // GenParameters
            // 
            this.GenParameters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenParameters.Controls.Add(this.LoadSolutionButton);
            this.GenParameters.Controls.Add(this.CreateButton);
            this.GenParameters.Controls.Add(this.ImagePanel);
            this.GenParameters.Controls.Add(this.LoadButton);
            this.GenParameters.Controls.Add(this.SaveButton);
            this.GenParameters.Controls.Add(this.ModifyButton);
            this.GenParameters.Controls.Add(this.GenAndSaveButton);
            this.GenParameters.Controls.Add(this.GeneratorButton);
            this.GenParameters.Controls.Add(this.ContinueButton1);
            this.GenParameters.Controls.Add(this.ErrorLabel);
            this.GenParameters.Controls.Add(this.ErrorBox);
            this.GenParameters.Controls.Add(this.FillLabel);
            this.GenParameters.Controls.Add(this.FillNumeric);
            this.GenParameters.Controls.Add(this.SampleLabel);
            this.GenParameters.Controls.Add(this.SampleBox);
            this.GenParameters.Controls.Add(this.FragmentLabel);
            this.GenParameters.Controls.Add(this.FragmentBox);
            this.GenParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.GenParameters.Location = new System.Drawing.Point(3, 3);
            this.GenParameters.Name = "GenParameters";
            this.GenParameters.Size = new System.Drawing.Size(786, 277);
            this.GenParameters.TabIndex = 0;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(7, 175);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 15;
            this.CreateButton.Text = "Stwórz";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ImagePanel
            // 
            this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePanel.BackgroundImage = global::ZP_GA.Properties.Resources.DNA_inf;
            this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImagePanel.Location = new System.Drawing.Point(333, 0);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(451, 275);
            this.ImagePanel.TabIndex = 14;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(88, 233);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(114, 23);
            this.LoadButton.TabIndex = 13;
            this.LoadButton.Text = "Wczytaj";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(6, 233);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(208, 204);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyButton.TabIndex = 11;
            this.ModifyButton.Text = "Modyfikuj";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // GenAndSaveButton
            // 
            this.GenAndSaveButton.Location = new System.Drawing.Point(88, 204);
            this.GenAndSaveButton.Name = "GenAndSaveButton";
            this.GenAndSaveButton.Size = new System.Drawing.Size(114, 23);
            this.GenAndSaveButton.TabIndex = 10;
            this.GenAndSaveButton.Text = "Wygeneruj i zapisz";
            this.GenAndSaveButton.UseVisualStyleBackColor = true;
            this.GenAndSaveButton.Click += new System.EventHandler(this.GenAndSaveButton_Click);
            // 
            // GeneratorButton
            // 
            this.GeneratorButton.Location = new System.Drawing.Point(7, 204);
            this.GeneratorButton.Name = "GeneratorButton";
            this.GeneratorButton.Size = new System.Drawing.Size(75, 23);
            this.GeneratorButton.TabIndex = 9;
            this.GeneratorButton.Text = "Wygeneruj";
            this.GeneratorButton.UseVisualStyleBackColor = true;
            this.GeneratorButton.Click += new System.EventHandler(this.GeneratorButton_Click);
            // 
            // ContinueButton1
            // 
            this.ContinueButton1.Location = new System.Drawing.Point(208, 233);
            this.ContinueButton1.Name = "ContinueButton1";
            this.ContinueButton1.Size = new System.Drawing.Size(75, 23);
            this.ContinueButton1.TabIndex = 8;
            this.ContinueButton1.Text = "Zatwierdź";
            this.ContinueButton1.UseVisualStyleBackColor = true;
            this.ContinueButton1.Click += new System.EventHandler(this.ContinueButton1_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(3, 128);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(77, 13);
            this.ErrorLabel.TabIndex = 7;
            this.ErrorLabel.Text = "Liczba błędów";
            // 
            // ErrorBox
            // 
            this.ErrorBox.Location = new System.Drawing.Point(178, 125);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(120, 20);
            this.ErrorBox.TabIndex = 6;
            this.ErrorBox.Text = "0";
            this.ErrorBox.Enter += new System.EventHandler(this.ErrorBox_Enter);
            this.ErrorBox.Leave += new System.EventHandler(this.ErrorBox_Leave);
            // 
            // FillLabel
            // 
            this.FillLabel.AutoSize = true;
            this.FillLabel.Location = new System.Drawing.Point(3, 101);
            this.FillLabel.Name = "FillLabel";
            this.FillLabel.Size = new System.Drawing.Size(167, 13);
            this.FillLabel.TabIndex = 5;
            this.FillLabel.Text = "Poziom wypełnienia wiersza (w %)";
            // 
            // FillNumeric
            // 
            this.FillNumeric.Location = new System.Drawing.Point(178, 99);
            this.FillNumeric.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.FillNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FillNumeric.Name = "FillNumeric";
            this.FillNumeric.Size = new System.Drawing.Size(120, 20);
            this.FillNumeric.TabIndex = 4;
            this.FillNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SampleLabel
            // 
            this.SampleLabel.AutoSize = true;
            this.SampleLabel.Location = new System.Drawing.Point(4, 76);
            this.SampleLabel.Name = "SampleLabel";
            this.SampleLabel.Size = new System.Drawing.Size(74, 13);
            this.SampleLabel.TabIndex = 3;
            this.SampleLabel.Text = "Liczba próbek";
            // 
            // SampleBox
            // 
            this.SampleBox.Location = new System.Drawing.Point(178, 73);
            this.SampleBox.Name = "SampleBox";
            this.SampleBox.Size = new System.Drawing.Size(120, 20);
            this.SampleBox.TabIndex = 2;
            this.SampleBox.Enter += new System.EventHandler(this.SampleBox_Enter);
            this.SampleBox.Leave += new System.EventHandler(this.SampleBox_Leave);
            // 
            // FragmentLabel
            // 
            this.FragmentLabel.AutoSize = true;
            this.FragmentLabel.Location = new System.Drawing.Point(2, 50);
            this.FragmentLabel.Name = "FragmentLabel";
            this.FragmentLabel.Size = new System.Drawing.Size(96, 13);
            this.FragmentLabel.TabIndex = 1;
            this.FragmentLabel.Text = "Liczba fragmentów";
            // 
            // FragmentBox
            // 
            this.FragmentBox.Location = new System.Drawing.Point(178, 47);
            this.FragmentBox.Name = "FragmentBox";
            this.FragmentBox.Size = new System.Drawing.Size(120, 20);
            this.FragmentBox.TabIndex = 0;
            this.FragmentBox.Enter += new System.EventHandler(this.FragmentBox_Enter);
            this.FragmentBox.Leave += new System.EventHandler(this.FragmentBox_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.HeurParameters);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Metaheurystyka";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // HeurParameters
            // 
            this.HeurParameters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeurParameters.Controls.Add(this.StopButton);
            this.HeurParameters.Controls.Add(this.PauseButton);
            this.HeurParameters.Controls.Add(this.ReturnButton1);
            this.HeurParameters.Controls.Add(this.ContinueButton3);
            this.HeurParameters.Controls.Add(this.ProgressChart);
            this.HeurParameters.Controls.Add(this.progressBar1);
            this.HeurParameters.Controls.Add(this.MutProbNumeric);
            this.HeurParameters.Controls.Add(this.PopSizeLabel);
            this.HeurParameters.Controls.Add(this.MutProbLabel);
            this.HeurParameters.Controls.Add(this.CrossingNumeric);
            this.HeurParameters.Controls.Add(this.GenNumberLabel);
            this.HeurParameters.Controls.Add(this.CrossingLabel);
            this.HeurParameters.Controls.Add(this.ContinueButton2);
            this.HeurParameters.Controls.Add(this.TimeBox);
            this.HeurParameters.Controls.Add(this.TournamentBox);
            this.HeurParameters.Controls.Add(this.ImprovementBox);
            this.HeurParameters.Controls.Add(this.TimeLabel);
            this.HeurParameters.Controls.Add(this.AdditionalRadioButton);
            this.HeurParameters.Controls.Add(this.TournamentLabel);
            this.HeurParameters.Controls.Add(this.PopSizeBox);
            this.HeurParameters.Controls.Add(this.ImprovementLabel);
            this.HeurParameters.Controls.Add(this.GenNumberBox);
            this.HeurParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeurParameters.Location = new System.Drawing.Point(3, 3);
            this.HeurParameters.Name = "HeurParameters";
            this.HeurParameters.Size = new System.Drawing.Size(786, 418);
            this.HeurParameters.TabIndex = 0;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(340, 390);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 20;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(259, 390);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(75, 23);
            this.PauseButton.TabIndex = 19;
            this.PauseButton.Text = "Pauza";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // ReturnButton1
            // 
            this.ReturnButton1.Location = new System.Drawing.Point(64, 359);
            this.ReturnButton1.Name = "ReturnButton1";
            this.ReturnButton1.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton1.TabIndex = 18;
            this.ReturnButton1.Text = "Cofnij";
            this.ReturnButton1.UseVisualStyleBackColor = true;
            this.ReturnButton1.Click += new System.EventHandler(this.ReturnButton1_Click);
            // 
            // ContinueButton3
            // 
            this.ContinueButton3.Location = new System.Drawing.Point(707, 390);
            this.ContinueButton3.Name = "ContinueButton3";
            this.ContinueButton3.Size = new System.Drawing.Size(75, 23);
            this.ContinueButton3.TabIndex = 17;
            this.ContinueButton3.Text = "Wyniki";
            this.ContinueButton3.UseVisualStyleBackColor = true;
            this.ContinueButton3.Click += new System.EventHandler(this.ContinueButton3_Click);
            // 
            // ProgressChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ProgressChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ProgressChart.Legends.Add(legend1);
            this.ProgressChart.Location = new System.Drawing.Point(259, 11);
            this.ProgressChart.Name = "ProgressChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Funkcja celu";
            this.ProgressChart.Series.Add(series1);
            this.ProgressChart.Size = new System.Drawing.Size(521, 333);
            this.ProgressChart.TabIndex = 16;
            this.ProgressChart.Text = "Funkcja celu";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(259, 359);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(521, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // MutProbNumeric
            // 
            this.MutProbNumeric.Location = new System.Drawing.Point(8, 299);
            this.MutProbNumeric.Name = "MutProbNumeric";
            this.MutProbNumeric.Size = new System.Drawing.Size(120, 20);
            this.MutProbNumeric.TabIndex = 10;
            this.MutProbNumeric.Enter += new System.EventHandler(this.MutProbNumeric_Enter);
            // 
            // PopSizeLabel
            // 
            this.PopSizeLabel.AutoSize = true;
            this.PopSizeLabel.Location = new System.Drawing.Point(4, 14);
            this.PopSizeLabel.Name = "PopSizeLabel";
            this.PopSizeLabel.Size = new System.Drawing.Size(90, 13);
            this.PopSizeLabel.TabIndex = 0;
            this.PopSizeLabel.Text = "Rozmiar populacji";
            // 
            // MutProbLabel
            // 
            this.MutProbLabel.AutoSize = true;
            this.MutProbLabel.Location = new System.Drawing.Point(4, 283);
            this.MutProbLabel.Name = "MutProbLabel";
            this.MutProbLabel.Size = new System.Drawing.Size(173, 13);
            this.MutProbLabel.TabIndex = 9;
            this.MutProbLabel.Text = "Prawdopodobieństwo mutacji (w %)";
            // 
            // CrossingNumeric
            // 
            this.CrossingNumeric.Location = new System.Drawing.Point(8, 243);
            this.CrossingNumeric.Name = "CrossingNumeric";
            this.CrossingNumeric.Size = new System.Drawing.Size(120, 20);
            this.CrossingNumeric.TabIndex = 14;
            this.CrossingNumeric.Enter += new System.EventHandler(this.CrossingNumeric_Enter);
            // 
            // GenNumberLabel
            // 
            this.GenNumberLabel.AutoSize = true;
            this.GenNumberLabel.Location = new System.Drawing.Point(4, 44);
            this.GenNumberLabel.Name = "GenNumberLabel";
            this.GenNumberLabel.Size = new System.Drawing.Size(84, 13);
            this.GenNumberLabel.TabIndex = 2;
            this.GenNumberLabel.Text = "Liczba generacji";
            // 
            // CrossingLabel
            // 
            this.CrossingLabel.AutoSize = true;
            this.CrossingLabel.Location = new System.Drawing.Point(4, 227);
            this.CrossingLabel.Name = "CrossingLabel";
            this.CrossingLabel.Size = new System.Drawing.Size(198, 13);
            this.CrossingLabel.TabIndex = 13;
            this.CrossingLabel.Text = "Prawdopodobieństwo krzyżowania (w %)";
            // 
            // ContinueButton2
            // 
            this.ContinueButton2.Location = new System.Drawing.Point(145, 359);
            this.ContinueButton2.Name = "ContinueButton2";
            this.ContinueButton2.Size = new System.Drawing.Size(75, 23);
            this.ContinueButton2.TabIndex = 0;
            this.ContinueButton2.Text = "Zatwierdź";
            this.ContinueButton2.UseVisualStyleBackColor = true;
            this.ContinueButton2.Click += new System.EventHandler(this.ContinueButton2_Click);
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(145, 108);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(100, 20);
            this.TimeBox.TabIndex = 6;
            this.TimeBox.Text = "0";
            this.TimeBox.Leave += new System.EventHandler(this.TimeBox_Leave);
            // 
            // TournamentBox
            // 
            this.TournamentBox.Location = new System.Drawing.Point(100, 187);
            this.TournamentBox.Name = "TournamentBox";
            this.TournamentBox.Size = new System.Drawing.Size(100, 20);
            this.TournamentBox.TabIndex = 12;
            this.TournamentBox.Leave += new System.EventHandler(this.TournamentBox_Leave);
            // 
            // ImprovementBox
            // 
            this.ImprovementBox.Location = new System.Drawing.Point(145, 142);
            this.ImprovementBox.Name = "ImprovementBox";
            this.ImprovementBox.Size = new System.Drawing.Size(100, 20);
            this.ImprovementBox.TabIndex = 8;
            this.ImprovementBox.Text = "0";
            this.ImprovementBox.Leave += new System.EventHandler(this.ImprovementBox_Leave);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(4, 111);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(135, 13);
            this.TimeLabel.TabIndex = 5;
            this.TimeLabel.Text = "Czas obliczeń (w minutach)";
            // 
            // AdditionalRadioButton
            // 
            this.AdditionalRadioButton.AutoCheck = false;
            this.AdditionalRadioButton.AutoSize = true;
            this.AdditionalRadioButton.Location = new System.Drawing.Point(7, 79);
            this.AdditionalRadioButton.Name = "AdditionalRadioButton";
            this.AdditionalRadioButton.Size = new System.Drawing.Size(160, 17);
            this.AdditionalRadioButton.TabIndex = 4;
            this.AdditionalRadioButton.TabStop = true;
            this.AdditionalRadioButton.Text = "Dodatkowe kryterium stopu?";
            this.AdditionalRadioButton.UseVisualStyleBackColor = true;
            this.AdditionalRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // TournamentLabel
            // 
            this.TournamentLabel.AutoSize = true;
            this.TournamentLabel.Location = new System.Drawing.Point(4, 190);
            this.TournamentLabel.Name = "TournamentLabel";
            this.TournamentLabel.Size = new System.Drawing.Size(82, 13);
            this.TournamentLabel.TabIndex = 11;
            this.TournamentLabel.Text = "Rozmiar turnieju";
            // 
            // PopSizeBox
            // 
            this.PopSizeBox.Location = new System.Drawing.Point(100, 11);
            this.PopSizeBox.Name = "PopSizeBox";
            this.PopSizeBox.Size = new System.Drawing.Size(100, 20);
            this.PopSizeBox.TabIndex = 1;
            this.PopSizeBox.Enter += new System.EventHandler(this.PopSizeBox_Enter);
            this.PopSizeBox.Leave += new System.EventHandler(this.PopSizeBox_Leave);
            // 
            // ImprovementLabel
            // 
            this.ImprovementLabel.AutoSize = true;
            this.ImprovementLabel.Location = new System.Drawing.Point(5, 145);
            this.ImprovementLabel.Name = "ImprovementLabel";
            this.ImprovementLabel.Size = new System.Drawing.Size(134, 13);
            this.ImprovementLabel.TabIndex = 7;
            this.ImprovementLabel.Text = "Liczba iteracji bez poprawy";
            // 
            // GenNumberBox
            // 
            this.GenNumberBox.Location = new System.Drawing.Point(100, 41);
            this.GenNumberBox.Name = "GenNumberBox";
            this.GenNumberBox.Size = new System.Drawing.Size(100, 20);
            this.GenNumberBox.TabIndex = 3;
            this.GenNumberBox.Enter += new System.EventHandler(this.GenNumberBox_Enter);
            this.GenNumberBox.Leave += new System.EventHandler(this.GenNumberBox_Leave);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ResultsPanel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Wyniki";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.Controls.Add(this.SolutionGridView);
            this.ResultsPanel.Controls.Add(this.SaveSolutionButton);
            this.ResultsPanel.Controls.Add(this.ReturnButton2);
            this.ResultsPanel.Controls.Add(this.SolutionValueLabel);
            this.ResultsPanel.Controls.Add(this.ContinueButton4);
            this.ResultsPanel.Controls.Add(this.SolutionValueBox);
            this.ResultsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ResultsPanel.Location = new System.Drawing.Point(0, 0);
            this.ResultsPanel.Name = "ResultsPanel";
            this.ResultsPanel.Size = new System.Drawing.Size(792, 424);
            this.ResultsPanel.TabIndex = 8;
            // 
            // SolutionGridView
            // 
            this.SolutionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SolutionGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SolutionGridView.Location = new System.Drawing.Point(0, 66);
            this.SolutionGridView.Name = "SolutionGridView";
            this.SolutionGridView.Size = new System.Drawing.Size(792, 358);
            this.SolutionGridView.TabIndex = 9;
            // 
            // SaveSolutionButton
            // 
            this.SaveSolutionButton.Location = new System.Drawing.Point(229, 37);
            this.SaveSolutionButton.Name = "SaveSolutionButton";
            this.SaveSolutionButton.Size = new System.Drawing.Size(75, 23);
            this.SaveSolutionButton.TabIndex = 10;
            this.SaveSolutionButton.Text = "Zapisz";
            this.SaveSolutionButton.UseVisualStyleBackColor = true;
            this.SaveSolutionButton.Click += new System.EventHandler(this.SaveSolutionButton_Click);
            // 
            // ReturnButton2
            // 
            this.ReturnButton2.Location = new System.Drawing.Point(148, 37);
            this.ReturnButton2.Name = "ReturnButton2";
            this.ReturnButton2.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton2.TabIndex = 5;
            this.ReturnButton2.Text = "Cofnij";
            this.ReturnButton2.UseVisualStyleBackColor = true;
            this.ReturnButton2.Click += new System.EventHandler(this.ReturnButton2_Click);
            // 
            // SolutionValueLabel
            // 
            this.SolutionValueLabel.AutoSize = true;
            this.SolutionValueLabel.Location = new System.Drawing.Point(3, 43);
            this.SolutionValueLabel.Name = "SolutionValueLabel";
            this.SolutionValueLabel.Size = new System.Drawing.Size(47, 13);
            this.SolutionValueLabel.TabIndex = 6;
            this.SolutionValueLabel.Text = "Wartość";
            // 
            // ContinueButton4
            // 
            this.ContinueButton4.Location = new System.Drawing.Point(310, 37);
            this.ContinueButton4.Name = "ContinueButton4";
            this.ContinueButton4.Size = new System.Drawing.Size(75, 23);
            this.ContinueButton4.TabIndex = 4;
            this.ContinueButton4.Text = "Zatwierdź";
            this.ContinueButton4.UseVisualStyleBackColor = true;
            this.ContinueButton4.Click += new System.EventHandler(this.ContinueButton4_Click);
            // 
            // SolutionValueBox
            // 
            this.SolutionValueBox.Location = new System.Drawing.Point(56, 40);
            this.SolutionValueBox.Name = "SolutionValueBox";
            this.SolutionValueBox.Size = new System.Drawing.Size(86, 20);
            this.SolutionValueBox.TabIndex = 7;
            // 
            // LoadSolutionButton
            // 
            this.LoadSolutionButton.Location = new System.Drawing.Point(89, 174);
            this.LoadSolutionButton.Name = "LoadSolutionButton";
            this.LoadSolutionButton.Size = new System.Drawing.Size(113, 23);
            this.LoadSolutionButton.TabIndex = 16;
            this.LoadSolutionButton.Text = "Wczytaj rozwiązanie";
            this.LoadSolutionButton.UseVisualStyleBackColor = true;
            this.LoadSolutionButton.Click += new System.EventHandler(this.LoadSolutionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form1";
            this.Text = "Algorytm Genetyczny";
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.InstanceView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InstanceGridView)).EndInit();
            this.GenParameters.ResumeLayout(false);
            this.GenParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FillNumeric)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.HeurParameters.ResumeLayout(false);
            this.HeurParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutProbNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossingNumeric)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResultsPanel.ResumeLayout(false);
            this.ResultsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel InstanceView;
        private System.Windows.Forms.Panel GenParameters;
        private System.Windows.Forms.Label FragmentLabel;
        private System.Windows.Forms.Label SampleLabel;
        private System.Windows.Forms.TextBox SampleBox;
        private System.Windows.Forms.Label FillLabel;
        private System.Windows.Forms.NumericUpDown FillNumeric;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox ErrorBox;
        private System.Windows.Forms.Button ContinueButton1;
        private System.Windows.Forms.Panel HeurParameters;
        private System.Windows.Forms.Button ContinueButton2;
        private System.Windows.Forms.Button GeneratorButton;
        private System.Windows.Forms.DataGridView InstanceGridView;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button GenAndSaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox FragmentBox;
        private System.Windows.Forms.Label PopSizeLabel;
        private System.Windows.Forms.NumericUpDown MutProbNumeric;
        private System.Windows.Forms.Label MutProbLabel;
        private System.Windows.Forms.NumericUpDown CrossingNumeric;
        private System.Windows.Forms.Label CrossingLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TextBox TournamentBox;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Label TournamentLabel;
        private System.Windows.Forms.Label ImprovementLabel;
        private System.Windows.Forms.TextBox ImprovementBox;
        private System.Windows.Forms.Label GenNumberLabel;
        private System.Windows.Forms.TextBox PopSizeBox;
        private System.Windows.Forms.TextBox GenNumberBox;
        private System.Windows.Forms.RadioButton AdditionalRadioButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProgressChart;
        private System.Windows.Forms.Button ContinueButton3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox SolutionValueBox;
        private System.Windows.Forms.Label SolutionValueLabel;
        private System.Windows.Forms.Button ReturnButton2;
        private System.Windows.Forms.Button ContinueButton4;
        private System.Windows.Forms.Panel ResultsPanel;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.DataGridView SolutionGridView;
        private System.Windows.Forms.Button SaveSolutionButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button ReturnButton1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button LoadSolutionButton;
    }
}

