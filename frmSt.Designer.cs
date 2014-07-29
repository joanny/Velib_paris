namespace Velib
{
    partial class frmSt
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
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.dtVStations = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.infosIndispo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB = new System.Windows.Forms.Label();
            this.NbAttache = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nbPointAttache = new System.Windows.Forms.Label();
            this.Vdisponible = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.Label();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.rdb5 = new System.Windows.Forms.RadioButton();
            this.rdb6 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.rdb15 = new System.Windows.Forms.RadioButton();
            this.rdb16 = new System.Windows.Forms.RadioButton();
            this.rdb17 = new System.Windows.Forms.RadioButton();
            this.rdb18 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.rdb14 = new System.Windows.Forms.RadioButton();
            this.rdb13 = new System.Windows.Forms.RadioButton();
            this.rdb12 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.rdb20 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdb92 = new System.Windows.Forms.RadioButton();
            this.rdb93 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtVStations)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(33, 19);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(31, 17);
            this.rdb1.TabIndex = 0;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "1";
            this.rdb1.UseVisualStyleBackColor = true;
            this.rdb1.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            this.rdb1.Click += new System.EventHandler(this.rdb1_Click);
            // 
            // dtVStations
            // 
            this.dtVStations.AllowUserToAddRows = false;
            this.dtVStations.AllowUserToDeleteRows = false;
            this.dtVStations.AllowUserToOrderColumns = true;
            this.dtVStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVStations.Location = new System.Drawing.Point(21, 378);
            this.dtVStations.Name = "dtVStations";
            this.dtVStations.ReadOnly = true;
            this.dtVStations.Size = new System.Drawing.Size(557, 311);
            this.dtVStations.TabIndex = 1;
            this.dtVStations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtVStations_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.infosIndispo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CB);
            this.groupBox1.Controls.Add(this.NbAttache);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nbPointAttache);
            this.groupBox1.Controls.Add(this.Vdisponible);
            this.groupBox1.Controls.Add(this.adresse);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 134);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disponibilité";
            this.groupBox1.UseCompatibleTextRendering = true;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // infosIndispo
            // 
            this.infosIndispo.AutoSize = true;
            this.infosIndispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infosIndispo.ForeColor = System.Drawing.Color.Red;
            this.infosIndispo.Location = new System.Drawing.Point(117, 46);
            this.infosIndispo.Name = "infosIndispo";
            this.infosIndispo.Size = new System.Drawing.Size(354, 31);
            this.infosIndispo.TabIndex = 10;
            this.infosIndispo.Text = "Informations indisponibles";
            this.infosIndispo.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(7, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 9;
            // 
            // CB
            // 
            this.CB.AutoSize = true;
            this.CB.ForeColor = System.Drawing.Color.Red;
            this.CB.Location = new System.Drawing.Point(450, 77);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(0, 13);
            this.CB.TabIndex = 8;
            // 
            // NbAttache
            // 
            this.NbAttache.AutoSize = true;
            this.NbAttache.ForeColor = System.Drawing.Color.Red;
            this.NbAttache.Location = new System.Drawing.Point(447, 39);
            this.NbAttache.Name = "NbAttache";
            this.NbAttache.Size = new System.Drawing.Size(0, 13);
            this.NbAttache.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Location par carte bancaire :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Point d\'attache  disponible :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre total de point d\'attache :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vélo disponible :";
            // 
            // nbPointAttache
            // 
            this.nbPointAttache.AutoSize = true;
            this.nbPointAttache.ForeColor = System.Drawing.Color.Red;
            this.nbPointAttache.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.nbPointAttache.Location = new System.Drawing.Point(188, 77);
            this.nbPointAttache.Name = "nbPointAttache";
            this.nbPointAttache.Size = new System.Drawing.Size(0, 13);
            this.nbPointAttache.TabIndex = 2;
            // 
            // Vdisponible
            // 
            this.Vdisponible.AutoSize = true;
            this.Vdisponible.ForeColor = System.Drawing.Color.Red;
            this.Vdisponible.Location = new System.Drawing.Point(188, 39);
            this.Vdisponible.Name = "Vdisponible";
            this.Vdisponible.Size = new System.Drawing.Size(0, 13);
            this.Vdisponible.TabIndex = 1;
            // 
            // adresse
            // 
            this.adresse.AutoSize = true;
            this.adresse.Location = new System.Drawing.Point(54, 20);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(0, 13);
            this.adresse.TabIndex = 0;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(33, 42);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(31, 17);
            this.rdb2.TabIndex = 4;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "2";
            this.rdb2.UseVisualStyleBackColor = true;
            this.rdb2.CheckedChanged += new System.EventHandler(this.rdb2_CheckedChanged);
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(33, 65);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(31, 17);
            this.rdb3.TabIndex = 5;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "3";
            this.rdb3.UseVisualStyleBackColor = true;
            this.rdb3.CheckedChanged += new System.EventHandler(this.rdb3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb20);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.rdb12);
            this.groupBox2.Controls.Add(this.rdb13);
            this.groupBox2.Controls.Add(this.rdb14);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.rdb18);
            this.groupBox2.Controls.Add(this.rdb17);
            this.groupBox2.Controls.Add(this.rdb16);
            this.groupBox2.Controls.Add(this.rdb15);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.rdb6);
            this.groupBox2.Controls.Add(this.rdb5);
            this.groupBox2.Controls.Add(this.rdb4);
            this.groupBox2.Controls.Add(this.rdb1);
            this.groupBox2.Controls.Add(this.rdb3);
            this.groupBox2.Controls.Add(this.rdb2);
            this.groupBox2.Location = new System.Drawing.Point(12, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 144);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paris";
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Location = new System.Drawing.Point(33, 89);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(31, 17);
            this.rdb4.TabIndex = 6;
            this.rdb4.TabStop = true;
            this.rdb4.Text = "4";
            this.rdb4.UseVisualStyleBackColor = true;
            this.rdb4.CheckedChanged += new System.EventHandler(this.rdb4_CheckedChanged);
            // 
            // rdb5
            // 
            this.rdb5.AutoSize = true;
            this.rdb5.Location = new System.Drawing.Point(33, 113);
            this.rdb5.Name = "rdb5";
            this.rdb5.Size = new System.Drawing.Size(31, 17);
            this.rdb5.TabIndex = 7;
            this.rdb5.TabStop = true;
            this.rdb5.Text = "5";
            this.rdb5.UseVisualStyleBackColor = true;
            this.rdb5.CheckedChanged += new System.EventHandler(this.rdb5_CheckedChanged);
            // 
            // rdb6
            // 
            this.rdb6.AutoSize = true;
            this.rdb6.Location = new System.Drawing.Point(135, 19);
            this.rdb6.Name = "rdb6";
            this.rdb6.Size = new System.Drawing.Size(31, 17);
            this.rdb6.TabIndex = 8;
            this.rdb6.TabStop = true;
            this.rdb6.Text = "6";
            this.rdb6.UseVisualStyleBackColor = true;
            this.rdb6.CheckedChanged += new System.EventHandler(this.rdb6_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(135, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "7";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(135, 67);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "8";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(135, 91);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "9";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(135, 113);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 17);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "10";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdb15
            // 
            this.rdb15.AutoSize = true;
            this.rdb15.Location = new System.Drawing.Point(212, 113);
            this.rdb15.Name = "rdb15";
            this.rdb15.Size = new System.Drawing.Size(37, 17);
            this.rdb15.TabIndex = 13;
            this.rdb15.TabStop = true;
            this.rdb15.Text = "15";
            this.rdb15.UseVisualStyleBackColor = true;
            this.rdb15.CheckedChanged += new System.EventHandler(this.rdb15_CheckedChanged);
            // 
            // rdb16
            // 
            this.rdb16.AutoSize = true;
            this.rdb16.Location = new System.Drawing.Point(316, 19);
            this.rdb16.Name = "rdb16";
            this.rdb16.Size = new System.Drawing.Size(37, 17);
            this.rdb16.TabIndex = 14;
            this.rdb16.TabStop = true;
            this.rdb16.Text = "16";
            this.rdb16.UseVisualStyleBackColor = true;
            this.rdb16.CheckedChanged += new System.EventHandler(this.rdb16_CheckedChanged);
            // 
            // rdb17
            // 
            this.rdb17.AutoSize = true;
            this.rdb17.Location = new System.Drawing.Point(316, 43);
            this.rdb17.Name = "rdb17";
            this.rdb17.Size = new System.Drawing.Size(37, 17);
            this.rdb17.TabIndex = 15;
            this.rdb17.TabStop = true;
            this.rdb17.Text = "17";
            this.rdb17.UseVisualStyleBackColor = true;
            this.rdb17.CheckedChanged += new System.EventHandler(this.rdb17_CheckedChanged);
            // 
            // rdb18
            // 
            this.rdb18.AutoSize = true;
            this.rdb18.Location = new System.Drawing.Point(316, 66);
            this.rdb18.Name = "rdb18";
            this.rdb18.Size = new System.Drawing.Size(37, 17);
            this.rdb18.TabIndex = 16;
            this.rdb18.TabStop = true;
            this.rdb18.Text = "18";
            this.rdb18.UseVisualStyleBackColor = true;
            this.rdb18.CheckedChanged += new System.EventHandler(this.rdb18_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(316, 91);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(37, 17);
            this.radioButton8.TabIndex = 17;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "19";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // rdb14
            // 
            this.rdb14.AutoSize = true;
            this.rdb14.Location = new System.Drawing.Point(212, 91);
            this.rdb14.Name = "rdb14";
            this.rdb14.Size = new System.Drawing.Size(37, 17);
            this.rdb14.TabIndex = 18;
            this.rdb14.TabStop = true;
            this.rdb14.Text = "14";
            this.rdb14.UseVisualStyleBackColor = true;
            this.rdb14.CheckedChanged += new System.EventHandler(this.rdb14_CheckedChanged);
            // 
            // rdb13
            // 
            this.rdb13.AutoSize = true;
            this.rdb13.Location = new System.Drawing.Point(212, 65);
            this.rdb13.Name = "rdb13";
            this.rdb13.Size = new System.Drawing.Size(37, 17);
            this.rdb13.TabIndex = 19;
            this.rdb13.TabStop = true;
            this.rdb13.Text = "13";
            this.rdb13.UseVisualStyleBackColor = true;
            this.rdb13.CheckedChanged += new System.EventHandler(this.rdb13_CheckedChanged);
            // 
            // rdb12
            // 
            this.rdb12.AutoSize = true;
            this.rdb12.Location = new System.Drawing.Point(212, 43);
            this.rdb12.Name = "rdb12";
            this.rdb12.Size = new System.Drawing.Size(37, 17);
            this.rdb12.TabIndex = 20;
            this.rdb12.TabStop = true;
            this.rdb12.Text = "12";
            this.rdb12.UseVisualStyleBackColor = true;
            this.rdb12.CheckedChanged += new System.EventHandler(this.rdb12_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(212, 20);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(37, 17);
            this.radioButton5.TabIndex = 21;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "11";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rdb20
            // 
            this.rdb20.AutoSize = true;
            this.rdb20.Location = new System.Drawing.Point(316, 113);
            this.rdb20.Name = "rdb20";
            this.rdb20.Size = new System.Drawing.Size(37, 17);
            this.rdb20.TabIndex = 22;
            this.rdb20.TabStop = true;
            this.rdb20.Text = "20";
            this.rdb20.UseVisualStyleBackColor = true;
            this.rdb20.CheckedChanged += new System.EventHandler(this.rdb20_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton9);
            this.groupBox3.Controls.Add(this.rdb93);
            this.groupBox3.Controls.Add(this.rdb92);
            this.groupBox3.Location = new System.Drawing.Point(482, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(87, 144);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Département";
            // 
            // rdb92
            // 
            this.rdb92.AutoSize = true;
            this.rdb92.Location = new System.Drawing.Point(16, 36);
            this.rdb92.Name = "rdb92";
            this.rdb92.Size = new System.Drawing.Size(37, 17);
            this.rdb92.TabIndex = 0;
            this.rdb92.TabStop = true;
            this.rdb92.Text = "92";
            this.rdb92.UseVisualStyleBackColor = true;
            this.rdb92.CheckedChanged += new System.EventHandler(this.rdb92_CheckedChanged);
            // 
            // rdb93
            // 
            this.rdb93.AutoSize = true;
            this.rdb93.Location = new System.Drawing.Point(16, 71);
            this.rdb93.Name = "rdb93";
            this.rdb93.Size = new System.Drawing.Size(37, 17);
            this.rdb93.TabIndex = 1;
            this.rdb93.TabStop = true;
            this.rdb93.Text = "93";
            this.rdb93.UseVisualStyleBackColor = true;
            this.rdb93.CheckedChanged += new System.EventHandler(this.rdb93_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(16, 107);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(37, 17);
            this.radioButton9.TabIndex = 2;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "94";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 342);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 20);
            this.textBox1.TabIndex = 8;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(494, 340);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(75, 23);
            this.find.TabIndex = 9;
            this.find.Text = "Rechercher";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // frmSt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 716);
            this.Controls.Add(this.find);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtVStations);
            this.Name = "frmSt";
            this.Text = "frmSt";
            this.Click += new System.EventHandler(this.frmSt_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dtVStations)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.DataGridView dtVStations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CB;
        private System.Windows.Forms.Label NbAttache;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nbPointAttache;
        private System.Windows.Forms.Label Vdisponible;
        private System.Windows.Forms.Label adresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label infosIndispo;
        private System.Windows.Forms.RadioButton rdb20;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton rdb12;
        private System.Windows.Forms.RadioButton rdb13;
        private System.Windows.Forms.RadioButton rdb14;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton rdb18;
        private System.Windows.Forms.RadioButton rdb17;
        private System.Windows.Forms.RadioButton rdb16;
        private System.Windows.Forms.RadioButton rdb15;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdb6;
        private System.Windows.Forms.RadioButton rdb5;
        private System.Windows.Forms.RadioButton rdb4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton rdb93;
        private System.Windows.Forms.RadioButton rdb92;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button find;

    }
}