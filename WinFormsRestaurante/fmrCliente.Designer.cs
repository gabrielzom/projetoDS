﻿
namespace WinFormsRestaurante
{
    partial class fmrCliente
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
            this.grBoxCliente = new System.Windows.Forms.GroupBox();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.btnIncluirCliente = new System.Windows.Forms.Button();
            this.maskTxBoxNascimentoCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblNascimentoCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.txBoxPesquisarCliente = new System.Windows.Forms.TextBox();
            this.lblPesquisarCliente = new System.Windows.Forms.Label();
            this.grBoxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxCliente
            // 
            this.grBoxCliente.Controls.Add(this.btnExcluirCliente);
            this.grBoxCliente.Controls.Add(this.btnAlterarCliente);
            this.grBoxCliente.Controls.Add(this.btnIncluirCliente);
            this.grBoxCliente.Controls.Add(this.maskTxBoxNascimentoCliente);
            this.grBoxCliente.Controls.Add(this.lblNascimentoCliente);
            this.grBoxCliente.Controls.Add(this.lblNomeCliente);
            this.grBoxCliente.Controls.Add(this.txBoxNomeCliente);
            this.grBoxCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grBoxCliente.Location = new System.Drawing.Point(12, 191);
            this.grBoxCliente.Name = "grBoxCliente";
            this.grBoxCliente.Size = new System.Drawing.Size(480, 115);
            this.grBoxCliente.TabIndex = 0;
            this.grBoxCliente.TabStop = false;
            this.grBoxCliente.Text = "Cliente";
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirCliente.Location = new System.Drawing.Point(232, 66);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(75, 29);
            this.btnExcluirCliente.TabIndex = 11;
            this.btnExcluirCliente.Text = "Excluir";
            this.btnExcluirCliente.UseVisualStyleBackColor = true;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterarCliente.Location = new System.Drawing.Point(142, 66);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(75, 29);
            this.btnAlterarCliente.TabIndex = 10;
            this.btnAlterarCliente.Text = "Alterar";
            this.btnAlterarCliente.UseVisualStyleBackColor = true;
            this.btnAlterarCliente.Click += new System.EventHandler(this.btnAlterarCliente_Click);
            // 
            // btnIncluirCliente
            // 
            this.btnIncluirCliente.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIncluirCliente.Location = new System.Drawing.Point(51, 66);
            this.btnIncluirCliente.Name = "btnIncluirCliente";
            this.btnIncluirCliente.Size = new System.Drawing.Size(75, 29);
            this.btnIncluirCliente.TabIndex = 9;
            this.btnIncluirCliente.Text = "Incluir";
            this.btnIncluirCliente.UseVisualStyleBackColor = true;
            this.btnIncluirCliente.Click += new System.EventHandler(this.btnIncluirCliente_Click);
            // 
            // maskTxBoxNascimentoCliente
            // 
            this.maskTxBoxNascimentoCliente.Enabled = false;
            this.maskTxBoxNascimentoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskTxBoxNascimentoCliente.Location = new System.Drawing.Point(396, 24);
            this.maskTxBoxNascimentoCliente.Mask = "00/00/0000";
            this.maskTxBoxNascimentoCliente.Name = "maskTxBoxNascimentoCliente";
            this.maskTxBoxNascimentoCliente.PromptChar = ' ';
            this.maskTxBoxNascimentoCliente.Size = new System.Drawing.Size(76, 25);
            this.maskTxBoxNascimentoCliente.TabIndex = 8;
            this.maskTxBoxNascimentoCliente.ValidatingType = typeof(System.DateTime);
            // 
            // lblNascimentoCliente
            // 
            this.lblNascimentoCliente.AutoSize = true;
            this.lblNascimentoCliente.Location = new System.Drawing.Point(313, 27);
            this.lblNascimentoCliente.Name = "lblNascimentoCliente";
            this.lblNascimentoCliente.Size = new System.Drawing.Size(81, 17);
            this.lblNascimentoCliente.TabIndex = 7;
            this.lblNascimentoCliente.Text = "Nascimento";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(6, 27);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(45, 17);
            this.lblNomeCliente.TabIndex = 6;
            this.lblNomeCliente.Text = "Nome";
            // 
            // txBoxNomeCliente
            // 
            this.txBoxNomeCliente.Enabled = false;
            this.txBoxNomeCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBoxNomeCliente.Location = new System.Drawing.Point(51, 24);
            this.txBoxNomeCliente.MaxLength = 40;
            this.txBoxNomeCliente.Name = "txBoxNomeCliente";
            this.txBoxNomeCliente.Size = new System.Drawing.Size(256, 25);
            this.txBoxNomeCliente.TabIndex = 4;
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.RowTemplate.Height = 25;
            this.dataGridViewCliente.Size = new System.Drawing.Size(480, 132);
            this.dataGridViewCliente.TabIndex = 1;
            this.dataGridViewCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCliente_CellClick);
            // 
            // txBoxPesquisarCliente
            // 
            this.txBoxPesquisarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txBoxPesquisarCliente.ForeColor = System.Drawing.Color.Silver;
            this.txBoxPesquisarCliente.Location = new System.Drawing.Point(129, 22);
            this.txBoxPesquisarCliente.Name = "txBoxPesquisarCliente";
            this.txBoxPesquisarCliente.Size = new System.Drawing.Size(293, 25);
            this.txBoxPesquisarCliente.TabIndex = 2;
            this.txBoxPesquisarCliente.Text = "Buscar...";
            this.txBoxPesquisarCliente.Click += new System.EventHandler(this.txBoxPesquisarCliente_Click);
            this.txBoxPesquisarCliente.TextChanged += new System.EventHandler(this.txBoxPesquisarCliente_TextChanged);
            // 
            // lblPesquisarCliente
            // 
            this.lblPesquisarCliente.AutoSize = true;
            this.lblPesquisarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPesquisarCliente.Location = new System.Drawing.Point(12, 25);
            this.lblPesquisarCliente.Name = "lblPesquisarCliente";
            this.lblPesquisarCliente.Size = new System.Drawing.Size(114, 17);
            this.lblPesquisarCliente.TabIndex = 3;
            this.lblPesquisarCliente.Text = "Pesquisar Cliente";
            // 
            // fmrCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 312);
            this.Controls.Add(this.lblPesquisarCliente);
            this.Controls.Add(this.txBoxPesquisarCliente);
            this.Controls.Add(this.dataGridViewCliente);
            this.Controls.Add(this.grBoxCliente);
            this.Name = "fmrCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.fmrCliente_Load);
            this.Click += new System.EventHandler(this.fmrCliente_Click);
            this.grBoxCliente.ResumeLayout(false);
            this.grBoxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxCliente;
        private System.Windows.Forms.MaskedTextBox maskTxBoxNascimentoCliente;
        private System.Windows.Forms.Label lblNascimentoCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txBoxNomeCliente;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.TextBox txBoxPesquisarCliente;
        private System.Windows.Forms.Label lblPesquisarCliente;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Button btnAlterarCliente;
        private System.Windows.Forms.Button btnIncluirCliente;
    }
}