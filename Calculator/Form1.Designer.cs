
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Vvod = new System.Windows.Forms.TextBox();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonPM = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Vvod
            // 
            this.Vvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vvod.Location = new System.Drawing.Point(12, 12);
            this.Vvod.Multiline = true;
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(366, 65);
            this.Vvod.TabIndex = 1;
            this.Vvod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Vvod.TextChanged += new System.EventHandler(this.Vvod_TextChanged);
            // 
            // buttonP
            // 
            this.buttonP.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonP.Location = new System.Drawing.Point(258, 83);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(120, 47);
            this.buttonP.TabIndex = 4;
            this.buttonP.Text = "+";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonM
            // 
            this.buttonM.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonM.Location = new System.Drawing.Point(258, 136);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(120, 47);
            this.buttonM.TabIndex = 5;
            this.buttonM.Text = "-";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonU
            // 
            this.buttonU.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonU.Location = new System.Drawing.Point(258, 242);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(120, 47);
            this.buttonU.TabIndex = 6;
            this.buttonU.Text = "*";
            this.buttonU.UseVisualStyleBackColor = true;
            this.buttonU.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonD
            // 
            this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonD.Location = new System.Drawing.Point(258, 189);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(120, 47);
            this.buttonD.TabIndex = 7;
            this.buttonD.Text = "/";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.button5_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(12, 83);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(76, 47);
            this.delete.TabIndex = 9;
            this.delete.Text = "C";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(12, 295);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(76, 47);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonT
            // 
            this.buttonT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonT.Location = new System.Drawing.Point(94, 296);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(76, 47);
            this.buttonT.TabIndex = 11;
            this.buttonT.Text = ",";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Click += new System.EventHandler(this.button00_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(176, 136);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 47);
            this.button9.TabIndex = 14;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(94, 136);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 47);
            this.button8.TabIndex = 13;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(12, 136);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 47);
            this.button7.TabIndex = 12;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button11_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(176, 189);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 47);
            this.button6.TabIndex = 17;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(94, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 47);
            this.button5.TabIndex = 16;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(12, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 47);
            this.button4.TabIndex = 15;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(176, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 47);
            this.button3.TabIndex = 20;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(94, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 47);
            this.button2.TabIndex = 19;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 47);
            this.button1.TabIndex = 18;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button17_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(94, 83);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(76, 47);
            this.buttonDel.TabIndex = 22;
            this.buttonDel.Text = "Del";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonPM
            // 
            this.buttonPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPM.Location = new System.Drawing.Point(176, 83);
            this.buttonPM.Name = "buttonPM";
            this.buttonPM.Size = new System.Drawing.Size(76, 47);
            this.buttonPM.TabIndex = 23;
            this.buttonPM.Text = "+/-";
            this.buttonPM.UseVisualStyleBackColor = true;
            this.buttonPM.Click += new System.EventHandler(this.buttonPM_Click);
            // 
            // buttonR
            // 
            this.buttonR.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonR.Location = new System.Drawing.Point(176, 296);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(202, 47);
            this.buttonR.TabIndex = 24;
            this.buttonR.Text = "=";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 42);
            this.label1.TabIndex = 25;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonPM);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonU);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.Vvod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonPM;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Label label1;
    }
}

