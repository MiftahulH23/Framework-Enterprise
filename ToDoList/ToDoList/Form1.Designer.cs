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
            this.MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MK.Location = new System.Drawing.Point(42, 46);
            this.MK.Name = "MK";
            this.MK.Size = new System.Drawing.Size(103, 20);
            this.MK.TabIndex = 0;
            this.MK.Text = "Mata Kuliah";
            this.MK.Click += new System.EventHandler(this.MK_Click);
            // 
            // Detail
            // 
            this.Detail.AutoSize = true;
            this.Detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detail.Location = new System.Drawing.Point(42, 112);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(110, 20);
            this.Detail.TabIndex = 1;
            this.Detail.Text = "Detail Tugas";
            // 
            // Deadline
            // 
            this.Deadline.AutoSize = true;
            this.Deadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deadline.Location = new System.Drawing.Point(42, 169);
            this.Deadline.Name = "Deadline";
            this.Deadline.Size = new System.Drawing.Size(170, 20);
            this.Deadline.TabIndex = 2;
            this.Deadline.Text = "Batas Pengumpulan";
            this.Deadline.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(258, 46);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(360, 26);
            this.txtMK.TabIndex = 3;
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(258, 112);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(360, 26);
            this.txtDetail.TabIndex = 4;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(336, 228);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(87, 38);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.tambah_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMK,
            this.columnDetail,
            this.columnDeadline});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 290);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 159);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            this.dateTimeDeadline.Location = new System.Drawing.Point(258, 169);
            this.dateTimeDeadline.Name = "dateTimeDeadline";
            this.dateTimeDeadline.Size = new System.Drawing.Size(360, 26);
            this.dateTimeDeadline.TabIndex = 8;
            this.dateTimeDeadline.Value = new System.DateTime(2023, 10, 13, 22, 56, 21, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(430, 228);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 38);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(530, 228);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(90, 38);
            this.btnHapus.TabIndex = 10;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 449);
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

