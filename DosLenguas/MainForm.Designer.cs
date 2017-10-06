/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 03/07/2017
 * Hora: 23:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace DosLenguas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btStart;
		private System.Windows.Forms.TextBox textIng;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textEsp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnIngles;
		private System.Windows.Forms.Button btnFormFile;
		private System.Windows.Forms.RadioButton rdIng;
		private System.Windows.Forms.RadioButton rdEsp;
		private System.Windows.Forms.RadioButton rdAdd;
		private System.Windows.Forms.Button btnModif;
		private System.Windows.Forms.RichTextBox richTextCom;
		private System.Windows.Forms.Button btnpracticaverbos;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btStart = new System.Windows.Forms.Button();
            this.textIng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textEsp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIngles = new System.Windows.Forms.Button();
            this.btnFormFile = new System.Windows.Forms.Button();
            this.rdIng = new System.Windows.Forms.RadioButton();
            this.rdEsp = new System.Windows.Forms.RadioButton();
            this.rdAdd = new System.Windows.Forms.RadioButton();
            this.btnModif = new System.Windows.Forms.Button();
            this.richTextCom = new System.Windows.Forms.RichTextBox();
            this.btnpracticaverbos = new System.Windows.Forms.Button();
            this.btnPractica = new System.Windows.Forms.Button();
            this.btbPlay = new System.Windows.Forms.Button();
            this.btnAsociar = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.comboBoxFuncion = new System.Windows.Forms.ComboBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btndelate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.Red;
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(361, 237);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(66, 30);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Conectar";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.BtStartClick);
            // 
            // textIng
            // 
            this.textIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIng.Location = new System.Drawing.Point(12, 35);
            this.textIng.Name = "textIng";
            this.textIng.Size = new System.Drawing.Size(292, 24);
            this.textIng.TabIndex = 1;
            this.textIng.TextChanged += new System.EventHandler(this.TextIngTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingles";
            // 
            // textEsp
            // 
            this.textEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEsp.Location = new System.Drawing.Point(12, 85);
            this.textEsp.Name = "textEsp";
            this.textEsp.ReadOnly = true;
            this.textEsp.Size = new System.Drawing.Size(366, 24);
            this.textEsp.TabIndex = 3;
            this.textEsp.TextChanged += new System.EventHandler(this.TextEspTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Español";
            // 
            // btnIngles
            // 
            this.btnIngles.Enabled = false;
            this.btnIngles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngles.Location = new System.Drawing.Point(384, 35);
            this.btnIngles.Name = "btnIngles";
            this.btnIngles.Size = new System.Drawing.Size(43, 24);
            this.btnIngles.TabIndex = 5;
            this.btnIngles.Text = "Add";
            this.btnIngles.UseVisualStyleBackColor = true;
            this.btnIngles.Click += new System.EventHandler(this.BtnInglesClick);
            // 
            // btnFormFile
            // 
            this.btnFormFile.Enabled = false;
            this.btnFormFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormFile.Location = new System.Drawing.Point(384, 84);
            this.btnFormFile.Name = "btnFormFile";
            this.btnFormFile.Size = new System.Drawing.Size(38, 25);
            this.btnFormFile.TabIndex = 6;
            this.btnFormFile.Text = "File";
            this.btnFormFile.UseVisualStyleBackColor = true;
            this.btnFormFile.Click += new System.EventHandler(this.BtnFormFileClick);
            // 
            // rdIng
            // 
            this.rdIng.Checked = true;
            this.rdIng.Location = new System.Drawing.Point(382, 136);
            this.rdIng.Name = "rdIng";
            this.rdIng.Size = new System.Drawing.Size(45, 32);
            this.rdIng.TabIndex = 8;
            this.rdIng.TabStop = true;
            this.rdIng.Text = "Ing";
            this.rdIng.UseVisualStyleBackColor = true;
            this.rdIng.CheckedChanged += new System.EventHandler(this.RdIngCheckedChanged);
            // 
            // rdEsp
            // 
            this.rdEsp.Location = new System.Drawing.Point(382, 165);
            this.rdEsp.Name = "rdEsp";
            this.rdEsp.Size = new System.Drawing.Size(45, 32);
            this.rdEsp.TabIndex = 9;
            this.rdEsp.Text = "Esp";
            this.rdEsp.UseVisualStyleBackColor = true;
            this.rdEsp.CheckedChanged += new System.EventHandler(this.RdEspCheckedChanged);
            // 
            // rdAdd
            // 
            this.rdAdd.Location = new System.Drawing.Point(382, 199);
            this.rdAdd.Name = "rdAdd";
            this.rdAdd.Size = new System.Drawing.Size(45, 32);
            this.rdAdd.TabIndex = 10;
            this.rdAdd.Text = "Add";
            this.rdAdd.UseVisualStyleBackColor = true;
            this.rdAdd.CheckedChanged += new System.EventHandler(this.RdAddCheckedChanged);
            // 
            // btnModif
            // 
            this.btnModif.Enabled = false;
            this.btnModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModif.Location = new System.Drawing.Point(384, 5);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(43, 24);
            this.btnModif.TabIndex = 11;
            this.btnModif.Text = "M";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.BtnModifClick);
            // 
            // richTextCom
            // 
            this.richTextCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextCom.Location = new System.Drawing.Point(12, 119);
            this.richTextCom.Name = "richTextCom";
            this.richTextCom.Size = new System.Drawing.Size(343, 78);
            this.richTextCom.TabIndex = 12;
            this.richTextCom.Text = "";
            // 
            // btnpracticaverbos
            // 
            this.btnpracticaverbos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpracticaverbos.Location = new System.Drawing.Point(65, 5);
            this.btnpracticaverbos.Name = "btnpracticaverbos";
            this.btnpracticaverbos.Size = new System.Drawing.Size(43, 24);
            this.btnpracticaverbos.TabIndex = 13;
            this.btnpracticaverbos.Text = "V";
            this.btnpracticaverbos.UseVisualStyleBackColor = true;
            this.btnpracticaverbos.Click += new System.EventHandler(this.BtnpracticaverbosClick);
            // 
            // btnPractica
            // 
            this.btnPractica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPractica.Location = new System.Drawing.Point(114, 5);
            this.btnPractica.Name = "btnPractica";
            this.btnPractica.Size = new System.Drawing.Size(43, 24);
            this.btnPractica.TabIndex = 14;
            this.btnPractica.Text = "P";
            this.btnPractica.UseVisualStyleBackColor = true;
            this.btnPractica.Click += new System.EventHandler(this.btnPractica_Click);
            // 
            // btbPlay
            // 
            this.btbPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbPlay.Image = ((System.Drawing.Image)(resources.GetObject("btbPlay.Image")));
            this.btbPlay.Location = new System.Drawing.Point(280, 5);
            this.btbPlay.Name = "btbPlay";
            this.btbPlay.Size = new System.Drawing.Size(24, 24);
            this.btbPlay.TabIndex = 15;
            this.btbPlay.UseVisualStyleBackColor = true;
            this.btbPlay.Click += new System.EventHandler(this.btbPlay_Click);
            // 
            // btnAsociar
            // 
            this.btnAsociar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsociar.Image = ((System.Drawing.Image)(resources.GetObject("btnAsociar.Image")));
            this.btnAsociar.Location = new System.Drawing.Point(310, 5);
            this.btnAsociar.Name = "btnAsociar";
            this.btnAsociar.Size = new System.Drawing.Size(24, 24);
            this.btnAsociar.TabIndex = 16;
            this.btnAsociar.UseVisualStyleBackColor = true;
            this.btnAsociar.Click += new System.EventHandler(this.btnAsociar_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(403, 303);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(24, 24);
            this.btnSettings.TabIndex = 17;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // comboBoxFuncion
            // 
            this.comboBoxFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFuncion.FormattingEnabled = true;
            this.comboBoxFuncion.Location = new System.Drawing.Point(309, 33);
            this.comboBoxFuncion.Name = "comboBoxFuncion";
            this.comboBoxFuncion.Size = new System.Drawing.Size(69, 26);
            this.comboBoxFuncion.TabIndex = 18;
            this.comboBoxFuncion.SelectedIndexChanged += new System.EventHandler(this.comboBoxFuncion_SelectedIndexChanged);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(12, 215);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(343, 112);
            this.listBox.TabIndex = 19;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // btndelate
            // 
            this.btndelate.Enabled = false;
            this.btndelate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelate.Image = ((System.Drawing.Image)(resources.GetObject("btndelate.Image")));
            this.btndelate.Location = new System.Drawing.Point(361, 293);
            this.btndelate.Name = "btndelate";
            this.btndelate.Size = new System.Drawing.Size(36, 34);
            this.btndelate.TabIndex = 20;
            this.btndelate.UseVisualStyleBackColor = true;
            this.btndelate.Click += new System.EventHandler(this.btndelate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 346);
            this.Controls.Add(this.btndelate);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.comboBoxFuncion);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnAsociar);
            this.Controls.Add(this.btbPlay);
            this.Controls.Add(this.btnPractica);
            this.Controls.Add(this.btnpracticaverbos);
            this.Controls.Add(this.richTextCom);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.rdAdd);
            this.Controls.Add(this.rdEsp);
            this.Controls.Add(this.rdIng);
            this.Controls.Add(this.btnFormFile);
            this.Controls.Add(this.btnIngles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textEsp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textIng);
            this.Controls.Add(this.btStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DosLenguas";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button btnPractica;
        private System.Windows.Forms.Button btbPlay;
        private System.Windows.Forms.Button btnAsociar;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ComboBox comboBoxFuncion;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btndelate;
    }
}
