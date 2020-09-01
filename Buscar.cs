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
    public partial class Buscar : Form

    {
        //proipriedade de controle
        public bool cancelado { get; set; }//para  informar se foi feito o cancelamento ou prosseguir pesquisa
        public string ItemPesquisa { get; set; }
        //variavel para enviar ao novo form quadro de busca  que vai comparar usando foreache e preencher uma lista com dadoscom resultados
        //==============
        public Buscar()
        {
            InitializeComponent();
        }
        //===========================================================================
        private void buscar_Load(object sender, EventArgs e)
        {

        }
        //===========================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            //cancela o quadro

            cancelado = true;
            this.Close();

        }
        //===========================================================================
        private void btn_buscar_Click(object sender, EventArgs e)
        {//define o item a pesquisar ,define cancelado como false e fecha o quadro de pesquisa
            if (txtBuscar.Text == "") return;

            ItemPesquisa = txtBuscar.Text;
            cancelado = false;
            this.Close();
        }
    }
}
