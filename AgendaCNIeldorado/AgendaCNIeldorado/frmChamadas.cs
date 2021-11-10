using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaCNIeldorado
{
    public partial class frmChamadas : Form
    {
        public frmChamadas()
        {
            InitializeComponent();
        }

        Int32 segundos, minutos, milissegundos;
        DateTime dataHora;

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //exibirá o form

            this.Show();

            //o form iniciará maximizado

            this.WindowState = FormWindowState.Normal;

            //oculta o aviso

            notifyIcon1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //data e a hora do sistema. é possivel pegar a data do servidor para evitar possiveis conflitos,
            //pois a data da maquina local, pode estar alterada e tals…
            //para buscar a data do sistema, faça uma consulta do tipo:
            //select GETDATE() mais detalhes no tópico da msdn, link abaixo…
            dataHora = DateTime.Now;
            //variavel recebe o minuto do sistema
            minutos = dataHora.Minute;
            //variavel recebe o segundo do sistema
            segundos = dataHora.Second;
            //variavel recebe o milisegundo do sistema
            milissegundos = dataHora.Millisecond;

            //Para ficar melhor ainda, e mostrar para o usuário, quantos boletos tem para vencer, faça uma consulta 
            //do tipo Count para contar quantos boletos tem para vencer dentro de 10 dias e é claro, para não ficar mostrando a mensagem 
            //toda vez que atender o critério mesmo não tendo boleto a vencer!.
            //SqlCommand cmd = new SqlCommand("Select COUNT(*) FROM Segunda Where Data = @Data", conn);
            //cmd.Parameters.Add(new SqlParameter("@Data", novadata));
            //executa a consulta
            //cmd.ExecuteNonQuery();
            //variavel recebe o resultado da consulta
           // int qtdAlunos = Convert.ToInt32(this.boletoVencerTableAdapter.ContarBoletoVencer(dataHora.Date, dataHora.AddDays(+10)));



            //verifica se tem boletos a vencer
           // if (qtdAlunos > 0)
            {
                if (minutos == 57 && segundos == 10 && milissegundos >= 600)
                //{
                    //exibe o icone
                    //notifyIcon1.Visible = true;
                    //texto a ser exibido da notificação
                    //notifyIcon1.Text = "ATENÇÃO";
                    //titulo da mensagem
                    //notifyIcon1.BalloonTipTitle = "Aluno para avaliação!";

                    //texto da mensagem
                    //if (qtdAlunos > 1)
                   // {
                        //notifyIcon1.BalloonTipText = "Possui " + qtdAlunos.ToString() + " alunos para avaliação dentro de cinco dias";
                   // }
                    else
                    {
                        //notifyIcon1.BalloonTipText = "Possui " + qtdAlunos.ToString() + " alunos para avaliação dentro de cinco dias";
                    }

                    //o tempo em que ficara sendo exibido
                    notifyIcon1.ShowBalloonTip(1000);
                //}
            }
        }

        private void avisoDeAgendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //para abrir o form

            new frmPrincipal().Show();
        }

        private void frmChamadas_Resize(object sender, EventArgs e)
        {
            //verifica se o form está minimizado

            if (this.WindowState == FormWindowState.Minimized)
            {
                //esconde o form

                this.Hide();

                //deixa o aviso visível

                notifyIcon1.Visible = true;
            }
        }        
    }
}
