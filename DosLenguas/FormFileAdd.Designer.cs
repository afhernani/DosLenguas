/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 20/07/2017
 * Hora: 20:59
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace DosLenguas
{
	partial class FormFileAdd
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnOpenfile;
		private System.Windows.Forms.RichTextBox richTextBox;
		private System.Windows.Forms.Button btnNext;
		
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
			this.btnOpenfile = new System.Windows.Forms.Button();
			this.richTextBox = new System.Windows.Forms.RichTextBox();
			this.btnNext = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOpenfile
			// 
			this.btnOpenfile.BackColor = System.Drawing.Color.Khaki;
			this.btnOpenfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpenfile.ForeColor = System.Drawing.Color.Crimson;
			this.btnOpenfile.Location = new System.Drawing.Point(2, 2);
			this.btnOpenfile.Name = "btnOpenfile";
			this.btnOpenfile.Size = new System.Drawing.Size(94, 30);
			this.btnOpenfile.TabIndex = 0;
			this.btnOpenfile.Text = "Open File";
			this.btnOpenfile.UseVisualStyleBackColor = false;
			this.btnOpenfile.Click += new System.EventHandler(this.BtnOpenFileClick);
			// 
			// richTextBox
			// 
			this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox.Location = new System.Drawing.Point(2, 38);
			this.richTextBox.Name = "richTextBox";
			this.richTextBox.Size = new System.Drawing.Size(421, 217);
			this.richTextBox.TabIndex = 1;
			this.richTextBox.Text = "";
			// 
			// btnNext
			// 
			this.btnNext.BackColor = System.Drawing.Color.Khaki;
			this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.ForeColor = System.Drawing.Color.Crimson;
			this.btnNext.Location = new System.Drawing.Point(102, 2);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(67, 30);
			this.btnNext.TabIndex = 2;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.BtnNextClick);
			// 
			// FormFileAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 262);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.richTextBox);
			this.Controls.Add(this.btnOpenfile);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Name = "FormFileAdd";
			this.Text = "FormFileAdd";
			this.ResumeLayout(false);

		}
	}
}
