using System;
using System.Windows.Forms;
//using System.Runtime.InteropServices;

using System.Runtime.InteropServices;

namespace LojahAbc
{
    public partial class frmPesquisarFuncionarios : Form
    {
        /*Criando variáveis para controle do menu

        //Criando variáveis para controle do menu
 bba9dfae79ec3a7c6369ce07296ddf9471969a87
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
 
        */

        public frmPesquisarFuncionarios()
        {
            InitializeComponent();
            DesabilitarCampos();
        }
        public void DesabilitarCampos()
        {
            rbtCodigo.Checked = false;
            rbtnome.Checked = false;
            txtDescricao.Focus();
        }
        public void Limparcampos()
        {
            rbtCodigo.Checked = false;
            rbtnome.Checked = false;
            txtDescricao.Clear();
            txtDescricao.Focus();
            ltbpesquisar.Items.Clear();
            txtDescricao.Enabled = false;
        }
        public void Limparcampospesquisar()
        {
            rbtCodigo.Checked = false;
            rbtnome.Checked = false;
            txtDescricao.Clear();
            txtDescricao.Focus();
            txtDescricao.Enabled = false;
        }

        private void bntPesquisar_Click(object sender, EventArgs e)
        {
            ltbpesquisar.Items.Clear();
            ltbpesquisar.Items.Add(txtDescricao.Text);
            Limparcampospesquisar();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //limparcampos
            Limparcampos();
            txtDescricao.Focus();
        }

        private void ltbpesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string descricao = ltbpesquisar.SelectedItem.ToString();
            frmfuncionarios abrir = new frmfuncionarios(descricao);
            abrir.ShowDialog();
            this.Hide();
        }

        private void frmPesquisarFuncionarios_Load(object sender, EventArgs e)
        {

            /*IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
            

            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
            */
        }

        private void gpbPesquisarPor_Enter(object sender, EventArgs e)
        {

        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            Habilitarcampos();
        }

        private void rbtnome_CheckedChanged(object sender, EventArgs e)
        {
            Habilitarcampos();
        }
        public void Habilitarcampos()
        {
            txtDescricao.Enabled = true;
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;
            txtDescricao.Focus();
        }
    }
}
