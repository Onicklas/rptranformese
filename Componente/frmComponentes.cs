using System;
using System.Windows.Forms;

namespace Componente
{
    public partial class frmComponentes : Form
    {
        public frmComponentes()
        {
            InitializeComponent();
        }

        private void gpb_lala_Enter(object sender, EventArgs e)
        {

        }

        private void txt_nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbb_listarnomes.Items.Add(txt_nome.Text);
                txt_nome.Clear();
                txt_nome.Focus();
            }
        }

        private void ckb_livros_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_livros.Checked)
            {
                lbx_listarnomes.Items.Add("Livros");
                pcb_imagens.Load(@"/Imagens\livro.png");
            }
            else
            {
                lbx_listarnomes.Items.Remove("Livros");
            }
        }

        private void ckb_computador_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_computador.Checked)
            {
                lbx_listarnomes.Items.Add("Computador");
                pcb_imagens.Load(@"/Imagens\pc.png");
            }
            else
            {
                lbx_listarnomes.Items.Remove("Computador");
            }
        }

        private void ckb_mesa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_mesa.Checked)
            {
                lbx_listarnomes.Items.Add("Mesa");
                pcb_imagens.Load(@"/Imagens\mesa.png");
            }
            else
            {
                lbx_listarnomes.Items.Remove("Mesa");
            }
        }

        private void ckb_banana_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_banana.Checked)
            {
                lbx_listarnomes.Items.Add("Banana");
                pcb_imagens.Load(@"/Imagens\banana.png");
            }
            else
            {
                lbx_listarnomes.Items.Remove("Banana");
            }
        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "selecione uma imagem";
            ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp|Todos os arquivos|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pcb_imagens.ImageLocation = ofd.FileName;
                pcb_imagens.Load();
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            pcb_imagens.Image = null;
        }
    }
}
