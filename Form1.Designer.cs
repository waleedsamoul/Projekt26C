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
            MainLabel.Location = new Point(9, 7);
            MainLabel.Margin = new Padding(2, 0, 2, 0);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(176, 25);
            MainLabel.TabIndex = 1;
            MainLabel.Text = "RSS-läsare projekt26";
            MainLabel.Click += label1_Click;
            // 
            // textBoxRSSURL
            // 
            textBoxRSSURL.Location = new Point(57, 213);
            textBoxRSSURL.Margin = new Padding(2, 2, 2, 2);
            textBoxRSSURL.Name = "textBoxRSSURL";
            textBoxRSSURL.Size = new Size(349, 31);
            textBoxRSSURL.TabIndex = 2;
            // 
            // InfoPodd
            // 
            InfoPodd.AllowUserToResizeColumns = false;
            InfoPodd.AllowUserToResizeRows = false;
            InfoPodd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InfoPodd.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column6 });
            InfoPodd.Location = new Point(57, 304);
            InfoPodd.Margin = new Padding(2, 2, 2, 2);
            InfoPodd.Name = "InfoPodd";
            InfoPodd.RowHeadersWidth = 82;
            InfoPodd.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            InfoPodd.Size = new Size(632, 450);
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
            InfoAvsnitt.Location = new Point(721, 304);
            InfoAvsnitt.Margin = new Padding(2, 2, 2, 2);
            InfoAvsnitt.Name = "InfoAvsnitt";
            InfoAvsnitt.RowHeadersWidth = 82;
            InfoAvsnitt.Size = new Size(219, 450);
            InfoAvsnitt.TabIndex = 5;
            InfoAvsnitt.CellContentClick += InfoAvsnitt_CellContentClick;
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
            label1.Location = new Point(57, 186);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 6;
            label1.Text = "RSS URL";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column5 });
            dataGridView3.Location = new Point(1284, 304);
            dataGridView3.Margin = new Padding(2, 2, 2, 2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 82;
            dataGridView3.Size = new Size(212, 450);
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
            label2.Location = new Point(57, 95);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 8;
            label2.Text = "Namn ";
            label2.Click += label2_Click;
            // 
            // textBoxNamn
            // 
            textBoxNamn.Location = new Point(57, 130);
            textBoxNamn.Margin = new Padding(2, 2, 2, 2);
            textBoxNamn.Name = "textBoxNamn";
            textBoxNamn.Size = new Size(155, 31);
            textBoxNamn.TabIndex = 9;
            // 
            // buttonLaggTillPodd
            // 
            buttonLaggTillPodd.Location = new Point(57, 257);
            buttonLaggTillPodd.Margin = new Padding(2, 2, 2, 2);
            buttonLaggTillPodd.Name = "buttonLaggTillPodd";
            buttonLaggTillPodd.Size = new Size(115, 36);
            buttonLaggTillPodd.TabIndex = 10;
            buttonLaggTillPodd.Text = "Lägg till";
            buttonLaggTillPodd.UseVisualStyleBackColor = true;
            // 
            // buttonTaBortPodd
            // 
            buttonTaBortPodd.Location = new Point(336, 257);
            buttonTaBortPodd.Margin = new Padding(2, 2, 2, 2);
            buttonTaBortPodd.Name = "buttonTaBortPodd";
            buttonTaBortPodd.Size = new Size(115, 36);
            buttonTaBortPodd.TabIndex = 11;
            buttonTaBortPodd.Text = "Ta bort";
            buttonTaBortPodd.UseVisualStyleBackColor = true;
            buttonTaBortPodd.Click += buttonTaBortPodd_Click;
            // 
            // buttonAndraPodd
            // 
            buttonAndraPodd.Location = new Point(194, 257);
            buttonAndraPodd.Margin = new Padding(2, 2, 2, 2);
            buttonAndraPodd.Name = "buttonAndraPodd";
            buttonAndraPodd.Size = new Size(115, 36);
            buttonAndraPodd.TabIndex = 12;
            buttonAndraPodd.Text = "Ändra";
            buttonAndraPodd.UseVisualStyleBackColor = true;
            // 
            // comboBoxValjKategori
            // 
            comboBoxValjKategori.FormattingEnabled = true;
            comboBoxValjKategori.Location = new Point(251, 130);
            comboBoxValjKategori.Margin = new Padding(2, 2, 2, 2);
            comboBoxValjKategori.Name = "comboBoxValjKategori";
            comboBoxValjKategori.Size = new Size(187, 33);
            comboBoxValjKategori.TabIndex = 14;
            // 
            // Kategori
            // 
            Kategori.AutoSize = true;
            Kategori.Location = new Point(251, 95);
            Kategori.Margin = new Padding(2, 0, 2, 0);
            Kategori.Name = "Kategori";
            Kategori.Size = new Size(78, 25);
            Kategori.TabIndex = 16;
            Kategori.Text = "Kategori";
            // 
            // buttonLaggTillKategori
            // 
            buttonLaggTillKategori.Location = new Point(1284, 257);
            buttonLaggTillKategori.Margin = new Padding(2, 2, 2, 2);
            buttonLaggTillKategori.Name = "buttonLaggTillKategori";
            buttonLaggTillKategori.Size = new Size(115, 36);
            buttonLaggTillKategori.TabIndex = 17;
            buttonLaggTillKategori.Text = "Lägg till";
            buttonLaggTillKategori.UseVisualStyleBackColor = true;
            // 
            // richTextBoxBeskrivning
            // 
            richTextBoxBeskrivning.Location = new Point(958, 491);
            richTextBoxBeskrivning.Margin = new Padding(2, 2, 2, 2);
            richTextBoxBeskrivning.Name = "richTextBoxBeskrivning";
            richTextBoxBeskrivning.Size = new Size(250, 263);
            richTextBoxBeskrivning.TabIndex = 18;
            richTextBoxBeskrivning.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(958, 452);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 19;
            label3.Text = "Beskrivning";
            // 
            // buttonAndraKategori
            // 
            buttonAndraKategori.Location = new Point(1404, 257);
            buttonAndraKategori.Margin = new Padding(2, 2, 2, 2);
            buttonAndraKategori.Name = "buttonAndraKategori";
            buttonAndraKategori.Size = new Size(115, 36);
            buttonAndraKategori.TabIndex = 20;
            buttonAndraKategori.Text = "Ändra";
            buttonAndraKategori.UseVisualStyleBackColor = true;
            // 
            // buttonTaBortKategori
            // 
            buttonTaBortKategori.Location = new Point(1524, 257);
            buttonTaBortKategori.Margin = new Padding(2, 2, 2, 2);
            buttonTaBortKategori.Name = "buttonTaBortKategori";
            buttonTaBortKategori.Size = new Size(115, 36);
            buttonTaBortKategori.TabIndex = 21;
            buttonTaBortKategori.Text = "Ta bort";
            buttonTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // textBoxKategori
            // 
            textBoxKategori.Location = new Point(1284, 216);
            textBoxKategori.Margin = new Padding(2, 2, 2, 2);
            textBoxKategori.Name = "textBoxKategori";
            textBoxKategori.Size = new Size(155, 31);
            textBoxKategori.TabIndex = 22;
            // 
            // comboBoxFilterKategori
            // 
            comboBoxFilterKategori.FormattingEnabled = true;
            comboBoxFilterKategori.Location = new Point(485, 130);
            comboBoxFilterKategori.Margin = new Padding(2, 2, 2, 2);
            comboBoxFilterKategori.Name = "comboBoxFilterKategori";
            comboBoxFilterKategori.Size = new Size(187, 33);
            comboBoxFilterKategori.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(485, 95);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 23;
            label4.Text = "Filter";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 809);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
