namespace Telas
{
    partial class telaFinal
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
            this.bFinalizar = new System.Windows.Forms.Button();
            this.bReter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bFinalizar
            // 
            this.bFinalizar.Location = new System.Drawing.Point(222, 302);
            this.bFinalizar.Name = "bFinalizar";
            this.bFinalizar.Size = new System.Drawing.Size(75, 23);
            this.bFinalizar.TabIndex = 0;
            this.bFinalizar.Text = "Finalizar";
            this.bFinalizar.UseVisualStyleBackColor = true;
            this.bFinalizar.Click += new System.EventHandler(this.bFinalizar_Click);
            // 
            // bReter
            // 
            this.bReter.Location = new System.Drawing.Point(141, 302);
            this.bReter.Name = "bReter";
            this.bReter.Size = new System.Drawing.Size(75, 23);
            this.bReter.TabIndex = 1;
            this.bReter.Text = "Reter";
            this.bReter.UseVisualStyleBackColor = true;
            this.bReter.Click += new System.EventHandler(this.bReter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caso Problema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Caso Selecionado";
            // 
            // telaFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bReter);
            this.Controls.Add(this.bFinalizar);
            this.Name = "telaFinal";
            this.Text = "Tela Final";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFinalizar;
        private System.Windows.Forms.Button bReter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}