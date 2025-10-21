namespace LAB03
{
    partial class Kalkulator_procentowy_roztworu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();

            txtCapacityMl = new TextBox();
            txtVesselsCount = new TextBox();
            txtPercentage = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            lbCapacityMl = new Label();
            lbPercentage = new Label();
            lbVesselsCount = new Label();
            lbTotalVolumeMl = new Label();
            lbVessel = new Label();
            lbPureSubstanceMl = new Label();
            lbSolution = new Label();
            cmbVessel = new ComboBox();
            cmbSolution = new ComboBox();
            chkLockCapacity = new CheckBox();
            chkLockPercentage = new CheckBox();
            txtPureSubstanceMl = new TextBox();
            txtTotalVolumeMl = new TextBox();

            SuspendLayout();
            // 
            // txtCapacityMl
            // 
            textBox1.Location = new Point(207, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(97, 23);
            textBox1.TabIndex = 0;
            
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(101, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(203, 72);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(101, 23);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(467, 165);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Oblicz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(360, 165);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Wyczyść";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 40);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 6;
            label1.Text = "Pojemność naczynia  (ml)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 80);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 7;
            label2.Text = "Zawartość substancji  (%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 123);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 8;
            label3.Text = "Liczba naczyń (szt)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 327);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 9;
            label4.Text = "Łączna objętość:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 235);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 10;
            label5.Text = "Naczynie:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 360);
            label6.Name = "label6";
            label6.Size = new Size(129, 15);
            label6.TabIndex = 11;
            label6.Text = "Objętość czystej subst.:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 266);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 12;
            label7.Text = "Roztwór:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(144, 232);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(99, 23);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "Kieliszek 50ml";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(144, 261);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(99, 23);
            comboBox2.TabIndex = 14;
            comboBox2.Text = "Etanol 40%";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(318, 231);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(178, 19);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Blokuj pjemność po wyborze";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(318, 263);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(136, 19);
            checkBox2.TabIndex = 16;
            checkBox2.Text = "Blokuj % po wyborze";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(203, 352);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(203, 319);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 18;
            txtCapacityMl.Location = new Point(207, 32);
            txtCapacityMl.Name = "txtCapacityMl";
            txtCapacityMl.Size = new Size(97, 23);
            txtCapacityMl.TabIndex = 0;
            // 
            // txtVesselsCount
            // 
            txtVesselsCount.Location = new Point(203, 115);
            txtVesselsCount.Name = "txtVesselsCount";
            txtVesselsCount.Size = new Size(101, 23);
            txtVesselsCount.TabIndex = 1;
            // 
            // txtPercentage
            // 
            txtPercentage.Location = new Point(203, 72);
            txtPercentage.Name = "txtPercentage";
            txtPercentage.Size = new Size(101, 23);
            txtPercentage.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(467, 165);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Oblicz";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(360, 165);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Wyczyść";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lbCapacityMl
            // 
            lbCapacityMl.AutoSize = true;
            lbCapacityMl.Location = new Point(29, 40);
            lbCapacityMl.Name = "lbCapacityMl";
            lbCapacityMl.Size = new Size(143, 15);
            lbCapacityMl.TabIndex = 6;
            lbCapacityMl.Text = "Pojemność naczynia  (ml)";
            // 
            // lbPercentage
            // 
            lbPercentage.AutoSize = true;
            lbPercentage.Location = new Point(29, 80);
            lbPercentage.Name = "lbPercentage";
            lbPercentage.Size = new Size(141, 15);
            lbPercentage.TabIndex = 7;
            lbPercentage.Text = "Zawartość substancji  (%)";
            // 
            // lbVesselsCount
            // 
            lbVesselsCount.AutoSize = true;
            lbVesselsCount.Location = new Point(29, 123);
            lbVesselsCount.Name = "lbVesselsCount";
            lbVesselsCount.Size = new Size(105, 15);
            lbVesselsCount.TabIndex = 8;
            lbVesselsCount.Text = "Liczba naczyń (szt)";
            // 
            // lbTotalVolumeMl
            // 
            lbTotalVolumeMl.AutoSize = true;
            lbTotalVolumeMl.Location = new Point(40, 327);
            lbTotalVolumeMl.Name = "lbTotalVolumeMl";
            lbTotalVolumeMl.Size = new Size(94, 15);
            lbTotalVolumeMl.TabIndex = 9;
            lbTotalVolumeMl.Text = "Łączna objętość:";
            // 
            // lbVessel
            // 
            lbVessel.AutoSize = true;
            lbVessel.Location = new Point(40, 235);
            lbVessel.Name = "lbVessel";
            lbVessel.Size = new Size(58, 15);
            lbVessel.TabIndex = 10;
            lbVessel.Text = "Naczynie:";
            // 
            // lbPureSubstanceMl
            // 
            lbPureSubstanceMl.AutoSize = true;
            lbPureSubstanceMl.Location = new Point(43, 360);
            lbPureSubstanceMl.Name = "lbPureSubstanceMl";
            lbPureSubstanceMl.Size = new Size(129, 15);
            lbPureSubstanceMl.TabIndex = 11;
            lbPureSubstanceMl.Text = "Objętość czystej subst.:";
            // 
            // lbSolution
            // 
            lbSolution.AutoSize = true;
            lbSolution.Location = new Point(43, 266);
            lbSolution.Name = "lbSolution";
            lbSolution.Size = new Size(53, 15);
            lbSolution.TabIndex = 12;
            lbSolution.Text = "Roztwór:";
            // 
            // cmbVessel
            // 
            cmbVessel.FormattingEnabled = true;
            cmbVessel.Location = new Point(144, 232);
            cmbVessel.Name = "cmbVessel";
            cmbVessel.Size = new Size(99, 23);
            cmbVessel.TabIndex = 13;
            cmbVessel.Text = "Kieliszek 50ml";
            // 
            // cmbSolution
            // 
            cmbSolution.FormattingEnabled = true;
            cmbSolution.Location = new Point(144, 261);
            cmbSolution.Name = "cmbSolution";
            cmbSolution.Size = new Size(99, 23);
            cmbSolution.TabIndex = 14;
            cmbSolution.Text = "Etanol 40%";
            // 
            // chkLockCapacity
            // 
            chkLockCapacity.AutoSize = true;
            chkLockCapacity.Location = new Point(318, 231);
            chkLockCapacity.Name = "chkLockCapacity";
            chkLockCapacity.Size = new Size(178, 19);
            chkLockCapacity.TabIndex = 15;
            chkLockCapacity.Text = "Blokuj pjemność po wyborze";
            chkLockCapacity.UseVisualStyleBackColor = true;
            // 
            // chkLockPercentage
            // 
            chkLockPercentage.AutoSize = true;
            chkLockPercentage.Location = new Point(318, 263);
            chkLockPercentage.Name = "chkLockPercentage";
            chkLockPercentage.Size = new Size(136, 19);
            chkLockPercentage.TabIndex = 16;
            chkLockPercentage.Text = "Blokuj % po wyborze";
            chkLockPercentage.UseVisualStyleBackColor = true;
            // 
            // txtPureSubstanceMl
            // 
            txtPureSubstanceMl.Location = new Point(203, 352);
            txtPureSubstanceMl.Name = "txtPureSubstanceMl";
            txtPureSubstanceMl.Size = new Size(100, 23);
            txtPureSubstanceMl.TabIndex = 17;
            // 
            // txtTotalVolumeMl
            // 
            txtTotalVolumeMl.Location = new Point(203, 319);
            txtTotalVolumeMl.Name = "txtTotalVolumeMl";
            txtTotalVolumeMl.Size = new Size(100, 23);
            txtTotalVolumeMl.TabIndex = 18;
            // 
            // Kalkulator_procentowy_roztworu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtTotalVolumeMl);
            Controls.Add(txtPureSubstanceMl);
            Controls.Add(chkLockPercentage);
            Controls.Add(chkLockCapacity);
            Controls.Add(cmbSolution);
            Controls.Add(cmbVessel);
            Controls.Add(lbSolution);
            Controls.Add(lbPureSubstanceMl);
            Controls.Add(lbVessel);
            Controls.Add(lbTotalVolumeMl);
            Controls.Add(lbVesselsCount);
            Controls.Add(lbPercentage);
            Controls.Add(lbCapacityMl);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtPercentage);
            Controls.Add(txtVesselsCount);
            Controls.Add(txtCapacityMl);
            Name = "Kalkulator_procentowy_roztworu";
            Text = "Kalkulator procentowy roztworu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox txtCapacityMl;
        private TextBox txtVesselsCount;
        private TextBox txtPercentage;
        private Button btnCalculate;
        private Button btnClear;
        private Label lbCapacityMl;
        private Label lbPercentage;
        private Label lbVesselsCount;
        private Label lbTotalVolumeMl;
        private Label lbVessel;
        private Label lbPureSubstanceMl;
        private Label lbSolution;
        private ComboBox cmbVessel;
        private ComboBox cmbSolution;
        private CheckBox chkLockCapacity;
        private CheckBox chkLockPercentage;
        private TextBox txtPureSubstanceMl;
        private TextBox txtTotalVolumeMl;
    }
}
