using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda_compromissos
{
	public partial class frmMenu : Form
	{
		public frmMenu()
		{
			InitializeComponent();
			//constroi a lista carrega a lista de registros
			Cl_carregamento_geral.construirLista();
			

			label1.Text = Cl_carregamento_geral.versao;
		}
		//===============================================================
		private void frmMenu_Load(object sender, EventArgs e)
		{
		
		}
		//===========================================================================
		private void lbl_versao_Load(object sender, EventArgs e)
		{
		

		}
		//===========================================================================
		private void btn_buscar_Click(object sender, EventArgs e)
		{
			Buscar novabusca = new Buscar();
			novabusca.ShowDialog();

			//quando fechar o quadro de busca verifica se foi cancelado ,se nao foi ele pega a busca
			if (novabusca.cancelado) return;
			//selse
			MessageBox.Show("faz pesquisa de " + novabusca.ItemPesquisa);
			//abrir quadro com resultados


			// agora vai criar uma instancia do form com quadro com resultados
			QuadroBuscaResult QuadroPesquisa = new QuadroBuscaResult(novabusca.ItemPesquisa);
			QuadroPesquisa.ShowDialog();

		}
		//===========================================================================
		private void btn_sair_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("deseja sair da aplicação?", "sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No ) return;

			Application.Exit();
		}
		//===========================================================================
		private void lbl_duracao_Click(object sender, EventArgs e)
		{

		}
		//===========================================================================
		private void txtBox_diaSem_TextChanged(object sender, EventArgs e)
		{

		}
		//===========================================================================
		private void txtBox_duracao_TextChanged(object sender, EventArgs e)
		{

		}
		//===========================================================================
		private void label3_Click(object sender, EventArgs e)
		{

		}
		//===========================================================================
		private void txtBox_horario_TextChanged(object sender, EventArgs e)
		{

		}
		//===========================================================================
		private void label2_Click(object sender, EventArgs e)
		{

		}
		//===========================================================================
		private void lbl_compromis_Click(object sender, EventArgs e)
		{

		}
		//===========================================================================
		private void txtBox_compromiss_TextChanged(object sender, EventArgs e)
		{

		}
		//===========================================================================
		private void btn_iserir_Click(object sender, EventArgs e)
		{
			inserirEditar formulario = new inserirEditar();//cria uma nova instancia do formulario 
			formulario.ShowDialog();			//e abre ela

		}

        
    }
}
