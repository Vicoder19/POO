namespace POO
{
    partial class FormAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgenda));
            this.label1 = new System.Windows.Forms.Label();
            this.lvAgenda = new System.Windows.Forms.ListView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEndereço = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Endereço = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // lvAgenda
            // 
            this.lvAgenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Endereço,
            this.Telefone,
            this.Email});
            this.lvAgenda.HideSelection = false;
            this.lvAgenda.Location = new System.Drawing.Point(16, 184);
            this.lvAgenda.Name = "lvAgenda";
            this.lvAgenda.Size = new System.Drawing.Size(521, 185);
            this.lvAgenda.TabIndex = 2;
            this.lvAgenda.UseCompatibleStateImageBehavior = false;
            this.lvAgenda.View = System.Windows.Forms.View.Details;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(72, 64);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(183, 20);
            this.tbName.TabIndex = 3;
            // 
            // tbEndereço
            // 
            this.tbEndereço.Location = new System.Drawing.Point(72, 90);
            this.tbEndereço.Name = "tbEndereço";
            this.tbEndereço.Size = new System.Drawing.Size(183, 20);
            this.tbEndereço.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Endereço";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(72, 116);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(183, 20);
            this.tbTelefone.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(72, 142);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(183, 20);
            this.tbEmail.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(286, 64);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(77, 46);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(286, 116);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(77, 46);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(377, 64);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(77, 46);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = " ";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(377, 116);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(77, 46);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = " ";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 160;
            // 
            // Endereço
            // 
            this.Endereço.Text = "Endereço";
            this.Endereço.Width = 116;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 83;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 160;
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEndereço);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lvAgenda);
            this.Controls.Add(this.label1);
            this.Name = "FormAgenda";
            this.Text = "Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvAgenda;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Endereço;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEndereço;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
    }
}