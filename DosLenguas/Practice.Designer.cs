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
            this.btnAction = new System.Windows.Forms.Button();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBoxExtrae
            // 
            this.richTextBoxExtrae.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxExtrae.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxExtrae.Name = "richTextBoxExtrae";
            this.richTextBoxExtrae.Size = new System.Drawing.Size(575, 110);
            this.richTextBoxExtrae.TabIndex = 0;
            this.richTextBoxExtrae.Text = "";
            // 
            // btnAction
            // 
            this.btnAction.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.Location = new System.Drawing.Point(260, 171);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(81, 33);
            this.btnAction.TabIndex = 2;
            this.btnAction.Text = "O.K";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // textBoxRes
            // 
            this.textBoxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRes.Location = new System.Drawing.Point(12, 139);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(575, 24);
            this.textBoxRes.TabIndex = 3;
            this.textBoxRes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRes_KeyDown);
            // 
            // Practice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAction;
            this.ClientSize = new System.Drawing.Size(599, 216);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.richTextBoxExtrae);
            this.Name = "Practice";
            this.Text = "Practice";
            this.Load += new System.EventHandler(this.Practice_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Practice_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxExtrae;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox textBoxRes;
    }
}