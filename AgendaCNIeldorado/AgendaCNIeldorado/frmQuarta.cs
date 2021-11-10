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
    public partial class frmQuarta : Form
    {
        public frmQuarta()
        {
            InitializeComponent();

            //inicializa com os groupBoxes bloqueados

            gbDadosAlunoQuarta.Enabled = false;
            gbDadosAgendamentoQuarta.Enabled = false;
            gbResultadosQuarta.Enabled = false;
        }

        private void quartaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //implementa o botão salvar, bloqueia os groupBoxes, atualiza o DGW

            MessageBox.Show("Agendamento salvo com sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Validate();
            this.quartaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaCNIeldoradoDataSet);

            gbDadosAlunoQuarta.Enabled = false;
            gbDadosAgendamentoQuarta.Enabled = false;
            gbResultadosQuarta.Enabled = false;

            quartaDataGridView.Refresh();
        }

        private void frmQuarta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'agendaCNIeldoradoDataSet.Quarta'. Você pode movê-la ou removê-la conforme necessário.
            this.quartaTableAdapter.Fill(this.agendaCNIeldoradoDataSet.Quarta);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //habilita os groupBoxes

            gbDadosAlunoQuarta.Enabled = true;
            gbDadosAgendamentoQuarta.Enabled = true;
            gbResultadosQuarta.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //implementa o botão excluir, bloqueia os groupBoxes, atualiza o DGW

            MessageBox.Show("Agendamento excluído com sucesso!", "Exclusão!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Validate();
            this.quartaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaCNIeldoradoDataSet);

            gbDadosAlunoQuarta.Enabled = false;
            gbDadosAgendamentoQuarta.Enabled = false;
            gbResultadosQuarta.Enabled = false;

            quartaDataGridView.Refresh();
        }

        private void tsEditarQuarta_Click(object sender, EventArgs e)
        {
            //habilita os groupBoxes

            gbDadosAlunoQuarta.Enabled = true;
            gbDadosAgendamentoQuarta.Enabled = true;
            gbResultadosQuarta.Enabled = true;
        }

        private void dataDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //este evento bloqueia o dateTimePicker para funcionar apenas nas quartas-feiras; exibe uma mensagem; limpa os txt's com o nome do aluno, 
            //matrícula, curso e professor

            if (dataDateTimePicker.Value.DayOfWeek != DayOfWeek.Wednesday)
            {
                MessageBox.Show("Atenção! Este agendamento é apenas para a quarta-feira.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                nomeDoAlunoTextBox.Clear();
                matriculaTextBox.Clear();
                cursoTextBox.Clear();
                professorTextBox.Clear();
            }
        }

        //Implementa o botão pesquisar por nome e limpa a caixa de texto após a pesquisa

        private void btnPesquisaNomeQuarta_Click(object sender, EventArgs e)
        {           
            quartaDataGridView.DataSource = quartaTableAdapter.retornarNomeQuar(txtPesquisarNomeQuar.Text);

            txtPesquisarNomeQuar.Clear();
        }
    }
}
