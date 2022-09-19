
namespace Katal_Ref.Properties
{
    partial class FormTermodinHarak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTermodinHarak));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.characidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обозначениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.δH298КДжмольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s298ДжмольКDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сp298ДжмольградDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b103DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c106DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c105DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сp298ДжмольградРасчитаннаяЧерезКоэфициентыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ошибкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.термодинхаракBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.katal_Reform_DBDataSet1 = new Katal_Ref.Katal_Reform_DBDataSet1();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.термодин_харак_TableAdapter = new Katal_Ref.Katal_Reform_DBDataSet1TableAdapters.Термодин_харак_TableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.термодинхаракBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katal_Reform_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.characidDataGridViewTextBoxColumn,
            this.обозначениеDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.δH298КДжмольDataGridViewTextBoxColumn,
            this.s298ДжмольКDataGridViewTextBoxColumn,
            this.сp298ДжмольградDataGridViewTextBoxColumn,
            this.aDataGridViewTextBoxColumn,
            this.b103DataGridViewTextBoxColumn,
            this.c106DataGridViewTextBoxColumn,
            this.c105DataGridViewTextBoxColumn,
            this.сp298ДжмольградРасчитаннаяЧерезКоэфициентыDataGridViewTextBoxColumn,
            this.ошибкаDataGridViewTextBoxColumn,
            this.f13DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.термодинхаракBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1100, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // characidDataGridViewTextBoxColumn
            // 
            this.characidDataGridViewTextBoxColumn.DataPropertyName = "charac_id";
            this.characidDataGridViewTextBoxColumn.HeaderText = "charac_id";
            this.characidDataGridViewTextBoxColumn.Name = "characidDataGridViewTextBoxColumn";
            // 
            // обозначениеDataGridViewTextBoxColumn
            // 
            this.обозначениеDataGridViewTextBoxColumn.DataPropertyName = "Обозначение ";
            this.обозначениеDataGridViewTextBoxColumn.HeaderText = "Обозначение ";
            this.обозначениеDataGridViewTextBoxColumn.Name = "обозначениеDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // δH298КДжмольDataGridViewTextBoxColumn
            // 
            this.δH298КДжмольDataGridViewTextBoxColumn.DataPropertyName = "ΔH298 , кДж/моль";
            this.δH298КДжмольDataGridViewTextBoxColumn.HeaderText = "ΔH298 , кДж/моль";
            this.δH298КДжмольDataGridViewTextBoxColumn.Name = "δH298КДжмольDataGridViewTextBoxColumn";
            // 
            // s298ДжмольКDataGridViewTextBoxColumn
            // 
            this.s298ДжмольКDataGridViewTextBoxColumn.DataPropertyName = " S298 , Дж/(моль*К)";
            this.s298ДжмольКDataGridViewTextBoxColumn.HeaderText = " S298 , Дж/(моль*К)";
            this.s298ДжмольКDataGridViewTextBoxColumn.Name = "s298ДжмольКDataGridViewTextBoxColumn";
            // 
            // сp298ДжмольградDataGridViewTextBoxColumn
            // 
            this.сp298ДжмольградDataGridViewTextBoxColumn.DataPropertyName = "Сp 298, Дж/(моль*град)";
            this.сp298ДжмольградDataGridViewTextBoxColumn.HeaderText = "Сp 298, Дж/(моль*град)";
            this.сp298ДжмольградDataGridViewTextBoxColumn.Name = "сp298ДжмольградDataGridViewTextBoxColumn";
            // 
            // aDataGridViewTextBoxColumn
            // 
            this.aDataGridViewTextBoxColumn.DataPropertyName = "a ";
            this.aDataGridViewTextBoxColumn.HeaderText = "a ";
            this.aDataGridViewTextBoxColumn.Name = "aDataGridViewTextBoxColumn";
            // 
            // b103DataGridViewTextBoxColumn
            // 
            this.b103DataGridViewTextBoxColumn.DataPropertyName = "b*10^3";
            this.b103DataGridViewTextBoxColumn.HeaderText = "b*10^3";
            this.b103DataGridViewTextBoxColumn.Name = "b103DataGridViewTextBoxColumn";
            // 
            // c106DataGridViewTextBoxColumn
            // 
            this.c106DataGridViewTextBoxColumn.DataPropertyName = "c*10^6";
            this.c106DataGridViewTextBoxColumn.HeaderText = "c*10^6";
            this.c106DataGridViewTextBoxColumn.Name = "c106DataGridViewTextBoxColumn";
            // 
            // c105DataGridViewTextBoxColumn
            // 
            this.c105DataGridViewTextBoxColumn.DataPropertyName = "c_*10^-5";
            this.c105DataGridViewTextBoxColumn.HeaderText = "c_*10^-5";
            this.c105DataGridViewTextBoxColumn.Name = "c105DataGridViewTextBoxColumn";
            // 
            // сp298ДжмольградРасчитаннаяЧерезКоэфициентыDataGridViewTextBoxColumn
            // 
            this.сp298ДжмольградРасчитаннаяЧерезКоэфициентыDataGridViewTextBoxColumn.DataPropertyName = "Сp 298, Дж/(моль*град), Расчитанная через коэфициенты";
            this.сp298ДжмольградРасчитаннаяЧерезКоэфициентыDataGridViewTextBoxColumn.HeaderText = "Сp 298, Дж/(моль*град), Расчитанная через коэфициенты";
            this.сp298ДжмольградРасчитаннаяЧерезКоэфициентыDataGridViewTextBoxColumn.Name = "сp298ДжмольградРасчитаннаяЧерезКоэфициентыDataGridViewTextBoxColumn";
            // 
            // ошибкаDataGridViewTextBoxColumn
            // 
            this.ошибкаDataGridViewTextBoxColumn.DataPropertyName = "Ошибка, %";
            this.ошибкаDataGridViewTextBoxColumn.HeaderText = "Ошибка, %";
            this.ошибкаDataGridViewTextBoxColumn.Name = "ошибкаDataGridViewTextBoxColumn";
            // 
            // f13DataGridViewTextBoxColumn
            // 
            this.f13DataGridViewTextBoxColumn.DataPropertyName = "F13";
            this.f13DataGridViewTextBoxColumn.HeaderText = "F13";
            this.f13DataGridViewTextBoxColumn.Name = "f13DataGridViewTextBoxColumn";
            // 
            // термодинхаракBindingSource
            // 
            this.термодинхаракBindingSource.DataMember = "Термодин_харак$";
            this.термодинхаракBindingSource.DataSource = this.katal_Reform_DBDataSet1;
            // 
            // katal_Reform_DBDataSet1
            // 
            this.katal_Reform_DBDataSet1.DataSetName = "Katal_Reform_DBDataSet1";
            this.katal_Reform_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.термодинхаракBindingSource, "charac_id", true));
            this.textBox1.Location = new System.Drawing.Point(12, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.термодинхаракBindingSource, "Обозначение ", true));
            this.textBox2.Location = new System.Drawing.Point(12, 348);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.термодинхаракBindingSource, "Наименование", true));
            this.textBox3.Location = new System.Drawing.Point(12, 374);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.термодинхаракBindingSource, "ΔH298 , кДж/моль", true));
            this.textBox4.Location = new System.Drawing.Point(12, 400);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.термодинхаракBindingSource, " S298 , Дж/(моль*К)", true));
            this.textBox5.Location = new System.Drawing.Point(12, 426);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.термодинхаракBindingSource, "Сp 298, Дж/(моль*град)", true));
            this.textBox6.Location = new System.Drawing.Point(12, 452);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.термодинхаракBindingSource, "a ", true));
            this.textBox7.Location = new System.Drawing.Point(12, 478);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.термодинхаракBindingSource, "b*10^3", true));
            this.textBox8.Location = new System.Drawing.Point(164, 322);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.термодинхаракBindingSource, "c*10^6", true));
            this.textBox9.Location = new System.Drawing.Point(164, 348);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 10;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.термодинхаракBindingSource, "c_*10^-5", true));
            this.textBox10.Location = new System.Drawing.Point(164, 374);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 11;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.термодинхаракBindingSource, "Сp 298, Дж/(моль*град), Расчитанная через коэфициенты", true));
            this.textBox11.Location = new System.Drawing.Point(164, 400);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 12;
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.термодинхаракBindingSource, "Ошибка, %", true));
            this.textBox12.Location = new System.Drawing.Point(164, 426);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 13;
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.термодинхаракBindingSource, "F13", true));
            this.textBox13.Location = new System.Drawing.Point(164, 452);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(298, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 24);
            this.button1.TabIndex = 15;
            this.button1.Text = "ОБНОВИТЬ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // термодин_харак_TableAdapter
            // 
            this.термодин_харак_TableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.термодинхаракBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1124, 25);
            this.bindingNavigator1.TabIndex = 16;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // FormTermodinHarak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1124, 533);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTermodinHarak";
            this.Text = "FormTermodinHarak";
            this.Load += new System.EventHandler(this.FormTermodinHarak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.термодинхаракBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katal_Reform_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button1;
        private Katal_Reform_DBDataSet1 katal_Reform_DBDataSet1;
        private System.Windows.Forms.BindingSource термодинхаракBindingSource;
        private Katal_Reform_DBDataSet1TableAdapters.Термодин_харак_TableAdapter термодин_харак_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn characidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обозначениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn δH298КДжмольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s298ДжмольКDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сp298ДжмольградDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b103DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c106DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c105DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сp298ДжмольградРасчитаннаяЧерезКоэфициентыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ошибкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn f13DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
    }
}