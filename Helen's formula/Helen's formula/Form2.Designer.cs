namespace Helen_s_formula
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxFirstEdge = new System.Windows.Forms.TextBox();
            this.textBoxSecondEdge = new System.Windows.Forms.TextBox();
            this.textBoxThirdEdge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRun);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxThirdEdge);
            this.panel1.Controls.Add(this.textBoxSecondEdge);
            this.panel1.Controls.Add(this.textBoxFirstEdge);
            this.panel1.Location = new System.Drawing.Point(30, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 279);
            this.panel1.TabIndex = 0;
            // 
            // textBoxFirstEdge
            // 
            this.textBoxFirstEdge.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFirstEdge.Location = new System.Drawing.Point(213, 44);
            this.textBoxFirstEdge.Name = "textBoxFirstEdge";
            this.textBoxFirstEdge.Size = new System.Drawing.Size(292, 42);
            this.textBoxFirstEdge.TabIndex = 0;
            // 
            // textBoxSecondEdge
            // 
            this.textBoxSecondEdge.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSecondEdge.Location = new System.Drawing.Point(213, 103);
            this.textBoxSecondEdge.Name = "textBoxSecondEdge";
            this.textBoxSecondEdge.Size = new System.Drawing.Size(291, 42);
            this.textBoxSecondEdge.TabIndex = 1;
            // 
            // textBoxThirdEdge
            // 
            this.textBoxThirdEdge.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxThirdEdge.Location = new System.Drawing.Point(213, 157);
            this.textBoxThirdEdge.Name = "textBoxThirdEdge";
            this.textBoxThirdEdge.Size = new System.Drawing.Size(291, 42);
            this.textBoxThirdEdge.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(46, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "第一条边";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(46, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "第二条边";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(46, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "第三条边";
            // 
            // buttonRun
            // 
            this.buttonRun.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRun.Location = new System.Drawing.Point(213, 216);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(128, 50);
            this.buttonRun.TabIndex = 6;
            this.buttonRun.Text = "计算";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelResult);
            this.panel2.Location = new System.Drawing.Point(30, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 130);
            this.panel2.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelResult.Location = new System.Drawing.Point(148, 52);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(193, 30);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "三角形的面积";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxThirdEdge;
        private System.Windows.Forms.TextBox textBoxSecondEdge;
        private System.Windows.Forms.TextBox textBoxFirstEdge;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelResult;
    }
}