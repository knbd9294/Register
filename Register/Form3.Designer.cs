namespace Register
{
    partial class Form3
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
            this.bunifuDataViz1 = new Bunifu.DataViz.WinForms.BunifuDataViz();
            this.dateInitial = new System.Windows.Forms.DateTimePicker();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.serviceVisCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuDataViz2 = new Bunifu.DataViz.WinForms.BunifuDataViz();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bunifuDataViz1
            // 
            this.bunifuDataViz1.animationEnabled = false;
            this.bunifuDataViz1.AxisLineColor = System.Drawing.Color.LightGray;
            this.bunifuDataViz1.AxisXFontColor = System.Drawing.Color.Gray;
            this.bunifuDataViz1.AxisXGridColor = System.Drawing.Color.Gray;
            this.bunifuDataViz1.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz1.AxisYFontColor = System.Drawing.Color.Gray;
            this.bunifuDataViz1.AxisYGridColor = System.Drawing.Color.Gray;
            this.bunifuDataViz1.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuDataViz1.Location = new System.Drawing.Point(82, 38);
            this.bunifuDataViz1.Name = "bunifuDataViz1";
            this.bunifuDataViz1.Size = new System.Drawing.Size(1246, 451);
            this.bunifuDataViz1.TabIndex = 78;
            this.bunifuDataViz1.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme1;
            this.bunifuDataViz1.Title = "";
            // 
            // dateInitial
            // 
            this.dateInitial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInitial.Location = new System.Drawing.Point(470, 523);
            this.dateInitial.Name = "dateInitial";
            this.dateInitial.Size = new System.Drawing.Size(125, 22);
            this.dateInitial.TabIndex = 79;
            // 
            // dateFinal
            // 
            this.dateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinal.Location = new System.Drawing.Point(637, 522);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(121, 22);
            this.dateFinal.TabIndex = 80;
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
            "Enseignant(e)",
            "Tout"});
            this.serviceVisCmb.Location = new System.Drawing.Point(223, 523);
            this.serviceVisCmb.Name = "serviceVisCmb";
            this.serviceVisCmb.Size = new System.Drawing.Size(181, 21);
            this.serviceVisCmb.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Service Visite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "de :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "a :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 38);
            this.button1.TabIndex = 85;
            this.button1.Text = "Recherche";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1319, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 40);
            this.label4.TabIndex = 87;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 40);
            this.label5.TabIndex = 88;
            this.label5.Text = "Effectifs";
            // 
            // bunifuDataViz2
            // 
            this.bunifuDataViz2.animationEnabled = false;
            this.bunifuDataViz2.AxisLineColor = System.Drawing.Color.LightGray;
            this.bunifuDataViz2.AxisXFontColor = System.Drawing.Color.Gray;
            this.bunifuDataViz2.AxisXGridColor = System.Drawing.Color.Gray;
            this.bunifuDataViz2.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz2.AxisYFontColor = System.Drawing.Color.Gray;
            this.bunifuDataViz2.AxisYGridColor = System.Drawing.Color.Gray;
            this.bunifuDataViz2.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuDataViz2.Location = new System.Drawing.Point(958, 521);
            this.bunifuDataViz2.Name = "bunifuDataViz2";
            this.bunifuDataViz2.Size = new System.Drawing.Size(456, 331);
            this.bunifuDataViz2.TabIndex = 89;
            this.bunifuDataViz2.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme1;
            this.bunifuDataViz2.Title = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(778, 584);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 38);
            this.button2.TabIndex = 90;
            this.button2.Text = "Recherche Pie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 882);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bunifuDataViz2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serviceVisCmb);
            this.Controls.Add(this.dateFinal);
            this.Controls.Add(this.dateInitial);
            this.Controls.Add(this.bunifuDataViz1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.DataViz.WinForms.BunifuDataViz bunifuDataViz1;
        private System.Windows.Forms.DateTimePicker dateInitial;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.ComboBox serviceVisCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.DataViz.WinForms.BunifuDataViz bunifuDataViz2;
        private System.Windows.Forms.Button button2;
    }
}