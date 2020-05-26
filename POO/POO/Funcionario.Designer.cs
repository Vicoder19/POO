namespace POO
{
    partial class FormFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionario));
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.tbAdicional = new System.Windows.Forms.TextBox();
            this.tbLiquido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbSemDesconto = new System.Windows.Forms.CheckBox();
            this.Listview = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desconto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adicional = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Liquido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(65, 12);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(303, 20);
            this.tbNome.TabIndex = 0;
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(65, 41);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(168, 20);
            this.tbSalario.TabIndex = 1;
            // 
            // tbDesconto
            // 
            this.tbDesconto.Location = new System.Drawing.Point(65, 67);
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Size = new System.Drawing.Size(168, 20);
            this.tbDesconto.TabIndex = 2;
            // 
            // tbAdicional
            // 
            this.tbAdicional.Location = new System.Drawing.Point(65, 90);
            this.tbAdicional.Name = "tbAdicional";
            this.tbAdicional.Size = new System.Drawing.Size(168, 20);
            this.tbAdicional.TabIndex = 3;
            // 
            // tbLiquido
            // 
            this.tbLiquido.Location = new System.Drawing.Point(65, 116);
            this.tbLiquido.Name = "tbLiquido";
            this.tbLiquido.Size = new System.Drawing.Size(168, 20);
            this.tbLiquido.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Desconto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adicional:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Líquido:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(403, 70);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(66, 62);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbSemDesconto
            // 
            this.cbSemDesconto.AutoSize = true;
            this.cbSemDesconto.Location = new System.Drawing.Point(240, 66);
            this.cbSemDesconto.Name = "cbSemDesconto";
            this.cbSemDesconto.Size = new System.Drawing.Size(96, 17);
            this.cbSemDesconto.TabIndex = 12;
            this.cbSemDesconto.Text = "Sem Desconto";
            this.cbSemDesconto.UseVisualStyleBackColor = true;
            this.cbSemDesconto.CheckedChanged += new System.EventHandler(this.cbSemDesconto_CheckedChanged);
            // 
            // Listview
            // 
            this.Listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Salario,
            this.Desconto,
            this.Adicional,
            this.Liquido,
            this.Cargo});
            this.Listview.HideSelection = false;
            this.Listview.Location = new System.Drawing.Point(9, 171);
            this.Listview.Name = "Listview";
            this.Listview.Size = new System.Drawing.Size(571, 178);
            this.Listview.TabIndex = 13;
            this.Listview.UseCompatibleStateImageBehavior = false;
            this.Listview.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 116;
            // 
            // Salario
            // 
            this.Salario.Text = "Salario";
            this.Salario.Width = 94;
            // 
            // Desconto
            // 
            this.Desconto.Text = "Desconto";
            this.Desconto.Width = 86;
            // 
            // Adicional
            // 
            this.Adicional.Text = "Adicional";
            this.Adicional.Width = 74;
            // 
            // Liquido
            // 
            this.Liquido.Text = "Liquido";
            this.Liquido.Width = 82;
            // 
            // Cargo
            // 
            this.Cargo.Text = "Cargo";
            this.Cargo.Width = 115;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cargo";
            // 
            // tbCargo
            // 
            this.tbCargo.Location = new System.Drawing.Point(425, 12);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(127, 20);
            this.tbCargo.TabIndex = 14;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(475, 70);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(77, 62);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = " ";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 361);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCargo);
            this.Controls.Add(this.Listview);
            this.Controls.Add(this.cbSemDesconto);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLiquido);
            this.Controls.Add(this.tbAdicional);
            this.Controls.Add(this.tbDesconto);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.tbNome);
            this.Name = "FormFuncionario";
            this.Text = "Cadastrar Funcionario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.TextBox tbDesconto;
        private System.Windows.Forms.TextBox tbAdicional;
        private System.Windows.Forms.TextBox tbLiquido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox cbSemDesconto;
        private System.Windows.Forms.ListView Listview;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Salario;
        private System.Windows.Forms.ColumnHeader Desconto;
        private System.Windows.Forms.ColumnHeader Adicional;
        private System.Windows.Forms.ColumnHeader Liquido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.ColumnHeader Cargo;
        private System.Windows.Forms.Button btnExcluir;
    }
}

