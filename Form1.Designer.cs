
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
            this.ch_GetUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_Updated = new System.Windows.Forms.Label();
            this.lbl_UpdatedValue = new System.Windows.Forms.Label();
            this.cbo_Languages = new System.Windows.Forms.ComboBox();
            this.btn_Export = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1133, 313);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.ch_publishDate,
            this.ch_GetUrl});
            this.lv_Library.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Library.FullRowSelect = true;
            this.lv_Library.GridLines = true;
            this.lv_Library.HideSelection = false;
            this.lv_Library.HoverSelection = true;
            this.lv_Library.Location = new System.Drawing.Point(3, 2);
            this.lv_Library.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_Library.MultiSelect = false;
            this.lv_Library.Name = "lv_Library";
            this.lv_Library.Size = new System.Drawing.Size(1127, 263);
            this.lv_Library.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_Library.TabIndex = 0;
            this.lv_Library.UseCompatibleStateImageBehavior = false;
            this.lv_Library.View = System.Windows.Forms.View.Details;
            this.lv_Library.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lv_Library_MouseMove);
            this.lv_Library.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lv_Library_MouseUp);
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
            this.ch_targetAudience.Width = 146;
            // 
            // ch_language
            // 
            this.ch_language.Text = "Language";
            this.ch_language.Width = 148;
            // 
            // ch_format
            // 
            this.ch_format.Text = "Format";
            this.ch_format.Width = 110;
            // 
            // ch_subject
            // 
            this.ch_subject.Text = "Subject";
            this.ch_subject.Width = 112;
            // 
            // ch_available
            // 
            this.ch_available.Text = "Available";
            this.ch_available.Width = 115;
            // 
            // ch_publishDate
            // 
            this.ch_publishDate.Text = "Published Date";
            this.ch_publishDate.Width = 148;
            // 
            // ch_GetUrl
            // 
            this.ch_GetUrl.Text = "Url";
            this.ch_GetUrl.Width = 150;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btn_display);
            this.flowLayoutPanel1.Controls.Add(this.btn_close);
            this.flowLayoutPanel1.Controls.Add(this.lbl_Updated);
            this.flowLayoutPanel1.Controls.Add(this.lbl_UpdatedValue);
            this.flowLayoutPanel1.Controls.Add(this.cbo_Languages);
            this.flowLayoutPanel1.Controls.Add(this.btn_Export);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 269);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1127, 42);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btn_display
            // 
            this.btn_display.AutoSize = true;
            this.btn_display.Location = new System.Drawing.Point(3, 2);
            this.btn_display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(70, 30);
            this.btn_display.TabIndex = 5;
            this.btn_display.Text = "&Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.Location = new System.Drawing.Point(79, 2);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(62, 30);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "&Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // lbl_Updated
            // 
            this.lbl_Updated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Updated.Location = new System.Drawing.Point(147, 2);
            this.lbl_Updated.Name = "lbl_Updated";
            this.lbl_Updated.Size = new System.Drawing.Size(69, 34);
            this.lbl_Updated.TabIndex = 3;
            this.lbl_Updated.Text = "Updated:";
            this.lbl_Updated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_UpdatedValue
            // 
            this.lbl_UpdatedValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_UpdatedValue.AutoSize = true;
            this.lbl_UpdatedValue.Location = new System.Drawing.Point(222, 9);
            this.lbl_UpdatedValue.Name = "lbl_UpdatedValue";
            this.lbl_UpdatedValue.Size = new System.Drawing.Size(31, 17);
            this.lbl_UpdatedValue.TabIndex = 2;
            this.lbl_UpdatedValue.Text = "N/A";
            this.lbl_UpdatedValue.Click += new System.EventHandler(this.lbl_UpdatedValue_Click);
            // 
            // cbo_Languages
            // 
            this.cbo_Languages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Languages.FormattingEnabled = true;
            this.cbo_Languages.Items.AddRange(new object[] {
            "All",
            "English",
            "French",
            "Inuktut"});
            this.cbo_Languages.Location = new System.Drawing.Point(259, 3);
            this.cbo_Languages.Name = "cbo_Languages";
            this.cbo_Languages.Size = new System.Drawing.Size(121, 24);
            this.cbo_Languages.TabIndex = 2;
            this.cbo_Languages.SelectedIndexChanged += new System.EventHandler(this.cbo_Languages_SelectedIndexChanged);
            // 
            // btn_Export
            // 
            this.btn_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Export.Location = new System.Drawing.Point(386, 3);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(80, 30);
            this.btn_Export.TabIndex = 7;
            this.btn_Export.Text = "&Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 313);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "ListViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbo_Languages;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.ColumnHeader ch_GetUrl;
    }
}

