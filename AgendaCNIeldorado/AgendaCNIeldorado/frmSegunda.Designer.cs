namespace AgendaCNIeldorado
{
    partial class frmSegunda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSegunda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesquisarNomeSeg = new System.Windows.Forms.TextBox();
            this.btnPesquisaNomeSeg = new System.Windows.Forms.Button();
            this.segundaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaCNIeldoradoDataSet = new AgendaCNIeldorado.AgendaCNIeldoradoDataSet();
            this.gbResultadosSeg = new System.Windows.Forms.GroupBox();
            this.reprovadoRadioButton = new System.Windows.Forms.RadioButton();
            this.aprovadoRadioButton = new System.Windows.Forms.RadioButton();
            this.situacaoTextBox = new System.Windows.Forms.TextBox();
            this.avaliacaoTextBox = new System.Windows.Forms.TextBox();
            this.gbDadosAgendamentoSeg = new System.Windows.Forms.GroupBox();
            this.operadorTextBox = new System.Windows.Forms.TextBox();
            this.horaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gbDadosAlunoSeg = new System.Windows.Forms.GroupBox();
            this.professorTextBox = new System.Windows.Forms.TextBox();
            this.cursoTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.nomeDoAlunoTextBox = new System.Windows.Forms.TextBox();
            this.segundaTableAdapter = new AgendaCNIeldorado.AgendaCNIeldoradoDataSetTableAdapters.SegundaTableAdapter();
            this.tableAdapterManager = new AgendaCNIeldorado.AgendaCNIeldoradoDataSetTableAdapters.TableAdapterManager();
            this.segundaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.segundaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsEditarSeg = new System.Windows.Forms.ToolStripButton();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.segundaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segundaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaCNIeldoradoDataSet)).BeginInit();
            this.gbResultadosSeg.SuspendLayout();
            this.gbDadosAgendamentoSeg.SuspendLayout();
            this.gbDadosAlunoSeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.segundaBindingNavigator)).BeginInit();
            this.segundaBindingNavigator.SuspendLayout();
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
            matriculaLabel.Location = new System.Drawing.Point(6, 72);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(84, 19);
            matriculaLabel.TabIndex = 2;
            matriculaLabel.Text = "Matrícula:";
            // 
            // cursoLabel
            // 
            cursoLabel.AutoSize = true;
            cursoLabel.Location = new System.Drawing.Point(130, 72);
            cursoLabel.Name = "cursoLabel";
            cursoLabel.Size = new System.Drawing.Size(62, 19);
            cursoLabel.TabIndex = 4;
            cursoLabel.Text = "Curso:";
            // 
            // professorLabel
            // 
            professorLabel.AutoSize = true;
            professorLabel.Location = new System.Drawing.Point(356, 72);
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
            horaLabel.Location = new System.Drawing.Point(130, 22);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(52, 19);
            horaLabel.TabIndex = 2;
            horaLabel.Text = "Hora:";
            // 
            // operadorLabel
            // 
            operadorLabel.AutoSize = true;
            operadorLabel.Location = new System.Drawing.Point(257, 22);
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
            situacaoLabel.Location = new System.Drawing.Point(278, 22);
            situacaoLabel.Name = "situacaoLabel";
            situacaoLabel.Size = new System.Drawing.Size(82, 19);
            situacaoLabel.TabIndex = 3;
            situacaoLabel.Text = "Situação:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.segundaDataGridView);
            this.panel1.Controls.Add(this.gbResultadosSeg);
            this.panel1.Controls.Add(this.gbDadosAgendamentoSeg);
            this.panel1.Controls.Add(this.gbDadosAlunoSeg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 767);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPesquisarNomeSeg);
            this.groupBox1.Controls.Add(this.btnPesquisaNomeSeg);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar ... ";
            // 
            // txtPesquisarNomeSeg
            // 
            this.txtPesquisarNomeSeg.Location = new System.Drawing.Point(10, 34);
            this.txtPesquisarNomeSeg.Name = "txtPesquisarNomeSeg";
            this.txtPesquisarNomeSeg.Size = new System.Drawing.Size(395, 26);
            this.txtPesquisarNomeSeg.TabIndex = 6;
            // 
            // btnPesquisaNomeSeg
            // 
            this.btnPesquisaNomeSeg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisaNomeSeg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisaNomeSeg.Image = global::AgendaCNIeldorado.Properties.Resources.buscar;
            this.btnPesquisaNomeSeg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisaNomeSeg.Location = new System.Drawing.Point(411, 16);
            this.btnPesquisaNomeSeg.Name = "btnPesquisaNomeSeg";
            this.btnPesquisaNomeSeg.Size = new System.Drawing.Size(132, 60);
            this.btnPesquisaNomeSeg.TabIndex = 5;
            this.btnPesquisaNomeSeg.Text = "por nome";
            this.btnPesquisaNomeSeg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisaNomeSeg.UseVisualStyleBackColor = true;
            this.btnPesquisaNomeSeg.Click += new System.EventHandler(this.btnPesquisaNomeSeg_Click);
            // 
            // segundaDataGridView
            // 
            this.segundaDataGridView.AllowUserToAddRows = false;
            this.segundaDataGridView.AllowUserToDeleteRows = false;
            this.segundaDataGridView.AutoGenerateColumns = false;
            this.segundaDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.segundaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.segundaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.segundaDataGridView.DataSource = this.segundaBindingSource;
            this.segundaDataGridView.Location = new System.Drawing.Point(12, 490);
            this.segundaDataGridView.Name = "segundaDataGridView";
            this.segundaDataGridView.ReadOnly = true;
            this.segundaDataGridView.RowHeadersVisible = false;
            this.segundaDataGridView.Size = new System.Drawing.Size(551, 249);
            this.segundaDataGridView.TabIndex = 3;
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
            // segundaBindingSource
            // 
            this.segundaBindingSource.DataMember = "Segunda";
            this.segundaBindingSource.DataSource = this.agendaCNIeldoradoDataSet;
            // 
            // agendaCNIeldoradoDataSet
            // 
            this.agendaCNIeldoradoDataSet.DataSetName = "AgendaCNIeldoradoDataSet";
            this.agendaCNIeldoradoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbResultadosSeg
            // 
            this.gbResultadosSeg.Controls.Add(this.reprovadoRadioButton);
            this.gbResultadosSeg.Controls.Add(this.aprovadoRadioButton);
            this.gbResultadosSeg.Controls.Add(this.situacaoTextBox);
            this.gbResultadosSeg.Controls.Add(situacaoLabel);
            this.gbResultadosSeg.Controls.Add(avaliacaoLabel);
            this.gbResultadosSeg.Controls.Add(this.avaliacaoTextBox);
            this.gbResultadosSeg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultadosSeg.Location = new System.Drawing.Point(12, 237);
            this.gbResultadosSeg.Name = "gbResultadosSeg";
            this.gbResultadosSeg.Size = new System.Drawing.Size(551, 159);
            this.gbResultadosSeg.TabIndex = 2;
            this.gbResultadosSeg.TabStop = false;
            this.gbResultadosSeg.Text = "Resultados";
            // 
            // reprovadoRadioButton
            // 
            this.reprovadoRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.segundaBindingSource, "Reprovado", true));
            this.reprovadoRadioButton.Location = new System.Drawing.Point(281, 130);
            this.reprovadoRadioButton.Name = "reprovadoRadioButton";
            this.reprovadoRadioButton.Size = new System.Drawing.Size(136, 24);
            this.reprovadoRadioButton.TabIndex = 6;
            this.reprovadoRadioButton.TabStop = true;
            this.reprovadoRadioButton.Text = "Reprovado (a)";
            this.reprovadoRadioButton.UseVisualStyleBackColor = true;
            // 
            // aprovadoRadioButton
            // 
            this.aprovadoRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.segundaBindingSource, "Aprovado", true));
            this.aprovadoRadioButton.Location = new System.Drawing.Point(144, 130);
            this.aprovadoRadioButton.Name = "aprovadoRadioButton";
            this.aprovadoRadioButton.Size = new System.Drawing.Size(127, 24);
            this.aprovadoRadioButton.TabIndex = 5;
            this.aprovadoRadioButton.TabStop = true;
            this.aprovadoRadioButton.Text = "Aprovado (a)";
            this.aprovadoRadioButton.UseVisualStyleBackColor = true;
            // 
            // situacaoTextBox
            // 
            this.situacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.segundaBindingSource, "Situacao", true));
            this.situacaoTextBox.Location = new System.Drawing.Point(281, 43);
            this.situacaoTextBox.Multiline = true;
            this.situacaoTextBox.Name = "situacaoTextBox";
            this.situacaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.situacaoTextBox.Size = new System.Drawing.Size(262, 81);
            this.situacaoTextBox.TabIndex = 4;
            // 
            // avaliacaoTextBox
            // 
            this.avaliacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.segundaBindingSource, "Avaliacao", true));
            this.avaliacaoTextBox.Location = new System.Drawing.Point(9, 43);
            this.avaliacaoTextBox.Multiline = true;
            this.avaliacaoTextBox.Name = "avaliacaoTextBox";
            this.avaliacaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.avaliacaoTextBox.Size = new System.Drawing.Size(262, 81);
            this.avaliacaoTextBox.TabIndex = 1;
            // 
            // gbDadosAgendamentoSeg
            // 
            this.gbDadosAgendamentoSeg.Controls.Add(operadorLabel);
            this.gbDadosAgendamentoSeg.Controls.Add(this.operadorTextBox);
            this.gbDadosAgendamentoSeg.Controls.Add(horaLabel);
            this.gbDadosAgendamentoSeg.Controls.Add(this.horaDateTimePicker);
            this.gbDadosAgendamentoSeg.Controls.Add(dataLabel);
            this.gbDadosAgendamentoSeg.Controls.Add(this.dataDateTimePicker);
            this.gbDadosAgendamentoSeg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosAgendamentoSeg.Location = new System.Drawing.Point(12, 150);
            this.gbDadosAgendamentoSeg.Name = "gbDadosAgendamentoSeg";
            this.gbDadosAgendamentoSeg.Size = new System.Drawing.Size(551, 81);
            this.gbDadosAgendamentoSeg.TabIndex = 1;
            this.gbDadosAgendamentoSeg.TabStop = false;
            this.gbDadosAgendamentoSeg.Text = "Dados do agendamento";
            // 
            // operadorTextBox
            // 
            this.operadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.segundaBindingSource, "Operador", true));
            this.operadorTextBox.Location = new System.Drawing.Point(257, 43);
            this.operadorTextBox.Name = "operadorTextBox";
            this.operadorTextBox.Size = new System.Drawing.Size(286, 26);
            this.operadorTextBox.TabIndex = 5;
            // 
            // horaDateTimePicker
            // 
            this.horaDateTimePicker.CustomFormat = "HH:mm";
            this.horaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.segundaBindingSource, "Hora", true));
            this.horaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horaDateTimePicker.Location = new System.Drawing.Point(133, 43);
            this.horaDateTimePicker.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.horaDateTimePicker.Name = "horaDateTimePicker";
            this.horaDateTimePicker.ShowUpDown = true;
            this.horaDateTimePicker.Size = new System.Drawing.Size(118, 26);
            this.horaDateTimePicker.TabIndex = 3;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.segundaBindingSource, "Data", true));
            this.dataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDateTimePicker.Location = new System.Drawing.Point(9, 43);
            this.dataDateTimePicker.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(118, 26);
            this.dataDateTimePicker.TabIndex = 1;
            this.dataDateTimePicker.ValueChanged += new System.EventHandler(this.dataDateTimePicker_ValueChanged);
            // 
            // gbDadosAlunoSeg
            // 
            this.gbDadosAlunoSeg.Controls.Add(professorLabel);
            this.gbDadosAlunoSeg.Controls.Add(this.professorTextBox);
            this.gbDadosAlunoSeg.Controls.Add(cursoLabel);
            this.gbDadosAlunoSeg.Controls.Add(this.cursoTextBox);
            this.gbDadosAlunoSeg.Controls.Add(matriculaLabel);
            this.gbDadosAlunoSeg.Controls.Add(this.matriculaTextBox);
            this.gbDadosAlunoSeg.Controls.Add(nomeDoAlunoLabel);
            this.gbDadosAlunoSeg.Controls.Add(this.nomeDoAlunoTextBox);
            this.gbDadosAlunoSeg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosAlunoSeg.Location = new System.Drawing.Point(12, 12);
            this.gbDadosAlunoSeg.Name = "gbDadosAlunoSeg";
            this.gbDadosAlunoSeg.Size = new System.Drawing.Size(551, 132);
            this.gbDadosAlunoSeg.TabIndex = 0;
            this.gbDadosAlunoSeg.TabStop = false;
            this.gbDadosAlunoSeg.Text = "Dados do aluno";
            // 
            // professorTextBox
            // 
            this.professorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.segundaBindingSource, "Professor", true));
            this.professorTextBox.Location = new System.Drawing.Point(359, 93);
            this.professorTextBox.Name = "professorTextBox";
            this.professorTextBox.Size = new System.Drawing.Size(184, 26);
            this.professorTextBox.TabIndex = 7;
            // 
            // cursoTextBox
            // 
            this.cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.segundaBindingSource, "Curso", true));
            this.cursoTextBox.Location = new System.Drawing.Point(133, 93);
            this.cursoTextBox.Name = "cursoTextBox";
            this.cursoTextBox.Size = new System.Drawing.Size(220, 26);
            this.cursoTextBox.TabIndex = 5;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.segundaBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(9, 93);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(118, 26);
            this.matriculaTextBox.TabIndex = 3;
            // 
            // nomeDoAlunoTextBox
            // 
            this.nomeDoAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.segundaBindingSource, "NomeDoAluno", true));
            this.nomeDoAlunoTextBox.Location = new System.Drawing.Point(9, 43);
            this.nomeDoAlunoTextBox.Name = "nomeDoAlunoTextBox";
            this.nomeDoAlunoTextBox.Size = new System.Drawing.Size(534, 26);
            this.nomeDoAlunoTextBox.TabIndex = 1;
            // 
            // segundaTableAdapter
            // 
            this.segundaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QuartaTableAdapter = null;
            this.tableAdapterManager.QuintaTableAdapter = null;
            this.tableAdapterManager.SabadoTableAdapter = null;
            this.tableAdapterManager.SegundaTableAdapter = this.segundaTableAdapter;
            this.tableAdapterManager.SextaTableAdapter = null;
            this.tableAdapterManager.TercaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AgendaCNIeldorado.AgendaCNIeldoradoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // segundaBindingNavigator
            // 
            this.segundaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.segundaBindingNavigator.BindingSource = this.segundaBindingSource;
            this.segundaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.segundaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.segundaBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.segundaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.segundaBindingNavigatorSaveItem,
            this.tsEditarSeg});
            this.segundaBindingNavigator.Location = new System.Drawing.Point(0, 742);
            this.segundaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.segundaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.segundaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.segundaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.segundaBindingNavigator.Name = "segundaBindingNavigator";
            this.segundaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.segundaBindingNavigator.Size = new System.Drawing.Size(576, 25);
            this.segundaBindingNavigator.TabIndex = 1;
            this.segundaBindingNavigator.Text = "bindingNavigator1";
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
            // segundaBindingNavigatorSaveItem
            // 
            this.segundaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.segundaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("segundaBindingNavigatorSaveItem.Image")));
            this.segundaBindingNavigatorSaveItem.Name = "segundaBindingNavigatorSaveItem";
            this.segundaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.segundaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.segundaBindingNavigatorSaveItem.Click += new System.EventHandler(this.segundaBindingNavigatorSaveItem_Click);
            // 
            // tsEditarSeg
            // 
            this.tsEditarSeg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEditarSeg.Image = ((System.Drawing.Image)(resources.GetObject("tsEditarSeg.Image")));
            this.tsEditarSeg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditarSeg.Name = "tsEditarSeg";
            this.tsEditarSeg.Size = new System.Drawing.Size(23, 22);
            this.tsEditarSeg.Text = "Editar";
            this.tsEditarSeg.Click += new System.EventHandler(this.tsEditarSeg_Click);
            // 
            // frmSegunda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(576, 767);
            this.Controls.Add(this.segundaBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSegunda";
            this.Text = "Agendamento para segunda-feira";
            this.Load += new System.EventHandler(this.frmSegunda_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.segundaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segundaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaCNIeldoradoDataSet)).EndInit();
            this.gbResultadosSeg.ResumeLayout(false);
            this.gbResultadosSeg.PerformLayout();
            this.gbDadosAgendamentoSeg.ResumeLayout(false);
            this.gbDadosAgendamentoSeg.PerformLayout();
            this.gbDadosAlunoSeg.ResumeLayout(false);
            this.gbDadosAlunoSeg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.segundaBindingNavigator)).EndInit();
            this.segundaBindingNavigator.ResumeLayout(false);
            this.segundaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDadosAlunoSeg;
        private AgendaCNIeldoradoDataSet agendaCNIeldoradoDataSet;
        private System.Windows.Forms.BindingSource segundaBindingSource;
        private AgendaCNIeldoradoDataSetTableAdapters.SegundaTableAdapter segundaTableAdapter;
        private AgendaCNIeldoradoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator segundaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton segundaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView segundaDataGridView;
        private System.Windows.Forms.GroupBox gbResultadosSeg;
        private System.Windows.Forms.TextBox situacaoTextBox;
        private System.Windows.Forms.TextBox avaliacaoTextBox;
        private System.Windows.Forms.GroupBox gbDadosAgendamentoSeg;
        private System.Windows.Forms.TextBox operadorTextBox;
        private System.Windows.Forms.DateTimePicker horaDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox professorTextBox;
        private System.Windows.Forms.TextBox cursoTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox nomeDoAlunoTextBox;
        private System.Windows.Forms.ToolStripButton tsEditarSeg;
        private System.Windows.Forms.RadioButton reprovadoRadioButton;
        private System.Windows.Forms.RadioButton aprovadoRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisarNomeSeg;
        private System.Windows.Forms.Button btnPesquisaNomeSeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}