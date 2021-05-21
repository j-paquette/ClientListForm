﻿
namespace ClientListForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lv_Library = new System.Windows.Forms.ListView();
            this.ch_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_targetAudience = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_language = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_format = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_available = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_publishDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_UpdatedValue = new System.Windows.Forms.Label();
            this.lbl_Updated = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Controls.Add(this.lv_Library, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.3755F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.62451F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 313);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lv_Library
            // 
            this.lv_Library.AllowColumnReorder = true;
            this.lv_Library.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_title,
            this.ch_author,
            this.ch_targetAudience,
            this.ch_language,
            this.ch_format,
            this.ch_subject,
            this.ch_available,
            this.ch_publishDate});
            this.lv_Library.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Library.FullRowSelect = true;
            this.lv_Library.GridLines = true;
            this.lv_Library.HideSelection = false;
            this.lv_Library.Location = new System.Drawing.Point(3, 2);
            this.lv_Library.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_Library.MultiSelect = false;
            this.lv_Library.Name = "lv_Library";
            this.lv_Library.Size = new System.Drawing.Size(687, 263);
            this.lv_Library.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_Library.TabIndex = 0;
            this.lv_Library.UseCompatibleStateImageBehavior = false;
            this.lv_Library.View = System.Windows.Forms.View.Details;
            this.lv_Library.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ch_title
            // 
            this.ch_title.Text = "Title";
            // 
            // ch_author
            // 
            this.ch_author.Text = "Author";
            // 
            // ch_targetAudience
            // 
            this.ch_targetAudience.Text = "TargetAudience";
            // 
            // ch_language
            // 
            this.ch_language.Text = "Language";
            // 
            // ch_format
            // 
            this.ch_format.Text = "Format";
            // 
            // ch_subject
            // 
            this.ch_subject.Text = "Subject";
            // 
            // ch_available
            // 
            this.ch_available.Text = "Available";
            // 
            // ch_publishDate
            // 
            this.ch_publishDate.Text = "Published Date";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_display);
            this.flowLayoutPanel1.Controls.Add(this.btn_close);
            this.flowLayoutPanel1.Controls.Add(this.lbl_Updated);
            this.flowLayoutPanel1.Controls.Add(this.lbl_UpdatedValue);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 281);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(687, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btn_display
            // 
            this.btn_display.AutoSize = true;
            this.btn_display.Location = new System.Drawing.Point(3, 2);
            this.btn_display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(64, 28);
            this.btn_display.TabIndex = 5;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.Location = new System.Drawing.Point(73, 2);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(62, 28);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // lbl_UpdatedValue
            // 
            this.lbl_UpdatedValue.AutoSize = true;
            this.lbl_UpdatedValue.Location = new System.Drawing.Point(213, 0);
            this.lbl_UpdatedValue.Name = "lbl_UpdatedValue";
            this.lbl_UpdatedValue.Size = new System.Drawing.Size(31, 17);
            this.lbl_UpdatedValue.TabIndex = 2;
            this.lbl_UpdatedValue.Text = "N/A";
            // 
            // lbl_Updated
            // 
            this.lbl_Updated.AutoSize = true;
            this.lbl_Updated.Location = new System.Drawing.Point(141, 0);
            this.lbl_Updated.Name = "lbl_Updated";
            this.lbl_Updated.Size = new System.Drawing.Size(66, 17);
            this.lbl_Updated.TabIndex = 3;
            this.lbl_Updated.Text = "Updated:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 313);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "ListViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lv_Library;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ColumnHeader ch_title;
        private System.Windows.Forms.ColumnHeader ch_author;
        private System.Windows.Forms.ColumnHeader ch_targetAudience;
        private System.Windows.Forms.ColumnHeader ch_language;
        private System.Windows.Forms.ColumnHeader ch_format;
        private System.Windows.Forms.ColumnHeader ch_subject;
        private System.Windows.Forms.ColumnHeader ch_available;
        private System.Windows.Forms.ColumnHeader ch_publishDate;
        private System.Windows.Forms.Label lbl_Updated;
        private System.Windows.Forms.Label lbl_UpdatedValue;
    }
}

