namespace DosLenguas
{
    partial class Practice
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
            this.richTextBoxExtrae = new System.Windows.Forms.RichTextBox();
            this.richTextBoxRespuesta = new System.Windows.Forms.RichTextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxExtrae
            // 
            this.richTextBoxExtrae.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxExtrae.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxExtrae.Name = "richTextBoxExtrae";
            this.richTextBoxExtrae.Size = new System.Drawing.Size(366, 82);
            this.richTextBoxExtrae.TabIndex = 0;
            this.richTextBoxExtrae.Text = "";
            // 
            // richTextBoxRespuesta
            // 
            this.richTextBoxRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxRespuesta.Location = new System.Drawing.Point(12, 128);
            this.richTextBoxRespuesta.Name = "richTextBoxRespuesta";
            this.richTextBoxRespuesta.Size = new System.Drawing.Size(366, 104);
            this.richTextBoxRespuesta.TabIndex = 1;
            this.richTextBoxRespuesta.Text = "";
            // 
            // btnAction
            // 
            this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.Location = new System.Drawing.Point(297, 249);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(81, 33);
            this.btnAction.TabIndex = 2;
            this.btnAction.Text = "O.K";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // Practice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAction;
            this.ClientSize = new System.Drawing.Size(390, 294);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.richTextBoxRespuesta);
            this.Controls.Add(this.richTextBoxExtrae);
            this.Name = "Practice";
            this.Text = "Practice";
            this.Load += new System.EventHandler(this.Practice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxExtrae;
        private System.Windows.Forms.RichTextBox richTextBoxRespuesta;
        private System.Windows.Forms.Button btnAction;
    }
}