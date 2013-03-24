namespace BioFind
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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.open = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clean = new System.Windows.Forms.Button();
            this.showExample = new System.Windows.Forms.Button();
            this.get = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.wordList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // open
            // 
            this.open.Dock = System.Windows.Forms.DockStyle.Left;
            this.open.Location = new System.Drawing.Point(3, 16);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 40);
            this.open.TabIndex = 0;
            this.open.Text = "Open File";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clean);
            this.groupBox1.Controls.Add(this.showExample);
            this.groupBox1.Controls.Add(this.get);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.open);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commands";
            // 
            // clean
            // 
            this.clean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clean.Enabled = false;
            this.clean.Location = new System.Drawing.Point(228, 16);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(150, 40);
            this.clean.TabIndex = 4;
            this.clean.Text = "Clean Up";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // showExample
            // 
            this.showExample.Dock = System.Windows.Forms.DockStyle.Right;
            this.showExample.Location = new System.Drawing.Point(378, 16);
            this.showExample.Name = "showExample";
            this.showExample.Size = new System.Drawing.Size(150, 40);
            this.showExample.TabIndex = 3;
            this.showExample.Text = "Show Format";
            this.showExample.UseVisualStyleBackColor = true;
            this.showExample.Click += new System.EventHandler(this.showExample_Click);
            // 
            // get
            // 
            this.get.Dock = System.Windows.Forms.DockStyle.Left;
            this.get.Enabled = false;
            this.get.Location = new System.Drawing.Point(78, 16);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(150, 40);
            this.get.TabIndex = 2;
            this.get.Text = "Get Data";
            this.get.UseVisualStyleBackColor = true;
            this.get.Click += new System.EventHandler(this.get_Click);
            // 
            // save
            // 
            this.save.Dock = System.Windows.Forms.DockStyle.Right;
            this.save.Enabled = false;
            this.save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.save.Location = new System.Drawing.Point(528, 16);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 40);
            this.save.TabIndex = 1;
            this.save.Text = "Save Data";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // wordList
            // 
            this.wordList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.wordList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.wordList.FullRowSelect = true;
            this.wordList.GridLines = true;
            this.wordList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.wordList.Location = new System.Drawing.Point(0, 59);
            this.wordList.Name = "wordList";
            this.wordList.Size = new System.Drawing.Size(606, 209);
            this.wordList.TabIndex = 2;
            this.wordList.UseCompatibleStateImageBehavior = false;
            this.wordList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Word";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Definition";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 268);
            this.Controls.Add(this.wordList);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "BioFind";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button showExample;
        private System.Windows.Forms.ListView wordList;
        private System.Windows.Forms.Button clean;
    }
}

