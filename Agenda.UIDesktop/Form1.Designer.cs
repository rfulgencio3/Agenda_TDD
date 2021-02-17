
namespace Agenda.UIDesktop
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
            this.lblContatoNovo = new System.Windows.Forms.Label();
            this.lblContatoSalvo = new System.Windows.Forms.Label();
            this.txtContatoNovo = new System.Windows.Forms.TextBox();
            this.txtContatoSalvo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContatoNovo
            // 
            this.lblContatoNovo.AutoSize = true;
            this.lblContatoNovo.Location = new System.Drawing.Point(13, 13);
            this.lblContatoNovo.Name = "lblContatoNovo";
            this.lblContatoNovo.Size = new System.Drawing.Size(71, 13);
            this.lblContatoNovo.TabIndex = 0;
            this.lblContatoNovo.Text = "Contato novo";
            // 
            // lblContatoSalvo
            // 
            this.lblContatoSalvo.AutoSize = true;
            this.lblContatoSalvo.Location = new System.Drawing.Point(13, 58);
            this.lblContatoSalvo.Name = "lblContatoSalvo";
            this.lblContatoSalvo.Size = new System.Drawing.Size(72, 13);
            this.lblContatoSalvo.TabIndex = 1;
            this.lblContatoSalvo.Text = "Contato salvo";
            // 
            // txtContatoNovo
            // 
            this.txtContatoNovo.Location = new System.Drawing.Point(16, 30);
            this.txtContatoNovo.Name = "txtContatoNovo";
            this.txtContatoNovo.Size = new System.Drawing.Size(335, 20);
            this.txtContatoNovo.TabIndex = 2;
            // 
            // txtContatoSalvo
            // 
            this.txtContatoSalvo.Location = new System.Drawing.Point(16, 74);
            this.txtContatoSalvo.Name = "txtContatoSalvo";
            this.txtContatoSalvo.Size = new System.Drawing.Size(335, 20);
            this.txtContatoSalvo.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(276, 116);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtContatoSalvo);
            this.Controls.Add(this.txtContatoNovo);
            this.Controls.Add(this.lblContatoSalvo);
            this.Controls.Add(this.lblContatoNovo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContatoNovo;
        private System.Windows.Forms.Label lblContatoSalvo;
        private System.Windows.Forms.TextBox txtContatoNovo;
        private System.Windows.Forms.TextBox txtContatoSalvo;
        private System.Windows.Forms.Button btnSalvar;
    }
}

