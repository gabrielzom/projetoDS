
namespace WinFormsRestaurante
{
    partial class fmrLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrLogin));
            this.picBoxPictureLogin = new System.Windows.Forms.PictureBox();
            this.txBoxUserLogin = new System.Windows.Forms.TextBox();
            this.txBoxUserPassword = new System.Windows.Forms.TextBox();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.lblPasswoordLogin = new System.Windows.Forms.Label();
            this.btnConfirmLogin = new System.Windows.Forms.Button();
            this.btnExitLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPictureLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxPictureLogin
            // 
            this.picBoxPictureLogin.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPictureLogin.Image")));
            this.picBoxPictureLogin.Location = new System.Drawing.Point(30, -21);
            this.picBoxPictureLogin.Name = "picBoxPictureLogin";
            this.picBoxPictureLogin.Size = new System.Drawing.Size(213, 193);
            this.picBoxPictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPictureLogin.TabIndex = 0;
            this.picBoxPictureLogin.TabStop = false;
            // 
            // txBoxUserLogin
            // 
            this.txBoxUserLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBoxUserLogin.Location = new System.Drawing.Point(81, 147);
            this.txBoxUserLogin.Name = "txBoxUserLogin";
            this.txBoxUserLogin.Size = new System.Drawing.Size(118, 25);
            this.txBoxUserLogin.TabIndex = 1;
            // 
            // txBoxUserPassword
            // 
            this.txBoxUserPassword.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBoxUserPassword.Location = new System.Drawing.Point(81, 176);
            this.txBoxUserPassword.Name = "txBoxUserPassword";
            this.txBoxUserPassword.PasswordChar = 'l';
            this.txBoxUserPassword.Size = new System.Drawing.Size(118, 22);
            this.txBoxUserPassword.TabIndex = 2;
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserLogin.Location = new System.Drawing.Point(20, 150);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(55, 17);
            this.lblUserLogin.TabIndex = 3;
            this.lblUserLogin.Text = "Usuário";
            // 
            // lblPasswoordLogin
            // 
            this.lblPasswoordLogin.AutoSize = true;
            this.lblPasswoordLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasswoordLogin.Location = new System.Drawing.Point(30, 179);
            this.lblPasswoordLogin.Name = "lblPasswoordLogin";
            this.lblPasswoordLogin.Size = new System.Drawing.Size(45, 17);
            this.lblPasswoordLogin.TabIndex = 4;
            this.lblPasswoordLogin.Text = "Senha";
            // 
            // btnConfirmLogin
            // 
            this.btnConfirmLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmLogin.Location = new System.Drawing.Point(81, 207);
            this.btnConfirmLogin.Name = "btnConfirmLogin";
            this.btnConfirmLogin.Size = new System.Drawing.Size(56, 23);
            this.btnConfirmLogin.TabIndex = 5;
            this.btnConfirmLogin.Text = "Entrar";
            this.btnConfirmLogin.UseVisualStyleBackColor = true;
            // 
            // btnExitLogin
            // 
            this.btnExitLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExitLogin.Location = new System.Drawing.Point(143, 207);
            this.btnExitLogin.Name = "btnExitLogin";
            this.btnExitLogin.Size = new System.Drawing.Size(56, 23);
            this.btnExitLogin.TabIndex = 6;
            this.btnExitLogin.Text = "Sair";
            this.btnExitLogin.UseVisualStyleBackColor = true;
            // 
            // fmrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 239);
            this.Controls.Add(this.btnExitLogin);
            this.Controls.Add(this.btnConfirmLogin);
            this.Controls.Add(this.lblPasswoordLogin);
            this.Controls.Add(this.lblUserLogin);
            this.Controls.Add(this.txBoxUserPassword);
            this.Controls.Add(this.txBoxUserLogin);
            this.Controls.Add(this.picBoxPictureLogin);
            this.Name = "fmrLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPictureLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxPictureLogin;
        private System.Windows.Forms.TextBox txBoxUserLogin;
        private System.Windows.Forms.TextBox txBoxUserPassword;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.Label lblPasswoordLogin;
        private System.Windows.Forms.Button btnConfirmLogin;
        private System.Windows.Forms.Button btnExitLogin;
    }
}

