using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.DAL;

namespace WindowsFormsApp1
{
    public partial class frm_Cadastrar : Form
    {
        public frm_Cadastrar()
        {
            InitializeComponent();
        }

        private void frm_Cadastrar_Load(object sender, EventArgs e)
        {
            this.tbAlunosBindingSource.DataSource = DataContextFactory.dataContext.tb_Alunos;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.tbAlunosBindingSource.AddNew();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (this.Valida())
            {
                this.tbAlunosBindingSource.EndEdit();
                DataContextFactory.dataContext.SubmitChanges();
                MessageBox.Show("Aluno Inserido com Sucesso!");
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
            }

            
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza!", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.tbAlunosBindingSource.RemoveCurrent();
                DataContextFactory.dataContext.SubmitChanges();
                MessageBox.Show("Aluno Excluido com Sucesso!");
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
            }

        }
        private bool Valida()
        {
            if (txt_aluno.Text.Trim() == String.Empty)
            {
                MessageBox.Show("O nome do Aluno e Obrigatorio");
                txt_aluno.Focus();
                return false;
            }
            return true;
        }

        
    } 
}
