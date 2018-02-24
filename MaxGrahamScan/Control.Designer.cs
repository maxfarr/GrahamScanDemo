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
            this.generateRandom = new System.Windows.Forms.Button();
            this.stepByStep = new System.Windows.Forms.Button();
            this.speed = new System.Windows.Forms.NumericUpDown();
            this.instant = new System.Windows.Forms.Button();
            this.collinear = new System.Windows.Forms.Button();
            this.nightmare = new System.Windows.Forms.Button();
            this.hexagon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.even = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateN
            // 
            this.generateN.Location = new System.Drawing.Point(24, 177);
            this.generateN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.generateN.Name = "generateN";
            this.generateN.Size = new System.Drawing.Size(198, 44);
            this.generateN.TabIndex = 0;
            this.generateN.Text = "Generate n";
            this.generateN.UseVisualStyleBackColor = true;
            this.generateN.Click += new System.EventHandler(this.generateN_Click);
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(26, 121);
            this.n.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(196, 31);
            this.n.TabIndex = 1;
            // 
            // generateRandom
            // 
            this.generateRandom.Location = new System.Drawing.Point(248, 115);
            this.generateRandom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.generateRandom.Name = "generateRandom";
            this.generateRandom.Size = new System.Drawing.Size(198, 106);
            this.generateRandom.TabIndex = 4;
            this.generateRandom.Text = "Generate random";
            this.generateRandom.UseVisualStyleBackColor = true;
            this.generateRandom.Click += new System.EventHandler(this.generateRandom_Click);
            // 
            // stepByStep
            // 
            this.stepByStep.Location = new System.Drawing.Point(20, 137);
            this.stepByStep.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stepByStep.Name = "stepByStep";
            this.stepByStep.Size = new System.Drawing.Size(198, 44);
            this.stepByStep.TabIndex = 6;
            this.stepByStep.Text = "Step-by-step";
            this.stepByStep.UseVisualStyleBackColor = true;
            this.stepByStep.Click += new System.EventHandler(this.stepByStep_Click);
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(282, 354);
            this.speed.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.speed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(118, 31);
            this.speed.TabIndex = 7;
            this.speed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // instant
            // 
            this.instant.Location = new System.Drawing.Point(20, 225);
            this.instant.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.instant.Name = "instant";
            this.instant.Size = new System.Drawing.Size(198, 44);
            this.instant.TabIndex = 8;
            this.instant.Text = "Instant";
            this.instant.UseVisualStyleBackColor = true;
            this.instant.Click += new System.EventHandler(this.instant_Click);
            // 
            // collinear
            // 
            this.collinear.Location = new System.Drawing.Point(16, 137);
            this.collinear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.collinear.Name = "collinear";
            this.collinear.Size = new System.Drawing.Size(196, 44);
            this.collinear.TabIndex = 11;
            this.collinear.Text = "Collinear test";
            this.collinear.UseVisualStyleBackColor = true;
            // 
            // nightmare
            // 
            this.nightmare.Location = new System.Drawing.Point(16, 225);
            this.nightmare.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nightmare.Name = "nightmare";
            this.nightmare.Size = new System.Drawing.Size(196, 44);
            this.nightmare.TabIndex = 12;
            this.nightmare.Text = "Nightmare";
            this.nightmare.UseVisualStyleBackColor = true;
            // 
            // hexagon
            // 
            this.hexagon.Location = new System.Drawing.Point(36, 348);
            this.hexagon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hexagon.Name = "hexagon";
            this.hexagon.Size = new System.Drawing.Size(196, 44);
            this.hexagon.TabIndex = 13;
            this.hexagon.Text = "Hexagon";
            this.hexagon.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.instant);
            this.groupBox1.Controls.Add(this.stepByStep);
            this.groupBox1.Location = new System.Drawing.Point(260, 289);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(232, 309);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Speed";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.even);
            this.groupBox2.Controls.Add(this.generateRandom);
            this.groupBox2.Controls.Add(this.generateN);
            this.groupBox2.Controls.Add(this.n);
            this.groupBox2.Location = new System.Drawing.Point(20, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 243);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate";
            // 
            // even
            // 
            this.even.AutoSize = true;
            this.even.Location = new System.Drawing.Point(160, 39);
            this.even.Name = "even";
            this.even.Size = new System.Drawing.Size(144, 54);
            this.even.TabIndex = 0;
            this.even.Text = "Evenly\r\ndistributed\r\n";
            this.even.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.collinear);
            this.groupBox3.Controls.Add(this.nightmare);
            this.groupBox3.Location = new System.Drawing.Point(20, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 309);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Presets";
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 616);
            this.Controls.Add(this.hexagon);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Control";
            this.Text = "Controls";
            this.Load += new System.EventHandler(this.Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateN;
        private System.Windows.Forms.NumericUpDown n;
        private System.Windows.Forms.Button generateRandom;
        private System.Windows.Forms.Button stepByStep;
        private System.Windows.Forms.NumericUpDown speed;
        private System.Windows.Forms.Button instant;
        private System.Windows.Forms.Button collinear;
        private System.Windows.Forms.Button nightmare;
        private System.Windows.Forms.Button hexagon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox even;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}