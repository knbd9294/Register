namespace Registre
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dsafsfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.cni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.motifVis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.qualite = new System.Windows.Forms.TextBox();
            this.serviceVis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.heureEntrer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.heureSortie = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.fingerId = new System.Windows.Forms.TextBox();
            this.qualiteCmb = new System.Windows.Forms.ComboBox();
            this.motifVisCmb = new System.Windows.Forms.ComboBox();
            this.serviceVisCmb = new System.Windows.Forms.ComboBox();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.note = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.critere1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.critereCmb1 = new System.Windows.Forms.ComboBox();
            this.critereCmb2 = new System.Windows.Forms.ComboBox();
            this.critere2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateVal = new System.Windows.Forms.Label();
            this.heureEntVal = new System.Windows.Forms.Label();
            this.cniVal = new System.Windows.Forms.Label();
            this.surnameVal = new System.Windows.Forms.Label();
            this.nameVal = new System.Windows.Forms.Label();
            this.fingerIdVal = new System.Windows.Forms.Label();
            this.serviceVisVal = new System.Windows.Forms.Label();
            this.motifVisVal = new System.Windows.Forms.Label();
            this.qualiteVal = new System.Windows.Forms.Label();
            this.telVal = new System.Windows.Forms.Label();
            this.idVal = new System.Windows.Forms.Label();
            this.heureSortieVal = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.nombreGroupeVal = new System.Windows.Forms.Label();
            this.nombreGroupe = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupe = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(657, 8);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(775, 640);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsafsfToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // dsafsfToolStripMenuItem
            // 
            this.dsafsfToolStripMenuItem.Name = "dsafsfToolStripMenuItem";
            this.dsafsfToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.dsafsfToolStripMenuItem.Text = "Supprimer";
            this.dsafsfToolStripMenuItem.Click += new System.EventHandler(this.dsafsfToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "No";
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(101, 56);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(147, 22);
            this.id.TabIndex = 18;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Date";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(101, 168);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(147, 22);
            this.date.TabIndex = 20;
            this.date.TextChanged += new System.EventHandler(this.date_TextChanged);
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(101, 276);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(147, 22);
            this.surname.TabIndex = 25;
            this.surname.TextChanged += new System.EventHandler(this.surname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nom";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(101, 222);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(147, 22);
            this.name.TabIndex = 22;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // cni
            // 
            this.cni.Location = new System.Drawing.Point(101, 329);
            this.cni.Name = "cni";
            this.cni.Size = new System.Drawing.Size(147, 22);
            this.cni.TabIndex = 27;
            this.cni.TextChanged += new System.EventHandler(this.cni_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "No CNI";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(101, 379);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(147, 22);
            this.tel.TabIndex = 29;
            this.tel.TextChanged += new System.EventHandler(this.tel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "No Tel";
            // 
            // motifVis
            // 
            this.motifVis.Location = new System.Drawing.Point(334, 113);
            this.motifVis.Name = "motifVis";
            this.motifVis.Size = new System.Drawing.Size(148, 22);
            this.motifVis.TabIndex = 33;
            this.motifVis.TextChanged += new System.EventHandler(this.motifVis_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Motif visite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Qualite";
            // 
            // qualite
            // 
            this.qualite.Location = new System.Drawing.Point(334, 57);
            this.qualite.Name = "qualite";
            this.qualite.Size = new System.Drawing.Size(148, 22);
            this.qualite.TabIndex = 30;
            this.qualite.TextChanged += new System.EventHandler(this.qualite_TextChanged);
            // 
            // serviceVis
            // 
            this.serviceVis.Location = new System.Drawing.Point(334, 169);
            this.serviceVis.Name = "serviceVis";
            this.serviceVis.Size = new System.Drawing.Size(148, 22);
            this.serviceVis.TabIndex = 35;
            this.serviceVis.TextChanged += new System.EventHandler(this.serviceVis_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Service visite";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Heure entree";
            // 
            // heureEntrer
            // 
            this.heureEntrer.Location = new System.Drawing.Point(334, 223);
            this.heureEntrer.Name = "heureEntrer";
            this.heureEntrer.Size = new System.Drawing.Size(148, 22);
            this.heureEntrer.TabIndex = 36;
            this.heureEntrer.TextChanged += new System.EventHandler(this.heureEntrer_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Heure sorti";
            // 
            // heureSortie
            // 
            this.heureSortie.Location = new System.Drawing.Point(334, 276);
            this.heureSortie.Name = "heureSortie";
            this.heureSortie.Size = new System.Drawing.Size(148, 22);
            this.heureSortie.TabIndex = 38;
            this.heureSortie.TextChanged += new System.EventHandler(this.heureSortie_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Finger Print Id";
            // 
            // fingerId
            // 
            this.fingerId.Enabled = false;
            this.fingerId.Location = new System.Drawing.Point(101, 112);
            this.fingerId.Name = "fingerId";
            this.fingerId.Size = new System.Drawing.Size(147, 22);
            this.fingerId.TabIndex = 40;
            this.fingerId.TextChanged += new System.EventHandler(this.fingerId_TextChanged);
            // 
            // qualiteCmb
            // 
            this.qualiteCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualiteCmb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualiteCmb.FormattingEnabled = true;
            this.qualiteCmb.Items.AddRange(new object[] {
            "Parent",
            "Enseignant(e)",
            "Frere",
            "Soeur"});
            this.qualiteCmb.Location = new System.Drawing.Point(495, 55);
            this.qualiteCmb.Name = "qualiteCmb";
            this.qualiteCmb.Size = new System.Drawing.Size(132, 21);
            this.qualiteCmb.TabIndex = 62;
            this.qualiteCmb.TextChanged += new System.EventHandler(this.qualiteCmb_TextChanged);
            // 
            // motifVisCmb
            // 
            this.motifVisCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.motifVisCmb.FormattingEnabled = true;
            this.motifVisCmb.Items.AddRange(new object[] {
            "Pension",
            "Inscription",
            "Convocation",
            "Prospection",
            "Ventes",
            "Rendez-vous",
            "Plainte",
            "Seminaire",
            "Depot de dossier",
            "Revendication"});
            this.motifVisCmb.Location = new System.Drawing.Point(495, 112);
            this.motifVisCmb.MaxDropDownItems = 12;
            this.motifVisCmb.Name = "motifVisCmb";
            this.motifVisCmb.Size = new System.Drawing.Size(132, 21);
            this.motifVisCmb.TabIndex = 61;
            this.motifVisCmb.TextChanged += new System.EventHandler(this.motifVisCmb_TextChanged);
            // 
            // serviceVisCmb
            // 
            this.serviceVisCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceVisCmb.FormattingEnabled = true;
            this.serviceVisCmb.Items.AddRange(new object[] {
            "Administration",
            "Proviseur",
            "Chateau d\'eau",
            "Intandant",
            "Surveillant",
            "SGKO",
            "Censeur",
            "Secretariat Proviseur",
            "Surveillant General",
            "Gardien",
            "Enseignant(e)"});
            this.serviceVisCmb.Location = new System.Drawing.Point(495, 167);
            this.serviceVisCmb.Name = "serviceVisCmb";
            this.serviceVisCmb.Size = new System.Drawing.Size(132, 21);
            this.serviceVisCmb.TabIndex = 60;
            this.serviceVisCmb.TextChanged += new System.EventHandler(this.serviceVisCmb_TextChanged);
            // 
            // modifier
            // 
            this.modifier.Enabled = false;
            this.modifier.Location = new System.Drawing.Point(6, 623);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(121, 44);
            this.modifier.TabIndex = 63;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.Enabled = false;
            this.supprimer.Location = new System.Drawing.Point(148, 623);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(121, 44);
            this.supprimer.TabIndex = 64;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(334, 444);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(221, 128);
            this.note.TabIndex = 65;
            this.note.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(274, 444);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 66;
            this.label12.Text = "note";
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Location = new System.Drawing.Point(744, 675);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(144, 22);
            this.total.TabIndex = 67;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(741, 654);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 13);
            this.label14.TabIndex = 68;
            this.label14.Text = "Total Enregistrement";
            // 
            // critere1
            // 
            this.critere1.Location = new System.Drawing.Point(952, 675);
            this.critere1.Name = "critere1";
            this.critere1.Size = new System.Drawing.Size(144, 22);
            this.critere1.TabIndex = 69;
            this.critere1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.critere1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(745, 713);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 31);
            this.button1.TabIndex = 70;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // critereCmb1
            // 
            this.critereCmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.critereCmb1.FormattingEnabled = true;
            this.critereCmb1.Items.AddRange(new object[] {
            "Date",
            "Id",
            "Cni",
            "Nom"});
            this.critereCmb1.Location = new System.Drawing.Point(952, 719);
            this.critereCmb1.Name = "critereCmb1";
            this.critereCmb1.Size = new System.Drawing.Size(144, 21);
            this.critereCmb1.TabIndex = 71;
            this.critereCmb1.SelectedIndexChanged += new System.EventHandler(this.critereCmb1_SelectedIndexChanged);
            // 
            // critereCmb2
            // 
            this.critereCmb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.critereCmb2.FormattingEnabled = true;
            this.critereCmb2.Items.AddRange(new object[] {
            "Date",
            "Id",
            "Cni",
            "Nom"});
            this.critereCmb2.Location = new System.Drawing.Point(1118, 719);
            this.critereCmb2.Name = "critereCmb2";
            this.critereCmb2.Size = new System.Drawing.Size(144, 21);
            this.critereCmb2.TabIndex = 73;
            this.critereCmb2.SelectedIndexChanged += new System.EventHandler(this.critereCmb2_SelectedIndexChanged);
            // 
            // critere2
            // 
            this.critere2.Location = new System.Drawing.Point(1118, 675);
            this.critere2.Name = "critere2";
            this.critere2.Size = new System.Drawing.Size(144, 22);
            this.critere2.TabIndex = 72;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(948, 654);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 74;
            this.label15.Text = "critere 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1115, 654);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 75;
            this.label16.Text = "critere 2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(432, 604);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 44);
            this.button2.TabIndex = 76;
            this.button2.Text = "Load Info on Form1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1277, 654);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 79;
            this.label17.Text = "critere 3";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Date",
            "Id",
            "Cni",
            "Nom"});
            this.comboBox1.Location = new System.Drawing.Point(1280, 719);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 78;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1280, 675);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 22);
            this.textBox1.TabIndex = 77;
            // 
            // dateVal
            // 
            this.dateVal.AutoSize = true;
            this.dateVal.BackColor = System.Drawing.Color.Red;
            this.dateVal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateVal.Location = new System.Drawing.Point(98, 193);
            this.dateVal.Name = "dateVal";
            this.dateVal.Size = new System.Drawing.Size(46, 13);
            this.dateVal.TabIndex = 92;
            this.dateVal.Text = "is Empty";
            // 
            // heureEntVal
            // 
            this.heureEntVal.AutoSize = true;
            this.heureEntVal.BackColor = System.Drawing.Color.Red;
            this.heureEntVal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heureEntVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.heureEntVal.Location = new System.Drawing.Point(331, 248);
            this.heureEntVal.Name = "heureEntVal";
            this.heureEntVal.Size = new System.Drawing.Size(46, 13);
            this.heureEntVal.TabIndex = 91;
            this.heureEntVal.Text = "is Empty";
            // 
            // cniVal
            // 
            this.cniVal.AutoSize = true;
            this.cniVal.BackColor = System.Drawing.Color.Red;
            this.cniVal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cniVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cniVal.Location = new System.Drawing.Point(98, 354);
            this.cniVal.Name = "cniVal";
            this.cniVal.Size = new System.Drawing.Size(46, 13);
            this.cniVal.TabIndex = 90;
            this.cniVal.Text = "is Empty";
            // 
            // surnameVal
            // 
            this.surnameVal.AutoSize = true;
            this.surnameVal.BackColor = System.Drawing.Color.Red;
            this.surnameVal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.surnameVal.Location = new System.Drawing.Point(98, 301);
            this.surnameVal.Name = "surnameVal";
            this.surnameVal.Size = new System.Drawing.Size(46, 13);
            this.surnameVal.TabIndex = 89;
            this.surnameVal.Text = "is Empty";
            // 
            // nameVal
            // 
            this.nameVal.AutoSize = true;
            this.nameVal.BackColor = System.Drawing.Color.Red;
            this.nameVal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameVal.Location = new System.Drawing.Point(98, 247);
            this.nameVal.Name = "nameVal";
            this.nameVal.Size = new System.Drawing.Size(46, 13);
            this.nameVal.TabIndex = 88;
            this.nameVal.Text = "is Empty";
            // 
            // fingerIdVal
            // 
            this.fingerIdVal.AutoSize = true;
            this.fingerIdVal.BackColor = System.Drawing.Color.Red;
            this.fingerIdVal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fingerIdVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fingerIdVal.Location = new System.Drawing.Point(98, 137);
            this.fingerIdVal.Name = "fingerIdVal";
            this.fingerIdVal.Size = new System.Drawing.Size(46, 13);
            this.fingerIdVal.TabIndex = 87;
            this.fingerIdVal.Text = "is Empty";
            // 
            // serviceVisVal
            // 
            this.serviceVisVal.AutoSize = true;
            this.serviceVisVal.BackColor = System.Drawing.Color.Red;
            this.serviceVisVal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceVisVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.serviceVisVal.Location = new System.Drawing.Point(331, 194);
            this.serviceVisVal.Name = "serviceVisVal";
            this.serviceVisVal.Size = new System.Drawing.Size(46, 13);
            this.serviceVisVal.TabIndex = 96;
            this.serviceVisVal.Text = "is Empty";
            // 
            // motifVisVal
            // 
            this.motifVisVal.AutoSize = true;
            this.motifVisVal.BackColor = System.Drawing.Color.Red;
            this.motifVisVal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motifVisVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.motifVisVal.Location = new System.Drawing.Point(331, 138);
            this.motifVisVal.Name = "motifVisVal";
            this.motifVisVal.Size = new System.Drawing.Size(46, 13);
            this.motifVisVal.TabIndex = 95;
            this.motifVisVal.Text = "is Empty";
            // 
            // qualiteVal
            // 
            this.qualiteVal.AutoSize = true;
            this.qualiteVal.BackColor = System.Drawing.Color.Red;
            this.qualiteVal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualiteVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.qualiteVal.Location = new System.Drawing.Point(331, 82);
            this.qualiteVal.Name = "qualiteVal";
            this.qualiteVal.Size = new System.Drawing.Size(46, 13);
            this.qualiteVal.TabIndex = 94;
            this.qualiteVal.Text = "is Empty";
            // 
            // telVal
            // 
            this.telVal.AutoSize = true;
            this.telVal.BackColor = System.Drawing.Color.Red;
            this.telVal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.telVal.Location = new System.Drawing.Point(98, 404);
            this.telVal.Name = "telVal";
            this.telVal.Size = new System.Drawing.Size(46, 13);
            this.telVal.TabIndex = 93;
            this.telVal.Text = "is Empty";
            // 
            // idVal
            // 
            this.idVal.AutoSize = true;
            this.idVal.BackColor = System.Drawing.Color.Red;
            this.idVal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idVal.Location = new System.Drawing.Point(98, 82);
            this.idVal.Name = "idVal";
            this.idVal.Size = new System.Drawing.Size(46, 13);
            this.idVal.TabIndex = 97;
            this.idVal.Text = "is Empty";
            // 
            // heureSortieVal
            // 
            this.heureSortieVal.AutoSize = true;
            this.heureSortieVal.BackColor = System.Drawing.Color.Red;
            this.heureSortieVal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heureSortieVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.heureSortieVal.Location = new System.Drawing.Point(331, 301);
            this.heureSortieVal.Name = "heureSortieVal";
            this.heureSortieVal.Size = new System.Drawing.Size(46, 13);
            this.heureSortieVal.TabIndex = 98;
            this.heureSortieVal.Text = "is Empty";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(471, 668);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(121, 42);
            this.button16.TabIndex = 99;
            this.button16.Text = "Statistics Form";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // nombreGroupeVal
            // 
            this.nombreGroupeVal.AutoSize = true;
            this.nombreGroupeVal.BackColor = System.Drawing.Color.Red;
            this.nombreGroupeVal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreGroupeVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nombreGroupeVal.Location = new System.Drawing.Point(331, 404);
            this.nombreGroupeVal.Name = "nombreGroupeVal";
            this.nombreGroupeVal.Size = new System.Drawing.Size(46, 13);
            this.nombreGroupeVal.TabIndex = 104;
            this.nombreGroupeVal.Text = "is Empty";
            this.nombreGroupeVal.Visible = false;
            // 
            // nombreGroupe
            // 
            this.nombreGroupe.Location = new System.Drawing.Point(334, 379);
            this.nombreGroupe.Name = "nombreGroupe";
            this.nombreGroupe.Size = new System.Drawing.Size(174, 22);
            this.nombreGroupe.TabIndex = 103;
            this.nombreGroupe.Text = "1";
            this.nombreGroupe.Visible = false;
            this.nombreGroupe.TextChanged += new System.EventHandler(this.nombreGroupe_TextChanged);
            this.nombreGroupe.VisibleChanged += new System.EventHandler(this.nombreGroupe_VisibleChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(262, 381);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 102;
            this.label18.Text = "Nombre";
            this.label18.Visible = false;
            // 
            // groupe
            // 
            this.groupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupe.FormattingEnabled = true;
            this.groupe.Items.AddRange(new object[] {
            "Non",
            "Oui"});
            this.groupe.Location = new System.Drawing.Point(334, 329);
            this.groupe.Name = "groupe";
            this.groupe.Size = new System.Drawing.Size(64, 21);
            this.groupe.TabIndex = 101;
            this.groupe.SelectedIndexChanged += new System.EventHandler(this.nombreGroupe_VisibleChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(262, 332);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 100;
            this.label19.Text = "Groupe";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 768);
            this.Controls.Add(this.nombreGroupeVal);
            this.Controls.Add(this.nombreGroupe);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupe);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.heureSortieVal);
            this.Controls.Add(this.idVal);
            this.Controls.Add(this.serviceVisVal);
            this.Controls.Add(this.motifVisVal);
            this.Controls.Add(this.qualiteVal);
            this.Controls.Add(this.telVal);
            this.Controls.Add(this.dateVal);
            this.Controls.Add(this.heureEntVal);
            this.Controls.Add(this.cniVal);
            this.Controls.Add(this.surnameVal);
            this.Controls.Add(this.nameVal);
            this.Controls.Add(this.fingerIdVal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.critereCmb2);
            this.Controls.Add(this.critere2);
            this.Controls.Add(this.critereCmb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.critere1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.note);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.qualiteCmb);
            this.Controls.Add(this.motifVisCmb);
            this.Controls.Add(this.serviceVisCmb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.fingerId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.heureSortie);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.heureEntrer);
            this.Controls.Add(this.serviceVis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.motifVis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.qualite);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.Text = "Formulaire Modification";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox cni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox motifVis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox qualite;
        private System.Windows.Forms.TextBox serviceVis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox heureEntrer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox heureSortie;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox fingerId;
        private System.Windows.Forms.ComboBox qualiteCmb;
        private System.Windows.Forms.ComboBox motifVisCmb;
        private System.Windows.Forms.ComboBox serviceVisCmb;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.RichTextBox note;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox critere1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox critereCmb1;
        private System.Windows.Forms.ComboBox critereCmb2;
        private System.Windows.Forms.TextBox critere2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dsafsfToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label dateVal;
        private System.Windows.Forms.Label heureEntVal;
        private System.Windows.Forms.Label cniVal;
        private System.Windows.Forms.Label surnameVal;
        private System.Windows.Forms.Label nameVal;
        private System.Windows.Forms.Label fingerIdVal;
        private System.Windows.Forms.Label serviceVisVal;
        private System.Windows.Forms.Label motifVisVal;
        private System.Windows.Forms.Label qualiteVal;
        private System.Windows.Forms.Label telVal;
        private System.Windows.Forms.Label idVal;
        private System.Windows.Forms.Label heureSortieVal;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label nombreGroupeVal;
        private System.Windows.Forms.TextBox nombreGroupe;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox groupe;
        private System.Windows.Forms.Label label19;
    }
}