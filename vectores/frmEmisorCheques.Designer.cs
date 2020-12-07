
namespace vectores
{
    partial class frmEmisorCheques
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
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtpaguesealaordende = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(98, 133);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(177, 20);
            this.txtcantidad.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(243, 191);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(71, 35);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(98, 230);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(2);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(373, 86);
            this.txtResultado.TabIndex = 2;
            // 
            // txtpaguesealaordende
            // 
            this.txtpaguesealaordende.Location = new System.Drawing.Point(98, 86);
            this.txtpaguesealaordende.Margin = new System.Windows.Forms.Padding(2);
            this.txtpaguesealaordende.Name = "txtpaguesealaordende";
            this.txtpaguesealaordende.Size = new System.Drawing.Size(177, 20);
            this.txtpaguesealaordende.TabIndex = 3;
            // 
            // frmEmisorCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtpaguesealaordende);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtcantidad);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEmisorCheques";
            this.Text = "frmCheques";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtpaguesealaordende;
    }
}