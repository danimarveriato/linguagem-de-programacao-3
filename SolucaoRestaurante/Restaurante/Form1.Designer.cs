
namespace Restaurante
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalDespesa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDivisao);
            this.panel1.Controls.Add(this.txtDivisor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDividendo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(40, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 118);
            this.panel1.TabIndex = 2;
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(108, 16);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(146, 26);
            this.txtDividendo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dividendo:";
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(366, 16);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(146, 26);
            this.txtDivisor.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Divisor:";
            // 
            // txtResto
            // 
            this.txtResto.Enabled = false;
            this.txtResto.Location = new System.Drawing.Point(460, 148);
            this.txtResto.Name = "txtResto";
            this.txtResto.Size = new System.Drawing.Size(146, 26);
            this.txtResto.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resto:";
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(194, 55);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(178, 52);
            this.btnDivisao.TabIndex = 8;
            this.btnDivisao.Text = "Realizar divisão";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            this.btnDivisao.Enter += new System.EventHandler(this.btnDivisao_Enter);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtTotalDespesa);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnCalcular);
            this.panel2.Controls.Add(this.txtDespesa);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(46, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 118);
            this.panel2.TabIndex = 12;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(293, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(130, 52);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtDespesa
            // 
            this.txtDespesa.Location = new System.Drawing.Point(95, 18);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(146, 26);
            this.txtDespesa.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Despesa:";
            // 
            // txtTotalDespesa
            // 
            this.txtTotalDespesa.Enabled = false;
            this.txtTotalDespesa.Location = new System.Drawing.Point(233, 73);
            this.txtTotalDespesa.Name = "txtTotalDespesa";
            this.txtTotalDespesa.Size = new System.Drawing.Size(190, 26);
            this.txtTotalDespesa.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(37, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total com 10%:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 352);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtResto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Resto de uma divisão";
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTotalDespesa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.Label label5;
    }
}

