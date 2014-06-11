namespace Splunk.VisualStudio
{
    partial class ModularInputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VersionTextbox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VisibleInLauncherCheckbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author";
            // 
            // AuthorTextbox
            // 
            this.AuthorTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorTextbox.BackColor = System.Drawing.Color.White;
            this.AuthorTextbox.Location = new System.Drawing.Point(51, 26);
            this.AuthorTextbox.Name = "AuthorTextbox";
            this.AuthorTextbox.Size = new System.Drawing.Size(480, 20);
            this.AuthorTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version";
            // 
            // VersionTextbox
            // 
            this.VersionTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VersionTextbox.Location = new System.Drawing.Point(51, 82);
            this.VersionTextbox.Name = "VersionTextbox";
            this.VersionTextbox.Size = new System.Drawing.Size(78, 20);
            this.VersionTextbox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.Location = new System.Drawing.Point(18, 211);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(476, 211);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.AuthorTextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionTextbox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.VersionTextbox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.VisibleInLauncherCheckbox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 18);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(50);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(204, 121);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 177);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.DescriptionTextbox, 2);
            this.DescriptionTextbox.Location = new System.Drawing.Point(3, 159);
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.Size = new System.Drawing.Size(528, 20);
            this.DescriptionTextbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Location = new System.Drawing.Point(3, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            this.label3.Visible = false;
            // 
            // VisibleInLauncherCheckbox
            // 
            this.VisibleInLauncherCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VisibleInLauncherCheckbox.AutoSize = true;
            this.VisibleInLauncherCheckbox.Location = new System.Drawing.Point(51, 113);
            this.VisibleInLauncherCheckbox.Name = "VisibleInLauncherCheckbox";
            this.VisibleInLauncherCheckbox.Size = new System.Drawing.Size(210, 17);
            this.VisibleInLauncherCheckbox.TabIndex = 7;
            this.VisibleInLauncherCheckbox.Text = "Show modular input in Splunk launcher";
            this.VisibleInLauncherCheckbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.Location = new System.Drawing.Point(49, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(482, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "(This should be your splunk.com user name if you intend to publish this modular i" +
    "nput to SplunkBase.)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Label";
            // 
            // labelTextBox
            // 
            this.labelTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTextBox.Location = new System.Drawing.Point(51, 3);
            this.labelTextBox.Name = "labelTextBox";
            this.labelTextBox.Size = new System.Drawing.Size(194, 20);
            this.labelTextBox.TabIndex = 9;
            // 
            // ModularInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(571, 248);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.MinimumSize = new System.Drawing.Size(587, 286);
            this.Name = "ModularInputForm";
            this.Text = "Modular Input Configuration";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AuthorTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VersionTextbox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox VisibleInLauncherCheckbox;
        private System.Windows.Forms.TextBox DescriptionTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox labelTextBox;
    }
}