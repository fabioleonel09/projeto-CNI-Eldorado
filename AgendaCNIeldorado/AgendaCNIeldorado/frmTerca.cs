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
    public partial class frmTerca : Form
    {
        public frmTerca()
        {
            InitializeComponent();

            //inicializa com os groupBoxes bloqueados

            gbDadosTerca.Enabled = false;
            gbDadosAgendamentoTerca.Enabled = false;
            gbResultadosTerca.Enabled = false;
        }

        private void tercaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //implementa o botão salvar, bloqueia os groupBoxes, atualiza o DGW

            MessageBox.Show("Agendamento salvo com sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Validate();
            this.tercaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaCNIeldoradoDataSet);

            gbDadosTerca.Enabled = false;
            gbDadosAgendamentoTerca.Enabled = false;
            gbResultadosTerca.Enabled = false;

            tercaDataGridView.Refresh();
        }

        private void frmTerca_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'agendaCNIeldoradoDataSet.Terca'. Você pode movê-la ou removê-la conforme necessário.
            this.tercaTableAdapter.Fill(this.agendaCNIeldoradoDataSet.Terca);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //habilita os groupBoxes

            gbDadosTerca.Enabled = true;
            gbDadosAgendamentoTerca.Enabled = true;
            gbResultadosTerca.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //implementa o botão excluir, bloqueia os groupBoxes, atualiza o DGW

            MessageBox.Show("Agendamento excluído com sucesso!", "Exclusão!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Validate();
            this.tercaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaCNIeldoradoDataSet);

            gbDadosTerca.Enabled = false;
            gbDadosAgendamentoTerca.Enabled = false;
            gbResultadosTerca.Enabled = false;

            tercaDataGridView.Refresh();
        }

        private void tsEditarTer_Click(object sender, EventArgs e)
        {
            //habilita os groupBoxes

            gbDadosTerca.Enabled = true;
            gbDadosAgendamentoTerca.Enabled = true;
            gbResultadosTerca.Enabled = true;
        }

        private void dataDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //este evento bloqueia o dateTimePicker para funcionar apenas nas terças-feiras; exibe uma mensagem; limpa os txt's com o nome do aluno, 
            //matrícula, curso e professor

            if (dataDateTimePicker.Value.DayOfWeek != DayOfWeek.Tuesday)
            {
                MessageBox.Show("Atenção! Este agendamento é apenas para a terça-feira.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                nomeDoAlunoTextBox.Clear();
                matriculaTextBox.Clear();
                cursoTextBox.Clear();
                professorTextBox.Clear();
            }
        }

        //Implementa o botão pesquisar por nome e limpa a caixa de texto após a pesquisa

        private void btnPesquisaNomeTer_Click(object sender, EventArgs e)
        {           
            tercaDataGridView.DataSource = tercaTableAdapter.retornarNomeTer(txtPesquisarNomeTer.Text);

            txtPesquisarNomeTer.Clear();
        }
    }
}
