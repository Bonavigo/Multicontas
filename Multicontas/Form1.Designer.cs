
namespace Multicontas
{
    partial class Multicontas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multicontas));
            this.btn_new_account = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_question = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_new_account
            // 
            this.btn_new_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_new_account.Location = new System.Drawing.Point(35, 33);
            this.btn_new_account.Name = "btn_new_account";
            this.btn_new_account.Size = new System.Drawing.Size(223, 28);
            this.btn_new_account.TabIndex = 0;
            this.btn_new_account.Text = "Nova Conta";
            this.btn_new_account.UseVisualStyleBackColor = true;
            this.btn_new_account.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_reset.Location = new System.Drawing.Point(35, 67);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(223, 28);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Resetar";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_question
            // 
            this.btn_question.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_question.Location = new System.Drawing.Point(35, 101);
            this.btn_question.Name = "btn_question";
            this.btn_question.Size = new System.Drawing.Size(223, 28);
            this.btn_question.TabIndex = 2;
            this.btn_question.Text = "Funcionamento";
            this.btn_question.UseVisualStyleBackColor = true;
            this.btn_question.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_about
            // 
            this.btn_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_about.Location = new System.Drawing.Point(35, 135);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(223, 28);
            this.btn_about.TabIndex = 3;
            this.btn_about.Text = "Sobre";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // Multicontas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 196);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_question);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_new_account);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Multicontas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multicontas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_new_account;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_question;
        private System.Windows.Forms.Button btn_about;
    }
}

