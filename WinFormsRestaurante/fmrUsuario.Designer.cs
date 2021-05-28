
namespace WinFormsRestaurante
{
    partial class fmrUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrUsuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuarioCad = new System.Windows.Forms.Label();
            this.lblSenhaCad = new System.Windows.Forms.Label();
            this.lblConfSenhaCad = new System.Windows.Forms.Label();
            this.lblSupervisorCad = new System.Windows.Forms.Label();
            this.txBoxUsuario = new System.Windows.Forms.TextBox();
            this.txBoxSenha = new System.Windows.Forms.TextBox();
            this.txBoxConfSenha = new System.Windows.Forms.TextBox();
            this.rdBtnSimUsuario = new System.Windows.Forms.RadioButton();
            this.rdBtnNaoUsuario = new System.Windows.Forms.RadioButton();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.btnLimparUsuario = new System.Windows.Forms.Button();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuarioCad
            // 
            this.lblUsuarioCad.AutoSize = true;
            this.lblUsuarioCad.Location = new System.Drawing.Point(9, 154);
            this.lblUsuarioCad.Name = "lblUsuarioCad";
            this.lblUsuarioCad.Size = new System.Drawing.Size(78, 15);
            this.lblUsuarioCad.TabIndex = 1;
            this.lblUsuarioCad.Text = "Novo usuário";
            // 
            // lblSenhaCad
            // 
            this.lblSenhaCad.AutoSize = true;
            this.lblSenhaCad.Location = new System.Drawing.Point(20, 183);
            this.lblSenhaCad.Name = "lblSenhaCad";
            this.lblSenhaCad.Size = new System.Drawing.Size(69, 15);
            this.lblSenhaCad.TabIndex = 2;
            this.lblSenhaCad.Text = "Nova senha";
            // 
            // lblConfSenhaCad
            // 
            this.lblConfSenhaCad.AutoSize = true;
            this.lblConfSenhaCad.Location = new System.Drawing.Point(22, 210);
            this.lblConfSenhaCad.Name = "lblConfSenhaCad";
            this.lblConfSenhaCad.Size = new System.Drawing.Size(67, 15);
            this.lblConfSenhaCad.TabIndex = 3;
            this.lblConfSenhaCad.Text = "Conf senha";
            // 
            // lblSupervisorCad
            // 
            this.lblSupervisorCad.AutoSize = true;
            this.lblSupervisorCad.Location = new System.Drawing.Point(12, 234);
            this.lblSupervisorCad.Name = "lblSupervisorCad";
            this.lblSupervisorCad.Size = new System.Drawing.Size(78, 15);
            this.lblSupervisorCad.TabIndex = 4;
            this.lblSupervisorCad.Text = "É supervisor ?";
            // 
            // txBoxUsuario
            // 
            this.txBoxUsuario.Location = new System.Drawing.Point(93, 151);
            this.txBoxUsuario.MaxLength = 20;
            this.txBoxUsuario.Name = "txBoxUsuario";
            this.txBoxUsuario.Size = new System.Drawing.Size(100, 23);
            this.txBoxUsuario.TabIndex = 5;
            // 
            // txBoxSenha
            // 
            this.txBoxSenha.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBoxSenha.Location = new System.Drawing.Point(93, 180);
            this.txBoxSenha.MaxLength = 10;
            this.txBoxSenha.Name = "txBoxSenha";
            this.txBoxSenha.PasswordChar = 'l';
            this.txBoxSenha.Size = new System.Drawing.Size(100, 21);
            this.txBoxSenha.TabIndex = 6;
            // 
            // txBoxConfSenha
            // 
            this.txBoxConfSenha.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBoxConfSenha.Location = new System.Drawing.Point(93, 207);
            this.txBoxConfSenha.MaxLength = 10;
            this.txBoxConfSenha.Name = "txBoxConfSenha";
            this.txBoxConfSenha.PasswordChar = 'l';
            this.txBoxConfSenha.Size = new System.Drawing.Size(100, 21);
            this.txBoxConfSenha.TabIndex = 7;
            // 
            // rdBtnSimUsuario
            // 
            this.rdBtnSimUsuario.AutoSize = true;
            this.rdBtnSimUsuario.Location = new System.Drawing.Point(93, 232);
            this.rdBtnSimUsuario.Name = "rdBtnSimUsuario";
            this.rdBtnSimUsuario.Size = new System.Drawing.Size(45, 19);
            this.rdBtnSimUsuario.TabIndex = 8;
            this.rdBtnSimUsuario.TabStop = true;
            this.rdBtnSimUsuario.Text = "Sim";
            this.rdBtnSimUsuario.UseVisualStyleBackColor = true;
            // 
            // rdBtnNaoUsuario
            // 
            this.rdBtnNaoUsuario.AutoSize = true;
            this.rdBtnNaoUsuario.Location = new System.Drawing.Point(146, 232);
            this.rdBtnNaoUsuario.Name = "rdBtnNaoUsuario";
            this.rdBtnNaoUsuario.Size = new System.Drawing.Size(47, 19);
            this.rdBtnNaoUsuario.TabIndex = 9;
            this.rdBtnNaoUsuario.TabStop = true;
            this.rdBtnNaoUsuario.Text = "Não";
            this.rdBtnNaoUsuario.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(216, 223);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarUsuario.TabIndex = 10;
            this.btnCadastrarUsuario.Text = "Cadastrar";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(216, 41);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.RowTemplate.Height = 25;
            this.dataGridViewUsuario.Size = new System.Drawing.Size(310, 157);
            this.dataGridViewUsuario.TabIndex = 12;
            // 
            // btnLimparUsuario
            // 
            this.btnLimparUsuario.Location = new System.Drawing.Point(313, 223);
            this.btnLimparUsuario.Name = "btnLimparUsuario";
            this.btnLimparUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnLimparUsuario.TabIndex = 11;
            this.btnLimparUsuario.Text = "Limpar";
            this.btnLimparUsuario.UseVisualStyleBackColor = true;
            this.btnLimparUsuario.Click += new System.EventHandler(this.btnLimparUsuario_Click);
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.Location = new System.Drawing.Point(408, 223);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirUsuario.TabIndex = 13;
            this.btnExcluirUsuario.Text = "Excluir";
            this.btnExcluirUsuario.UseVisualStyleBackColor = true;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(216, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Selecione a linha para excluir o usuário";
            // 
            // fmrUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Controls.Add(this.dataGridViewUsuario);
            this.Controls.Add(this.btnLimparUsuario);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.rdBtnNaoUsuario);
            this.Controls.Add(this.rdBtnSimUsuario);
            this.Controls.Add(this.txBoxConfSenha);
            this.Controls.Add(this.txBoxSenha);
            this.Controls.Add(this.txBoxUsuario);
            this.Controls.Add(this.lblSupervisorCad);
            this.Controls.Add(this.lblConfSenhaCad);
            this.Controls.Add(this.lblSenhaCad);
            this.Controls.Add(this.lblUsuarioCad);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fmrUsuario";
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.fmrUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuarioCad;
        private System.Windows.Forms.Label lblSenhaCad;
        private System.Windows.Forms.Label lblConfSenhaCad;
        private System.Windows.Forms.Label lblSupervisorCad;
        private System.Windows.Forms.TextBox txBoxUsuario;
        private System.Windows.Forms.TextBox txBoxSenha;
        private System.Windows.Forms.TextBox txBoxConfSenha;
        private System.Windows.Forms.RadioButton rdBtnSimUsuario;
        private System.Windows.Forms.RadioButton rdBtnNaoUsuario;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.DataGridView dataGridViewUsuario;
        private System.Windows.Forms.Button btnLimparUsuario;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.Label label1;
    }
}