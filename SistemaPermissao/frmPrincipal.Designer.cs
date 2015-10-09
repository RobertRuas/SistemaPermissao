namespace SistemaPermissao
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_Usuarios = new System.Windows.Forms.ListView();
            this.IDUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usuario_Previlegio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.listView_Previlegios = new System.Windows.Forms.ListView();
            this.IDPrevilegio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Previlegio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.listView_Permissoes = new System.Windows.Forms.ListView();
            this.Permissao_IDPrevilegio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Permissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxUsuarios = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Verifcar = new System.Windows.Forms.Label();
            this.buttonTestarExcluir = new System.Windows.Forms.Button();
            this.buttonTestarEditar = new System.Windows.Forms.Button();
            this.buttonTestarInserir = new System.Windows.Forms.Button();
            this.PermissaoPrevilegio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonTestarLer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Usuarios
            // 
            this.listView_Usuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDUsuario,
            this.Nome,
            this.Usuario_Previlegio});
            this.listView_Usuarios.FullRowSelect = true;
            this.listView_Usuarios.GridLines = true;
            this.listView_Usuarios.Location = new System.Drawing.Point(12, 179);
            this.listView_Usuarios.MultiSelect = false;
            this.listView_Usuarios.Name = "listView_Usuarios";
            this.listView_Usuarios.Size = new System.Drawing.Size(366, 107);
            this.listView_Usuarios.TabIndex = 0;
            this.listView_Usuarios.UseCompatibleStateImageBehavior = false;
            this.listView_Usuarios.View = System.Windows.Forms.View.Details;
            // 
            // IDUsuario
            // 
            this.IDUsuario.Text = "ID";
            this.IDUsuario.Width = 35;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 178;
            // 
            // Usuario_Previlegio
            // 
            this.Usuario_Previlegio.Text = "Previlegio";
            this.Usuario_Previlegio.Width = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios";
            // 
            // listView_Previlegios
            // 
            this.listView_Previlegios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDPrevilegio,
            this.Previlegio});
            this.listView_Previlegios.FullRowSelect = true;
            this.listView_Previlegios.GridLines = true;
            this.listView_Previlegios.Location = new System.Drawing.Point(12, 308);
            this.listView_Previlegios.MultiSelect = false;
            this.listView_Previlegios.Name = "listView_Previlegios";
            this.listView_Previlegios.Size = new System.Drawing.Size(142, 207);
            this.listView_Previlegios.TabIndex = 0;
            this.listView_Previlegios.UseCompatibleStateImageBehavior = false;
            this.listView_Previlegios.View = System.Windows.Forms.View.Details;
            // 
            // IDPrevilegio
            // 
            this.IDPrevilegio.Text = "IDPrevilegio";
            this.IDPrevilegio.Width = 35;
            // 
            // Previlegio
            // 
            this.Previlegio.Text = "Previlegio";
            this.Previlegio.Width = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Previlegios";
            // 
            // listView_Permissoes
            // 
            this.listView_Permissoes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Permissao_IDPrevilegio,
            this.Permissao,
            this.PermissaoPrevilegio});
            this.listView_Permissoes.FullRowSelect = true;
            this.listView_Permissoes.GridLines = true;
            this.listView_Permissoes.Location = new System.Drawing.Point(160, 308);
            this.listView_Permissoes.MultiSelect = false;
            this.listView_Permissoes.Name = "listView_Permissoes";
            this.listView_Permissoes.Size = new System.Drawing.Size(218, 207);
            this.listView_Permissoes.TabIndex = 0;
            this.listView_Permissoes.UseCompatibleStateImageBehavior = false;
            this.listView_Permissoes.View = System.Windows.Forms.View.Details;
            // 
            // Permissao_IDPrevilegio
            // 
            this.Permissao_IDPrevilegio.Text = "IDPrevilegio";
            this.Permissao_IDPrevilegio.Width = 35;
            // 
            // Permissao
            // 
            this.Permissao.Text = "Permissão";
            this.Permissao.Width = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Permissões";
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Location = new System.Drawing.Point(6, 44);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(354, 21);
            this.comboBoxUsuarios.TabIndex = 2;
            this.comboBoxUsuarios.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsuarios_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTestarExcluir);
            this.groupBox1.Controls.Add(this.buttonTestarLer);
            this.groupBox1.Controls.Add(this.label_Verifcar);
            this.groupBox1.Controls.Add(this.buttonTestarEditar);
            this.groupBox1.Controls.Add(this.comboBoxUsuarios);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonTestarInserir);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 145);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Testar Permissão";
            // 
            // label_Verifcar
            // 
            this.label_Verifcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Verifcar.ForeColor = System.Drawing.Color.DimGray;
            this.label_Verifcar.Location = new System.Drawing.Point(6, 119);
            this.label_Verifcar.Name = "label_Verifcar";
            this.label_Verifcar.Size = new System.Drawing.Size(354, 23);
            this.label_Verifcar.TabIndex = 5;
            this.label_Verifcar.Text = "Verificar";
            this.label_Verifcar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTestarExcluir
            // 
            this.buttonTestarExcluir.Location = new System.Drawing.Point(274, 71);
            this.buttonTestarExcluir.Name = "buttonTestarExcluir";
            this.buttonTestarExcluir.Size = new System.Drawing.Size(86, 36);
            this.buttonTestarExcluir.TabIndex = 4;
            this.buttonTestarExcluir.Text = "Excluir";
            this.buttonTestarExcluir.UseVisualStyleBackColor = true;
            this.buttonTestarExcluir.Click += new System.EventHandler(this.buttonTestarExcluir_Click);
            // 
            // buttonTestarEditar
            // 
            this.buttonTestarEditar.Location = new System.Drawing.Point(182, 71);
            this.buttonTestarEditar.Name = "buttonTestarEditar";
            this.buttonTestarEditar.Size = new System.Drawing.Size(86, 36);
            this.buttonTestarEditar.TabIndex = 4;
            this.buttonTestarEditar.Text = "Editar";
            this.buttonTestarEditar.UseVisualStyleBackColor = true;
            this.buttonTestarEditar.Click += new System.EventHandler(this.buttonTestarEditar_Click);
            // 
            // buttonTestarInserir
            // 
            this.buttonTestarInserir.Location = new System.Drawing.Point(92, 71);
            this.buttonTestarInserir.Name = "buttonTestarInserir";
            this.buttonTestarInserir.Size = new System.Drawing.Size(84, 36);
            this.buttonTestarInserir.TabIndex = 4;
            this.buttonTestarInserir.Text = "Gravar";
            this.buttonTestarInserir.UseVisualStyleBackColor = true;
            this.buttonTestarInserir.Click += new System.EventHandler(this.buttonTestarInserir_Click);
            // 
            // PermissaoPrevilegio
            // 
            this.PermissaoPrevilegio.Text = "Previlegio";
            this.PermissaoPrevilegio.Width = 95;
            // 
            // buttonTestarLer
            // 
            this.buttonTestarLer.Location = new System.Drawing.Point(6, 71);
            this.buttonTestarLer.Name = "buttonTestarLer";
            this.buttonTestarLer.Size = new System.Drawing.Size(80, 36);
            this.buttonTestarLer.TabIndex = 6;
            this.buttonTestarLer.Text = "Ler";
            this.buttonTestarLer.UseVisualStyleBackColor = true;
            this.buttonTestarLer.Click += new System.EventHandler(this.buttonTestarLer_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_Permissoes);
            this.Controls.Add(this.listView_Previlegios);
            this.Controls.Add(this.listView_Usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Permissão";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_Previlegios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_Permissoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Verifcar;
        private System.Windows.Forms.Button buttonTestarExcluir;
        private System.Windows.Forms.Button buttonTestarEditar;
        private System.Windows.Forms.Button buttonTestarInserir;
        private System.Windows.Forms.ColumnHeader IDUsuario;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Usuario_Previlegio;
        private System.Windows.Forms.ColumnHeader IDPrevilegio;
        private System.Windows.Forms.ColumnHeader Previlegio;
        private System.Windows.Forms.ColumnHeader Permissao_IDPrevilegio;
        private System.Windows.Forms.ColumnHeader Permissao;
        private System.Windows.Forms.ColumnHeader PermissaoPrevilegio;
        private System.Windows.Forms.Button buttonTestarLer;
    }
}

