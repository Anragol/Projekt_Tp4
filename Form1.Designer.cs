namespace ProjektTp4
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conf_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prz_3_ptr = new System.Windows.Forms.Button();
            this.prz_2_ptr = new System.Windows.Forms.Button();
            this.prz_1_ptr = new System.Windows.Forms.Button();
            this.parter_prz = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(688, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(688, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ilość pasażerów wchodzących do windy: ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ilość pasażerów wychodzących z windy: ";
            // 
            // conf_button
            // 
            this.conf_button.Location = new System.Drawing.Point(688, 100);
            this.conf_button.Name = "conf_button";
            this.conf_button.Size = new System.Drawing.Size(75, 37);
            this.conf_button.TabIndex = 5;
            this.conf_button.Text = "Potwierdź i jedź";
            this.conf_button.UseVisualStyleBackColor = true;
            this.conf_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Parter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(462, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "1 Piętro";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "2 Piętro";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(462, 299);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "3 Piętro";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Przyciski w windzie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Przyciski na piętrach do przyw. windy";
            // 
            // prz_3_ptr
            // 
            this.prz_3_ptr.Location = new System.Drawing.Point(584, 299);
            this.prz_3_ptr.Name = "prz_3_ptr";
            this.prz_3_ptr.Size = new System.Drawing.Size(75, 23);
            this.prz_3_ptr.TabIndex = 15;
            this.prz_3_ptr.Text = "3 Piętro";
            this.prz_3_ptr.UseVisualStyleBackColor = true;
            this.prz_3_ptr.Click += new System.EventHandler(this.Prz_3_ptr_Click);
            // 
            // prz_2_ptr
            // 
            this.prz_2_ptr.Location = new System.Drawing.Point(584, 270);
            this.prz_2_ptr.Name = "prz_2_ptr";
            this.prz_2_ptr.Size = new System.Drawing.Size(75, 23);
            this.prz_2_ptr.TabIndex = 14;
            this.prz_2_ptr.Text = "2 Piętro";
            this.prz_2_ptr.UseVisualStyleBackColor = true;
            this.prz_2_ptr.Click += new System.EventHandler(this.Prz_2_ptr_Click);
            // 
            // prz_1_ptr
            // 
            this.prz_1_ptr.Location = new System.Drawing.Point(584, 241);
            this.prz_1_ptr.Name = "prz_1_ptr";
            this.prz_1_ptr.Size = new System.Drawing.Size(75, 23);
            this.prz_1_ptr.TabIndex = 13;
            this.prz_1_ptr.Text = "1 Piętro";
            this.prz_1_ptr.UseVisualStyleBackColor = true;
            this.prz_1_ptr.Click += new System.EventHandler(this.Prz_1_ptr_Click);
            // 
            // parter_prz
            // 
            this.parter_prz.Location = new System.Drawing.Point(584, 212);
            this.parter_prz.Name = "parter_prz";
            this.parter_prz.Size = new System.Drawing.Size(75, 23);
            this.parter_prz.TabIndex = 12;
            this.parter_prz.Text = "Parter";
            this.parter_prz.UseVisualStyleBackColor = true;
            this.parter_prz.Click += new System.EventHandler(this.Parter_prz_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ile osob jest w windzie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prz_3_ptr);
            this.Controls.Add(this.prz_2_ptr);
            this.Controls.Add(this.prz_1_ptr);
            this.Controls.Add(this.parter_prz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.conf_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button conf_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button prz_3_ptr;
        private System.Windows.Forms.Button prz_2_ptr;
        private System.Windows.Forms.Button prz_1_ptr;
        private System.Windows.Forms.Button parter_prz;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

