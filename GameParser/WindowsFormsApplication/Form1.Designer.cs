namespace WindowsFormsApplication
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajListeZPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszListęDoPlikuXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdrowieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnpkuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wojownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.usunWojownikaButton = new System.Windows.Forms.Button();
            this.edytujWojownikaButton = new System.Windows.Forms.Button();
            this.dodajWojownikaButton = new System.Windows.Forms.Button();
            this.plecCB = new System.Windows.Forms.ComboBox();
            this.zdrowieTB = new System.Windows.Forms.TextBox();
            this.silaTB = new System.Windows.Forms.TextBox();
            this.imieTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sortowanieGB = new System.Windows.Forms.GroupBox();
            this.malejacoRB = new System.Windows.Forms.RadioButton();
            this.rosnacoRB = new System.Windows.Forms.RadioButton();
            this.sortowanieCB = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dodajWojownikaPoWskazanymButton = new System.Windows.Forms.Button();
            this.usunCiezkoRannychButton = new System.Windows.Forms.Button();
            this.plciStarszychButton = new System.Windows.Forms.Button();
            this.imionaWszystkichButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wojownikBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.sortowanieGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajListeZPlikuToolStripMenuItem,
            this.zapiszListęDoPlikuXMLToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wczytajListeZPlikuToolStripMenuItem
            // 
            this.wczytajListeZPlikuToolStripMenuItem.Name = "wczytajListeZPlikuToolStripMenuItem";
            this.wczytajListeZPlikuToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.wczytajListeZPlikuToolStripMenuItem.Text = "Wczytaj liste z pliku XML";
            // 
            // zapiszListęDoPlikuXMLToolStripMenuItem
            // 
            this.zapiszListęDoPlikuXMLToolStripMenuItem.Name = "zapiszListęDoPlikuXMLToolStripMenuItem";
            this.zapiszListęDoPlikuXMLToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.zapiszListęDoPlikuXMLToolStripMenuItem.Text = "Zapisz listę do pliku XML";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plecDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.silaDataGridViewTextBoxColumn,
            this.zdrowieDataGridViewTextBoxColumn,
            this.nnpkuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wojownikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(724, 149);
            this.dataGridView1.TabIndex = 1;
            // 
            // plecDataGridViewTextBoxColumn
            // 
            this.plecDataGridViewTextBoxColumn.DataPropertyName = "Plec";
            this.plecDataGridViewTextBoxColumn.HeaderText = "Plec";
            this.plecDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plecDataGridViewTextBoxColumn.Name = "plecDataGridViewTextBoxColumn";
            this.plecDataGridViewTextBoxColumn.Width = 125;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.Width = 125;
            // 
            // silaDataGridViewTextBoxColumn
            // 
            this.silaDataGridViewTextBoxColumn.DataPropertyName = "Sila";
            this.silaDataGridViewTextBoxColumn.HeaderText = "Sila";
            this.silaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.silaDataGridViewTextBoxColumn.Name = "silaDataGridViewTextBoxColumn";
            this.silaDataGridViewTextBoxColumn.Width = 125;
            // 
            // zdrowieDataGridViewTextBoxColumn
            // 
            this.zdrowieDataGridViewTextBoxColumn.DataPropertyName = "Zdrowie";
            this.zdrowieDataGridViewTextBoxColumn.HeaderText = "Zdrowie";
            this.zdrowieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zdrowieDataGridViewTextBoxColumn.Name = "zdrowieDataGridViewTextBoxColumn";
            this.zdrowieDataGridViewTextBoxColumn.Width = 125;
            // 
            // nnpkuDataGridViewTextBoxColumn
            // 
            this.nnpkuDataGridViewTextBoxColumn.DataPropertyName = "Nnpku";
            this.nnpkuDataGridViewTextBoxColumn.HeaderText = "Nnpku";
            this.nnpkuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nnpkuDataGridViewTextBoxColumn.Name = "nnpkuDataGridViewTextBoxColumn";
            this.nnpkuDataGridViewTextBoxColumn.Width = 125;
            // 
            // wojownikBindingSource
            // 
            this.wojownikBindingSource.DataSource = typeof(WindowsFormsApplication.Wojownik);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 206);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.usunWojownikaButton);
            this.groupBox1.Controls.Add(this.edytujWojownikaButton);
            this.groupBox1.Controls.Add(this.dodajWojownikaButton);
            this.groupBox1.Controls.Add(this.plecCB);
            this.groupBox1.Controls.Add(this.zdrowieTB);
            this.groupBox1.Controls.Add(this.silaTB);
            this.groupBox1.Controls.Add(this.imieTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 239);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(417, 167);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wojownik";
            // 
            // usunWojownikaButton
            // 
            this.usunWojownikaButton.Location = new System.Drawing.Point(265, 129);
            this.usunWojownikaButton.Margin = new System.Windows.Forms.Padding(4);
            this.usunWojownikaButton.Name = "usunWojownikaButton";
            this.usunWojownikaButton.Size = new System.Drawing.Size(100, 28);
            this.usunWojownikaButton.TabIndex = 10;
            this.usunWojownikaButton.Text = "Usuń";
            this.usunWojownikaButton.UseVisualStyleBackColor = true;
            // 
            // edytujWojownikaButton
            // 
            this.edytujWojownikaButton.Location = new System.Drawing.Point(265, 75);
            this.edytujWojownikaButton.Margin = new System.Windows.Forms.Padding(4);
            this.edytujWojownikaButton.Name = "edytujWojownikaButton";
            this.edytujWojownikaButton.Size = new System.Drawing.Size(100, 28);
            this.edytujWojownikaButton.TabIndex = 9;
            this.edytujWojownikaButton.Text = "Aktualizuj";
            this.edytujWojownikaButton.UseVisualStyleBackColor = true;
            // 
            // dodajWojownikaButton
            // 
            this.dodajWojownikaButton.Location = new System.Drawing.Point(265, 23);
            this.dodajWojownikaButton.Margin = new System.Windows.Forms.Padding(4);
            this.dodajWojownikaButton.Name = "dodajWojownikaButton";
            this.dodajWojownikaButton.Size = new System.Drawing.Size(100, 28);
            this.dodajWojownikaButton.TabIndex = 8;
            this.dodajWojownikaButton.Text = "Dodaj";
            this.dodajWojownikaButton.UseVisualStyleBackColor = true;
            // 
            // plecCB
            // 
            this.plecCB.FormattingEnabled = true;
            this.plecCB.Location = new System.Drawing.Point(87, 53);
            this.plecCB.Margin = new System.Windows.Forms.Padding(4);
            this.plecCB.Name = "plecCB";
            this.plecCB.Size = new System.Drawing.Size(132, 24);
            this.plecCB.TabIndex = 7;
            // 
            // zdrowieTB
            // 
            this.zdrowieTB.Location = new System.Drawing.Point(87, 110);
            this.zdrowieTB.Margin = new System.Windows.Forms.Padding(4);
            this.zdrowieTB.Name = "zdrowieTB";
            this.zdrowieTB.Size = new System.Drawing.Size(132, 22);
            this.zdrowieTB.TabIndex = 6;
            // 
            // silaTB
            // 
            this.silaTB.Location = new System.Drawing.Point(87, 84);
            this.silaTB.Margin = new System.Windows.Forms.Padding(4);
            this.silaTB.Name = "silaTB";
            this.silaTB.Size = new System.Drawing.Size(132, 22);
            this.silaTB.TabIndex = 5;
     
            // 
            // imieTB
            // 
            this.imieTB.Location = new System.Drawing.Point(87, 26);
            this.imieTB.Margin = new System.Windows.Forms.Padding(4);
            this.imieTB.Name = "imieTB";
            this.imieTB.Size = new System.Drawing.Size(132, 22);
            this.imieTB.TabIndex = 4;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zdrowie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Siła";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Płeć";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // sortowanieGB
            // 
            this.sortowanieGB.Controls.Add(this.malejacoRB);
            this.sortowanieGB.Controls.Add(this.rosnacoRB);
            this.sortowanieGB.Controls.Add(this.sortowanieCB);
            this.sortowanieGB.Location = new System.Drawing.Point(469, 244);
            this.sortowanieGB.Margin = new System.Windows.Forms.Padding(4);
            this.sortowanieGB.Name = "sortowanieGB";
            this.sortowanieGB.Padding = new System.Windows.Forms.Padding(4);
            this.sortowanieGB.Size = new System.Drawing.Size(277, 129);
            this.sortowanieGB.TabIndex = 4;
            this.sortowanieGB.TabStop = false;
            this.sortowanieGB.Text = "Sortowanie";
            // 
            // malejacoRB
            // 
            this.malejacoRB.AutoSize = true;
            this.malejacoRB.Location = new System.Drawing.Point(124, 57);
            this.malejacoRB.Margin = new System.Windows.Forms.Padding(4);
            this.malejacoRB.Name = "malejacoRB";
            this.malejacoRB.Size = new System.Drawing.Size(85, 21);
            this.malejacoRB.TabIndex = 2;
            this.malejacoRB.TabStop = true;
            this.malejacoRB.Text = "malejąco";
            this.malejacoRB.UseVisualStyleBackColor = true;
            // 
            // rosnacoRB
            // 
            this.rosnacoRB.AutoSize = true;
            this.rosnacoRB.Location = new System.Drawing.Point(25, 57);
            this.rosnacoRB.Margin = new System.Windows.Forms.Padding(4);
            this.rosnacoRB.Name = "rosnacoRB";
            this.rosnacoRB.Size = new System.Drawing.Size(80, 21);
            this.rosnacoRB.TabIndex = 1;
            this.rosnacoRB.TabStop = true;
            this.rosnacoRB.Text = "rosnąco";
            this.rosnacoRB.UseVisualStyleBackColor = true;
            // 
            // sortowanieCB
            // 
            this.sortowanieCB.FormattingEnabled = true;
            this.sortowanieCB.Location = new System.Drawing.Point(25, 23);
            this.sortowanieCB.Margin = new System.Windows.Forms.Padding(4);
            this.sortowanieCB.Name = "sortowanieCB";
            this.sortowanieCB.Size = new System.Drawing.Size(187, 24);
            this.sortowanieCB.TabIndex = 0;

            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dodajWojownikaPoWskazanymButton);
            this.groupBox2.Controls.Add(this.usunCiezkoRannychButton);
            this.groupBox2.Controls.Add(this.plciStarszychButton);
            this.groupBox2.Controls.Add(this.imionaWszystkichButton);
            this.groupBox2.Location = new System.Drawing.Point(44, 414);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(724, 103);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zdarzenia";
            // 
            // dodajWojownikaPoWskazanymButton
            // 
            this.dodajWojownikaPoWskazanymButton.Location = new System.Drawing.Point(465, 55);
            this.dodajWojownikaPoWskazanymButton.Margin = new System.Windows.Forms.Padding(4);
            this.dodajWojownikaPoWskazanymButton.Name = "dodajWojownikaPoWskazanymButton";
            this.dodajWojownikaPoWskazanymButton.Size = new System.Drawing.Size(251, 28);
            this.dodajWojownikaPoWskazanymButton.TabIndex = 3;
            this.dodajWojownikaPoWskazanymButton.Text = "Dodaj wojownka z editboxa";
            this.dodajWojownikaPoWskazanymButton.UseVisualStyleBackColor = true;
            // 
            // usunCiezkoRannychButton
            // 
            this.usunCiezkoRannychButton.Location = new System.Drawing.Point(292, 23);
            this.usunCiezkoRannychButton.Margin = new System.Windows.Forms.Padding(4);
            this.usunCiezkoRannychButton.Name = "usunCiezkoRannychButton";
            this.usunCiezkoRannychButton.Size = new System.Drawing.Size(424, 28);
            this.usunCiezkoRannychButton.TabIndex = 2;
            this.usunCiezkoRannychButton.Text = "Usuń wojownikow o Zdrowiu mniejszym niz w editbox";
            this.usunCiezkoRannychButton.UseVisualStyleBackColor = true;
            // 
            // plciStarszychButton
            // 
            this.plciStarszychButton.Location = new System.Drawing.Point(8, 55);
            this.plciStarszychButton.Margin = new System.Windows.Forms.Padding(4);
            this.plciStarszychButton.Name = "plciStarszychButton";
            this.plciStarszychButton.Size = new System.Drawing.Size(436, 28);
            this.plciStarszychButton.TabIndex = 1;
            this.plciStarszychButton.Text = "Pokaż imiona o danej płci i sile powyżej wartosci z editboxow";
            this.plciStarszychButton.UseVisualStyleBackColor = true;
            // 
            // imionaWszystkichButton
            // 
            this.imionaWszystkichButton.Location = new System.Drawing.Point(8, 23);
            this.imionaWszystkichButton.Margin = new System.Windows.Forms.Padding(4);
            this.imionaWszystkichButton.Name = "imionaWszystkichButton";
            this.imionaWszystkichButton.Size = new System.Drawing.Size(251, 28);
            this.imionaWszystkichButton.TabIndex = 0;
            this.imionaWszystkichButton.Text = "Pokaż imiona czlonkow gildii";
            this.imionaWszystkichButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.sortowanieGB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wojownikBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.sortowanieGB.ResumeLayout(false);
            this.sortowanieGB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajListeZPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszListęDoPlikuXMLToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn silaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdrowieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnpkuDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource wojownikBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button usunWojownikaButton;
        private System.Windows.Forms.Button edytujWojownikaButton;
        private System.Windows.Forms.Button dodajWojownikaButton;
        private System.Windows.Forms.ComboBox plecCB;
        private System.Windows.Forms.TextBox zdrowieTB;
        private System.Windows.Forms.TextBox silaTB;
        private System.Windows.Forms.TextBox imieTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox sortowanieGB;
        private System.Windows.Forms.RadioButton malejacoRB;
        private System.Windows.Forms.RadioButton rosnacoRB;
        private System.Windows.Forms.ComboBox sortowanieCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button usunCiezkoRannychButton;
        private System.Windows.Forms.Button plciStarszychButton;
        private System.Windows.Forms.Button imionaWszystkichButton;
        private System.Windows.Forms.Button dodajWojownikaPoWskazanymButton;
    }
}

