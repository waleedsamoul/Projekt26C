namespace Projekt26C_
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
            //HEJ
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainLabel = new Label();
            textBoxRSSURL = new TextBox();
            InfoPodd = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            InfoAvsnitt = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            dataGridView3 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            textBoxNamn = new TextBox();
            buttonLaggTillPodd = new Button();
            buttonTaBortPodd = new Button();
            buttonAndraPodd = new Button();
            comboBoxValjKategori = new ComboBox();
            Kategori = new Label();
            buttonLaggTillKategori = new Button();
            richTextBoxBeskrivning = new RichTextBox();
            label3 = new Label();
            buttonAndraKategori = new Button();
            buttonTaBortKategori = new Button();
            textBoxKategori = new TextBox();
            comboBoxFilterKategori = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)InfoPodd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InfoAvsnitt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // MainLabel
            // 
            MainLabel.AutoSize = true;
            MainLabel.Location = new Point(12, 9);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(233, 32);
            MainLabel.TabIndex = 1;
            MainLabel.Text = "RSS-läsare projekt26";
            MainLabel.Click += label1_Click;
            // 
            // textBoxRSSURL
            // 
            textBoxRSSURL.Location = new Point(74, 273);
            textBoxRSSURL.Name = "textBoxRSSURL";
            textBoxRSSURL.Size = new Size(453, 39);
            textBoxRSSURL.TabIndex = 2;
            // 
            // InfoPodd
            // 
            InfoPodd.AllowUserToResizeColumns = false;
            InfoPodd.AllowUserToResizeRows = false;
            InfoPodd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InfoPodd.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column6 });
            InfoPodd.Location = new Point(74, 389);
            InfoPodd.Name = "InfoPodd";
            InfoPodd.RowHeadersWidth = 82;
            InfoPodd.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            InfoPodd.Size = new Size(822, 576);
            InfoPodd.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "Titel";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Antal Avsnitt";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Kategori";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "Namn";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // InfoAvsnitt
            // 
            InfoAvsnitt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InfoAvsnitt.Columns.AddRange(new DataGridViewColumn[] { Column4 });
            InfoAvsnitt.Location = new Point(943, 389);
            InfoAvsnitt.Name = "InfoAvsnitt";
            InfoAvsnitt.RowHeadersWidth = 82;
            InfoAvsnitt.Size = new Size(285, 576);
            InfoAvsnitt.TabIndex = 5;
            // 
            // Column4
            // 
            Column4.HeaderText = "Avsnitt";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 238);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 6;
            label1.Text = "RSS URL";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column5 });
            dataGridView3.Location = new Point(1669, 389);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 82;
            dataGridView3.Size = new Size(276, 576);
            dataGridView3.TabIndex = 7;
            // 
            // Column5
            // 
            Column5.HeaderText = "Kategori";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 121);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 8;
            label2.Text = "Namn ";
            label2.Click += label2_Click;
            // 
            // textBoxNamn
            // 
            textBoxNamn.Location = new Point(74, 166);
            textBoxNamn.Name = "textBoxNamn";
            textBoxNamn.Size = new Size(200, 39);
            textBoxNamn.TabIndex = 9;
            // 
            // buttonLaggTillPodd
            // 
            buttonLaggTillPodd.Location = new Point(74, 329);
            buttonLaggTillPodd.Name = "buttonLaggTillPodd";
            buttonLaggTillPodd.Size = new Size(150, 46);
            buttonLaggTillPodd.TabIndex = 10;
            buttonLaggTillPodd.Text = "Lägg till";
            buttonLaggTillPodd.UseVisualStyleBackColor = true;
            // 
            // buttonTaBortPodd
            // 
            buttonTaBortPodd.Location = new Point(437, 329);
            buttonTaBortPodd.Name = "buttonTaBortPodd";
            buttonTaBortPodd.Size = new Size(150, 46);
            buttonTaBortPodd.TabIndex = 11;
            buttonTaBortPodd.Text = "Ta bort";
            buttonTaBortPodd.UseVisualStyleBackColor = true;
            // 
            // buttonAndraPodd
            // 
            buttonAndraPodd.Location = new Point(252, 329);
            buttonAndraPodd.Name = "buttonAndraPodd";
            buttonAndraPodd.Size = new Size(150, 46);
            buttonAndraPodd.TabIndex = 12;
            buttonAndraPodd.Text = "Ändra";
            buttonAndraPodd.UseVisualStyleBackColor = true;
            // 
            // comboBoxValjKategori
            // 
            comboBoxValjKategori.FormattingEnabled = true;
            comboBoxValjKategori.Location = new Point(326, 166);
            comboBoxValjKategori.Name = "comboBoxValjKategori";
            comboBoxValjKategori.Size = new Size(242, 40);
            comboBoxValjKategori.TabIndex = 14;
            // 
            // Kategori
            // 
            Kategori.AutoSize = true;
            Kategori.Location = new Point(326, 121);
            Kategori.Name = "Kategori";
            Kategori.Size = new Size(103, 32);
            Kategori.TabIndex = 16;
            Kategori.Text = "Kategori";
            // 
            // buttonLaggTillKategori
            // 
            buttonLaggTillKategori.Location = new Point(1669, 329);
            buttonLaggTillKategori.Name = "buttonLaggTillKategori";
            buttonLaggTillKategori.Size = new Size(150, 46);
            buttonLaggTillKategori.TabIndex = 17;
            buttonLaggTillKategori.Text = "Lägg till";
            buttonLaggTillKategori.UseVisualStyleBackColor = true;
            // 
            // richTextBoxBeskrivning
            // 
            richTextBoxBeskrivning.Location = new Point(1245, 629);
            richTextBoxBeskrivning.Name = "richTextBoxBeskrivning";
            richTextBoxBeskrivning.Size = new Size(324, 336);
            richTextBoxBeskrivning.TabIndex = 18;
            richTextBoxBeskrivning.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1245, 579);
            label3.Name = "label3";
            label3.Size = new Size(137, 32);
            label3.TabIndex = 19;
            label3.Text = "Beskrivning";
            // 
            // buttonAndraKategori
            // 
            buttonAndraKategori.Location = new Point(1825, 329);
            buttonAndraKategori.Name = "buttonAndraKategori";
            buttonAndraKategori.Size = new Size(150, 46);
            buttonAndraKategori.TabIndex = 20;
            buttonAndraKategori.Text = "Ändra";
            buttonAndraKategori.UseVisualStyleBackColor = true;
            // 
            // buttonTaBortKategori
            // 
            buttonTaBortKategori.Location = new Point(1981, 329);
            buttonTaBortKategori.Name = "buttonTaBortKategori";
            buttonTaBortKategori.Size = new Size(150, 46);
            buttonTaBortKategori.TabIndex = 21;
            buttonTaBortKategori.Text = "Ta bort";
            buttonTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // textBoxKategori
            // 
            textBoxKategori.Location = new Point(1669, 277);
            textBoxKategori.Name = "textBoxKategori";
            textBoxKategori.Size = new Size(200, 39);
            textBoxKategori.TabIndex = 22;
            // 
            // comboBoxFilterKategori
            // 
            comboBoxFilterKategori.FormattingEnabled = true;
            comboBoxFilterKategori.Location = new Point(631, 166);
            comboBoxFilterKategori.Name = "comboBoxFilterKategori";
            comboBoxFilterKategori.Size = new Size(242, 40);
            comboBoxFilterKategori.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(631, 121);
            label4.Name = "label4";
            label4.Size = new Size(67, 32);
            label4.TabIndex = 23;
            label4.Text = "Filter";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2224, 1036);
            Controls.Add(label4);
            Controls.Add(textBoxKategori);
            Controls.Add(buttonTaBortKategori);
            Controls.Add(buttonAndraKategori);
            Controls.Add(label3);
            Controls.Add(richTextBoxBeskrivning);
            Controls.Add(buttonLaggTillKategori);
            Controls.Add(Kategori);
            Controls.Add(comboBoxFilterKategori);
            Controls.Add(comboBoxValjKategori);
            Controls.Add(buttonAndraPodd);
            Controls.Add(buttonTaBortPodd);
            Controls.Add(buttonLaggTillPodd);
            Controls.Add(textBoxNamn);
            Controls.Add(label2);
            Controls.Add(dataGridView3);
            Controls.Add(label1);
            Controls.Add(InfoAvsnitt);
            Controls.Add(InfoPodd);
            Controls.Add(textBoxRSSURL);
            Controls.Add(MainLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)InfoPodd).EndInit();
            ((System.ComponentModel.ISupportInitialize)InfoAvsnitt).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label MainLabel;
        private TextBox textBoxRSSURL;
        private DataGridView InfoPodd;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridView InfoAvsnitt;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column4;
        private Label label1;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Column5;
        private Label label2;
        private TextBox textBoxNamn;
        private Button buttonLaggTillPodd;
        private Button buttonTaBortPodd;
        private Button button2;
        private Button button3;
        private Button buttonAndraPodd;
        private ComboBox comboBoxValjKategori;
        private Label Kategori;
        private DataGridViewTextBoxColumn Column6;
        private Button buttonLaggTillKategori;
        private RichTextBox richTextBoxBeskrivning;
        private Label label3;
        private Button buttonAndraKategori;
        private Button buttonTaBortKategori;
        private TextBox textBoxKategori;
        private ComboBox comboBoxFilterKategori;
        private Label label4;
    }
}
