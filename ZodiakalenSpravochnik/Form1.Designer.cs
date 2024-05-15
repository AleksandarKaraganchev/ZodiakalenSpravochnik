namespace ZodiakalenSpravochnik
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbZodia = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.TextBox();
            this.lblDeviz = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.TextBox();
            this.lblPlanet = new System.Windows.Forms.TextBox();
            this.lblElement = new System.Windows.Forms.TextBox();
            this.lblStone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Зодиакален справочник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Избери зодия:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Период:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Девиз:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цвят:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Планета:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Елемент:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(19, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Камък:";
            // 
            // cbZodia
            // 
            this.cbZodia.FormattingEnabled = true;
            this.cbZodia.Items.AddRange(new object[] {
            "Овен",
            "Телец",
            "Близнаци",
            "Рак",
            "Лъв",
            "Дева",
            "Везни",
            "Скорпион",
            "Стрелец",
            "Козирог",
            "Водолей",
            "Риби"});
            this.cbZodia.Location = new System.Drawing.Point(168, 49);
            this.cbZodia.Name = "cbZodia";
            this.cbZodia.Size = new System.Drawing.Size(121, 23);
            this.cbZodia.TabIndex = 8;
            this.cbZodia.SelectedIndexChanged += new System.EventHandler(this.cbZodia_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(168, 326);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 32);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(168, 91);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(121, 23);
            this.lblTime.TabIndex = 16;
            // 
            // lblDeviz
            // 
            this.lblDeviz.Location = new System.Drawing.Point(168, 132);
            this.lblDeviz.Name = "lblDeviz";
            this.lblDeviz.Size = new System.Drawing.Size(121, 23);
            this.lblDeviz.TabIndex = 17;
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(169, 171);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(120, 23);
            this.lblColor.TabIndex = 18;
            // 
            // lblPlanet
            // 
            this.lblPlanet.Location = new System.Drawing.Point(169, 213);
            this.lblPlanet.Name = "lblPlanet";
            this.lblPlanet.Size = new System.Drawing.Size(121, 23);
            this.lblPlanet.TabIndex = 19;
            // 
            // lblElement
            // 
            this.lblElement.Location = new System.Drawing.Point(169, 255);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(120, 23);
            this.lblElement.TabIndex = 20;
            // 
            // lblStone
            // 
            this.lblStone.Location = new System.Drawing.Point(168, 296);
            this.lblStone.Name = "lblStone";
            this.lblStone.Size = new System.Drawing.Size(121, 23);
            this.lblStone.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.lblStone);
            this.Controls.Add(this.lblElement);
            this.Controls.Add(this.lblPlanet);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblDeviz);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbZodia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Зодии";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cbZodia;
        private Button btnClear;
        private TextBox lblTime;
        private TextBox lblDeviz;
        private TextBox lblColor;
        private TextBox lblPlanet;
        private TextBox lblElement;
        private TextBox lblStone;
    }
}