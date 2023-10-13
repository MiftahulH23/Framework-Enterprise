namespace ToDoList
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
            this.MK = new System.Windows.Forms.Label();
            this.Detail = new System.Windows.Forms.Label();
            this.Deadline = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnMK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDetail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDeadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimeDeadline = new System.Windows.Forms.DateTimePicker();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MK
            // 
            this.MK.AutoSize = true;
            this.MK.Location = new System.Drawing.Point(28, 30);
            this.MK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MK.Name = "MK";
            this.MK.Size = new System.Drawing.Size(63, 13);
            this.MK.TabIndex = 0;
            this.MK.Text = "Mata Kuliah";
            this.MK.Click += new System.EventHandler(this.MK_Click);
            // 
            // Detail
            // 
            this.Detail.AutoSize = true;
            this.Detail.Location = new System.Drawing.Point(28, 73);
            this.Detail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(67, 13);
            this.Detail.TabIndex = 1;
            this.Detail.Text = "Detail Tugas";
            // 
            // Deadline
            // 
            this.Deadline.AutoSize = true;
            this.Deadline.Location = new System.Drawing.Point(28, 110);
            this.Deadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Deadline.Name = "Deadline";
            this.Deadline.Size = new System.Drawing.Size(102, 13);
            this.Deadline.TabIndex = 2;
            this.Deadline.Text = "Batas Pengumpulan";
            this.Deadline.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(172, 30);
            this.txtMK.Margin = new System.Windows.Forms.Padding(2);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(241, 20);
            this.txtMK.TabIndex = 3;
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(172, 73);
            this.txtDetail.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(241, 20);
            this.txtDetail.TabIndex = 4;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(224, 148);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(58, 25);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.tambah_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMK,
            this.columnDetail,
            this.columnDeadline});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 187);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(533, 105);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnMK
            // 
            this.columnMK.Text = "Mata Kuliah";
            this.columnMK.Width = 200;
            // 
            // columnDetail
            // 
            this.columnDetail.Text = "Detail Tugas";
            this.columnDetail.Width = 167;
            // 
            // columnDeadline
            // 
            this.columnDeadline.Text = "Batas Pengumpulan";
            this.columnDeadline.Width = 236;
            // 
            // dateTimeDeadline
            // 
            this.dateTimeDeadline.Location = new System.Drawing.Point(172, 110);
            this.dateTimeDeadline.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeDeadline.Name = "dateTimeDeadline";
            this.dateTimeDeadline.Size = new System.Drawing.Size(241, 20);
            this.dateTimeDeadline.TabIndex = 8;
            this.dateTimeDeadline.Value = new System.DateTime(2023, 10, 13, 22, 56, 21, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(287, 148);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 25);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(353, 148);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(60, 25);
            this.btnHapus.TabIndex = 10;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dateTimeDeadline);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.Deadline);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.MK);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "To Do LIst";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MK;
        private System.Windows.Forms.Label Detail;
        private System.Windows.Forms.Label Deadline;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnMK;
        private System.Windows.Forms.ColumnHeader columnDetail;
        private System.Windows.Forms.ColumnHeader columnDeadline;
        private System.Windows.Forms.DateTimePicker dateTimeDeadline;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
    }
}

