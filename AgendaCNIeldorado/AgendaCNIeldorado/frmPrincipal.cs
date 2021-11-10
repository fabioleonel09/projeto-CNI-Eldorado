using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaCNIeldorado
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            //inicia bloqueando ou deixando invisíveis os componentes até a barra de progressos ficar completa

            tbcSemana.Visible = false;
            tbcSemana.Enabled = false;

            btnSegunda.Visible = false;
            btnTerca.Visible = false;
            btnQuarta.Visible = false;
            btnQuinta.Visible = false;
            btnSexta.Visible = false;
            btnSabado.Visible = false;
            btnRefreshDGV.Visible = false;

            //Deixa os componentes inativos com a cor cinza clara

            btnSegunda.Enabled = false;
            btnSegunda.BackColor = Color.LightGray;
            btnTerca.Enabled = false;
            btnTerca.BackColor = Color.LightGray;
            btnQuarta.Enabled = false;
            btnQuarta.BackColor = Color.LightGray;
            btnQuinta.Enabled = false;
            btnQuinta.BackColor = Color.LightGray;
            btnSexta.Enabled = false;
            btnSexta.BackColor = Color.LightGray;
            btnSabado.Enabled = false;
            btnSabado.BackColor = Color.LightGray;

            tabPage1.BackColor = Color.LightGray;
            tabPage2.BackColor = Color.LightGray;
            tabPage3.BackColor = Color.LightGray;
            tabPage4.BackColor = Color.LightGray;
            tabPage5.BackColor = Color.LightGray;
            tabPage6.BackColor = Color.LightGray;

            //inicia bloqueando ou deixando invisíveis os componentes até a barra de progressos ficar completa

            pbStudent1.Visible = false;
            pbStudent2.Visible = false;

            cbNivel.Visible = false;
            txtSenha.Visible = false;
            btnAbrir.Visible = false;
            btnFechar.Visible = false;

            lblNivel.Visible = false;
            lblSenha.Visible = false;

            gbLogar.Visible = false;

            gbMarcacoes.Visible = false;

            //groupBox sempre bloqueado

            gbMarcacoes.Enabled = false;            
        }

        private void tSplash_Tick(object sender, EventArgs e)
        {
            //programa a barra de progressos

            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }

            else
            {
                //aqui o componente Timer fica desabilitado
                tSplash.Enabled = false;

                //deixa visível todos componentes do formulário principal
                gbCarregando.Visible = false;
                tbcSemana.Visible = true;

                btnSegunda.Visible = true;
                btnTerca.Visible = true;
                btnQuarta.Visible = true;
                btnQuinta.Visible = true;
                btnSexta.Visible = true;
                btnSabado.Visible = true;
                btnRefreshDGV.Visible = true;

                pbStudent1.Visible = true;
                pbStudent2.Visible = true;

                cbNivel.Visible = true;
                txtSenha.Visible = true;
                btnAbrir.Visible = true;
                btnFechar.Visible = true;

                lblNivel.Visible = true;
                lblSenha.Visible = true;

                gbLogar.Visible = true;

                gbMarcacoes.Visible = true;

                DateTime dataMarcacao;
                TimeSpan horasVividas;
                int diasVividos;

                dataMarcacao = dataDateTimePicker.Value;
                horasVividas = DateTime.Now.Subtract(dataMarcacao);
                diasVividos = horasVividas.Days;
                if (diasVividos < 5)
                {
                    MessageBox.Show("ola");
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {      
            //o evento do botão fechar deixa os componentes do formulário principal no estado
            //inicial de carregamento, desabilitados e com a cor cinza clara.

                tbcSemana.Enabled = false;

                btnSegunda.Enabled = false;
                btnSegunda.BackColor = Color.LightGray;
                btnTerca.Enabled = false;
                btnTerca.BackColor = Color.LightGray;
                btnQuarta.Enabled = false;
                btnQuarta.BackColor = Color.LightGray;
                btnQuinta.Enabled = false;
                btnQuinta.BackColor = Color.LightGray;
                btnSexta.Enabled = false;
                btnSexta.BackColor = Color.LightGray;
                btnSabado.Enabled = false;
                btnSabado.BackColor = Color.LightGray;

                tabPage1.BackColor = Color.LightGray;
                tabPage2.BackColor = Color.LightGray;
                tabPage3.BackColor = Color.LightGray;
                tabPage4.BackColor = Color.LightGray;
                tabPage5.BackColor = Color.LightGray;
                tabPage6.BackColor = Color.LightGray;

            //limpa o txt e o comboBox

                cbNivel.Text = "";
                txtSenha.Clear();

            //habilita o txt e o comboBox

                cbNivel.Enabled = true;
                txtSenha.Enabled = true;            
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //aqui habilita quase todos os componentes do formulário principal

            if ((cbNivel.Text == "Diretoria") && (txtSenha.Text == "admdiretoria987"))
            {
                tbcSemana.Enabled = true;

                btnSegunda.Enabled = true;
                btnSegunda.BackColor = Color.AliceBlue;
                btnTerca.Enabled = true;
                btnTerca.BackColor = Color.Snow;
                btnQuarta.Enabled = true;
                btnQuarta.BackColor = Color.GhostWhite;
                btnQuinta.Enabled = true;
                btnQuinta.BackColor = Color.LavenderBlush;
                btnSexta.Enabled = true;
                btnSexta.BackColor = Color.Lavender;
                btnSabado.Enabled = true;
                btnSabado.BackColor = Color.Honeydew;

                tabPage1.BackColor = Color.AliceBlue;
                tabPage2.BackColor = Color.Snow;
                tabPage3.BackColor = Color.GhostWhite;
                tabPage4.BackColor = Color.LavenderBlush;
                tabPage5.BackColor = Color.Lavender;
                tabPage6.BackColor = Color.Honeydew;

                //desabilita txtSenha e comboBox

                cbNivel.Enabled = false;
                txtSenha.Enabled = false;                                
            }

            else
            {
                //este nível habilita apenas o conjunto de abas

                if (cbNivel.Text == "Docência")
                {
                    tbcSemana.Enabled = true;

                    //deixa cada aba com sua cor original

                    tabPage1.BackColor = Color.AliceBlue;
                    tabPage2.BackColor = Color.Snow;
                    tabPage3.BackColor = Color.GhostWhite;
                    tabPage4.BackColor = Color.LavenderBlush;
                    tabPage5.BackColor = Color.Lavender;
                    tabPage6.BackColor = Color.Honeydew;

                    //desabilita txtSenha e comboBox

                    cbNivel.Enabled = false;
                    txtSenha.Enabled = false;
                }

                else
                {
                    //este nível habilita apenas o conjunto de abas

                    if (cbNivel.Text == "Recepção")
                    {
                        tbcSemana.Enabled = true;

                        //deixa cada aba com sua cor original

                        tabPage1.BackColor = Color.AliceBlue;
                        tabPage2.BackColor = Color.Snow;
                        tabPage3.BackColor = Color.GhostWhite;
                        tabPage4.BackColor = Color.LavenderBlush;
                        tabPage5.BackColor = Color.Lavender;
                        tabPage6.BackColor = Color.Honeydew;

                        //desabilita txtSenha e comboBox

                        cbNivel.Enabled = false;
                        txtSenha.Enabled = false;
                    }

                    else
                    {
                        //este evento não permite o comboBox em branco
                        //gera um aviso

                        if (cbNivel.Text == "")
                        {
                            MessageBox.Show("Escolha um nível para logar. E, se necessário, digite uma senha!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cbNivel.Enabled = true;
                            txtSenha.Enabled = true;
                        }

                        else
                        {
                            //este evento não permite o txtSenha em branco
                            //gera um aviso

                            if ((txtSenha.Text == "") && (cbNivel.Text == "Diretoria"))
                            {
                                MessageBox.Show("Digite uma senha para o usuário nível 'Diretoria'!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cbNivel.Enabled = true;
                                txtSenha.Enabled = true;
                            }                           
                        }
                       
                    }
                }
            }
            
            //evento que sempre limpará o txtSenha e o comboBox, para obrigar
            //o usuário e reescrever os dados

            cbNivel.Text = "";
            txtSenha.Clear();           
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //evento de mensagem ao clicar no "sair" da janela do programa

            MessageBox.Show("Obrigado por utilizar o sistema de agendamento de TCC's do CNI Eldorado! \nUm projeto dos Sistemas Lua de gerenciamento.\nVisite nossas redes sociais: \nInstagram: @sistemaslua \nTwitter: @sistemaslua \nYoutube: Sistemas Lua \nMande-nos um e-mail: \nadmsistemaslua@gmail.com \nVisite nosso site: \nwww.sistemaslua.negocio.site", "Obrigado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //instancia e abre o form de cada dia da semana

        private void btnSegunda_Click(object sender, EventArgs e)
        {           
            frmSegunda fseg = new frmSegunda();
            fseg.Show();
        }

        private void btnTerca_Click(object sender, EventArgs e)
        {
            frmTerca fter = new frmTerca();
            fter.Show();
        }

        private void btnQuarta_Click(object sender, EventArgs e)
        {
            frmQuarta fquar = new frmQuarta();
            fquar.Show();
        }

        private void btnQuinta_Click(object sender, EventArgs e)
        {
            frmQuinta fquin = new frmQuinta();
            fquin.Show();
        }

        private void btnSexta_Click(object sender, EventArgs e)
        {
            frmSexta fsex = new frmSexta();
            fsex.Show();
        }

        private void btnSabado_Click(object sender, EventArgs e)
        {
            frmSabado fsab = new frmSabado();
            fsab.Show();
        }

        //salva os ítens do DB de segunda

        private void segundaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.segundaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaCNIeldoradoDataSet);

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'agendaCNIeldoradoDataSet.Sabado'. Você pode movê-la ou removê-la conforme necessário.
            this.sabadoTableAdapter.Fill(this.agendaCNIeldoradoDataSet.Sabado);
            // TODO: esta linha de código carrega dados na tabela 'agendaCNIeldoradoDataSet.Sexta'. Você pode movê-la ou removê-la conforme necessário.
            this.sextaTableAdapter.Fill(this.agendaCNIeldoradoDataSet.Sexta);
            // TODO: esta linha de código carrega dados na tabela 'agendaCNIeldoradoDataSet.Quinta'. Você pode movê-la ou removê-la conforme necessário.
            this.quintaTableAdapter.Fill(this.agendaCNIeldoradoDataSet.Quinta);
            // TODO: esta linha de código carrega dados na tabela 'agendaCNIeldoradoDataSet.Quarta'. Você pode movê-la ou removê-la conforme necessário.
            this.quartaTableAdapter.Fill(this.agendaCNIeldoradoDataSet.Quarta);
            // TODO: esta linha de código carrega dados na tabela 'agendaCNIeldoradoDataSet.Terca'. Você pode movê-la ou removê-la conforme necessário.
            this.tercaTableAdapter.Fill(this.agendaCNIeldoradoDataSet.Terca);
            // TODO: esta linha de código carrega dados na tabela 'agendaCNIeldoradoDataSet.Segunda'. Você pode movê-la ou removê-la conforme necessário.
            this.segundaTableAdapter.Fill(this.agendaCNIeldoradoDataSet.Segunda);

        }

        private void btnRefreshDGV_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.segundaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaCNIeldoradoDataSet);
            segundaDataGridView.Refresh();
        }

        //Os próximos eventos implementam todos os botões de pesquisa das abas do form principal
        //As caixas de texto são limpas após as pesquisas

        private void btnPesquisarSeg_Click(object sender, EventArgs e)
        {
            if (txtPesquisaSeg.Text == "")
            {
                segundaDataGridView.DataSource = segundaTableAdapter.retornarNomeSeg(txtPesquisaSeg.Text);
            }

            else
            {
                if (rbNomeSeg.Checked == true)
                {
                    segundaDataGridView.DataSource = segundaTableAdapter.retornarNomeSeg(txtPesquisaSeg.Text);
                }

                else
                {
                    if (rbMatriculaSeg.Checked == true)
                    {
                        segundaDataGridView.DataSource = segundaTableAdapter.retornarMatriculaSeg(txtPesquisaSeg.Text);
                    }                    
                }
            }

            txtPesquisaSeg.Clear();
        }

        private void btnPesquisaTer_Click(object sender, EventArgs e)
        {
            if (txtPesquisaTer.Text == "")
            {
                tercaDataGridView.DataSource = tercaTableAdapter.retornarNomeTer(txtPesquisaTer.Text);
            }

            else
            {
                if (rbNomeTer.Checked == true)
                {
                    tercaDataGridView.DataSource = tercaTableAdapter.retornarNomeTer(txtPesquisaTer.Text);
                }

                else
                {
                    if (rbMatriculaTer.Checked == true)
                    {
                        tercaDataGridView.DataSource = tercaTableAdapter.retornarMatriculaTer(txtPesquisaTer.Text);
                    }
                }
            }

            txtPesquisaTer.Clear();
        }

        private void btnPesquisaQuar_Click(object sender, EventArgs e)
        {
            if (txtPesquisaQuar.Text == "")
            {
                quartaDataGridView.DataSource = quartaTableAdapter.retornarNomeQuar(txtPesquisaQuar.Text);
            }

            else
            {
                if (rbNomeQuar.Checked == true)
                {
                    quartaDataGridView.DataSource = quartaTableAdapter.retornarNomeQuar(txtPesquisaQuar.Text);
                }

                else
                {
                    if (rbMatriculaQuar.Checked == true)
                    {
                        quartaDataGridView.DataSource = quartaTableAdapter.retornarMatriculaQuar(txtPesquisaQuar.Text);
                    }
                }
            }

            txtPesquisaQuar.Clear();
        }

        private void btnPesquisaQuin_Click(object sender, EventArgs e)
        {
            if (txtPesquisaQuin.Text == "")
            {
                quintaDataGridView.DataSource = quintaTableAdapter.retornarNomeQuin(txtPesquisaQuin.Text);
            }

            else
            {
                if (rbNomeQuin.Checked == true)
                {
                    quintaDataGridView.DataSource = quintaTableAdapter.retornarNomeQuin(txtPesquisaQuin.Text);
                }

                else
                {
                    if (rbMatriculaQuin.Checked == true)
                    {
                        quintaDataGridView.DataSource = quintaTableAdapter.retornarMatriculaQuin(txtPesquisaQuin.Text);
                    }
                }
            }

            txtPesquisaQuin.Clear();
        }

        private void btnPesquisaSex_Click(object sender, EventArgs e)
        {
            if (txtPesquisaSex.Text == "")
            {
                sextaDataGridView.DataSource = sextaTableAdapter.retornarNomeSex(txtPesquisaSex.Text);
            }

            else
            {
                if (rbNomeSex.Checked == true)
                {
                    sextaDataGridView.DataSource = sextaTableAdapter.retornarNomeSex(txtPesquisaSex.Text);
                }

                else
                {
                    if (rbMatriculaSex.Checked == true)
                    {
                        sextaDataGridView.DataSource = sextaTableAdapter.retornarMatriculaSex(txtPesquisaSex.Text);
                    }
                }
            }

            txtPesquisaSex.Clear();
        }

        private void btnPesquisaSab_Click(object sender, EventArgs e)
        {
            if (txtPesquisaSab.Text == "")
            {
                sabadoDataGridView.DataSource = sabadoTableAdapter.retornarNomeSab(txtPesquisaSab.Text);
            }

            else
            {
                if (rbNomeSab.Checked == true)
                {
                    sabadoDataGridView.DataSource = sabadoTableAdapter.retornarNomeSab(txtPesquisaSab.Text);
                }

                else
                {
                    if (rbMatriculaSab.Checked == true)
                    {
                        sabadoDataGridView.DataSource = sabadoTableAdapter.retornarMatriculaSab(txtPesquisaSab.Text);
                    }
                }
            }

            txtPesquisaSab.Clear();
        }
    }
}
