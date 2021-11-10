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
    public partial class frmSexta : Form
    {
        public frmSexta()
        {
            InitializeComponent();

            //inicializa com os groupBoxes bloqueados

            gbDadosAlunoSeg.Enabled = false;
            gbDadosAgendamentoSeg.Enabled = false;
            gbResultadosSeg.Enabled = false;
        }

        private void sextaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //implementa o botão salvar, bloqueia os groupBoxes, atualiza o DGW

            MessageBox.Show("Agendamento salvo com sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Validate();
            this.sextaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaCNIeldoradoDataSet);

            gbDadosAlunoSeg.Enabled = false;
            gbDadosAgendamentoSeg.Enabled = false;
            gbResultadosSeg.Enabled = false;

            sextaDataGridView.Refresh();
        }

        private void frmSexta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'agendaCNIeldoradoDataSet.Sexta'. Você pode movê-la ou removê-la conforme necessário.
            this.sextaTableAdapter.Fill(this.agendaCNIeldoradoDataSet.Sexta);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //habilita os groupBoxes

            gbDadosAlunoSeg.Enabled = true;
            gbDadosAgendamentoSeg.Enabled = true;
            gbResultadosSeg.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //implementa o botão excluir, bloqueia os groupBoxes, atualiza o DGW

            MessageBox.Show("Agendamento excluído com sucesso!", "Exclusão!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Validate();
            this.sextaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaCNIeldoradoDataSet);

            gbDadosAlunoSeg.Enabled = false;
            gbDadosAgendamentoSeg.Enabled = false;
            gbResultadosSeg.Enabled = false;

            sextaDataGridView.Refresh();
        }

        private void tsEditarSex_Click(object sender, EventArgs e)
        {
            //habilita os groupBoxes

            gbDadosAlunoSeg.Enabled = true;
            gbDadosAgendamentoSeg.Enabled = true;
            gbResultadosSeg.Enabled = true;
        }

        private void dataDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //este evento bloqueia o dateTimePicker para funcionar apenas nas sextas-feiras; exibe uma mensagem; limpa os txt's com o nome do aluno, 
            //matrícula, curso e professor

            if (dataDateTimePicker.Value.DayOfWeek != DayOfWeek.Friday)
            {
                MessageBox.Show("Atenção! Este agendamento é apenas para a sexta-feira.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                nomeDoAlunoTextBox.Clear();
                matriculaTextBox.Clear();
                cursoTextBox.Clear();
                professorTextBox.Clear();
            }
        }

        //Implementa o botão pesquisar por nome e limpa a caixa de texto após a pesquisa

        private void btnPesquisaNomeSex_Click(object sender, EventArgs e)
        {          
            sextaDataGridView.DataSource = sextaTableAdapter.retornarNomeSex(txtPesquisarNomeSex.Text);

            txtPesquisarNomeSex.Clear();
        }
    }
}
