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
    public partial class inserirEditar : Form
    {
        public int indice = -1;//para controlar linha selecionada para editar ou apagar

        public inserirEditar()
        {
            InitializeComponent();
            ConstroiListafisica();
            //chama esse metodo para adicionar a lista fisica a lista invisivel de registros que foi pego do doc


        }

        //===============================================================
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //===============================================================
        private void btn_inserir_Click(object sender, EventArgs e)
        {//insere novo registro a lista
            //label1.Text = Cl_carregamento_geral.construirLista.


            //nao precisava criar variavel
            if (textCompromisso.Text == "" || text_Horario.Text == "" || textDia.Text == "" || textDuracao.Text == "")
            {
                MessageBox.Show("falta inserir algum dado");
                return;
            }

            //verificar se existe registro igual
            foreach (registroAgenda registro in Cl_carregamento_geral.LISTA_REG)
            {
                if (registro.compromisso == textCompromisso.Text && registro.horario == text_Horario.Text && registro.DiaDaSemana == textDia.Text && registro.duracao == textDuracao.Text)
                { MessageBox.Show("erro! esse registro ja existe..!"); return; }
            }


            //chamar  metodo da classe apra gravar novo registro e add a lista e depois escrever por cima do ficheiro doc
            Cl_carregamento_geral.gravarNovoReg(textCompromisso.Text, text_Horario.Text, textDia.Text, textDuracao.Text);

            //apos inserir precisa refrescar /atualziar a lista fisica
            //entao chama novamente o metodo para construir ela ja que o novo registro foi add ao doc e ela puxa de la 
            ConstroiListafisica();

            //apos limpar  lsita fisica e ela reescrever as informações da list deixar todos os campos vazios para inserir novo registro
            textCompromisso.Text = " ";
            text_Horario.Text = " ";
            textDia.Text = " ";
            textDuracao.Text = " ";
            textCompromisso.Focus();
            //e apos isso ele foca um campo em branco e deixa os botoes desativados\
            btn_apagar.Enabled = false;
            btn_editar.Enabled = false;
        }
        //===============================================================
        private void inserirEditar_Load(object sender, EventArgs e)
        {

        }
        //criar um metodo para add a lista de compromissos invisivel os contatos registrados na listbox visivel
        //===============================================================

        private void ConstroiListafisica()
        {//adiciona a lista visivel os compromissos registrados

            listBoxCompromissos.Items.Clear();//vai limpar  para atualizar  sempre que houver uma alteracao

            foreach (registroAgenda registro in Cl_carregamento_geral.LISTA_REG)
            { //para cada registro(classe) em uma lista de classedo tipo registro

                listBoxCompromissos.Items.Add(registro.compromisso + " ##### " +
                                                registro.DiaDaSemana + " #### " +
                                                registro.horario + " #### " +
                                                registro.duracao);


            }
            //atualizar numero de registros
            lbl_numRegistro.Text = "registros: " + listBoxCompromissos.Items.Count;
        }

        private void listBoxCompromissos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verificar se indice = -1 se for ele nao abilida o enable dos botoes
            indice = listBoxCompromissos.SelectedIndex; //indice recebe o indice selecionado da lista
            if (listBoxCompromissos.SelectedIndex >= 0)
            {
                btn_editar.Enabled = true;
                btn_apagar.Enabled = true;
            }

            //caso contrario seleciona indice da lista
            else
            {
                btn_editar.Enabled = false;
                btn_apagar.Enabled = false;


            }
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            //apaga registro selecionado
            //eliminar registro da lista invisivel
            if (indice >= 0)

                Cl_carregamento_geral.LISTA_REG.RemoveAt(indice);

            //eliminar registro do ficheiro / doc
            Cl_carregamento_geral.gravaFicheiro();
            //atualizar a lista fisica
            ConstroiListafisica();
            indice = -1;
            btn_apagar.Enabled = false;
            btn_editar.Enabled = false;

        }



        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (indice >= 0)
            {
                //ainda não sei como abrir cada valor certo dentro do textbox especifico

               // Cl_carregamento_geral.LISTA_REG.    a resolver

            }


        }

        private void btn_texte_Click(object sender, EventArgs e)
        {

        }

        private void textDuracao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

