namespace Lab_3_KAML
{
    partial class program1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textadd = new System.Windows.Forms.TextBox();
            this.positivo = new System.Windows.Forms.ListBox();
            this.negativo = new System.Windows.Forms.ListBox();
            this.neutro = new System.Windows.Forms.ListBox();
            this.sump = new System.Windows.Forms.Button();
            this.sumn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.sumneu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "insertar 40 numeros enteros";
            // 
            // textadd
            // 
            this.textadd.Location = new System.Drawing.Point(41, 49);
            this.textadd.Name = "textadd";
            this.textadd.Size = new System.Drawing.Size(118, 20);
            this.textadd.TabIndex = 3;
            // 
            // positivo
            // 
            this.positivo.BackColor = System.Drawing.Color.PeachPuff;
            this.positivo.FormattingEnabled = true;
            this.positivo.Location = new System.Drawing.Point(461, 97);
            this.positivo.Name = "positivo";
            this.positivo.Size = new System.Drawing.Size(128, 329);
            this.positivo.TabIndex = 4;
            // 
            // negativo
            // 
            this.negativo.BackColor = System.Drawing.Color.PeachPuff;
            this.negativo.FormattingEnabled = true;
            this.negativo.Location = new System.Drawing.Point(605, 97);
            this.negativo.Name = "negativo";
            this.negativo.Size = new System.Drawing.Size(134, 329);
            this.negativo.TabIndex = 5;
            // 
            // neutro
            // 
            this.neutro.BackColor = System.Drawing.Color.PeachPuff;
            this.neutro.FormattingEnabled = true;
            this.neutro.Location = new System.Drawing.Point(531, 9);
            this.neutro.Name = "neutro";
            this.neutro.Size = new System.Drawing.Size(138, 82);
            this.neutro.TabIndex = 6;
            // 
            // sump
            // 
            this.sump.Location = new System.Drawing.Point(41, 97);
            this.sump.Name = "sump";
            this.sump.Size = new System.Drawing.Size(106, 23);
            this.sump.TabIndex = 7;
            this.sump.Text = "sumar positivos";
            this.sump.UseVisualStyleBackColor = true;
            this.sump.Click += new System.EventHandler(this.sump_Click);
            // 
            // sumn
            // 
            this.sumn.Location = new System.Drawing.Point(41, 167);
            this.sumn.Name = "sumn";
            this.sumn.Size = new System.Drawing.Size(106, 23);
            this.sumn.TabIndex = 8;
            this.sumn.Text = "sumar negativos";
            this.sumn.UseVisualStyleBackColor = true;
            this.sumn.Click += new System.EventHandler(this.sumn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(129, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 70);
            this.button2.TabIndex = 11;
            this.button2.Text = "regresar al menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sumneu
            // 
            this.sumneu.Location = new System.Drawing.Point(30, 239);
            this.sumneu.Name = "sumneu";
            this.sumneu.Size = new System.Drawing.Size(152, 23);
            this.sumneu.TabIndex = 12;
            this.sumneu.Text = "sumar cantidad de neutros";
            this.sumneu.UseVisualStyleBackColor = true;
            this.sumneu.Click += new System.EventHandler(this.sumneu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "la cantidad de elementos \r\npositivos es:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "la cantidad de elementos\r\n negativos es:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "la cantidad de neutros es de :";
            // 
            // program1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sumneu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sumn);
            this.Controls.Add(this.sump);
            this.Controls.Add(this.neutro);
            this.Controls.Add(this.negativo);
            this.Controls.Add(this.positivo);
            this.Controls.Add(this.textadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "program1";
            this.Text = "programa 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textadd;
        private System.Windows.Forms.ListBox positivo;
        private System.Windows.Forms.ListBox negativo;
        private System.Windows.Forms.ListBox neutro;
        private System.Windows.Forms.Button sump;
        private System.Windows.Forms.Button sumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sumneu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}