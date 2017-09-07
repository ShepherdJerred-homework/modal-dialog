using System;

namespace modal_dialog
{
    partial class ModalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private ModalBus modalBus;

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
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.GroupBox();
            this.Outline = new System.Windows.Forms.CheckBox();
            this.Shadow = new System.Windows.Forms.CheckBox();
            this.Gradient = new System.Windows.Forms.CheckBox();
            this.ShapeName = new System.Windows.Forms.TextBox();
            this.Color = new System.Windows.Forms.ComboBox();
            this.Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(121, 92);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 28);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(229, 92);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 28);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Options
            // 
            this.Options.Controls.Add(this.Outline);
            this.Options.Controls.Add(this.Shadow);
            this.Options.Controls.Add(this.Gradient);
            this.Options.Location = new System.Drawing.Point(13, 16);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(100, 100);
            this.Options.TabIndex = 14;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // Outline
            // 
            this.Outline.AutoSize = true;
            this.Outline.Location = new System.Drawing.Point(7, 22);
            this.Outline.Margin = new System.Windows.Forms.Padding(4);
            this.Outline.Name = "Outline";
            this.Outline.Size = new System.Drawing.Size(75, 21);
            this.Outline.TabIndex = 0;
            this.Outline.Text = "Outline";
            this.Outline.UseVisualStyleBackColor = true;
            // 
            // Shadow
            // 
            this.Shadow.AutoSize = true;
            this.Shadow.Location = new System.Drawing.Point(7, 43);
            this.Shadow.Margin = new System.Windows.Forms.Padding(4);
            this.Shadow.Name = "Shadow";
            this.Shadow.Size = new System.Drawing.Size(80, 21);
            this.Shadow.TabIndex = 1;
            this.Shadow.Text = "Shadow";
            this.Shadow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Shadow.UseVisualStyleBackColor = true;
            // 
            // Gradient
            // 
            this.Gradient.AutoSize = true;
            this.Gradient.Location = new System.Drawing.Point(7, 64);
            this.Gradient.Margin = new System.Windows.Forms.Padding(4);
            this.Gradient.Name = "Gradient";
            this.Gradient.Size = new System.Drawing.Size(85, 21);
            this.Gradient.TabIndex = 2;
            this.Gradient.Text = "Gradient";
            this.Gradient.UseVisualStyleBackColor = true;
            // 
            // ShapeName
            // 
            this.ShapeName.Location = new System.Drawing.Point(288, 22);
            this.ShapeName.Margin = new System.Windows.Forms.Padding(4);
            this.ShapeName.Name = "ShapeName";
            this.ShapeName.Size = new System.Drawing.Size(132, 22);
            this.ShapeName.TabIndex = 13;
            // 
            // Color
            // 
            this.Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Color.FormattingEnabled = true;
            this.Color.Items.AddRange(new object[] {
            modal_dialog.Color.Red,
            modal_dialog.Color.Blue,
            modal_dialog.Color.Green});
            this.Color.Location = new System.Drawing.Point(120, 20);
            this.Color.Margin = new System.Windows.Forms.Padding(4);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(160, 24);
            this.Color.TabIndex = 12;
            // 
            // ModalForm
            // 
            this.AcceptButton = this.Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(432, 133);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.ShapeName);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ModalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Shape";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modal_Load);
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.CheckBox Outline;
        private System.Windows.Forms.CheckBox Shadow;
        private System.Windows.Forms.CheckBox Gradient;
        private System.Windows.Forms.TextBox ShapeName;
        private System.Windows.Forms.ComboBox Color;
    }
}