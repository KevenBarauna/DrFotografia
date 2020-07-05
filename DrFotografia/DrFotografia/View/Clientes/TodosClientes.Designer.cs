namespace DrFotografia.View.Clientes
{
    partial class TodosClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodosClientes));
            this.BtnSair = new System.Windows.Forms.Button();
            this.LvClientes = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tel1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tel2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tel3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(15)))), ((int)(((byte)(60)))));
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(359, 537);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(108, 30);
            this.BtnSair.TabIndex = 16;
            this.BtnSair.Text = "Voltar pro inicio";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LvClientes
            // 
            this.LvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nome,
            this.email,
            this.Tel1,
            this.Tel2,
            this.Tel3,
            this.Desc});
            this.LvClientes.HideSelection = false;
            this.LvClientes.Location = new System.Drawing.Point(12, 12);
            this.LvClientes.Name = "LvClientes";
            this.LvClientes.Size = new System.Drawing.Size(783, 505);
            this.LvClientes.TabIndex = 15;
            this.LvClientes.UseCompatibleStateImageBehavior = false;
            this.LvClientes.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id:";
            this.id.Width = 50;
            // 
            // nome
            // 
            this.nome.Text = "Nome:";
            this.nome.Width = 120;
            // 
            // email
            // 
            this.email.Text = "E-mail:";
            this.email.Width = 158;
            // 
            // Tel1
            // 
            this.Tel1.Text = "Telefone (1)";
            this.Tel1.Width = 100;
            // 
            // Tel2
            // 
            this.Tel2.Text = "Telefone (2)";
            this.Tel2.Width = 100;
            // 
            // Tel3
            // 
            this.Tel3.Text = "Telefone (3)";
            this.Tel3.Width = 100;
            // 
            // Desc
            // 
            this.Desc.Text = "Descrição";
            this.Desc.Width = 150;
            // 
            // TodosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(809, 593);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TodosClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TodosClientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.ListView LvClientes;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader Tel1;
        private System.Windows.Forms.ColumnHeader Tel2;
        private System.Windows.Forms.ColumnHeader Tel3;
        private System.Windows.Forms.ColumnHeader Desc;
    }
}