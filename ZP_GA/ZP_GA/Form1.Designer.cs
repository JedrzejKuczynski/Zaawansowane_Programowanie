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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GenParameters = new System.Windows.Forms.Panel();
            this.InstanceView = new System.Windows.Forms.Panel();
            this.FragmentBox = new System.Windows.Forms.TextBox();
            this.FragmentLabel = new System.Windows.Forms.Label();
            this.SampleBox = new System.Windows.Forms.TextBox();
            this.SampleLabel = new System.Windows.Forms.Label();
            this.FillNumeric = new System.Windows.Forms.NumericUpDown();
            this.FillLabel = new System.Windows.Forms.Label();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ContinueButton1 = new System.Windows.Forms.Button();
            this.HeurParameters = new System.Windows.Forms.Panel();
            this.ContinueButton2 = new System.Windows.Forms.Button();
            this.GeneratorButton = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.GenParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FillNumeric)).BeginInit();
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
            // GenParameters
            // 
            this.GenParameters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.GenParameters.Size = new System.Drawing.Size(786, 221);
            this.GenParameters.TabIndex = 0;
            // 
            // InstanceView
            // 
            this.InstanceView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstanceView.Location = new System.Drawing.Point(3, 224);
            this.InstanceView.Name = "InstanceView";
            this.InstanceView.Size = new System.Drawing.Size(786, 197);
            this.InstanceView.TabIndex = 1;
            // 
            // FragmentBox
            // 
            this.FragmentBox.Location = new System.Drawing.Point(140, 4);
            this.FragmentBox.Name = "FragmentBox";
            this.FragmentBox.Size = new System.Drawing.Size(120, 20);
            this.FragmentBox.TabIndex = 0;
            // 
            // FragmentLabel
            // 
            this.FragmentLabel.AutoSize = true;
            this.FragmentLabel.Location = new System.Drawing.Point(5, 4);
            this.FragmentLabel.Name = "FragmentLabel";
            this.FragmentLabel.Size = new System.Drawing.Size(96, 13);
            this.FragmentLabel.TabIndex = 1;
            this.FragmentLabel.Text = "Liczba fragmentów";
            this.FragmentLabel.Click += new System.EventHandler(this.FragmentLabel_Click);
            // 
            // SampleBox
            // 
            this.SampleBox.Location = new System.Drawing.Point(140, 28);
            this.SampleBox.Name = "SampleBox";
            this.SampleBox.Size = new System.Drawing.Size(120, 20);
            this.SampleBox.TabIndex = 2;
            this.SampleBox.TextChanged += new System.EventHandler(this.SampleBox_TextChanged);
            // 
            // SampleLabel
            // 
            this.SampleLabel.AutoSize = true;
            this.SampleLabel.Location = new System.Drawing.Point(5, 31);
            this.SampleLabel.Name = "SampleLabel";
            this.SampleLabel.Size = new System.Drawing.Size(74, 13);
            this.SampleLabel.TabIndex = 3;
            this.SampleLabel.Text = "Liczba próbek";
            // 
            // FillNumeric
            // 
            this.FillNumeric.Location = new System.Drawing.Point(140, 54);
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
            // FillLabel
            // 
            this.FillLabel.AutoSize = true;
            this.FillLabel.Location = new System.Drawing.Point(5, 57);
            this.FillLabel.Name = "FillLabel";
            this.FillLabel.Size = new System.Drawing.Size(129, 13);
            this.FillLabel.TabIndex = 5;
            this.FillLabel.Text = "Poziom wypełnienia (w %)";
            // 
            // ErrorBox
            // 
            this.ErrorBox.Location = new System.Drawing.Point(140, 81);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(120, 20);
            this.ErrorBox.TabIndex = 6;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(5, 81);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(77, 13);
            this.ErrorLabel.TabIndex = 7;
            this.ErrorLabel.Text = "Liczba błędów";
            // 
            // ContinueButton1
            // 
            this.ContinueButton1.Location = new System.Drawing.Point(705, 191);
            this.ContinueButton1.Name = "ContinueButton1";
            this.ContinueButton1.Size = new System.Drawing.Size(75, 23);
            this.ContinueButton1.TabIndex = 8;
            this.ContinueButton1.Text = "Zatwierdź";
            this.ContinueButton1.UseVisualStyleBackColor = true;
            this.ContinueButton1.Click += new System.EventHandler(this.ContinueButton1_Click);
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
            // GeneratorButton
            // 
            this.GeneratorButton.Location = new System.Drawing.Point(8, 190);
            this.GeneratorButton.Name = "GeneratorButton";
            this.GeneratorButton.Size = new System.Drawing.Size(75, 23);
            this.GeneratorButton.TabIndex = 9;
            this.GeneratorButton.Text = "Wygeneruj";
            this.GeneratorButton.UseVisualStyleBackColor = true;
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
            this.tabPage2.ResumeLayout(false);
            this.GenParameters.ResumeLayout(false);
            this.GenParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FillNumeric)).EndInit();
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
    }
}

