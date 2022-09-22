namespace Calculadora_ComFormsPOO
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
            this.buttonSoma = new System.Windows.Forms.Button();
            this.labelNumero1 = new System.Windows.Forms.Label();
            this.labelNumero2 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelValorSaida = new System.Windows.Forms.Label();
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSoma
            // 
            this.buttonSoma.Location = new System.Drawing.Point(342, 114);
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.Size = new System.Drawing.Size(112, 34);
            this.buttonSoma.TabIndex = 0;
            this.buttonSoma.Text = "Soma";
            this.buttonSoma.UseVisualStyleBackColor = true;
            this.buttonSoma.Click += new System.EventHandler(this.buttonSoma_Click);
            // 
            // labelNumero1
            // 
            this.labelNumero1.AutoSize = true;
            this.labelNumero1.Location = new System.Drawing.Point(73, 45);
            this.labelNumero1.Name = "labelNumero1";
            this.labelNumero1.Size = new System.Drawing.Size(96, 25);
            this.labelNumero1.TabIndex = 1;
            this.labelNumero1.Text = "Numero 1:";
            // 
            // labelNumero2
            // 
            this.labelNumero2.AutoSize = true;
            this.labelNumero2.Location = new System.Drawing.Point(73, 123);
            this.labelNumero2.Name = "labelNumero2";
            this.labelNumero2.Size = new System.Drawing.Size(101, 25);
            this.labelNumero2.TabIndex = 2;
            this.labelNumero2.Text = "Numero 2: ";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(43, 313);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(90, 25);
            this.labelResultado.TabIndex = 3;
            this.labelResultado.Text = "Resultado";
            // 
            // labelValorSaida
            // 
            this.labelValorSaida.AutoSize = true;
            this.labelValorSaida.Location = new System.Drawing.Point(153, 313);
            this.labelValorSaida.Name = "labelValorSaida";
            this.labelValorSaida.Size = new System.Drawing.Size(22, 25);
            this.labelValorSaida.TabIndex = 4;
            this.labelValorSaida.Text = "0";
            // 
            // textBoxNumero1
            // 
            this.textBoxNumero1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNumero1.Location = new System.Drawing.Point(149, 80);
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(150, 31);
            this.textBoxNumero1.TabIndex = 5;
            // 
            // textBoxNumero2
            // 
            this.textBoxNumero2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNumero2.Location = new System.Drawing.Point(149, 165);
            this.textBoxNumero2.Name = "textBoxNumero2";
            this.textBoxNumero2.Size = new System.Drawing.Size(150, 31);
            this.textBoxNumero2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 371);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.textBoxNumero1);
            this.Controls.Add(this.labelValorSaida);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelNumero2);
            this.Controls.Add(this.labelNumero1);
            this.Controls.Add(this.buttonSoma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSoma;
        private Label labelNumero1;
        private Label labelNumero2;
        private Label labelResultado;
        private Label labelValorSaida;
        private TextBox textBoxNumero1;
        private TextBox textBoxNumero2;
    }
}