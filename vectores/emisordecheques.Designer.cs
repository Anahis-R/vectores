
namespace vectores
{
    partial class emisordecheques
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
            this.CALCULAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpagueselaordende = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.textResultados = new System.Windows.Forms.TextBox();
            this.textcantidades = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CALCULAR
            // 
            this.CALCULAR.ForeColor = System.Drawing.Color.Black;
            this.CALCULAR.Location = new System.Drawing.Point(445, 255);
            this.CALCULAR.Name = "CALCULAR";
            this.CALCULAR.Size = new System.Drawing.Size(103, 35);
            this.CALCULAR.TabIndex = 0;
            this.CALCULAR.Text = "CALCULAR";
            this.CALCULAR.UseVisualStyleBackColor = true;
            this.CALCULAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "PAGUE A LA ORDEN DE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "LA CANTIDAD DE:";
            // 
            // txtpagueselaordende
            // 
            this.txtpagueselaordende.Location = new System.Drawing.Point(296, 76);
            this.txtpagueselaordende.Name = "txtpagueselaordende";
            this.txtpagueselaordende.Size = new System.Drawing.Size(235, 22);
            this.txtpagueselaordende.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(52, 317);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(599, 22);
            this.txtResultado.TabIndex = 4;
            // 
            // textResultados
            // 
            this.textResultados.Location = new System.Drawing.Point(32, 317);
            this.textResultados.Multiline = true;
            this.textResultados.Name = "textResultados";
            this.textResultados.Size = new System.Drawing.Size(767, 185);
            this.textResultados.TabIndex = 5;
            // 
            // textcantidades
            // 
            this.textcantidades.Location = new System.Drawing.Point(296, 132);
            this.textcantidades.Name = "textcantidades";
            this.textcantidades.Size = new System.Drawing.Size(235, 22);
            this.textcantidades.TabIndex = 6;
            // 
            // emisordecheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1239, 635);
            this.Controls.Add(this.textcantidades);
            this.Controls.Add(this.textResultados);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtpagueselaordende);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CALCULAR);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Wheat;
            this.Name = "emisordecheques";
            this.Text = "Emisor de cheques ";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.emisordecheques_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CALCULAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpagueselaordende;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox textResultados;
        private System.Windows.Forms.TextBox textcantidades;
    }
}