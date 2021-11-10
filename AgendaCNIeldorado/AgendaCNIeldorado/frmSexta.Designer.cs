namespace AgendaCNIeldorado
{
    partial class frmSexta
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
            System.Windows.Forms.Label situacaoLabel;
            System.Windows.Forms.Label avaliacaoLabel;
            System.Windows.Forms.Label operadorLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label professorLabel;
            System.Windows.Forms.Label cursoLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label nomeDoAlunoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSexta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesquisarNomeSex = new System.Windows.Forms.TextBox();
            this.btnPesquisaNomeSex = new System.Windows.Forms.Button();
            this.gbResultadosSeg = new System.Windows.Forms.GroupBox();
            this.reprovadoRadioButton = new System.Windows.Forms.RadioButton();
            this.sextaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaCNIeldoradoDataSet = new AgendaCNIeldorado.AgendaCNIeldoradoDataSet();
            this.aprovadoRadioButton = new System.Windows.Forms.RadioButton();
            this.avaliacaoTextBox = new System.Windows.Forms.TextBox();
            this.situacaoTextBox = new System.Windows.Forms.TextBox();
            this.gbDadosAgendamentoSeg = new System.Windows.Forms.GroupBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.operadorTextBox = new System.Windows.Forms.TextBox();
            this.gbDadosAlunoSeg = new System.Windows.Forms.GroupBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.cursoTextBox = new System.Windows.Forms.TextBox();
            this.professorTextBox = new System.Windows.Forms.TextBox();
            this.nomeDoAlunoTextBox = new System.Windows.Forms.TextBox();
            this.sextaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sextaTableAdapter = new AgendaCNIeldorado.AgendaCNIeldoradoDataSetTableAdapters.SextaTableAdapter();
            this.tableAdapterManager = new AgendaCNIeldorado.AgendaCNIeldoradoDataSetTableAdapters.TableAdapterManager();
            this.sextaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sextaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsEditarSex = new System.Windows.Forms.ToolStripButton();
            situacaoLabel = new System.Windows.Forms.Label();
            avaliacaoLabel = new System.Windows.Forms.Label();
            operadorLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            professorLabel = new System.Windows.Forms.Label();
            cursoLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            nomeDoAlunoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbResultadosSeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sextaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaCNIeldoradoDataSet)).BeginInit();
            this.gbDadosAgendamentoSeg.SuspendLayout();
            this.gbDadosAlunoSeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sextaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sextaBindingNavigator)).BeginInit();
            this.sextaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            // avaliacaoLabel
            // 
            avaliacaoLabel.AutoSize = true;
            avaliacaoLabel.Location = new System.Drawing.Point(6, 22);
            avaliacaoLabel.Name = "avaliacaoLabel";
            avaliacaoLabel.Size = new System.Drawing.Size(88, 19);
            avaliacaoLabel.TabIndex = 0;
            avaliacaoLabel.Text = "Avaliação:";
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
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(130, 22);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(52, 19);
            horaLabel.TabIndex = 2;
            horaLabel.Text = "Hora:";
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
            // professorLabel
            // 
            professorLabel.AutoSize = true;
            professorLabel.Location = new System.Drawing.Point(356, 72);
            professorLabel.Name = "professorLabel";
            professorLabel.Size = new System.Drawing.Size(90, 19);
            professorLabel.TabIndex = 6;
            professorLabel.Text = "Professor:";
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
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(6, 72);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(84, 19);
            matriculaLabel.TabIndex = 2;
            matriculaLabel.Text = "Matrícula:";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbResultadosSeg);
            this.panel1.Controls.Add(this.gbDadosAgendamentoSeg);
            this.panel1.Controls.Add(this.gbDadosAlunoSeg);
            this.panel1.Controls.Add(this.sextaDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 767);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPesquisarNomeSex);
            this.groupBox1.Controls.Add(this.btnPesquisaNomeSex);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 82);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar ... ";
            // 
            // txtPesquisarNomeSex
            // 
            this.txtPesquisarNomeSex.Location = new System.Drawing.Point(10, 34);
            this.txtPesquisarNomeSex.Name = "txtPesquisarNomeSex";
            this.txtPesquisarNomeSex.Size = new System.Drawing.Size(395, 26);
            this.txtPesquisarNomeSex.TabIndex = 6;
            // 
            // btnPesquisaNomeSex
            // 
            this.btnPesquisaNomeSex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisaNomeSex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisaNomeSex.Image = global::AgendaCNIeldorado.Properties.Resources.buscar;
            this.btnPesquisaNomeSex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisaNomeSex.Location = new System.Drawing.Point(411, 16);
            this.btnPesquisaNomeSex.Name = "btnPesquisaNomeSex";
            this.btnPesquisaNomeSex.Size = new System.Drawing.Size(132, 60);
            this.btnPesquisaNomeSex.TabIndex = 5;
            this.btnPesquisaNomeSex.Text = "por nome";
            this.btnPesquisaNomeSex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisaNomeSex.UseVisualStyleBackColor = true;
            this.btnPesquisaNomeSex.Click += new System.EventHandler(this.btnPesquisaNomeSex_Click);
            // 
            // gbResultadosSeg
            // 
            this.gbResultadosSeg.Controls.Add(this.reprovadoRadioButton);
            this.gbResultadosSeg.Controls.Add(this.aprovadoRadioButton);
            this.gbResultadosSeg.Controls.Add(this.avaliacaoTextBox);
            this.gbResultadosSeg.Controls.Add(this.situacaoTextBox);
            this.gbResultadosSeg.Controls.Add(situacaoLabel);
            this.gbResultadosSeg.Controls.Add(avaliacaoLabel);
            this.gbResultadosSeg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultadosSeg.Location = new System.Drawing.Point(13, 237);
            this.gbResultadosSeg.Name = "gbResultadosSeg";
            this.gbResultadosSeg.Size = new System.Drawing.Size(551, 159);
            this.gbResultadosSeg.TabIndex = 7;
            this.gbResultadosSeg.TabStop = false;
            this.gbResultadosSeg.Text = "Resultados";
            // 
            // reprovadoRadioButton
            // 
            this.reprovadoRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.sextaBindingSource, "Reprovado", true));
            this.reprovadoRadioButton.Location = new System.Drawing.Point(282, 131);
            this.reprovadoRadioButton.Name = "reprovadoRadioButton";
            this.reprovadoRadioButton.Size = new System.Drawing.Size(136, 24);
            this.reprovadoRadioButton.TabIndex = 7;
            this.reprovadoRadioButton.TabStop = true;
            this.reprovadoRadioButton.Text = "Reprovado (a)";
            this.reprovadoRadioButton.UseVisualStyleBackColor = true;
            // 
            // sextaBindingSource
            // 
            this.sextaBindingSource.DataMember = "Sexta";
            this.sextaBindingSource.DataSource = this.agendaCNIeldoradoDataSet;
            // 
            // agendaCNIeldoradoDataSet
            // 
            this.agendaCNIeldoradoDataSet.DataSetName = "AgendaCNIeldoradoDataSet";
            this.agendaCNIeldoradoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aprovadoRadioButton
            // 
            this.aprovadoRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.sextaBindingSource, "Aprovado", true));
            this.aprovadoRadioButton.Location = new System.Drawing.Point(145, 131);
            this.aprovadoRadioButton.Name = "aprovadoRadioButton";
            this.aprovadoRadioButton.Size = new System.Drawing.Size(127, 24);
            this.aprovadoRadioButton.TabIndex = 6;
            this.aprovadoRadioButton.TabStop = true;
            this.aprovadoRadioButton.Text = "Aprovado (a)";
            this.aprovadoRadioButton.UseVisualStyleBackColor = true;
            // 
            // avaliacaoTextBox
            // 
            this.avaliacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sextaBindingSource, "Avaliacao", true));
            this.avaliacaoTextBox.Location = new System.Drawing.Point(10, 44);
            this.avaliacaoTextBox.Multiline = true;
            this.avaliacaoTextBox.Name = "avaliacaoTextBox";
            this.avaliacaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.avaliacaoTextBox.Size = new System.Drawing.Size(262, 81);
            this.avaliacaoTextBox.TabIndex = 5;
            // 
            // situacaoTextBox
            // 
            this.situacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sextaBindingSource, "Situacao", true));
            this.situacaoTextBox.Location = new System.Drawing.Point(282, 44);
            this.situacaoTextBox.Multiline = true;
            this.situacaoTextBox.Name = "situacaoTextBox";
            this.situacaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.situacaoTextBox.Size = new System.Drawing.Size(262, 81);
            this.situacaoTextBox.TabIndex = 4;
            // 
            // gbDadosAgendamentoSeg
            // 
            this.gbDadosAgendamentoSeg.Controls.Add(this.dataDateTimePicker);
            this.gbDadosAgendamentoSeg.Controls.Add(this.horaDateTimePicker);
            this.gbDadosAgendamentoSeg.Controls.Add(this.operadorTextBox);
            this.gbDadosAgendamentoSeg.Controls.Add(operadorLabel);
            this.gbDadosAgendamentoSeg.Controls.Add(horaLabel);
            this.gbDadosAgendamentoSeg.Controls.Add(dataLabel);
            this.gbDadosAgendamentoSeg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosAgendamentoSeg.Location = new System.Drawing.Point(13, 150);
            this.gbDadosAgendamentoSeg.Name = "gbDadosAgendamentoSeg";
            this.gbDadosAgendamentoSeg.Size = new System.Drawing.Size(551, 81);
            this.gbDadosAgendamentoSeg.TabIndex = 6;
            this.gbDadosAgendamentoSeg.TabStop = false;
            this.gbDadosAgendamentoSeg.Text = "Dados do agendamento";
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sextaBindingSource, "Data", true));
            this.dataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDateTimePicker.Location = new System.Drawing.Point(10, 44);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(118, 26);
            this.dataDateTimePicker.TabIndex = 7;
            this.dataDateTimePicker.ValueChanged += new System.EventHandler(this.dataDateTimePicker_ValueChanged);
            // 
            // horaDateTimePicker
            // 
            this.horaDateTimePicker.CustomFormat = "HH:mm";
            this.horaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sextaBindingSource, "Hora", true));
            this.horaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horaDateTimePicker.Location = new System.Drawing.Point(134, 44);
            this.horaDateTimePicker.Name = "horaDateTimePicker";
            this.horaDateTimePicker.ShowUpDown = true;
            this.horaDateTimePicker.Size = new System.Drawing.Size(120, 26);
            this.horaDateTimePicker.TabIndex = 6;
            // 
            // operadorTextBox
            // 
            this.operadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sextaBindingSource, "Operador", true));
            this.operadorTextBox.Location = new System.Drawing.Point(260, 44);
            this.operadorTextBox.Name = "operadorTextBox";
            this.operadorTextBox.Size = new System.Drawing.Size(283, 26);
            this.operadorTextBox.TabIndex = 5;
            // 
            // gbDadosAlunoSeg
            // 
            this.gbDadosAlunoSeg.Controls.Add(this.matriculaTextBox);
            this.gbDadosAlunoSeg.Controls.Add(this.cursoTextBox);
            this.gbDadosAlunoSeg.Controls.Add(this.professorTextBox);
            this.gbDadosAlunoSeg.Controls.Add(this.nomeDoAlunoTextBox);
            this.gbDadosAlunoSeg.Controls.Add(professorLabel);
            this.gbDadosAlunoSeg.Controls.Add(cursoLabel);
            this.gbDadosAlunoSeg.Controls.Add(matriculaLabel);
            this.gbDadosAlunoSeg.Controls.Add(nomeDoAlunoLabel);
            this.gbDadosAlunoSeg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosAlunoSeg.Location = new System.Drawing.Point(13, 12);
            this.gbDadosAlunoSeg.Name = "gbDadosAlunoSeg";
            this.gbDadosAlunoSeg.Size = new System.Drawing.Size(551, 132);
            this.gbDadosAlunoSeg.TabIndex = 5;
            this.gbDadosAlunoSeg.TabStop = false;
            this.gbDadosAlunoSeg.Text = "Dados do aluno";
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sextaBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(10, 94);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(118, 26);
            this.matriculaTextBox.TabIndex = 10;
            // 
            // cursoTextBox
            // 
            this.cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sextaBindingSource, "Curso", true));
            this.cursoTextBox.Location = new System.Drawing.Point(134, 94);
            this.cursoTextBox.Name = "cursoTextBox";
            this.cursoTextBox.Size = new System.Drawing.Size(220, 26);
            this.cursoTextBox.TabIndex = 9;
            // 
            // professorTextBox
            // 
            this.professorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sextaBindingSource, "Professor", true));
            this.professorTextBox.Location = new System.Drawing.Point(360, 94);
            this.professorTextBox.Name = "professorTextBox";
            this.professorTextBox.Size = new System.Drawing.Size(183, 26);
            this.professorTextBox.TabIndex = 8;
            // 
            // nomeDoAlunoTextBox
            // 
            this.nomeDoAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sextaBindingSource, "NomeDoAluno", true));
            this.nomeDoAlunoTextBox.Location = new System.Drawing.Point(10, 44);
            this.nomeDoAlunoTextBox.Name = "nomeDoAlunoTextBox";
            this.nomeDoAlunoTextBox.Size = new System.Drawing.Size(533, 26);
            this.nomeDoAlunoTextBox.TabIndex = 7;
            // 
            // sextaDataGridView
            // 
            this.sextaDataGridView.AllowUserToAddRows = false;
            this.sextaDataGridView.AllowUserToDeleteRows = false;
            this.sextaDataGridView.AutoGenerateColumns = false;
            this.sextaDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.sextaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sextaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.sextaDataGridView.DataSource = this.sextaBindingSource;
            this.sextaDataGridView.Location = new System.Drawing.Point(12, 490);
            this.sextaDataGridView.Name = "sextaDataGridView";
            this.sextaDataGridView.ReadOnly = true;
            this.sextaDataGridView.RowHeadersVisible = false;
            this.sextaDataGridView.Size = new System.Drawing.Size(551, 249);
            this.sextaDataGridView.TabIndex = 0;
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
            // sextaTableAdapter
            // 
            this.sextaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QuartaTableAdapter = null;
            this.tableAdapterManager.QuintaTableAdapter = null;
            this.tableAdapterManager.SabadoTableAdapter = null;
            this.tableAdapterManager.SegundaTableAdapter = null;
            this.tableAdapterManager.SextaTableAdapter = this.sextaTableAdapter;
            this.tableAdapterManager.TercaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AgendaCNIeldorado.AgendaCNIeldoradoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sextaBindingNavigator
            // 
            this.sextaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sextaBindingNavigator.BindingSource = this.sextaBindingSource;
            this.sextaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sextaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sextaBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sextaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sextaBindingNavigatorSaveItem,
            this.tsEditarSex});
            this.sextaBindingNavigator.Location = new System.Drawing.Point(0, 742);
            this.sextaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sextaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sextaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sextaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sextaBindingNavigator.Name = "sextaBindingNavigator";
            this.sextaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sextaBindingNavigator.Size = new System.Drawing.Size(576, 25);
            this.sextaBindingNavigator.TabIndex = 1;
            this.sextaBindingNavigator.Text = "bindingNavigator1";
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
            // sextaBindingNavigatorSaveItem
            // 
            this.sextaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sextaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sextaBindingNavigatorSaveItem.Image")));
            this.sextaBindingNavigatorSaveItem.Name = "sextaBindingNavigatorSaveItem";
            this.sextaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sextaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.sextaBindingNavigatorSaveItem.Click += new System.EventHandler(this.sextaBindingNavigatorSaveItem_Click);
            // 
            // tsEditarSex
            // 
            this.tsEditarSex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEditarSex.Image = global::AgendaCNIeldorado.Properties.Resources.editar;
            this.tsEditarSex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditarSex.Name = "tsEditarSex";
            this.tsEditarSex.Size = new System.Drawing.Size(23, 22);
            this.tsEditarSex.Text = "Editar";
            this.tsEditarSex.Click += new System.EventHandler(this.tsEditarSex_Click);
            // 
            // frmSexta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(576, 767);
            this.Controls.Add(this.sextaBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSexta";
            this.Text = "Agendamento para sexta-feira";
            this.Load += new System.EventHandler(this.frmSexta_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbResultadosSeg.ResumeLayout(false);
            this.gbResultadosSeg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sextaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaCNIeldoradoDataSet)).EndInit();
            this.gbDadosAgendamentoSeg.ResumeLayout(false);
            this.gbDadosAgendamentoSeg.PerformLayout();
            this.gbDadosAlunoSeg.ResumeLayout(false);
            this.gbDadosAlunoSeg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sextaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sextaBindingNavigator)).EndInit();
            this.sextaBindingNavigator.ResumeLayout(false);
            this.sextaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AgendaCNIeldoradoDataSet agendaCNIeldoradoDataSet;
        private System.Windows.Forms.BindingSource sextaBindingSource;
        private AgendaCNIeldoradoDataSetTableAdapters.SextaTableAdapter sextaTableAdapter;
        private AgendaCNIeldoradoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sextaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sextaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sextaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisarNomeSex;
        private System.Windows.Forms.Button btnPesquisaNomeSex;
        private System.Windows.Forms.GroupBox gbResultadosSeg;
        private System.Windows.Forms.GroupBox gbDadosAgendamentoSeg;
        private System.Windows.Forms.GroupBox gbDadosAlunoSeg;
        private System.Windows.Forms.TextBox avaliacaoTextBox;
        private System.Windows.Forms.TextBox situacaoTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.DateTimePicker horaDateTimePicker;
        private System.Windows.Forms.TextBox operadorTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox cursoTextBox;
        private System.Windows.Forms.TextBox professorTextBox;
        private System.Windows.Forms.TextBox nomeDoAlunoTextBox;
        private System.Windows.Forms.RadioButton reprovadoRadioButton;
        private System.Windows.Forms.RadioButton aprovadoRadioButton;
        private System.Windows.Forms.ToolStripButton tsEditarSex;
    }
}