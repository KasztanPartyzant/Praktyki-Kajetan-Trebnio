namespace Praktyki_Kajetan_Trebnio
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
            this.produktyButton = new System.Windows.Forms.Button();
            this.sprzedazButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.licenceStatus = new System.Windows.Forms.Label();
            this.contents = new System.Windows.Forms.TabControl();
            this.produktyTab = new System.Windows.Forms.TabPage();
            this.tableProdukty = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sprzedazTab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.produktTab = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.produktIlosc = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.produktOpis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.produktCenaPromocyjna = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.produktCena = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.produktNazwa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sprzedajTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.licenceTab = new System.Windows.Forms.TabPage();
            this.licence_error = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.licenceKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.contents.SuspendLayout();
            this.produktyTab.SuspendLayout();
            this.sprzedazTab.SuspendLayout();
            this.produktTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produktIlosc)).BeginInit();
            this.sprzedajTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.licenceTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // produktyButton
            // 
            this.produktyButton.Location = new System.Drawing.Point(16, 96);
            this.produktyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.produktyButton.Name = "produktyButton";
            this.produktyButton.Size = new System.Drawing.Size(231, 52);
            this.produktyButton.TabIndex = 1;
            this.produktyButton.Text = "Produkty";
            this.produktyButton.UseVisualStyleBackColor = true;
            this.produktyButton.Click += new System.EventHandler(this.produktyButton_Click);
            // 
            // sprzedazButton
            // 
            this.sprzedazButton.Location = new System.Drawing.Point(16, 156);
            this.sprzedazButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sprzedazButton.Name = "sprzedazButton";
            this.sprzedazButton.Size = new System.Drawing.Size(231, 52);
            this.sprzedazButton.TabIndex = 2;
            this.sprzedazButton.Text = "Sprzedaż";
            this.sprzedazButton.UseVisualStyleBackColor = true;
            this.sprzedazButton.Click += new System.EventHandler(this.sprzedazButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kajetan Trebnio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(582, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "System komunikacji pomiędzy aplikacją destopową a bazą danych na zewętrznym serwe" +
    "rze";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // licenceStatus
            // 
            this.licenceStatus.Location = new System.Drawing.Point(1036, 50);
            this.licenceStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.licenceStatus.Name = "licenceStatus";
            this.licenceStatus.Size = new System.Drawing.Size(253, 16);
            this.licenceStatus.TabIndex = 5;
            this.licenceStatus.Text = "Licencja aktywna";
            this.licenceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.licenceStatus.Click += new System.EventHandler(this.licenceStatus_Click);
            // 
            // contents
            // 
            this.contents.Controls.Add(this.produktyTab);
            this.contents.Controls.Add(this.sprzedazTab);
            this.contents.Controls.Add(this.produktTab);
            this.contents.Controls.Add(this.sprzedajTab);
            this.contents.Controls.Add(this.licenceTab);
            this.contents.Location = new System.Drawing.Point(255, 96);
            this.contents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contents.Name = "contents";
            this.contents.SelectedIndex = 0;
            this.contents.Size = new System.Drawing.Size(1052, 624);
            this.contents.TabIndex = 6;
            // 
            // produktyTab
            // 
            this.produktyTab.BackColor = System.Drawing.Color.White;
            this.produktyTab.Controls.Add(this.tableProdukty);
            this.produktyTab.Controls.Add(this.label4);
            this.produktyTab.Controls.Add(this.button1);
            this.produktyTab.Location = new System.Drawing.Point(4, 25);
            this.produktyTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.produktyTab.Name = "produktyTab";
            this.produktyTab.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.produktyTab.Size = new System.Drawing.Size(1044, 595);
            this.produktyTab.TabIndex = 0;
            this.produktyTab.Text = "Produkty";
            // 
            // tableProdukty
            // 
            this.tableProdukty.AutoScroll = true;
            this.tableProdukty.AutoSize = true;
            this.tableProdukty.ColumnCount = 7;
            this.tableProdukty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.25532F));
            this.tableProdukty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.74468F));
            this.tableProdukty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 329F));
            this.tableProdukty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableProdukty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableProdukty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableProdukty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableProdukty.Location = new System.Drawing.Point(24, 71);
            this.tableProdukty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableProdukty.Name = "tableProdukty";
            this.tableProdukty.RowCount = 1;
            this.tableProdukty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableProdukty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableProdukty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableProdukty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableProdukty.Size = new System.Drawing.Size(997, 41);
            this.tableProdukty.TabIndex = 2;
            this.tableProdukty.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(17, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "Produkty";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(840, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj nowy produkt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sprzedazTab
            // 
            this.sprzedazTab.BackColor = System.Drawing.Color.White;
            this.sprzedazTab.Controls.Add(this.button2);
            this.sprzedazTab.Controls.Add(this.label5);
            this.sprzedazTab.Location = new System.Drawing.Point(4, 25);
            this.sprzedazTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sprzedazTab.Name = "sprzedazTab";
            this.sprzedazTab.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.sprzedazTab.Size = new System.Drawing.Size(1044, 595);
            this.sprzedazTab.TabIndex = 1;
            this.sprzedazTab.Text = "Sprzedaż";
            this.sprzedazTab.Click += new System.EventHandler(this.sprzedazTab_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(840, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Dodaj sprzedaż";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(17, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sprzedaż";
            // 
            // produktTab
            // 
            this.produktTab.BackColor = System.Drawing.Color.White;
            this.produktTab.Controls.Add(this.button4);
            this.produktTab.Controls.Add(this.produktIlosc);
            this.produktTab.Controls.Add(this.label12);
            this.produktTab.Controls.Add(this.label11);
            this.produktTab.Controls.Add(this.produktOpis);
            this.produktTab.Controls.Add(this.label10);
            this.produktTab.Controls.Add(this.produktCenaPromocyjna);
            this.produktTab.Controls.Add(this.label9);
            this.produktTab.Controls.Add(this.produktCena);
            this.produktTab.Controls.Add(this.label8);
            this.produktTab.Controls.Add(this.produktNazwa);
            this.produktTab.Controls.Add(this.label6);
            this.produktTab.Location = new System.Drawing.Point(4, 25);
            this.produktTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.produktTab.Name = "produktTab";
            this.produktTab.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.produktTab.Size = new System.Drawing.Size(1044, 595);
            this.produktTab.TabIndex = 2;
            this.produktTab.Text = "Nowy produkt";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(548, 455);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 55);
            this.button4.TabIndex = 22;
            this.button4.Text = "Dodaj";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // produktIlosc
            // 
            this.produktIlosc.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.produktIlosc.Location = new System.Drawing.Point(365, 193);
            this.produktIlosc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.produktIlosc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.produktIlosc.Name = "produktIlosc";
            this.produktIlosc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.produktIlosc.Size = new System.Drawing.Size(135, 40);
            this.produktIlosc.TabIndex = 18;
            this.produktIlosc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.produktIlosc.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 171);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Ilość";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 278);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Opis produktu";
            // 
            // produktOpis
            // 
            this.produktOpis.Location = new System.Drawing.Point(24, 304);
            this.produktOpis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.produktOpis.Multiline = true;
            this.produktOpis.Name = "produktOpis";
            this.produktOpis.Size = new System.Drawing.Size(475, 206);
            this.produktOpis.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(187, 171);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Cena promocyjna";
            // 
            // produktCenaPromocyjna
            // 
            this.produktCenaPromocyjna.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.produktCenaPromocyjna.Location = new System.Drawing.Point(191, 193);
            this.produktCenaPromocyjna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.produktCenaPromocyjna.Name = "produktCenaPromocyjna";
            this.produktCenaPromocyjna.Size = new System.Drawing.Size(133, 40);
            this.produktCenaPromocyjna.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 171);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cena";
            // 
            // produktCena
            // 
            this.produktCena.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.produktCena.Location = new System.Drawing.Point(24, 194);
            this.produktCena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.produktCena.Name = "produktCena";
            this.produktCena.Size = new System.Drawing.Size(133, 40);
            this.produktCena.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nazwa produktu";
            // 
            // produktNazwa
            // 
            this.produktNazwa.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produktNazwa.Location = new System.Drawing.Point(24, 95);
            this.produktNazwa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.produktNazwa.Name = "produktNazwa";
            this.produktNazwa.Size = new System.Drawing.Size(475, 40);
            this.produktNazwa.TabIndex = 8;
            this.produktNazwa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(17, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 33);
            this.label6.TabIndex = 7;
            this.label6.Text = "Dodaj nowy produkt";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // sprzedajTab
            // 
            this.sprzedajTab.BackColor = System.Drawing.Color.White;
            this.sprzedajTab.Controls.Add(this.button3);
            this.sprzedajTab.Controls.Add(this.label14);
            this.sprzedajTab.Controls.Add(this.numericUpDown1);
            this.sprzedajTab.Controls.Add(this.label13);
            this.sprzedajTab.Controls.Add(this.listBox1);
            this.sprzedajTab.Controls.Add(this.label7);
            this.sprzedajTab.Location = new System.Drawing.Point(4, 25);
            this.sprzedajTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sprzedajTab.Name = "sprzedajTab";
            this.sprzedajTab.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.sprzedajTab.Size = new System.Drawing.Size(1044, 595);
            this.sprzedajTab.TabIndex = 3;
            this.sprzedajTab.Text = "Sprzedaj produkt";
            this.sprzedajTab.Click += new System.EventHandler(this.sprzedajTab_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(465, 492);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 55);
            this.button3.TabIndex = 21;
            this.button3.Text = "Sprzedaj";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(461, 69);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Ilość";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.numericUpDown1.Location = new System.Drawing.Point(465, 95);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown1.Size = new System.Drawing.Size(171, 40);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 69);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Wybierz produkt";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Produkt 1 (ID: 1)",
            "Produkt 2 (ID: 2)"});
            this.listBox1.Location = new System.Drawing.Point(24, 95);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(397, 452);
            this.listBox1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(17, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 33);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sprzedaj produkt";
            // 
            // licenceTab
            // 
            this.licenceTab.Controls.Add(this.licence_error);
            this.licenceTab.Controls.Add(this.button6);
            this.licenceTab.Controls.Add(this.licenceKey);
            this.licenceTab.Controls.Add(this.label3);
            this.licenceTab.Location = new System.Drawing.Point(4, 25);
            this.licenceTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.licenceTab.Name = "licenceTab";
            this.licenceTab.Size = new System.Drawing.Size(1044, 595);
            this.licenceTab.TabIndex = 4;
            this.licenceTab.Text = "Licencja";
            this.licenceTab.UseVisualStyleBackColor = true;
            // 
            // licence_error
            // 
            this.licence_error.AutoSize = true;
            this.licence_error.Location = new System.Drawing.Point(27, 102);
            this.licence_error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.licence_error.Name = "licence_error";
            this.licence_error.Size = new System.Drawing.Size(0, 17);
            this.licence_error.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(27, 137);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 44);
            this.button6.TabIndex = 2;
            this.button6.Text = "Sprawdź klucz";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // licenceKey
            // 
            this.licenceKey.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.licenceKey.Location = new System.Drawing.Point(27, 55);
            this.licenceKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.licenceKey.Name = "licenceKey";
            this.licenceKey.Size = new System.Drawing.Size(548, 36);
            this.licenceKey.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Wprowadź numer seryjny aplikacji:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 218);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(231, 52);
            this.button5.TabIndex = 7;
            this.button5.Text = "Licencja";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 703);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.contents);
            this.Controls.Add(this.licenceStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sprzedazButton);
            this.Controls.Add(this.produktyButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1321, 750);
            this.MinimumSize = new System.Drawing.Size(1321, 750);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contents.ResumeLayout(false);
            this.produktyTab.ResumeLayout(false);
            this.produktyTab.PerformLayout();
            this.sprzedazTab.ResumeLayout(false);
            this.sprzedazTab.PerformLayout();
            this.produktTab.ResumeLayout(false);
            this.produktTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produktIlosc)).EndInit();
            this.sprzedajTab.ResumeLayout(false);
            this.sprzedajTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.licenceTab.ResumeLayout(false);
            this.licenceTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button produktyButton;
        private System.Windows.Forms.Button sprzedazButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label licenceStatus;
        private System.Windows.Forms.TabControl contents;
        private System.Windows.Forms.TabPage produktyTab;
        private System.Windows.Forms.TabPage sprzedazTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage produktTab;
        private System.Windows.Forms.TabPage sprzedajTab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox produktNazwa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox produktOpis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox produktCenaPromocyjna;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox produktCena;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown produktIlosc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableProdukty;
        private System.Windows.Forms.TabPage licenceTab;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox licenceKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label licence_error;
    }
}

