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
    public partial class QuadroBuscaResult : Form
    {
        string texto;  //variavel para pegar informação que será passada quando a instancia desse form for aberta
        public QuadroBuscaResult(string texto)
        {
            InitializeComponent();

            //definir texto de pesquisa
            this.texto = texto.ToUpper();

        }
        //===========================================================================
        private void QuadroBuscaResult_Load(object sender, EventArgs e)
        {//executa a pesquisa e constroi lista box
            ExecutaPesquisa(); //ao carreegar ele executa esse metodo


        }
        //===========================================================================
        private void ExecutaPesquisa()
        {
            //metodo criado para  fazer pesquisa e apresentar dados
            List<registroAgenda> listaregistro = new List<registroAgenda>();
            //essa lista é criada para pegar dados passados no fore each da lista com registro


            foreach (registroAgenda registro in Cl_carregamento_geral.LISTA_REG) //para cada registro existente ele verifica
            {
                if (registro.compromisso.ToUpper().Contains(texto) ||          //se conter o texto pesquisado em algum dado do registro existente
                    registro.DiaDaSemana.ToUpper().Contains(texto) ||
                    registro.horario.ToUpper().Contains(texto) ||
                    registro.duracao.ToUpper().Contains(texto)) 
                {
                    listaregistro.Add(registro);                            //lista registro vazia vai add todas informacoes daquele registro dentro da cl lista geral 
                                                                        //e agora so falta pegar essa informaçõe e colocar na lsit box com resultados
                }
            }
            //apresentar resultado na lista box agoora

            listBoxResult.Items.Clear();// primeiro limpa depois carrega lista
            foreach (registroAgenda reg in listaregistro)  //para cada registro que foi colocado dentro daquela lista vazia
                                                           //esse foreach add a list box toda informação do reg
            {
                listBoxResult.Items.Add(reg.compromisso +" "+reg.DiaDaSemana+" "+ reg.horario +" "+ reg.duracao);

                lbl_registro.Text = "registros : " + listBoxResult.Items.Count;
            }
        }
        //===========================================================================
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
            this.Close();
        }
        //===========================================================================
        private void btn_novapesq_Click(object sender, EventArgs e)
        {//pegar novo texto
            Buscar novaBusca = new Buscar();
            novaBusca.ShowDialog();

            if (novaBusca.cancelado) return;

            //senao a variavel texto desse qudro vai receber a pesquisa
            texto = novaBusca.ItemPesquisa.ToUpper(); //item de epsquisa é a variavel que receb o texto box em maiusculas

            ExecutaPesquisa(); //quando for clicado para fazer epsquisa ele entra novamente no metodo para construir pesquisa


          
        }
    }
}
