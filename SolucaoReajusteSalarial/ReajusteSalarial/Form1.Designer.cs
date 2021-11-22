
namespace ReajusteSalarial
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.salMinimo = new System.Windows.Forms.TextBox();
            this.hraTrabalhada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Noturno = new System.Windows.Forms.RadioButton();
            this.Vespertino = new System.Windows.Forms.RadioButton();
            this.Matutino = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.catVeterano = new System.Windows.Forms.RadioButton();
            this.catCalouro = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário Mínimo:";
            // 
            // salMinimo
            // 
            this.salMinimo.Location = new System.Drawing.Point(173, 43);
            this.salMinimo.Name = "salMinimo";
            this.salMinimo.Size = new System.Drawing.Size(165, 26);
            this.salMinimo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.salMinimo, "Teste");
            // 
            // hraTrabalhada
            // 
            this.hraTrabalhada.Location = new System.Drawing.Point(173, 75);
            this.hraTrabalhada.Name = "hraTrabalhada";
            this.hraTrabalhada.Size = new System.Drawing.Size(165, 26);
            this.hraTrabalhada.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horas trabalhadas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Noturno);
            this.groupBox1.Controls.Add(this.Vespertino);
            this.groupBox1.Controls.Add(this.Matutino);
            this.groupBox1.Location = new System.Drawing.Point(383, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turno";
            // 
            // Noturno
            // 
            this.Noturno.AutoSize = true;
            this.Noturno.Location = new System.Drawing.Point(33, 99);
            this.Noturno.Name = "Noturno";
            this.Noturno.Size = new System.Drawing.Size(91, 24);
            this.Noturno.TabIndex = 2;
            this.Noturno.TabStop = true;
            this.Noturno.Text = "Noturno";
            this.Noturno.UseVisualStyleBackColor = true;
            // 
            // Vespertino
            // 
            this.Vespertino.AutoSize = true;
            this.Vespertino.Location = new System.Drawing.Point(33, 66);
            this.Vespertino.Name = "Vespertino";
            this.Vespertino.Size = new System.Drawing.Size(111, 24);
            this.Vespertino.TabIndex = 1;
            this.Vespertino.TabStop = true;
            this.Vespertino.Text = "Vespertino";
            this.Vespertino.UseVisualStyleBackColor = true;
            // 
            // Matutino
            // 
            this.Matutino.AutoSize = true;
            this.Matutino.Location = new System.Drawing.Point(32, 32);
            this.Matutino.Name = "Matutino";
            this.Matutino.Size = new System.Drawing.Size(96, 24);
            this.Matutino.TabIndex = 0;
            this.Matutino.TabStop = true;
            this.Matutino.Text = "Matutino";
            this.Matutino.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.catVeterano);
            this.groupBox2.Controls.Add(this.catCalouro);
            this.groupBox2.Location = new System.Drawing.Point(32, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 84);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categoria";
            // 
            // catVeterano
            // 
            this.catVeterano.AutoSize = true;
            this.catVeterano.Location = new System.Drawing.Point(164, 42);
            this.catVeterano.Name = "catVeterano";
            this.catVeterano.Size = new System.Drawing.Size(100, 24);
            this.catVeterano.TabIndex = 1;
            this.catVeterano.TabStop = true;
            this.catVeterano.Text = "Veterano";
            this.catVeterano.UseVisualStyleBackColor = true;
            // 
            // catCalouro
            // 
            this.catCalouro.AutoSize = true;
            this.catCalouro.Location = new System.Drawing.Point(29, 41);
            this.catCalouro.Name = "catCalouro";
            this.catCalouro.Size = new System.Drawing.Size(89, 24);
            this.catCalouro.TabIndex = 0;
            this.catCalouro.TabStop = true;
            this.catCalouro.Text = "Calouro";
            this.catCalouro.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(47, 222);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(529, 184);
            this.listBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(50, 415);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(400, 26);
            this.textBox3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(210, 518);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informação";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 597);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hraTrabalhada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salMinimo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cálculo de Salário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salMinimo;
        private System.Windows.Forms.TextBox hraTrabalhada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Noturno;
        private System.Windows.Forms.RadioButton Vespertino;
        private System.Windows.Forms.RadioButton Matutino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton catVeterano;
        private System.Windows.Forms.RadioButton catCalouro;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

