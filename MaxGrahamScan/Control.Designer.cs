namespace MaxGrahamScan
{
    partial class Control
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
            this.generateN = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateRandom = new System.Windows.Forms.Button();
            this.stepByStep = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.instant = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.collinear = new System.Windows.Forms.Button();
            this.nightmare = new System.Windows.Forms.Button();
            this.hexagon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateN
            // 
            this.generateN.Location = new System.Drawing.Point(11, 69);
            this.generateN.Name = "generateN";
            this.generateN.Size = new System.Drawing.Size(99, 23);
            this.generateN.TabIndex = 0;
            this.generateN.Text = "Generate";
            this.generateN.UseVisualStyleBackColor = true;
            this.generateN.Click += new System.EventHandler(this.generateN_Click);
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(12, 40);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(98, 20);
            this.n.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generate n points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Generate random";
            // 
            // generateRandom
            // 
            this.generateRandom.Location = new System.Drawing.Point(123, 37);
            this.generateRandom.Name = "generateRandom";
            this.generateRandom.Size = new System.Drawing.Size(99, 55);
            this.generateRandom.TabIndex = 4;
            this.generateRandom.Text = "Generate";
            this.generateRandom.UseVisualStyleBackColor = true;
            this.generateRandom.Click += new System.EventHandler(this.generateRandom_Click);
            // 
            // stepByStep
            // 
            this.stepByStep.Location = new System.Drawing.Point(123, 159);
            this.stepByStep.Name = "stepByStep";
            this.stepByStep.Size = new System.Drawing.Size(99, 23);
            this.stepByStep.TabIndex = 6;
            this.stepByStep.Text = "Step-by-step";
            this.stepByStep.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(124, 124);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // instant
            // 
            this.instant.Location = new System.Drawing.Point(123, 199);
            this.instant.Name = "instant";
            this.instant.Size = new System.Drawing.Size(99, 23);
            this.instant.TabIndex = 8;
            this.instant.Text = "Instant";
            this.instant.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preset plots";
            // 
            // collinear
            // 
            this.collinear.Location = new System.Drawing.Point(12, 166);
            this.collinear.Name = "collinear";
            this.collinear.Size = new System.Drawing.Size(98, 23);
            this.collinear.TabIndex = 11;
            this.collinear.Text = "Collinear test";
            this.collinear.UseVisualStyleBackColor = true;
            // 
            // nightmare
            // 
            this.nightmare.Location = new System.Drawing.Point(12, 199);
            this.nightmare.Name = "nightmare";
            this.nightmare.Size = new System.Drawing.Size(98, 23);
            this.nightmare.TabIndex = 12;
            this.nightmare.Text = "Nightmare";
            this.nightmare.UseVisualStyleBackColor = true;
            // 
            // hexagon
            // 
            this.hexagon.Location = new System.Drawing.Point(12, 132);
            this.hexagon.Name = "hexagon";
            this.hexagon.Size = new System.Drawing.Size(98, 23);
            this.hexagon.TabIndex = 13;
            this.hexagon.Text = "Hexagon";
            this.hexagon.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(113, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 134);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Speed";
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 244);
            this.Controls.Add(this.hexagon);
            this.Controls.Add(this.nightmare);
            this.Controls.Add(this.collinear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.instant);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.stepByStep);
            this.Controls.Add(this.generateRandom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n);
            this.Controls.Add(this.generateN);
            this.Controls.Add(this.groupBox1);
            this.Name = "Control";
            this.Text = "Controls";
            this.Load += new System.EventHandler(this.Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateN;
        private System.Windows.Forms.NumericUpDown n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateRandom;
        private System.Windows.Forms.Button stepByStep;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button instant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button collinear;
        private System.Windows.Forms.Button nightmare;
        private System.Windows.Forms.Button hexagon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}