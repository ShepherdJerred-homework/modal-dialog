using System;

namespace modal_dialog
{
    partial class MainForm
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
            this.Outline = new System.Windows.Forms.CheckBox();
            this.Shadow = new System.Windows.Forms.CheckBox();
            this.Gradient = new System.Windows.Forms.CheckBox();
            this.Color = new System.Windows.Forms.ComboBox();
            this.ShapeName = new System.Windows.Forms.TextBox();
            this.Open = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.GroupBox();
            this.Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // Outline
            // 
            this.Outline.AutoSize = true;
            this.Outline.Location = new System.Drawing.Point(7, 22);
            this.Outline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.Shadow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.Gradient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gradient.Name = "Gradient";
            this.Gradient.Size = new System.Drawing.Size(85, 21);
            this.Gradient.TabIndex = 2;
            this.Gradient.Text = "Gradient";
            this.Gradient.UseVisualStyleBackColor = true;
            // 
            // Color
            // 
            this.Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Color.FormattingEnabled = true;
            this.Color.Items.AddRange(new object[] {
            modal_dialog.Color.Red,
            modal_dialog.Color.Blue,
            modal_dialog.Color.Green});
            this.Color.Location = new System.Drawing.Point(119, 16);
            this.Color.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(160, 24);
            this.Color.TabIndex = 3;
            // 
            // ShapeName
            // 
            this.ShapeName.Location = new System.Drawing.Point(287, 18);
            this.ShapeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShapeName.Name = "ShapeName";
            this.ShapeName.Size = new System.Drawing.Size(132, 22);
            this.ShapeName.TabIndex = 4;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(166, 93);
            this.Open.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(100, 28);
            this.Open.TabIndex = 5;
            this.Open.Text = "Edit";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Options
            // 
            this.Options.Controls.Add(this.Outline);
            this.Options.Controls.Add(this.Shadow);
            this.Options.Controls.Add(this.Gradient);
            this.Options.Location = new System.Drawing.Point(12, 12);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(100, 100);
            this.Options.TabIndex = 6;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 133);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.ShapeName);
            this.Controls.Add(this.Color);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Shape Editor";
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Outline;
        private System.Windows.Forms.CheckBox Shadow;
        private System.Windows.Forms.CheckBox Gradient;
        private System.Windows.Forms.ComboBox Color;
        private System.Windows.Forms.TextBox ShapeName;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.GroupBox Options;
    }
}

