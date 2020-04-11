namespace Windows_Forms___Impressão
{
    partial class frmImprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImprimir));
            this.btnImprime = new System.Windows.Forms.Button();
            this.chkVisualizar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnImprime
            // 
            this.btnImprime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprime.BackgroundImage")));
            this.btnImprime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnImprime.FlatAppearance.BorderSize = 2;
            this.btnImprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprime.Location = new System.Drawing.Point(12, 12);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(148, 162);
            this.btnImprime.TabIndex = 0;
            this.btnImprime.UseVisualStyleBackColor = true;
            this.btnImprime.Click += new System.EventHandler(this.btnImprime_Click);
            // 
            // chkVisualizar
            // 
            this.chkVisualizar.AutoSize = true;
            this.chkVisualizar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVisualizar.Location = new System.Drawing.Point(12, 180);
            this.chkVisualizar.Name = "chkVisualizar";
            this.chkVisualizar.Size = new System.Drawing.Size(148, 21);
            this.chkVisualizar.TabIndex = 1;
            this.chkVisualizar.Text = "Visualizar Impressão";
            this.chkVisualizar.UseVisualStyleBackColor = true;
            // 
            // frmImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 204);
            this.Controls.Add(this.chkVisualizar);
            this.Controls.Add(this.btnImprime);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImprimir";
            this.Text = "Imprimir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprime;
        private System.Windows.Forms.CheckBox chkVisualizar;
    }
}

