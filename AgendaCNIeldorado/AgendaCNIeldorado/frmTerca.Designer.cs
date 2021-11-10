namespace AgendaCNIeldorado
{
    partial class frmTerca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeDoAlunoLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label cursoLabel;
            System.Windows.Forms.Label professorLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label operadorLabel;
            System.Windows.Forms.Label avaliacaoLabel;
            System.Windows.Forms.Label situacaoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTerca));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tercaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tercaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaCNIeldoradoDataSet = new AgendaCNIeldorado.AgendaCNIeldoradoDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesquisarNomeTer = new System.Windows.Forms.TextBox();
            this.btnPesquisaNomeTer = new System.Windows.Forms.Button();
            this.gbResultadosTerca = new System.Windows.Forms.GroupBox();
            this.reprovadoRadioButton = new System.Windows.Forms.RadioButton();
            this.aprovadoRadioButton = new System.Windows.Forms.RadioButton();
            this.situacaoTextBox = new System.Windows.Forms.TextBox();
            this.avaliacaoTextBox = new System.Windows.Forms.TextBox();
            this.gbDadosAgendamentoTerca = new System.Windows.Forms.GroupBox();
            this.operadorTextBox = new System.Windows.Forms.TextBox();
            this.horaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gbDadosTerca = new System.Windows.Forms.GroupBox();
            this.professorTextBox = new System.Windows.Forms.TextBox();
            this.cursoTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.nomeDoAlunoTextBox = new System.Windows.Forms.TextBox();
            this.tercaTableAdapter = new AgendaCNIeldorado.AgendaCNIeldoradoDataSetTableAdapters.TercaTableAdapter();
            this.tableAdapterManager = new AgendaCNIeldorado.AgendaCNIeldoradoDataSetTableAdapters.TableAdapterManager();
            this.tercaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tercaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsEditarTer = new System.Windows.Forms.ToolStripButton();
            nomeDoAlunoLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            cursoLabel = new System.Windows.Forms.Label();
            professorLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            operadorLabel = new System.Windows.Forms.Label();
            avaliacaoLabel = new System.Windows.Forms.Label();
            situacaoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tercaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tercaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaCNIeldoradoDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbResultadosTerca.SuspendLayout();
            this.gbDadosAgendamentoTerca.SuspendLayout();
            this.gbDadosTerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tercaBindingNavigator)).BeginInit();
            this.tercaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeDoAlunoLabel
            // 
            nomeDoAlunoLabel.AutoSize = true;
            nomeDoAlunoLabel.Location = new System.Drawing.Point(6, 22);
            nomeDoAlunoLabel.Name = "nomeDoAlunoLabel";
            nomeDoAlunoLabel.Size = new System.Drawing.Size(131, 19);
            nomeDoAlunoLabel.TabIndex = 0;
            nomeDoAlunoLabel.Text = "Nome do aluno:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(6, 73);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(84, 19);
            matriculaLabel.TabIndex = 2;
            matriculaLabel.Text = "Matrícula:";
            // 
            // cursoLabel
            // 
            cursoLabel.AutoSize = true;
            cursoLabel.Location = new System.Drawing.Point(134, 73);
            cursoLabel.Name = "cursoLabel";
            cursoLabel.Size = new System.Drawing.Size(62, 19);
            cursoLabel.TabIndex = 4;
            cursoLabel.Text = "Curso:";
            // 
            // professorLabel
            // 
            professorLabel.AutoSize = true;
            professorLabel.Location = new System.Drawing.Point(360, 73);
            professorLabel.Name = "professorLabel";
            professorLabel.Size = new System.Drawing.Size(90, 19);
            professorLabel.TabIndex = 6;
            professorLabel.Text = "Professor:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(6, 22);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(50, 19);
            dataLabel.TabIndex = 0;
            dataLabel.Text = "Data:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(134, 22);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(52, 19);
            horaLabel.TabIndex = 2;
            horaLabel.Text = "Hora:";
            // 
            // operadorLabel
            // 
            operadorLabel.AutoSize = true;
            operadorLabel.Location = new System.Drawing.Point(258, 22);
            operadorLabel.Name = "operadorLabel";
            operadorLabel.Size = new System.Drawing.Size(87, 19);
            operadorLabel.TabIndex = 4;
            operadorLabel.Text = "Operador:";
            // 
            // avaliacaoLabel
            // 
            avaliacaoLabel.AutoSize = true;
            avaliacaoLabel.Location = new System.Drawing.Point(6, 22);
            avaliacaoLabel.Name = "avaliacaoLabel";
            avaliacaoLabel.Size = new System.Drawing.Size(88, 19);
            avaliacaoLabel.TabIndex = 0;
            avaliacaoLabel.Text = "Avaliação:";
            // 
            // situacaoLabel
            // 
            situacaoLabel.AutoSize = true;
            situacaoLabel.Location = new System.Drawing.Point(277, 22);
            situacaoLabel.Name = "situacaoLabel";
            situacaoLabel.Size = new System.Drawing.Size(82, 19);
            situacaoLabel.TabIndex = 2;
            situacaoLabel.Text = "Situação:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.tercaDataGridView);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbResultadosTerca);
            this.panel1.Controls.Add(this.gbDadosAgendamentoTerca);
            this.panel1.Controls.Add(this.gbDadosTerca);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 767);
            this.panel1.TabIndex = 0;
            // 
            // tercaDataGridView
            // 
            this.tercaDataGridView.AllowUserToAddRows = false;
            this.tercaDataGridView.AllowUserToDeleteRows = false;
            this.tercaDataGridView.AutoGenerateColumns = false;
            this.tercaDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.tercaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tercaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tercaDataGridView.DataSource = this.tercaBindingSource;
            this.tercaDataGridView.Location = new System.Drawing.Point(12, 490);
            this.tercaDataGridView.Name = "tercaDataGridView";
            this.tercaDataGridView.ReadOnly = true;
            this.tercaDataGridView.RowHeadersVisible = false;
            this.tercaDataGridView.Size = new System.Drawing.Size(551, 249);
            this.tercaDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeDoAluno";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do aluno:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 247;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Matricula";
            this.dataGridViewTextBoxColumn3.HeaderText = "Matrícula:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Data:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Hora";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn5.HeaderText = "Hora:";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // tercaBindingSource
            // 
            this.tercaBindingSource.DataMember = "Terca";
            this.tercaBindingSource.DataSource = this.agendaCNIeldoradoDataSet;
            // 
            // agendaCNIeldoradoDataSet
            // 
            this.agendaCNIeldoradoDataSet.DataSetName = "AgendaCNIeldoradoDataSet";
            this.agendaCNIeldoradoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPesquisarNomeTer);
            this.groupBox1.Controls.Add(this.btnPesquisaNomeTer);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 82);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar ... ";
            // 
            // txtPesquisarNomeTer
            // 
            this.txtPesquisarNomeTer.Location = new System.Drawing.Point(10, 34);
            this.txtPesquisarNomeTer.Name = "txtPesquisarNomeTer";
            this.txtPesquisarNomeTer.Size = new System.Drawing.Size(395, 26);
            this.txtPesquisarNomeTer.TabIndex = 6;
            // 
            // btnPesquisaNomeTer
            // 
            this.btnPesquisaNomeTer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisaNomeTer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisaNomeTer.Image = global::AgendaCNIeldorado.Properties.Resources.buscar;
            this.btnPesquisaNomeTer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisaNomeTer.Location = new System.Drawing.Point(411, 16);
            this.btnPesquisaNomeTer.Name = "btnPesquisaNomeTer";
            this.btnPesquisaNomeTer.Size = new System.Drawing.Size(132, 60);
            this.btnPesquisaNomeTer.TabIndex = 5;
            this.btnPesquisaNomeTer.Text = "por nome";
            this.btnPesquisaNomeTer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisaNomeTer.UseVisualStyleBackColor = true;
            this.btnPesquisaNomeTer.Click += new System.EventHandler(this.btnPesquisaNomeTer_Click);
            // 
            // gbResultadosTerca
            // 
            this.gbResultadosTerca.Controls.Add(this.reprovadoRadioButton);
            this.gbResultadosTerca.Controls.Add(this.aprovadoRadioButton);
            this.gbResultadosTerca.Controls.Add(situacaoLabel);
            this.gbResultadosTerca.Controls.Add(this.situacaoTextBox);
            this.gbResultadosTerca.Controls.Add(avaliacaoLabel);
            this.gbResultadosTerca.Controls.Add(this.avaliacaoTextBox);
            this.gbResultadosTerca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultadosTerca.Location = new System.Drawing.Point(12, 237);
            this.gbResultadosTerca.Name = "gbResultadosTerca";
            this.gbResultadosTerca.Size = new System.Drawing.Size(551, 159);
            this.gbResultadosTerca.TabIndex = 1;
            this.gbResultadosTerca.TabStop = false;
            this.gbResultadosTerca.Text = "Resultados";
            // 
            // reprovadoRadioButton
            // 
            this.reprovadoRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tercaBindingSource, "Reprovado", true));
            this.reprovadoRadioButton.Location = new System.Drawing.Point(281, 131);
            this.reprovadoRadioButton.Name = "reprovadoRadioButton";
            this.reprovadoRadioButton.Size = new System.Drawing.Size(137, 24);
            this.reprovadoRadioButton.TabIndex = 6;
            this.reprovadoRadioButton.TabStop = true;
            this.reprovadoRadioButton.Text = "Reprovado (a)";
            this.reprovadoRadioButton.UseVisualStyleBackColor = true;
            // 
            // aprovadoRadioButton
            // 
            this.aprovadoRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tercaBindingSource, "Aprovado", true));
            this.aprovadoRadioButton.Location = new System.Drawing.Point(145, 131);
            this.aprovadoRadioButton.Name = "aprovadoRadioButton";
            this.aprovadoRadioButton.Size = new System.Drawing.Size(127, 24);
            this.aprovadoRadioButton.TabIndex = 5;
            this.aprovadoRadioButton.TabStop = true;
            this.aprovadoRadioButton.Text = "Aprovado (a)";
            this.aprovadoRadioButton.UseVisualStyleBackColor = true;
            // 
            // situacaoTextBox
            // 
            this.situacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tercaBindingSource, "Situacao", true));
            this.situacaoTextBox.Location = new System.Drawing.Point(281, 44);
            this.situacaoTextBox.Multiline = true;
            this.situacaoTextBox.Name = "situacaoTextBox";
            this.situacaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.situacaoTextBox.Size = new System.Drawing.Size(262, 81);
            this.situacaoTextBox.TabIndex = 3;
            // 
            // avaliacaoTextBox
            // 
            this.avaliacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tercaBindingSource, "Avaliacao", true));
            this.avaliacaoTextBox.Location = new System.Drawing.Point(10, 44);
            this.avaliacaoTextBox.Multiline = true;
            this.avaliacaoTextBox.Name = "avaliacaoTextBox";
            this.avaliacaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.avaliacaoTextBox.Size = new System.Drawing.Size(262, 81);
            this.avaliacaoTextBox.TabIndex = 1;
            // 
            // gbDadosAgendamentoTerca
            // 
            this.gbDadosAgendamentoTerca.Controls.Add(operadorLabel);
            this.gbDadosAgendamentoTerca.Controls.Add(this.operadorTextBox);
            this.gbDadosAgendamentoTerca.Controls.Add(horaLabel);
            this.gbDadosAgendamentoTerca.Controls.Add(this.horaDateTimePicker);
            this.gbDadosAgendamentoTerca.Controls.Add(dataLabel);
            this.gbDadosAgendamentoTerca.Controls.Add(this.dataDateTimePicker);
            this.gbDadosAgendamentoTerca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosAgendamentoTerca.Location = new System.Drawing.Point(12, 150);
            this.gbDadosAgendamentoTerca.Name = "gbDadosAgendamentoTerca";
            this.gbDadosAgendamentoTerca.Size = new System.Drawing.Size(551, 81);
            this.gbDadosAgendamentoTerca.TabIndex = 1;
            this.gbDadosAgendamentoTerca.TabStop = false;
            this.gbDadosAgendamentoTerca.Text = "Dados do agendamento";
            // 
            // operadorTextBox
            // 
            this.operadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tercaBindingSource, "Operador", true));
            this.operadorTextBox.Location = new System.Drawing.Point(258, 44);
            this.operadorTextBox.Name = "operadorTextBox";
            this.operadorTextBox.Size = new System.Drawing.Size(285, 26);
            this.operadorTextBox.TabIndex = 5;
            // 
            // horaDateTimePicker
            // 
            this.horaDateTimePicker.CustomFormat = "HH:mm";
            this.horaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tercaBindingSource, "Hora", true));
            this.horaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horaDateTimePicker.Location = new System.Drawing.Point(134, 44);
            this.horaDateTimePicker.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.horaDateTimePicker.Name = "horaDateTimePicker";
            this.horaDateTimePicker.ShowUpDown = true;
            this.horaDateTimePicker.Size = new System.Drawing.Size(118, 26);
            this.horaDateTimePicker.TabIndex = 3;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tercaBindingSource, "Data", true));
            this.dataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDateTimePicker.Location = new System.Drawing.Point(10, 44);
            this.dataDateTimePicker.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(118, 26);
            this.dataDateTimePicker.TabIndex = 1;
            this.dataDateTimePicker.ValueChanged += new System.EventHandler(this.dataDateTimePicker_ValueChanged);
            // 
            // gbDadosTerca
            // 
            this.gbDadosTerca.Controls.Add(professorLabel);
            this.gbDadosTerca.Controls.Add(this.professorTextBox);
            this.gbDadosTerca.Controls.Add(cursoLabel);
            this.gbDadosTerca.Controls.Add(this.cursoTextBox);
            this.gbDadosTerca.Controls.Add(matriculaLabel);
            this.gbDadosTerca.Controls.Add(this.matriculaTextBox);
            this.gbDadosTerca.Controls.Add(nomeDoAlunoLabel);
            this.gbDadosTerca.Controls.Add(this.nomeDoAlunoTextBox);
            this.gbDadosTerca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosTerca.Location = new System.Drawing.Point(12, 12);
            this.gbDadosTerca.Name = "gbDadosTerca";
            this.gbDadosTerca.Size = new System.Drawing.Size(551, 132);
            this.gbDadosTerca.TabIndex = 0;
            this.gbDadosTerca.TabStop = false;
            this.gbDadosTerca.Text = "Dados do aluno";
            // 
            // professorTextBox
            // 
            this.professorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tercaBindingSource, "Professor", true));
            this.professorTextBox.Location = new System.Drawing.Point(360, 95);
            this.professorTextBox.Name = "professorTextBox";
            this.professorTextBox.Size = new System.Drawing.Size(183, 26);
            this.professorTextBox.TabIndex = 7;
            // 
            // cursoTextBox
            // 
            this.cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tercaBindingSource, "Curso", true));
            this.cursoTextBox.Location = new System.Drawing.Point(134, 95);
            this.cursoTextBox.Name = "cursoTextBox";
            this.cursoTextBox.Size = new System.Drawing.Size(220, 26);
            this.cursoTextBox.TabIndex = 5;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tercaBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(10, 95);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(118, 26);
            this.matriculaTextBox.TabIndex = 3;
            // 
            // nomeDoAlunoTextBox
            // 
            this.nomeDoAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tercaBindingSource, "NomeDoAluno", true));
            this.nomeDoAlunoTextBox.Location = new System.Drawing.Point(10, 44);
            this.nomeDoAlunoTextBox.Name = "nomeDoAlunoTextBox";
            this.nomeDoAlunoTextBox.Size = new System.Drawing.Size(533, 26);
            this.nomeDoAlunoTextBox.TabIndex = 1;
            // 
            // tercaTableAdapter
            // 
            this.tercaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QuartaTableAdapter = null;
            this.tableAdapterManager.QuintaTableAdapter = null;
            this.tableAdapterManager.SabadoTableAdapter = null;
            this.tableAdapterManager.SegundaTableAdapter = null;
            this.tableAdapterManager.SextaTableAdapter = null;
            this.tableAdapterManager.TercaTableAdapter = this.tercaTableAdapter;
            this.tableAdapterManager.UpdateOrder = AgendaCNIeldorado.AgendaCNIeldoradoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tercaBindingNavigator
            // 
            this.tercaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tercaBindingNavigator.BindingSource = this.tercaBindingSource;
            this.tercaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tercaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tercaBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tercaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tercaBindingNavigatorSaveItem,
            this.tsEditarTer});
            this.tercaBindingNavigator.Location = new System.Drawing.Point(0, 742);
            this.tercaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tercaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tercaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tercaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tercaBindingNavigator.Name = "tercaBindingNavigator";
            this.tercaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tercaBindingNavigator.Size = new System.Drawing.Size(576, 25);
            this.tercaBindingNavigator.TabIndex = 1;
            this.tercaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tercaBindingNavigatorSaveItem
            // 
            this.tercaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tercaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tercaBindingNavigatorSaveItem.Image")));
            this.tercaBindingNavigatorSaveItem.Name = "tercaBindingNavigatorSaveItem";
            this.tercaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tercaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tercaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tercaBindingNavigatorSaveItem_Click);
            // 
            // tsEditarTer
            // 
            this.tsEditarTer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEditarTer.Image = global::AgendaCNIeldorado.Properties.Resources.editar;
            this.tsEditarTer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditarTer.Name = "tsEditarTer";
            this.tsEditarTer.Size = new System.Drawing.Size(23, 22);
            this.tsEditarTer.Text = "Editar";
            this.tsEditarTer.Click += new System.EventHandler(this.tsEditarTer_Click);
            // 
            // frmTerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(576, 767);
            this.Controls.Add(this.tercaBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTerca";
            this.Text = "Agendamento para terça-feira";
            this.Load += new System.EventHandler(this.frmTerca_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tercaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tercaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaCNIeldoradoDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbResultadosTerca.ResumeLayout(false);
            this.gbResultadosTerca.PerformLayout();
            this.gbDadosAgendamentoTerca.ResumeLayout(false);
            this.gbDadosAgendamentoTerca.PerformLayout();
            this.gbDadosTerca.ResumeLayout(false);
            this.gbDadosTerca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tercaBindingNavigator)).EndInit();
            this.tercaBindingNavigator.ResumeLayout(false);
            this.tercaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbResultadosTerca;
        private System.Windows.Forms.GroupBox gbDadosAgendamentoTerca;
        private System.Windows.Forms.GroupBox gbDadosTerca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisarNomeTer;
        private System.Windows.Forms.Button btnPesquisaNomeTer;
        private AgendaCNIeldoradoDataSet agendaCNIeldoradoDataSet;
        private System.Windows.Forms.BindingSource tercaBindingSource;
        private AgendaCNIeldoradoDataSetTableAdapters.TercaTableAdapter tercaTableAdapter;
        private AgendaCNIeldoradoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tercaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tercaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tercaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox nomeDoAlunoTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox cursoTextBox;
        private System.Windows.Forms.TextBox professorTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.DateTimePicker horaDateTimePicker;
        private System.Windows.Forms.TextBox operadorTextBox;
        private System.Windows.Forms.TextBox avaliacaoTextBox;
        private System.Windows.Forms.RadioButton reprovadoRadioButton;
        private System.Windows.Forms.RadioButton aprovadoRadioButton;
        private System.Windows.Forms.TextBox situacaoTextBox;
        private System.Windows.Forms.ToolStripButton tsEditarTer;
    }
}