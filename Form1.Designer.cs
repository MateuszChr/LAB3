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
