namespace Lukas_Huvar_zkouska
{
    partial class FormTest
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTest));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otevřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.napovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.ButtonEsc = new System.Windows.Forms.Button();
            this.HelpButt = new System.Windows.Forms.HelpProvider();
            this.ProgBar = new System.Windows.Forms.ProgressBar();
            this.StatBar = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BTtlak = new System.Windows.Forms.Button();
            this.CBBarva = new System.Windows.Forms.ComboBox();
            this.LabBar = new System.Windows.Forms.Label();
            this.TBMesto = new System.Windows.Forms.TextBox();
            this.TBSyt = new System.Windows.Forms.TrackBar();
            this.labSyt = new System.Windows.Forms.Label();
            this.labplus = new System.Windows.Forms.Label();
            this.TBPSC = new System.Windows.Forms.TextBox();
            this.labmes = new System.Windows.Forms.Label();
            this.labPS = new System.Windows.Forms.Label();
            this.CBsvet = new System.Windows.Forms.CheckBox();
            this.CBSTRES = new System.Windows.Forms.CheckBox();
            this.RBFabia = new System.Windows.Forms.RadioButton();
            this.RBOctavia = new System.Windows.Forms.RadioButton();
            this.RBYetti = new System.Windows.Forms.RadioButton();
            this.RBRoomster = new System.Windows.Forms.RadioButton();
            this.GBAuta = new System.Windows.Forms.GroupBox();
            this.PocetKop = new System.Windows.Forms.NumericUpDown();
            this.labKus = new System.Windows.Forms.Label();
            this.labBarva = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.STATBARS = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatPOCETT = new System.Windows.Forms.ToolStripStatusLabel();
            this.STATCAS = new System.Windows.Forms.ToolStripStatusLabel();
            this.labrov = new System.Windows.Forms.Label();
            this.LabVypis = new System.Windows.Forms.Label();
            this.LabMisto = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBSyt)).BeginInit();
            this.GBAuta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PocetKop)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.napovědaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otevřítToolStripMenuItem,
            this.uložitToolStripMenuItem,
            this.konecToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            this.souborToolStripMenuItem.Click += new System.EventHandler(this.souborToolStripMenuItem_Click);
            // 
            // otevřítToolStripMenuItem
            // 
            this.otevřítToolStripMenuItem.Name = "otevřítToolStripMenuItem";
            this.otevřítToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otevřítToolStripMenuItem.Text = "Otevřít";
            this.otevřítToolStripMenuItem.ToolTipText = "Otevre soubor txt";
            this.otevřítToolStripMenuItem.Click += new System.EventHandler(this.otevřítToolStripMenuItem_Click);
            // 
            // uložitToolStripMenuItem
            // 
            this.uložitToolStripMenuItem.Name = "uložitToolStripMenuItem";
            this.uložitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uložitToolStripMenuItem.Text = "Uložit&";
            this.uložitToolStripMenuItem.ToolTipText = "Ulozi soubor txt";
            this.uložitToolStripMenuItem.Click += new System.EventHandler(this.uložitToolStripMenuItem_Click);
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.konecToolStripMenuItem.Text = "Konec";
            this.konecToolStripMenuItem.ToolTipText = "Ukonci program";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click);
            // 
            // napovědaToolStripMenuItem
            // 
            this.napovědaToolStripMenuItem.Name = "napovědaToolStripMenuItem";
            this.napovědaToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.napovědaToolStripMenuItem.Text = "FAQ";
            this.napovědaToolStripMenuItem.Click += new System.EventHandler(this.napovědaToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "NovýText(*.txt)|*.txt";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(580, 217);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(184, 168);
            this.TextBox.TabIndex = 1;
            this.TextBox.Text = "";
            // 
            // ButtonEsc
            // 
            this.HelpButt.SetHelpString(this.ButtonEsc, "HelpButt");
            this.ButtonEsc.Location = new System.Drawing.Point(619, 78);
            this.ButtonEsc.Name = "ButtonEsc";
            this.HelpButt.SetShowHelp(this.ButtonEsc, true);
            this.ButtonEsc.Size = new System.Drawing.Size(135, 50);
            this.ButtonEsc.TabIndex = 2;
            this.ButtonEsc.Text = "konec Programu";
            this.toolTip1.SetToolTip(this.ButtonEsc, "Esc Konec");
            this.ButtonEsc.UseCompatibleTextRendering = true;
            this.ButtonEsc.UseVisualStyleBackColor = true;
            this.ButtonEsc.Click += new System.EventHandler(this.ButtonEsc_Click);
            this.ButtonEsc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ButtonEsc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter);
            // 
            // ProgBar
            // 
            this.ProgBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProgBar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ProgBar.Location = new System.Drawing.Point(59, 234);
            this.ProgBar.Name = "ProgBar";
            this.ProgBar.Size = new System.Drawing.Size(318, 83);
            this.ProgBar.Step = 1;
            this.ProgBar.TabIndex = 4;
            // 
            // StatBar
            // 
            this.StatBar.AutoSize = true;
            this.StatBar.Location = new System.Drawing.Point(182, 335);
            this.StatBar.Name = "StatBar";
            this.StatBar.Size = new System.Drawing.Size(64, 13);
            this.StatBar.TabIndex = 5;
            this.StatBar.Text = "ProgressBar";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Yellow;
            // 
            // BTtlak
            // 
            this.BTtlak.Image = ((System.Drawing.Image)(resources.GetObject("BTtlak.Image")));
            this.BTtlak.Location = new System.Drawing.Point(46, 30);
            this.BTtlak.Name = "BTtlak";
            this.BTtlak.Size = new System.Drawing.Size(113, 42);
            this.BTtlak.TabIndex = 25;
            this.BTtlak.Text = "vypis text do textboxu";
            this.toolTip1.SetToolTip(this.BTtlak, "tlacitko");
            this.BTtlak.UseVisualStyleBackColor = true;
            // 
            // CBBarva
            // 
            this.CBBarva.FormattingEnabled = true;
            this.CBBarva.Items.AddRange(new object[] {
            "modrá",
            "červená",
            "zelená",
            "černá"});
            this.CBBarva.Location = new System.Drawing.Point(462, 169);
            this.CBBarva.Name = "CBBarva";
            this.CBBarva.Size = new System.Drawing.Size(138, 21);
            this.CBBarva.TabIndex = 7;
            this.CBBarva.SelectedIndexChanged += new System.EventHandler(this.CBBarva_SelectedIndexChanged);
            this.CBBarva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CBBarva_KeyPress);
            // 
            // LabBar
            // 
            this.LabBar.AutoSize = true;
            this.LabBar.Location = new System.Drawing.Point(464, 143);
            this.LabBar.Name = "LabBar";
            this.LabBar.Size = new System.Drawing.Size(65, 13);
            this.LabBar.TabIndex = 8;
            this.LabBar.Text = "Barva auta :";
            // 
            // TBMesto
            // 
            this.TBMesto.Location = new System.Drawing.Point(385, 31);
            this.TBMesto.Name = "TBMesto";
            this.TBMesto.Size = new System.Drawing.Size(116, 20);
            this.TBMesto.TabIndex = 9;
            this.TBMesto.TextChanged += new System.EventHandler(this.TBMesto_TextChanged);
            // 
            // TBSyt
            // 
            this.TBSyt.Location = new System.Drawing.Point(49, 379);
            this.TBSyt.Maximum = 100;
            this.TBSyt.Name = "TBSyt";
            this.TBSyt.Size = new System.Drawing.Size(211, 45);
            this.TBSyt.TabIndex = 10;
            this.TBSyt.TickFrequency = 10;
            this.TBSyt.Scroll += new System.EventHandler(this.TBSyt_Scroll);
            // 
            // labSyt
            // 
            this.labSyt.AutoSize = true;
            this.labSyt.Location = new System.Drawing.Point(284, 383);
            this.labSyt.Name = "labSyt";
            this.labSyt.Size = new System.Drawing.Size(83, 13);
            this.labSyt.TabIndex = 11;
            this.labSyt.Text = "v % sytost barvy";
            // 
            // labplus
            // 
            this.labplus.AutoSize = true;
            this.labplus.Location = new System.Drawing.Point(512, 35);
            this.labplus.Name = "labplus";
            this.labplus.Size = new System.Drawing.Size(13, 13);
            this.labplus.TabIndex = 13;
            this.labplus.Text = "+";
            this.labplus.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBPSC
            // 
            this.TBPSC.Location = new System.Drawing.Point(540, 30);
            this.TBPSC.Name = "TBPSC";
            this.TBPSC.Size = new System.Drawing.Size(101, 20);
            this.TBPSC.TabIndex = 14;
            this.TBPSC.TextChanged += new System.EventHandler(this.TBPSC_TextChanged);
            // 
            // labmes
            // 
            this.labmes.AutoSize = true;
            this.labmes.Location = new System.Drawing.Point(396, 8);
            this.labmes.Name = "labmes";
            this.labmes.Size = new System.Drawing.Size(45, 13);
            this.labmes.TabIndex = 15;
            this.labmes.Text = "Mesto : ";
            // 
            // labPS
            // 
            this.labPS.AutoSize = true;
            this.labPS.Location = new System.Drawing.Point(547, 8);
            this.labPS.Name = "labPS";
            this.labPS.Size = new System.Drawing.Size(28, 13);
            this.labPS.TabIndex = 16;
            this.labPS.Text = "PSC";
            // 
            // CBsvet
            // 
            this.CBsvet.AutoSize = true;
            this.CBsvet.Location = new System.Drawing.Point(272, 120);
            this.CBsvet.Name = "CBsvet";
            this.CBsvet.Size = new System.Drawing.Size(76, 17);
            this.CBsvet.TabIndex = 18;
            this.CBsvet.Text = "svetlomety";
            this.CBsvet.UseVisualStyleBackColor = true;
            this.CBsvet.CheckedChanged += new System.EventHandler(this.CBsvet_CheckedChanged);
            // 
            // CBSTRES
            // 
            this.CBSTRES.AutoSize = true;
            this.CBSTRES.Location = new System.Drawing.Point(272, 143);
            this.CBSTRES.Name = "CBSTRES";
            this.CBSTRES.Size = new System.Drawing.Size(84, 17);
            this.CBSTRES.TabIndex = 19;
            this.CBSTRES.Text = "stresni nosic";
            this.CBSTRES.UseVisualStyleBackColor = true;
            this.CBSTRES.CheckedChanged += new System.EventHandler(this.CBSTRES_CheckedChanged);
            // 
            // RBFabia
            // 
            this.RBFabia.AutoSize = true;
            this.RBFabia.Checked = true;
            this.RBFabia.Location = new System.Drawing.Point(32, 31);
            this.RBFabia.Name = "RBFabia";
            this.RBFabia.Size = new System.Drawing.Size(48, 17);
            this.RBFabia.TabIndex = 20;
            this.RBFabia.TabStop = true;
            this.RBFabia.Text = "fabia";
            this.RBFabia.UseVisualStyleBackColor = true;
            this.RBFabia.CheckedChanged += new System.EventHandler(this.RBFabia_CheckedChanged);
            // 
            // RBOctavia
            // 
            this.RBOctavia.AutoSize = true;
            this.RBOctavia.Location = new System.Drawing.Point(32, 54);
            this.RBOctavia.Name = "RBOctavia";
            this.RBOctavia.Size = new System.Drawing.Size(60, 17);
            this.RBOctavia.TabIndex = 21;
            this.RBOctavia.Text = "octavia";
            this.RBOctavia.UseVisualStyleBackColor = true;
            this.RBOctavia.CheckedChanged += new System.EventHandler(this.RBOctavia_CheckedChanged);
            // 
            // RBYetti
            // 
            this.RBYetti.AutoSize = true;
            this.RBYetti.Location = new System.Drawing.Point(32, 77);
            this.RBYetti.Name = "RBYetti";
            this.RBYetti.Size = new System.Drawing.Size(44, 17);
            this.RBYetti.TabIndex = 22;
            this.RBYetti.Text = "yetti";
            this.RBYetti.UseVisualStyleBackColor = true;
            this.RBYetti.CheckedChanged += new System.EventHandler(this.RBYetti_CheckedChanged);
            // 
            // RBRoomster
            // 
            this.RBRoomster.AutoSize = true;
            this.RBRoomster.Location = new System.Drawing.Point(32, 100);
            this.RBRoomster.Name = "RBRoomster";
            this.RBRoomster.Size = new System.Drawing.Size(71, 17);
            this.RBRoomster.TabIndex = 23;
            this.RBRoomster.Text = "roomester";
            this.RBRoomster.UseVisualStyleBackColor = true;
            this.RBRoomster.CheckedChanged += new System.EventHandler(this.RBRoomster_CheckedChanged);
            // 
            // GBAuta
            // 
            this.GBAuta.Controls.Add(this.RBRoomster);
            this.GBAuta.Controls.Add(this.RBYetti);
            this.GBAuta.Controls.Add(this.RBOctavia);
            this.GBAuta.Controls.Add(this.RBFabia);
            this.GBAuta.Location = new System.Drawing.Point(59, 99);
            this.GBAuta.Name = "GBAuta";
            this.GBAuta.Size = new System.Drawing.Size(146, 129);
            this.GBAuta.TabIndex = 24;
            this.GBAuta.TabStop = false;
            this.GBAuta.Text = "Vyberte typ auta";
            // 
            // PocetKop
            // 
            this.PocetKop.Location = new System.Drawing.Point(276, 194);
            this.PocetKop.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.PocetKop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PocetKop.Name = "PocetKop";
            this.PocetKop.Size = new System.Drawing.Size(51, 20);
            this.PocetKop.TabIndex = 28;
            this.PocetKop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PocetKop.ValueChanged += new System.EventHandler(this.PocetKop_ValueChanged);
            // 
            // labKus
            // 
            this.labKus.AutoSize = true;
            this.labKus.Location = new System.Drawing.Point(333, 201);
            this.labKus.Name = "labKus";
            this.labKus.Size = new System.Drawing.Size(105, 13);
            this.labKus.TabIndex = 29;
            this.labKus.Text = "Kolik kusu ? (max. 3)";
            // 
            // labBarva
            // 
            this.labBarva.AutoSize = true;
            this.labBarva.Location = new System.Drawing.Point(391, 86);
            this.labBarva.Name = "labBarva";
            this.labBarva.Size = new System.Drawing.Size(0, 13);
            this.labBarva.TabIndex = 34;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STATBARS,
            this.StatPOCETT,
            this.STATCAS});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // STATBARS
            // 
            this.STATBARS.Name = "STATBARS";
            this.STATBARS.Size = new System.Drawing.Size(67, 17);
            this.STATBARS.Text = "STATUSBAR";
            // 
            // StatPOCETT
            // 
            this.StatPOCETT.Name = "StatPOCETT";
            this.StatPOCETT.Size = new System.Drawing.Size(13, 17);
            this.StatPOCETT.Text = "1";
            // 
            // STATCAS
            // 
            this.STATCAS.Name = "STATCAS";
            this.STATCAS.Size = new System.Drawing.Size(24, 17);
            this.STATCAS.Text = "cas";
            // 
            // labrov
            // 
            this.labrov.AutoSize = true;
            this.labrov.Location = new System.Drawing.Point(655, 30);
            this.labrov.Name = "labrov";
            this.labrov.Size = new System.Drawing.Size(13, 13);
            this.labrov.TabIndex = 36;
            this.labrov.Text = "=";
            // 
            // LabVypis
            // 
            this.LabVypis.AutoSize = true;
            this.LabVypis.Location = new System.Drawing.Point(202, 78);
            this.LabVypis.Name = "LabVypis";
            this.LabVypis.Size = new System.Drawing.Size(29, 13);
            this.LabVypis.TabIndex = 39;
            this.LabVypis.Text = "Auto";
            this.LabVypis.Click += new System.EventHandler(this.LabVypis_Click);
            // 
            // LabMisto
            // 
            this.LabMisto.AutoSize = true;
            this.LabMisto.Location = new System.Drawing.Point(674, 33);
            this.LabMisto.Name = "LabMisto";
            this.LabMisto.Size = new System.Drawing.Size(65, 13);
            this.LabMisto.TabIndex = 40;
            this.LabMisto.Text = "mesto , PSC";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabMisto);
            this.Controls.Add(this.LabVypis);
            this.Controls.Add(this.labrov);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labBarva);
            this.Controls.Add(this.labKus);
            this.Controls.Add(this.PocetKop);
            this.Controls.Add(this.BTtlak);
            this.Controls.Add(this.GBAuta);
            this.Controls.Add(this.CBSTRES);
            this.Controls.Add(this.CBsvet);
            this.Controls.Add(this.labPS);
            this.Controls.Add(this.labmes);
            this.Controls.Add(this.TBPSC);
            this.Controls.Add(this.labplus);
            this.Controls.Add(this.labSyt);
            this.Controls.Add(this.TBSyt);
            this.Controls.Add(this.TBMesto);
            this.Controls.Add(this.LabBar);
            this.Controls.Add(this.CBBarva);
            this.Controls.Add(this.StatBar);
            this.Controls.Add(this.ProgBar);
            this.Controls.Add(this.ButtonEsc);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTest";
            this.Text = "Formular test";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBSyt)).EndInit();
            this.GBAuta.ResumeLayout(false);
            this.GBAuta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PocetKop)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otevřítToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button ButtonEsc;
        private System.Windows.Forms.ToolStripMenuItem napovědaToolStripMenuItem;
        private System.Windows.Forms.HelpProvider HelpButt;
        private System.Windows.Forms.ProgressBar ProgBar;
        private System.Windows.Forms.Label StatBar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox CBBarva;
        private System.Windows.Forms.Label LabBar;
        private System.Windows.Forms.TextBox TBMesto;
        private System.Windows.Forms.TrackBar TBSyt;
        private System.Windows.Forms.Label labSyt;
        private System.Windows.Forms.Label labplus;
        private System.Windows.Forms.TextBox TBPSC;
        private System.Windows.Forms.Label labmes;
        private System.Windows.Forms.Label labPS;
        private System.Windows.Forms.CheckBox CBsvet;
        private System.Windows.Forms.CheckBox CBSTRES;
        private System.Windows.Forms.RadioButton RBFabia;
        private System.Windows.Forms.RadioButton RBOctavia;
        private System.Windows.Forms.RadioButton RBYetti;
        private System.Windows.Forms.RadioButton RBRoomster;
        private System.Windows.Forms.GroupBox GBAuta;
        private System.Windows.Forms.Button BTtlak;
        private System.Windows.Forms.NumericUpDown PocetKop;
        private System.Windows.Forms.Label labKus;
        private System.Windows.Forms.Label labBarva;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel STATBARS;
        private System.Windows.Forms.ToolStripStatusLabel StatPOCETT;
        private System.Windows.Forms.ToolStripStatusLabel STATCAS;
        private System.Windows.Forms.Label labrov;
        private System.Windows.Forms.Label LabVypis;
        private System.Windows.Forms.Label LabMisto;
    }
}

