namespace Lab13
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
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Usuń = new System.Windows.Forms.Button();
            this.Aktualizuj = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plecCB = new System.Windows.Forms.ComboBox();
            this.potworTB = new System.Windows.Forms.TextBox();
            this.zdrowieTB = new System.Windows.Forms.TextBox();
            this.silaTB = new System.Windows.Forms.TextBox();
            this.imieTB = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajZXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszDoXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.malejacoRB = new System.Windows.Forms.RadioButton();
            this.rosnacoRB = new System.Windows.Forms.RadioButton();
            this.sortowanieCB = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DodajBT = new System.Windows.Forms.Button();
            this.PlecISilaBT = new System.Windows.Forms.Button();
            this.UsunBT = new System.Windows.Forms.Button();
            this.PokazGildieBT = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource9 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView3.DataSource = this.bindingSource8;
            this.dataGridView3.Location = new System.Drawing.Point(12, 50);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(681, 168);
            this.dataGridView3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Usuń);
            this.groupBox1.Controls.Add(this.Aktualizuj);
            this.groupBox1.Controls.Add(this.Dodaj);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.plecCB);
            this.groupBox1.Controls.Add(this.potworTB);
            this.groupBox1.Controls.Add(this.zdrowieTB);
            this.groupBox1.Controls.Add(this.silaTB);
            this.groupBox1.Controls.Add(this.imieTB);
            this.groupBox1.Location = new System.Drawing.Point(29, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "wojownik";
            // 
            // Usuń
            // 
            this.Usuń.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Usuń.Location = new System.Drawing.Point(331, 117);
            this.Usuń.Name = "Usuń";
            this.Usuń.Size = new System.Drawing.Size(75, 23);
            this.Usuń.TabIndex = 12;
            this.Usuń.Text = "usun";
            this.Usuń.UseVisualStyleBackColor = false;
            // 
            // Aktualizuj
            // 
            this.Aktualizuj.Location = new System.Drawing.Point(331, 88);
            this.Aktualizuj.Name = "Aktualizuj";
            this.Aktualizuj.Size = new System.Drawing.Size(75, 23);
            this.Aktualizuj.TabIndex = 11;
            this.Aktualizuj.Text = "aktualizuj";
            this.Aktualizuj.UseVisualStyleBackColor = true;
            // 
            // Dodaj
            // 
            this.Dodaj.BackColor = System.Drawing.Color.Green;
            this.Dodaj.ForeColor = System.Drawing.Color.White;
            this.Dodaj.Location = new System.Drawing.Point(331, 59);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 10;
            this.Dodaj.Text = "dodaj";
            this.Dodaj.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Plec";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Potwor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zdrowie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "imie";
            // 
            // plecCB
            // 
            this.plecCB.FormattingEnabled = true;
            this.plecCB.Location = new System.Drawing.Point(310, 34);
            this.plecCB.Name = "plecCB";
            this.plecCB.Size = new System.Drawing.Size(121, 24);
            this.plecCB.TabIndex = 4;
            // 
            // potworTB
            // 
            this.potworTB.Location = new System.Drawing.Point(73, 118);
            this.potworTB.Name = "potworTB";
            this.potworTB.Size = new System.Drawing.Size(100, 22);
            this.potworTB.TabIndex = 3;
            // 
            // zdrowieTB
            // 
            this.zdrowieTB.Location = new System.Drawing.Point(73, 90);
            this.zdrowieTB.Name = "zdrowieTB";
            this.zdrowieTB.Size = new System.Drawing.Size(100, 22);
            this.zdrowieTB.TabIndex = 2;
            // 
            // silaTB
            // 
            this.silaTB.Location = new System.Drawing.Point(73, 62);
            this.silaTB.Name = "silaTB";
            this.silaTB.Size = new System.Drawing.Size(100, 22);
            this.silaTB.TabIndex = 1;
            // 
            // imieTB
            // 
            this.imieTB.Location = new System.Drawing.Point(73, 34);
            this.imieTB.Name = "imieTB";
            this.imieTB.Size = new System.Drawing.Size(100, 22);
            this.imieTB.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 233);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajZXMLToolStripMenuItem,
            this.zapiszDoXMLToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wczytajZXMLToolStripMenuItem
            // 
            this.wczytajZXMLToolStripMenuItem.Name = "wczytajZXMLToolStripMenuItem";
            this.wczytajZXMLToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.wczytajZXMLToolStripMenuItem.Text = "wczytaj z XML";
            // 
            // zapiszDoXMLToolStripMenuItem
            // 
            this.zapiszDoXMLToolStripMenuItem.Name = "zapiszDoXMLToolStripMenuItem";
            this.zapiszDoXMLToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.zapiszDoXMLToolStripMenuItem.Text = "zapisz do XML";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.malejacoRB);
            this.groupBox2.Controls.Add(this.rosnacoRB);
            this.groupBox2.Controls.Add(this.sortowanieCB);
            this.groupBox2.Location = new System.Drawing.Point(713, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 153);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "sortowanie";
            // 
            // malejacoRB
            // 
            this.malejacoRB.AutoSize = true;
            this.malejacoRB.Location = new System.Drawing.Point(16, 101);
            this.malejacoRB.Name = "malejacoRB";
            this.malejacoRB.Size = new System.Drawing.Size(85, 21);
            this.malejacoRB.TabIndex = 2;
            this.malejacoRB.TabStop = true;
            this.malejacoRB.Text = "malejaco";
            this.malejacoRB.UseVisualStyleBackColor = true;
            // 
            // rosnacoRB
            // 
            this.rosnacoRB.AutoSize = true;
            this.rosnacoRB.Location = new System.Drawing.Point(16, 62);
            this.rosnacoRB.Name = "rosnacoRB";
            this.rosnacoRB.Size = new System.Drawing.Size(80, 21);
            this.rosnacoRB.TabIndex = 1;
            this.rosnacoRB.TabStop = true;
            this.rosnacoRB.Text = "rosnaco";
            this.rosnacoRB.UseVisualStyleBackColor = true;
            // 
            // sortowanieCB
            // 
            this.sortowanieCB.FormattingEnabled = true;
            this.sortowanieCB.Location = new System.Drawing.Point(7, 22);
            this.sortowanieCB.Name = "sortowanieCB";
            this.sortowanieCB.Size = new System.Drawing.Size(121, 24);
            this.sortowanieCB.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DodajBT);
            this.groupBox3.Controls.Add(this.PlecISilaBT);
            this.groupBox3.Controls.Add(this.UsunBT);
            this.groupBox3.Controls.Add(this.PokazGildieBT);
            this.groupBox3.Location = new System.Drawing.Point(523, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 168);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zdarzenia";
            // 
            // DodajBT
            // 
            this.DodajBT.Location = new System.Drawing.Point(17, 139);
            this.DodajBT.Name = "DodajBT";
            this.DodajBT.Size = new System.Drawing.Size(249, 23);
            this.DodajBT.TabIndex = 3;
            this.DodajBT.Text = "Dodaj po wskazanym";
            this.DodajBT.UseVisualStyleBackColor = true;
            // 
            // PlecISilaBT
            // 
            this.PlecISilaBT.Location = new System.Drawing.Point(17, 68);
            this.PlecISilaBT.Name = "PlecISilaBT";
            this.PlecISilaBT.Size = new System.Drawing.Size(241, 23);
            this.PlecISilaBT.TabIndex = 2;
            this.PlecISilaBT.Text = "Plec i sila wieksza od podanej";
            this.PlecISilaBT.UseVisualStyleBackColor = true;
            // 
            // UsunBT
            // 
            this.UsunBT.Location = new System.Drawing.Point(17, 108);
            this.UsunBT.Name = "UsunBT";
            this.UsunBT.Size = new System.Drawing.Size(269, 23);
            this.UsunBT.TabIndex = 1;
            this.UsunBT.Text = "Usun o zdrowiu mniejszym niz podane";
            this.UsunBT.UseVisualStyleBackColor = true;
            // 
            // PokazGildieBT
            // 
            this.PokazGildieBT.Location = new System.Drawing.Point(17, 39);
            this.PokazGildieBT.Name = "PokazGildieBT";
            this.PokazGildieBT.Size = new System.Drawing.Size(153, 23);
            this.PokazGildieBT.TabIndex = 0;
            this.PokazGildieBT.Text = "Pokaż Gildie";
            this.PokazGildieBT.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Plec";
            this.dataGridViewTextBoxColumn6.HeaderText = "Plec";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Imie";
            this.dataGridViewTextBoxColumn7.HeaderText = "Imie";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Sila";
            this.dataGridViewTextBoxColumn8.HeaderText = "Sila";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Zdrowie";
            this.dataGridViewTextBoxColumn9.HeaderText = "Zdrowie";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Potwor";
            this.dataGridViewTextBoxColumn10.HeaderText = "Potwor";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // bindingSource8
            // 
            this.bindingSource8.DataSource = typeof(Lab13.Wojownik);
            // 
            // bindingSource9
            // 
            this.bindingSource9.DataSource = typeof(Lab13.Wojownik);
            // 
            // bindingSource7
            // 
            this.bindingSource7.DataSource = typeof(Lab13.Wojownik);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1018, 506);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn silaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdrowieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potworDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource wojownikBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.BindingSource bindingSource5;
        private System.Windows.Forms.BindingSource bindingSource4;
        private System.Windows.Forms.BindingSource bindingSource6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource7;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource bindingSource8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox plecCB;
        private System.Windows.Forms.TextBox potworTB;
        private System.Windows.Forms.TextBox zdrowieTB;
        private System.Windows.Forms.TextBox silaTB;
        private System.Windows.Forms.TextBox imieTB;
        private System.Windows.Forms.Button Usuń;
        private System.Windows.Forms.Button Aktualizuj;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.BindingSource bindingSource9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajZXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszDoXMLToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox sortowanieCB;
        private System.Windows.Forms.RadioButton malejacoRB;
        private System.Windows.Forms.RadioButton rosnacoRB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button PokazGildieBT;
        private System.Windows.Forms.Button UsunBT;
        private System.Windows.Forms.Button DodajBT;
        private System.Windows.Forms.Button PlecISilaBT;
    }
}

