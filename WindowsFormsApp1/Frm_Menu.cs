using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.DAL;
namespace WindowsFormsApp1
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
          
            this.tbAlunosBindingSource.DataSource = DataContextFactory.dataContext.tb_Alunos;

            dgv_Ranking.Sort(dgv_Ranking.Columns[2], ListSortDirection.Descending);
            
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            frm_Cadastrar frm = new frm_Cadastrar();
            frm.Show();

            
        }

        

       
     }
}
