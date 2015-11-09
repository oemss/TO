namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textFIO = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.textAdres = new System.Windows.Forms.TextBox();
            this.textNomerP = new System.Windows.Forms.TextBox();
            this.textTelefon = new System.Windows.Forms.TextBox();
            this.textDateR = new System.Windows.Forms.TextBox();
            this.textNomerPrav = new System.Windows.Forms.TextBox();
            this.textVIN = new System.Windows.Forms.TextBox();
            this.textMark = new System.Windows.Forms.TextBox();
            this.textGodV = new System.Windows.Forms.TextBox();
            this.textIsgotov = new System.Windows.Forms.TextBox();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelNomerP = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelDataR = new System.Windows.Forms.Label();
            this.labelNomerPrav = new System.Windows.Forms.Label();
            this.labelVIN = new System.Windows.Forms.Label();
            this.labelMark = new System.Windows.Forms.Label();
            this.labelGodV = new System.Windows.Forms.Label();
            this.labelIsgotov = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.techinsDataSet = new WindowsFormsApplication2.TechinsDataSet();
            this.techinsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techinsDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.techinsDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.владелецBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.владелецTableAdapter = new WindowsFormsApplication2.TechinsDataSetTableAdapters.ВладелецTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonZapr = new System.Windows.Forms.Button();
            this.textZapr = new System.Windows.Forms.TextBox();
            this.labelZapr = new System.Windows.Forms.Label();
            this.buttonOtpr = new System.Windows.Forms.Button();
            this.buttonBD = new System.Windows.Forms.Button();
            this.textBD = new System.Windows.Forms.TextBox();
            this.buttonSaveBD = new System.Windows.Forms.Button();
            this.labelFail = new System.Windows.Forms.Label();
            this.buttonNeisp = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonDet = new System.Windows.Forms.Button();
            this.buttonTekZak = new System.Windows.Forms.Button();
            this.buttonRab = new System.Windows.Forms.Button();
            this.lableKodRab = new System.Windows.Forms.Label();
            this.lableOpis = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelNeisp = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.buttonSaveNeis = new System.Windows.Forms.Button();
            this.buttonSaveD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDannie = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.techinsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techinsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techinsDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techinsDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.владелецBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textFIO
            // 
            this.textFIO.Location = new System.Drawing.Point(13, 37);
            this.textFIO.Name = "textFIO";
            this.textFIO.Size = new System.Drawing.Size(186, 20);
            this.textFIO.TabIndex = 0;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(34, 21);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(131, 13);
            this.labelFIO.TabIndex = 1;
            this.labelFIO.Text = "Фамилия Имя Отчество";
            this.labelFIO.Click += new System.EventHandler(this.labelFIO_Click);
            // 
            // textAdres
            // 
            this.textAdres.Location = new System.Drawing.Point(204, 37);
            this.textAdres.Name = "textAdres";
            this.textAdres.Size = new System.Drawing.Size(171, 20);
            this.textAdres.TabIndex = 2;
            // 
            // textNomerP
            // 
            this.textNomerP.Location = new System.Drawing.Point(381, 37);
            this.textNomerP.Name = "textNomerP";
            this.textNomerP.Size = new System.Drawing.Size(100, 20);
            this.textNomerP.TabIndex = 3;
            // 
            // textTelefon
            // 
            this.textTelefon.Location = new System.Drawing.Point(487, 37);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Size = new System.Drawing.Size(100, 20);
            this.textTelefon.TabIndex = 4;
            // 
            // textDateR
            // 
            this.textDateR.Location = new System.Drawing.Point(593, 37);
            this.textDateR.Name = "textDateR";
            this.textDateR.Size = new System.Drawing.Size(118, 20);
            this.textDateR.TabIndex = 5;
            // 
            // textNomerPrav
            // 
            this.textNomerPrav.Location = new System.Drawing.Point(717, 37);
            this.textNomerPrav.Name = "textNomerPrav";
            this.textNomerPrav.Size = new System.Drawing.Size(100, 20);
            this.textNomerPrav.TabIndex = 6;
            // 
            // textVIN
            // 
            this.textVIN.Location = new System.Drawing.Point(203, 75);
            this.textVIN.Name = "textVIN";
            this.textVIN.Size = new System.Drawing.Size(172, 20);
            this.textVIN.TabIndex = 8;
            // 
            // textMark
            // 
            this.textMark.Location = new System.Drawing.Point(381, 75);
            this.textMark.Name = "textMark";
            this.textMark.Size = new System.Drawing.Size(135, 20);
            this.textMark.TabIndex = 10;
            // 
            // textGodV
            // 
            this.textGodV.Location = new System.Drawing.Point(522, 75);
            this.textGodV.Name = "textGodV";
            this.textGodV.Size = new System.Drawing.Size(100, 20);
            this.textGodV.TabIndex = 12;
            // 
            // textIsgotov
            // 
            this.textIsgotov.Location = new System.Drawing.Point(628, 75);
            this.textIsgotov.Name = "textIsgotov";
            this.textIsgotov.Size = new System.Drawing.Size(189, 20);
            this.textIsgotov.TabIndex = 13;
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(266, 21);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(38, 13);
            this.labelAdres.TabIndex = 14;
            this.labelAdres.Text = "Адрес";
            this.labelAdres.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelNomerP
            // 
            this.labelNomerP.AutoSize = true;
            this.labelNomerP.Location = new System.Drawing.Point(381, 24);
            this.labelNomerP.Name = "labelNomerP";
            this.labelNomerP.Size = new System.Drawing.Size(91, 13);
            this.labelNomerP.TabIndex = 15;
            this.labelNomerP.Text = "Номер паспорта";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(508, 21);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(52, 13);
            this.labelTelefon.TabIndex = 16;
            this.labelTelefon.Text = "Телефон";
            // 
            // labelDataR
            // 
            this.labelDataR.AutoSize = true;
            this.labelDataR.Location = new System.Drawing.Point(608, 21);
            this.labelDataR.Name = "labelDataR";
            this.labelDataR.Size = new System.Drawing.Size(86, 13);
            this.labelDataR.TabIndex = 17;
            this.labelDataR.Text = "Дата рождения";
            // 
            // labelNomerPrav
            // 
            this.labelNomerPrav.AutoSize = true;
            this.labelNomerPrav.Location = new System.Drawing.Point(731, 21);
            this.labelNomerPrav.Name = "labelNomerPrav";
            this.labelNomerPrav.Size = new System.Drawing.Size(68, 13);
            this.labelNomerPrav.TabIndex = 18;
            this.labelNomerPrav.Text = "Номер прав";
            // 
            // labelVIN
            // 
            this.labelVIN.AutoSize = true;
            this.labelVIN.Location = new System.Drawing.Point(257, 60);
            this.labelVIN.Name = "labelVIN";
            this.labelVIN.Size = new System.Drawing.Size(60, 13);
            this.labelVIN.TabIndex = 19;
            this.labelVIN.Text = "VIN номер";
            this.labelVIN.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Location = new System.Drawing.Point(429, 60);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(40, 13);
            this.labelMark.TabIndex = 20;
            this.labelMark.Text = "Марка";
            // 
            // labelGodV
            // 
            this.labelGodV.AutoSize = true;
            this.labelGodV.Location = new System.Drawing.Point(522, 60);
            this.labelGodV.Name = "labelGodV";
            this.labelGodV.Size = new System.Drawing.Size(71, 13);
            this.labelGodV.TabIndex = 21;
            this.labelGodV.Text = "Год выпуска";
            // 
            // labelIsgotov
            // 
            this.labelIsgotov.AutoSize = true;
            this.labelIsgotov.Location = new System.Drawing.Point(693, 60);
            this.labelIsgotov.Name = "labelIsgotov";
            this.labelIsgotov.Size = new System.Drawing.Size(78, 13);
            this.labelIsgotov.TabIndex = 22;
            this.labelIsgotov.Text = "Изготовитель";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(13, 488);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(162, 33);
            this.buttonNew.TabIndex = 23;
            this.buttonNew.Text = "Добавить нового владельца";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 73);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(185, 23);
            this.buttonSave.TabIndex = 24;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // techinsDataSet
            // 
            this.techinsDataSet.DataSetName = "TechinsDataSet";
            this.techinsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techinsDataSetBindingSource
            // 
            this.techinsDataSetBindingSource.DataSource = this.techinsDataSet;
            this.techinsDataSetBindingSource.Position = 0;
            // 
            // techinsDataSetBindingSource1
            // 
            this.techinsDataSetBindingSource1.DataSource = this.techinsDataSet;
            this.techinsDataSetBindingSource1.Position = 0;
            // 
            // techinsDataSetBindingSource2
            // 
            this.techinsDataSetBindingSource2.DataSource = this.techinsDataSet;
            this.techinsDataSetBindingSource2.Position = 0;
            // 
            // владелецBindingSource
            // 
            this.владелецBindingSource.DataMember = "Владелец";
            this.владелецBindingSource.DataSource = this.techinsDataSet;
            // 
            // владелецTableAdapter
            // 
            this.владелецTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(799, 238);
            this.dataGridView1.TabIndex = 25;
            // 
            // buttonZapr
            // 
            this.buttonZapr.Location = new System.Drawing.Point(181, 489);
            this.buttonZapr.Name = "buttonZapr";
            this.buttonZapr.Size = new System.Drawing.Size(161, 32);
            this.buttonZapr.TabIndex = 26;
            this.buttonZapr.Text = "Создать свой запрос";
            this.buttonZapr.UseVisualStyleBackColor = true;
            this.buttonZapr.Click += new System.EventHandler(this.button1_Click);
            // 
            // textZapr
            // 
            this.textZapr.Location = new System.Drawing.Point(117, 53);
            this.textZapr.Name = "textZapr";
            this.textZapr.Size = new System.Drawing.Size(594, 20);
            this.textZapr.TabIndex = 27;
            // 
            // labelZapr
            // 
            this.labelZapr.AutoSize = true;
            this.labelZapr.Location = new System.Drawing.Point(378, 37);
            this.labelZapr.Name = "labelZapr";
            this.labelZapr.Size = new System.Drawing.Size(88, 13);
            this.labelZapr.TabIndex = 28;
            this.labelZapr.Text = "Введите запрос";
            // 
            // buttonOtpr
            // 
            this.buttonOtpr.Location = new System.Drawing.Point(117, 86);
            this.buttonOtpr.Name = "buttonOtpr";
            this.buttonOtpr.Size = new System.Drawing.Size(182, 23);
            this.buttonOtpr.TabIndex = 29;
            this.buttonOtpr.Text = "Отправить";
            this.buttonOtpr.UseVisualStyleBackColor = true;
            this.buttonOtpr.Click += new System.EventHandler(this.buttonOtpr_Click);
            // 
            // buttonBD
            // 
            this.buttonBD.Location = new System.Drawing.Point(678, 495);
            this.buttonBD.Name = "buttonBD";
            this.buttonBD.Size = new System.Drawing.Size(139, 26);
            this.buttonBD.TabIndex = 30;
            this.buttonBD.Text = "Изменить БД";
            this.buttonBD.UseVisualStyleBackColor = true;
            this.buttonBD.Click += new System.EventHandler(this.buttonBD_Click);
            // 
            // textBD
            // 
            this.textBD.Location = new System.Drawing.Point(539, 469);
            this.textBD.Name = "textBD";
            this.textBD.Size = new System.Drawing.Size(278, 20);
            this.textBD.TabIndex = 31;
            // 
            // buttonSaveBD
            // 
            this.buttonSaveBD.Location = new System.Drawing.Point(539, 495);
            this.buttonSaveBD.Name = "buttonSaveBD";
            this.buttonSaveBD.Size = new System.Drawing.Size(133, 26);
            this.buttonSaveBD.TabIndex = 32;
            this.buttonSaveBD.Text = "Сохранить";
            this.buttonSaveBD.UseVisualStyleBackColor = true;
            this.buttonSaveBD.Click += new System.EventHandler(this.buttonSaveBD_Click);
            // 
            // labelFail
            // 
            this.labelFail.AutoSize = true;
            this.labelFail.Location = new System.Drawing.Point(332, 99);
            this.labelFail.Name = "labelFail";
            this.labelFail.Size = new System.Drawing.Size(137, 13);
            this.labelFail.TabIndex = 33;
            this.labelFail.Text = "Ошибка! Повторите ввод.";
            // 
            // buttonNeisp
            // 
            this.buttonNeisp.Location = new System.Drawing.Point(13, 449);
            this.buttonNeisp.Name = "buttonNeisp";
            this.buttonNeisp.Size = new System.Drawing.Size(162, 33);
            this.buttonNeisp.TabIndex = 34;
            this.buttonNeisp.Text = "Добавить неисправости";
            this.buttonNeisp.UseVisualStyleBackColor = true;
            this.buttonNeisp.Click += new System.EventHandler(this.buttonNeisp_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(539, 495);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(133, 26);
            this.buttonChange.TabIndex = 36;
            this.buttonChange.Text = "Изменить путь";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonDet
            // 
            this.buttonDet.Location = new System.Drawing.Point(181, 449);
            this.buttonDet.Name = "buttonDet";
            this.buttonDet.Size = new System.Drawing.Size(161, 33);
            this.buttonDet.TabIndex = 38;
            this.buttonDet.Text = "Добавление детали";
            this.buttonDet.UseVisualStyleBackColor = true;
            this.buttonDet.Click += new System.EventHandler(this.buttonDet_Click);
            // 
            // buttonTekZak
            // 
            this.buttonTekZak.Location = new System.Drawing.Point(348, 488);
            this.buttonTekZak.Name = "buttonTekZak";
            this.buttonTekZak.Size = new System.Drawing.Size(161, 33);
            this.buttonTekZak.TabIndex = 39;
            this.buttonTekZak.Text = "Текущие заказы";
            this.buttonTekZak.UseVisualStyleBackColor = true;
            this.buttonTekZak.Click += new System.EventHandler(this.buttonTekZak_Click);
            // 
            // buttonRab
            // 
            this.buttonRab.Location = new System.Drawing.Point(348, 449);
            this.buttonRab.Name = "buttonRab";
            this.buttonRab.Size = new System.Drawing.Size(161, 33);
            this.buttonRab.TabIndex = 40;
            this.buttonRab.Text = "Текущие работы";
            this.buttonRab.UseVisualStyleBackColor = true;
            this.buttonRab.Click += new System.EventHandler(this.buttonRab_Click);
            // 
            // lableKodRab
            // 
            this.lableKodRab.AutoSize = true;
            this.lableKodRab.Location = new System.Drawing.Point(409, 60);
            this.lableKodRab.Name = "lableKodRab";
            this.lableKodRab.Size = new System.Drawing.Size(82, 13);
            this.lableKodRab.TabIndex = 41;
            this.lableKodRab.Text = "Код работника";
            // 
            // lableOpis
            // 
            this.lableOpis.AutoSize = true;
            this.lableOpis.Location = new System.Drawing.Point(545, 60);
            this.lableOpis.Name = "lableOpis";
            this.lableOpis.Size = new System.Drawing.Size(57, 13);
            this.lableOpis.TabIndex = 42;
            this.lableOpis.Text = "Описание";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(714, 60);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(40, 13);
            this.labelTime.TabIndex = 43;
            this.labelTime.Text = "Время";
            // 
            // labelNeisp
            // 
            this.labelNeisp.AutoSize = true;
            this.labelNeisp.Location = new System.Drawing.Point(394, 60);
            this.labelNeisp.Name = "labelNeisp";
            this.labelNeisp.Size = new System.Drawing.Size(106, 13);
            this.labelNeisp.TabIndex = 44;
            this.labelNeisp.Text = "Код неисправности";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(714, 60);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(62, 13);
            this.labelMoney.TabIndex = 45;
            this.labelMoney.Text = "Стоимость";
            // 
            // buttonSaveNeis
            // 
            this.buttonSaveNeis.Location = new System.Drawing.Point(12, 75);
            this.buttonSaveNeis.Name = "buttonSaveNeis";
            this.buttonSaveNeis.Size = new System.Drawing.Size(185, 23);
            this.buttonSaveNeis.TabIndex = 46;
            this.buttonSaveNeis.Text = "Сохранить";
            this.buttonSaveNeis.UseVisualStyleBackColor = true;
            this.buttonSaveNeis.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonSaveD
            // 
            this.buttonSaveD.Location = new System.Drawing.Point(12, 73);
            this.buttonSaveD.Name = "buttonSaveD";
            this.buttonSaveD.Size = new System.Drawing.Size(185, 23);
            this.buttonSaveD.TabIndex = 47;
            this.buttonSaveD.Text = "Сохранить";
            this.buttonSaveD.UseVisualStyleBackColor = true;
            this.buttonSaveD.Click += new System.EventHandler(this.buttonSaveD_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 20);
            this.button1.TabIndex = 48;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // buttonDannie
            // 
            this.buttonDannie.Location = new System.Drawing.Point(14, 412);
            this.buttonDannie.Name = "buttonDannie";
            this.buttonDannie.Size = new System.Drawing.Size(161, 31);
            this.buttonDannie.TabIndex = 49;
            this.buttonDannie.Text = "Данные по автомобилю";
            this.buttonDannie.UseVisualStyleBackColor = true;
            this.buttonDannie.Click += new System.EventHandler(this.buttonDannie_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(12, 75);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(184, 23);
            this.buttonSend.TabIndex = 50;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 528);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonDannie);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSaveD);
            this.Controls.Add(this.buttonSaveNeis);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelNeisp);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.lableOpis);
            this.Controls.Add(this.lableKodRab);
            this.Controls.Add(this.buttonRab);
            this.Controls.Add(this.buttonTekZak);
            this.Controls.Add(this.buttonDet);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonNeisp);
            this.Controls.Add(this.labelFail);
            this.Controls.Add(this.buttonSaveBD);
            this.Controls.Add(this.textBD);
            this.Controls.Add(this.buttonBD);
            this.Controls.Add(this.buttonOtpr);
            this.Controls.Add(this.labelZapr);
            this.Controls.Add(this.textZapr);
            this.Controls.Add(this.buttonZapr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.labelIsgotov);
            this.Controls.Add(this.labelGodV);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.labelVIN);
            this.Controls.Add(this.labelNomerPrav);
            this.Controls.Add(this.labelDataR);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelNomerP);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.textIsgotov);
            this.Controls.Add(this.textGodV);
            this.Controls.Add(this.textMark);
            this.Controls.Add(this.textVIN);
            this.Controls.Add(this.textNomerPrav);
            this.Controls.Add(this.textDateR);
            this.Controls.Add(this.textTelefon);
            this.Controls.Add(this.textNomerP);
            this.Controls.Add(this.textAdres);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.textFIO);
            this.Name = "Form1";
            this.Text = "База ТО автомобилей";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.techinsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techinsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techinsDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techinsDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.владелецBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFIO;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textAdres;
        private System.Windows.Forms.TextBox textNomerP;
        private System.Windows.Forms.TextBox textTelefon;
        private System.Windows.Forms.TextBox textDateR;
        private System.Windows.Forms.TextBox textNomerPrav;
        private System.Windows.Forms.TextBox textVIN;
        private System.Windows.Forms.TextBox textMark;
        private System.Windows.Forms.TextBox textGodV;
        private System.Windows.Forms.TextBox textIsgotov;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelNomerP;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelDataR;
        private System.Windows.Forms.Label labelNomerPrav;
        private System.Windows.Forms.Label labelVIN;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.Label labelGodV;
        private System.Windows.Forms.Label labelIsgotov;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.BindingSource techinsDataSetBindingSource;
        private TechinsDataSet techinsDataSet;
        private System.Windows.Forms.BindingSource techinsDataSetBindingSource1;
        private System.Windows.Forms.BindingSource techinsDataSetBindingSource2;
        private System.Windows.Forms.BindingSource владелецBindingSource;
        private TechinsDataSetTableAdapters.ВладелецTableAdapter владелецTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonZapr;
        private System.Windows.Forms.TextBox textZapr;
        private System.Windows.Forms.Label labelZapr;
        private System.Windows.Forms.Button buttonOtpr;
        private System.Windows.Forms.Button buttonBD;
        private System.Windows.Forms.TextBox textBD;
        private System.Windows.Forms.Button buttonSaveBD;
        private System.Windows.Forms.Label labelFail;
        private System.Windows.Forms.Button buttonNeisp;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonDet;
        private System.Windows.Forms.Button buttonTekZak;
        private System.Windows.Forms.Button buttonRab;
        private System.Windows.Forms.Label lableKodRab;
        private System.Windows.Forms.Label lableOpis;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelNeisp;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Button buttonSaveNeis;
        private System.Windows.Forms.Button buttonSaveD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDannie;
        private System.Windows.Forms.Button buttonSend;
    }
}

