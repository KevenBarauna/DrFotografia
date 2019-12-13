namespace DrFotografia.View.Usuarios
{
    partial class TodosUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodosUsuarios));
            this.LvUsuarios = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LvUsuarios
            // 
            this.LvUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nome,
            this.email});
            this.LvUsuarios.HideSelection = false;
            this.LvUsuarios.Location = new System.Drawing.Point(12, 33);
            this.LvUsuarios.Name = "LvUsuarios";
            this.LvUsuarios.Size = new System.Drawing.Size(333, 505);
            this.LvUsuarios.TabIndex = 13;
            this.LvUsuarios.UseCompatibleStateImageBehavior = false;
            this.LvUsuarios.View = System.Windows.Forms.View.Details;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Location = new System.Drawing.Point(12, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 24);
            this.panel4.TabIndex = 12;
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(15)))), ((int)(((byte)(60)))));
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(119, 554);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(108, 30);
            this.BtnSair.TabIndex = 14;
            this.BtnSair.Text = "Voltar pro inicio";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // TodosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(359, 596);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LvUsuarios);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TodosUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TodosUsuarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvUsuarios;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnSair;
    }
}