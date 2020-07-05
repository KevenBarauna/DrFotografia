namespace DrFotografia.View.Eventos
{
    partial class TodosEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodosEventos));
            this.BtnSair = new System.Windows.Forms.Button();
            this.LvEvento = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Local = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(15)))), ((int)(((byte)(60)))));
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(426, 539);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(108, 30);
            this.BtnSair.TabIndex = 16;
            this.BtnSair.Text = "Voltar pro inicio";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LvEvento
            // 
            this.LvEvento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nome,
            this.Telefone,
            this.Tipo,
            this.Data,
            this.Hora,
            this.Local,
            this.Descricao});
            this.LvEvento.HideSelection = false;
            this.LvEvento.Location = new System.Drawing.Point(12, 12);
            this.LvEvento.Name = "LvEvento";
            this.LvEvento.Size = new System.Drawing.Size(940, 505);
            this.LvEvento.TabIndex = 15;
            this.LvEvento.UseCompatibleStateImageBehavior = false;
            this.LvEvento.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id:";
            this.id.Width = 50;
            // 
            // nome
            // 
            this.nome.Text = "Nome:";
            this.nome.Width = 100;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone(1):";
            this.Telefone.Width = 110;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo:";
            this.Tipo.Width = 90;
            // 
            // Data
            // 
            this.Data.Text = "Data:";
            this.Data.Width = 100;
            // 
            // Hora
            // 
            this.Hora.Text = "Hora";
            this.Hora.Width = 90;
            // 
            // Local
            // 
            this.Local.Text = "Local:";
            this.Local.Width = 190;
            // 
            // Descricao
            // 
            this.Descricao.Text = "Descrição";
            this.Descricao.Width = 200;
            // 
            // TodosEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(967, 581);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LvEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TodosEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TodosEventos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.ListView LvEvento;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Hora;
        private System.Windows.Forms.ColumnHeader Local;
        private System.Windows.Forms.ColumnHeader Descricao;
    }
}