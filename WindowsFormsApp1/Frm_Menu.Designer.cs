namespace WindowsFormsApp1
{
    partial class Frm_Menu
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
            this.components = new System.ComponentModel.Container();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Ranking = new System.Windows.Forms.DataGridView();
            this.tbAlunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ranking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlunosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.Location = new System.Drawing.Point(129, 14);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 0;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastrar Aluno ";
            // 
            // dgv_Ranking
            // 
            this.dgv_Ranking.AllowUserToAddRows = false;
            this.dgv_Ranking.AllowUserToDeleteRows = false;
            this.dgv_Ranking.AutoGenerateColumns = false;
            this.dgv_Ranking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ranking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.pontosDataGridViewTextBoxColumn});
            this.dgv_Ranking.DataSource = this.tbAlunosBindingSource;
            this.dgv_Ranking.Location = new System.Drawing.Point(29, 73);
            this.dgv_Ranking.Name = "dgv_Ranking";
            this.dgv_Ranking.ReadOnly = true;
            this.dgv_Ranking.Size = new System.Drawing.Size(443, 242);
            this.dgv_Ranking.TabIndex = 3;
            // 
            // tbAlunosBindingSource
            // 
            this.tbAlunosBindingSource.DataSource = typeof(Sistema.DAL.tb_Alunos);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(175, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ranking dos Alunos ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.Frozen = true;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome Aluno";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nomeDataGridViewTextBoxColumn.Width = 250;
            // 
            // pontosDataGridViewTextBoxColumn
            // 
            this.pontosDataGridViewTextBoxColumn.DataPropertyName = "Pontos";
            this.pontosDataGridViewTextBoxColumn.Frozen = true;
            this.pontosDataGridViewTextBoxColumn.HeaderText = "Pontos";
            this.pontosDataGridViewTextBoxColumn.Name = "pontosDataGridViewTextBoxColumn";
            this.pontosDataGridViewTextBoxColumn.ReadOnly = true;
            this.pontosDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pontosDataGridViewTextBoxColumn.Width = 150;
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(504, 327);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Ranking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cadastrar);
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ranking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlunosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Ranking;
        private System.Windows.Forms.BindingSource tbAlunosBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontosDataGridViewTextBoxColumn;
    }
}

