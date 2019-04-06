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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.InstanceView = new System.Windows.Forms.Panel();
            this.InstanceGridView = new System.Windows.Forms.DataGridView();
            this.GenParameters = new System.Windows.Forms.Panel();
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
            this.ContinueButton2 = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.InstanceView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InstanceGridView)).BeginInit();
            this.GenParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FillNumeric)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.HeurParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
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
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(6, 233);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
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
            this.HeurParameters.Controls.Add(this.ContinueButton2);
            this.HeurParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeurParameters.Location = new System.Drawing.Point(3, 3);
            this.HeurParameters.Name = "HeurParameters";
            this.HeurParameters.Size = new System.Drawing.Size(786, 418);
            this.HeurParameters.TabIndex = 0;
            // 
            // ContinueButton2
            // 
            this.ContinueButton2.Location = new System.Drawing.Point(705, 389);
            this.ContinueButton2.Name = "ContinueButton2";
            this.ContinueButton2.Size = new System.Drawing.Size(75, 23);
            this.ContinueButton2.TabIndex = 0;
            this.ContinueButton2.Text = "Zatwierdź";
            this.ContinueButton2.UseVisualStyleBackColor = true;
            this.ContinueButton2.Click += new System.EventHandler(this.ContinueButton2_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel InstanceView;
        private System.Windows.Forms.Panel GenParameters;
        private System.Windows.Forms.TextBox FragmentBox;
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
        private System.Windows.Forms.Panel ImagePanel;
    }
}

