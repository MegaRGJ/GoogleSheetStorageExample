namespace GoogleSheetStorageExample
{
    partial class PostcodeNotesApplication
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
            this.FindPostcode = new System.Windows.Forms.Button();
            this.PostcodeToFind = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PostcodeInformationRichBox = new System.Windows.Forms.RichTextBox();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FindPostcode
            // 
            this.FindPostcode.Location = new System.Drawing.Point(12, 86);
            this.FindPostcode.Name = "FindPostcode";
            this.FindPostcode.Size = new System.Drawing.Size(244, 44);
            this.FindPostcode.TabIndex = 0;
            this.FindPostcode.Text = "Find Postcode";
            this.FindPostcode.UseVisualStyleBackColor = true;
            this.FindPostcode.Click += new System.EventHandler(this.FindPostcode_Click);
            // 
            // PostcodeToFind
            // 
            this.PostcodeToFind.AccessibleDescription = "Test";
            this.PostcodeToFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PostcodeToFind.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PostcodeToFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostcodeToFind.Location = new System.Drawing.Point(12, 57);
            this.PostcodeToFind.MaxLength = 7;
            this.PostcodeToFind.Name = "PostcodeToFind";
            this.PostcodeToFind.Size = new System.Drawing.Size(244, 23);
            this.PostcodeToFind.TabIndex = 1;
            this.PostcodeToFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PostcodeToFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PostcodeToFind_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PostcodeInformationRichBox
            // 
            this.PostcodeInformationRichBox.BackColor = System.Drawing.SystemColors.Window;
            this.PostcodeInformationRichBox.Enabled = false;
            this.PostcodeInformationRichBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostcodeInformationRichBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PostcodeInformationRichBox.Location = new System.Drawing.Point(262, 57);
            this.PostcodeInformationRichBox.Name = "PostcodeInformationRichBox";
            this.PostcodeInformationRichBox.Size = new System.Drawing.Size(910, 528);
            this.PostcodeInformationRichBox.TabIndex = 3;
            this.PostcodeInformationRichBox.Text = "";
            this.PostcodeInformationRichBox.EnabledChanged += new System.EventHandler(this.PostcodeInformationRichBox_EnabledChanged);
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(12, 136);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(244, 44);
            this.SaveChanges.TabIndex = 4;
            this.SaveChanges.Text = "Save Changes";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Postcode Note Search";
            // 
            // PostcodeNotesApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1184, 598);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.PostcodeInformationRichBox);
            this.Controls.Add(this.PostcodeToFind);
            this.Controls.Add(this.FindPostcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PostcodeNotesApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postcode Note Search Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindPostcode;
        private System.Windows.Forms.TextBox PostcodeToFind;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox PostcodeInformationRichBox;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Label label1;
    }
}

