namespace AutoPricing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.column_autotype = new System.Windows.Forms.ColumnHeader();
            this.column_mark = new System.Windows.Forms.ColumnHeader();
            this.column_releaseyear = new System.Windows.Forms.ColumnHeader();
            this.column_initialprice = new System.Windows.Forms.ColumnHeader();
            this.column_actualprice = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_rowNumber = new System.Windows.Forms.TextBox();
            this.button_removeByRowNumber = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_InitialPrice = new System.Windows.Forms.TextBox();
            this.textBox_ReleaseYear = new System.Windows.Forms.TextBox();
            this.textBox_Mark = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.comboBox_SelectAutoType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 426);
            this.panel1.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_autotype,
            this.column_mark,
            this.column_releaseyear,
            this.column_initialprice,
            this.column_actualprice});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(565, 420);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // column_autotype
            // 
            this.column_autotype.Text = "Тип";
            // 
            // column_mark
            // 
            this.column_mark.Text = "Марка";
            this.column_mark.Width = 80;
            // 
            // column_releaseyear
            // 
            this.column_releaseyear.Text = "Год выпуска";
            this.column_releaseyear.Width = 80;
            // 
            // column_initialprice
            // 
            this.column_initialprice.Text = "Начальная стоимость";
            this.column_initialprice.Width = 140;
            // 
            // column_actualprice
            // 
            this.column_actualprice.Text = "Актуальная стоимость";
            this.column_actualprice.Width = 140;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox_rowNumber);
            this.panel2.Controls.Add(this.button_removeByRowNumber);
            this.panel2.Controls.Add(this.button_remove);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_InitialPrice);
            this.panel2.Controls.Add(this.textBox_ReleaseYear);
            this.panel2.Controls.Add(this.textBox_Mark);
            this.panel2.Controls.Add(this.button_Add);
            this.panel2.Controls.Add(this.comboBox_SelectAutoType);
            this.panel2.Location = new System.Drawing.Point(589, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 426);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Номер в списке";
            // 
            // textBox_rowNumber
            // 
            this.textBox_rowNumber.Location = new System.Drawing.Point(3, 362);
            this.textBox_rowNumber.Name = "textBox_rowNumber";
            this.textBox_rowNumber.Size = new System.Drawing.Size(100, 23);
            this.textBox_rowNumber.TabIndex = 16;
            // 
            // button_removeByRowNumber
            // 
            this.button_removeByRowNumber.Location = new System.Drawing.Point(3, 391);
            this.button_removeByRowNumber.Name = "button_removeByRowNumber";
            this.button_removeByRowNumber.Size = new System.Drawing.Size(193, 32);
            this.button_removeByRowNumber.TabIndex = 15;
            this.button_removeByRowNumber.Text = "Удалить по номеру в списке";
            this.button_removeByRowNumber.UseVisualStyleBackColor = true;
            this.button_removeByRowNumber.Click += new System.EventHandler(this.button_removeByRowNumber_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(3, 278);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(193, 32);
            this.button_remove.TabIndex = 14;
            this.button_remove.Text = "Удалить";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Тип автомобиля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Год выпуска";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Начальная стоимость";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Марка";
            // 
            // textBox_InitialPrice
            // 
            this.textBox_InitialPrice.Location = new System.Drawing.Point(3, 201);
            this.textBox_InitialPrice.Name = "textBox_InitialPrice";
            this.textBox_InitialPrice.Size = new System.Drawing.Size(128, 23);
            this.textBox_InitialPrice.TabIndex = 9;
            // 
            // textBox_ReleaseYear
            // 
            this.textBox_ReleaseYear.Location = new System.Drawing.Point(3, 141);
            this.textBox_ReleaseYear.Name = "textBox_ReleaseYear";
            this.textBox_ReleaseYear.Size = new System.Drawing.Size(128, 23);
            this.textBox_ReleaseYear.TabIndex = 8;
            // 
            // textBox_Mark
            // 
            this.textBox_Mark.Location = new System.Drawing.Point(3, 80);
            this.textBox_Mark.Name = "textBox_Mark";
            this.textBox_Mark.Size = new System.Drawing.Size(128, 23);
            this.textBox_Mark.TabIndex = 7;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(3, 240);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(193, 32);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // comboBox_SelectAutoType
            // 
            this.comboBox_SelectAutoType.FormattingEnabled = true;
            this.comboBox_SelectAutoType.Location = new System.Drawing.Point(3, 23);
            this.comboBox_SelectAutoType.Name = "comboBox_SelectAutoType";
            this.comboBox_SelectAutoType.Size = new System.Drawing.Size(100, 23);
            this.comboBox_SelectAutoType.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Автомобили";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox_InitialPrice;
        private TextBox textBox_ReleaseYear;
        private TextBox textBox_Mark;
        private Button button_Add;
        private ComboBox comboBox_SelectAutoType;
        private ListView listView1;
        private ColumnHeader column_mark;
        private ColumnHeader column_releaseyear;
        private ColumnHeader column_initialprice;
        public ColumnHeader column_actualprice;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button button_remove;
        private ColumnHeader column_autotype;
        private Label label5;
        private TextBox textBox_rowNumber;
        private Button button_removeByRowNumber;
    }
}