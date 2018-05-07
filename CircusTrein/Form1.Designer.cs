namespace CircusTrein
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVoegToe = new System.Windows.Forms.Button();
            this.listBoxAnimals = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEatType = new System.Windows.Forms.ComboBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "klein",
            "middelmatig",
            "groot"});
            this.comboBoxSize.Location = new System.Drawing.Point(8, 46);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSize.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grootte dier";
            // 
            // buttonVoegToe
            // 
            this.buttonVoegToe.Location = new System.Drawing.Point(262, 46);
            this.buttonVoegToe.Name = "buttonVoegToe";
            this.buttonVoegToe.Size = new System.Drawing.Size(75, 23);
            this.buttonVoegToe.TabIndex = 6;
            this.buttonVoegToe.Text = "Voeg toe";
            this.buttonVoegToe.UseVisualStyleBackColor = true;
            this.buttonVoegToe.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxAnimals
            // 
            this.listBoxAnimals.FormattingEnabled = true;
            this.listBoxAnimals.Location = new System.Drawing.Point(12, 102);
            this.listBoxAnimals.Name = "listBoxAnimals";
            this.listBoxAnimals.Size = new System.Drawing.Size(994, 95);
            this.listBoxAnimals.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Eet type";
            // 
            // comboBoxEatType
            // 
            this.comboBoxEatType.FormattingEnabled = true;
            this.comboBoxEatType.Items.AddRange(new object[] {
            "vlees",
            "planten"});
            this.comboBoxEatType.Location = new System.Drawing.Point(135, 46);
            this.comboBoxEatType.Name = "comboBoxEatType";
            this.comboBoxEatType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEatType.TabIndex = 8;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(1012, 183);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 10;
            this.buttonCalc.Text = "Berekenen";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(8, 212);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(1089, 186);
            this.listBoxResult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 416);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxEatType);
            this.Controls.Add(this.listBoxAnimals);
            this.Controls.Add(this.buttonVoegToe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSize);
            this.Name = "Form1";
            this.Text = "Cirque de Goodbye";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVoegToe;
        private System.Windows.Forms.ListBox listBoxAnimals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxEatType;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.ListBox listBoxResult;
    }
}

