namespace Parking
{
    partial class Form1
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
            this.brnInfo = new System.Windows.Forms.Button();
            this.txtIzlaz = new System.Windows.Forms.TextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPoternica = new System.Windows.Forms.Button();
            this.btnPovlascena = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtBrojMesta = new System.Windows.Forms.TextBox();
            this.txtVreme = new System.Windows.Forms.TextBox();
            this.cbmRadnik = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this._Parking_B = new Parking._Parking_B();
            this.parkiranavozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkirana_vozilaTableAdapter = new Parking._Parking_BTableAdapters.Parkirana_vozilaTableAdapter();
            this.registracijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vremeulaskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radnikTableAdapter = new Parking._Parking_BTableAdapters.RadnikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Parking_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkiranavozilaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // brnInfo
            // 
            this.brnInfo.AutoSize = true;
            this.brnInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.brnInfo.Location = new System.Drawing.Point(188, 314);
            this.brnInfo.Name = "brnInfo";
            this.brnInfo.Size = new System.Drawing.Size(154, 23);
            this.brnInfo.TabIndex = 39;
            this.brnInfo.Text = "Prikazi informacije o parkingu";
            this.brnInfo.UseVisualStyleBackColor = true;
            this.brnInfo.Click += new System.EventHandler(this.brnInfo_Click_1);
            // 
            // txtIzlaz
            // 
            this.txtIzlaz.Location = new System.Drawing.Point(414, 260);
            this.txtIzlaz.Name = "txtIzlaz";
            this.txtIzlaz.Size = new System.Drawing.Size(129, 20);
            this.txtIzlaz.TabIndex = 38;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(333, 258);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 37;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Izlazak vozila";
            // 
            // rtbIspis
            // 
            this.rtbIspis.Location = new System.Drawing.Point(12, 343);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(533, 181);
            this.rtbIspis.TabIndex = 35;
            this.rtbIspis.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registracijaDataGridViewTextBoxColumn,
            this.vremeulaskaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parkiranavozilaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(551, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 516);
            this.dataGridView1.TabIndex = 34;
            // 
            // btnPoternica
            // 
            this.btnPoternica.AutoSize = true;
            this.btnPoternica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPoternica.Location = new System.Drawing.Point(398, 314);
            this.btnPoternica.Name = "btnPoternica";
            this.btnPoternica.Size = new System.Drawing.Size(147, 23);
            this.btnPoternica.TabIndex = 33;
            this.btnPoternica.Text = "Prikazi vozila sa poternicom";
            this.btnPoternica.UseVisualStyleBackColor = true;
            this.btnPoternica.Click += new System.EventHandler(this.btnPoternica_Click_1);
            // 
            // btnPovlascena
            // 
            this.btnPovlascena.AutoSize = true;
            this.btnPovlascena.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPovlascena.Location = new System.Drawing.Point(12, 314);
            this.btnPovlascena.Name = "btnPovlascena";
            this.btnPovlascena.Size = new System.Drawing.Size(136, 23);
            this.btnPovlascena.TabIndex = 32;
            this.btnPovlascena.Text = "Prikazi povlascena vozila";
            this.btnPovlascena.UseVisualStyleBackColor = true;
            this.btnPovlascena.Click += new System.EventHandler(this.btnPovlascena_Click_1);
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(294, 141);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 31;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Registracija vozila";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Broj slobodnih mesta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Vreme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Dezurni radnik";
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(188, 143);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(100, 20);
            this.txtRegistracija.TabIndex = 25;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(428, 41);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(100, 20);
            this.txtDatum.TabIndex = 24;
            // 
            // txtBrojMesta
            // 
            this.txtBrojMesta.Location = new System.Drawing.Point(12, 96);
            this.txtBrojMesta.Name = "txtBrojMesta";
            this.txtBrojMesta.ReadOnly = true;
            this.txtBrojMesta.Size = new System.Drawing.Size(100, 20);
            this.txtBrojMesta.TabIndex = 23;
            // 
            // txtVreme
            // 
            this.txtVreme.Location = new System.Drawing.Point(428, 11);
            this.txtVreme.Name = "txtVreme";
            this.txtVreme.ReadOnly = true;
            this.txtVreme.Size = new System.Drawing.Size(100, 20);
            this.txtVreme.TabIndex = 22;
            // 
            // cbmRadnik
            // 
            this.cbmRadnik.DataSource = this.radnikBindingSource;
            this.cbmRadnik.DisplayMember = "Ime_Prezime";
            this.cbmRadnik.FormattingEnabled = true;
            this.cbmRadnik.Location = new System.Drawing.Point(12, 26);
            this.cbmRadnik.Name = "cbmRadnik";
            this.cbmRadnik.Size = new System.Drawing.Size(121, 21);
            this.cbmRadnik.TabIndex = 21;
            this.cbmRadnik.ValueMember = "ID Radnika";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // _Parking_B
            // 
            this._Parking_B.DataSetName = "_Parking_B";
            this._Parking_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkiranavozilaBindingSource
            // 
            this.parkiranavozilaBindingSource.DataMember = "Parkirana_vozila";
            this.parkiranavozilaBindingSource.DataSource = this._Parking_B;
            // 
            // parkirana_vozilaTableAdapter
            // 
            this.parkirana_vozilaTableAdapter.ClearBeforeFill = true;
            // 
            // registracijaDataGridViewTextBoxColumn
            // 
            this.registracijaDataGridViewTextBoxColumn.DataPropertyName = "Registracija";
            this.registracijaDataGridViewTextBoxColumn.HeaderText = "Registracija";
            this.registracijaDataGridViewTextBoxColumn.Name = "registracijaDataGridViewTextBoxColumn";
            // 
            // vremeulaskaDataGridViewTextBoxColumn
            // 
            this.vremeulaskaDataGridViewTextBoxColumn.DataPropertyName = "Vreme_ulaska";
            this.vremeulaskaDataGridViewTextBoxColumn.HeaderText = "Vreme_ulaska";
            this.vremeulaskaDataGridViewTextBoxColumn.Name = "vremeulaskaDataGridViewTextBoxColumn";
            // 
            // radnikBindingSource
            // 
            this.radnikBindingSource.DataMember = "Radnik";
            this.radnikBindingSource.DataSource = this._Parking_B;
            // 
            // radnikTableAdapter
            // 
            this.radnikTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 536);
            this.Controls.Add(this.brnInfo);
            this.Controls.Add(this.txtIzlaz);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbIspis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPoternica);
            this.Controls.Add(this.btnPovlascena);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegistracija);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtBrojMesta);
            this.Controls.Add(this.txtVreme);
            this.Controls.Add(this.cbmRadnik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Parking_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkiranavozilaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnInfo;
        private System.Windows.Forms.TextBox txtIzlaz;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbIspis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPoternica;
        private System.Windows.Forms.Button btnPovlascena;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtBrojMesta;
        private System.Windows.Forms.TextBox txtVreme;
        private System.Windows.Forms.ComboBox cbmRadnik;
        private System.Windows.Forms.Timer timer1;
        private _Parking_B _Parking_B;
        private System.Windows.Forms.BindingSource parkiranavozilaBindingSource;
        private _Parking_BTableAdapters.Parkirana_vozilaTableAdapter parkirana_vozilaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn registracijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vremeulaskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource radnikBindingSource;
        private _Parking_BTableAdapters.RadnikTableAdapter radnikTableAdapter;
    }
}

