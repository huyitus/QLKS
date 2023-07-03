namespace QLKS.GUI
{
    partial class FormAdmin_NV
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
            this.lb_NV = new System.Windows.Forms.Label();
            this.dgv_NV = new System.Windows.Forms.DataGridView();
            this.butt_Add = new System.Windows.Forms.Button();
            this.butt_Del = new System.Windows.Forms.Button();
            this.butt_Fix = new System.Windows.Forms.Button();
            this.panellabel = new System.Windows.Forms.Panel();
            this.butt_Re = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).BeginInit();
            this.panellabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_NV
            // 
            this.lb_NV.AutoSize = true;
            this.lb_NV.BackColor = System.Drawing.Color.DarkCyan;
            this.lb_NV.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NV.ForeColor = System.Drawing.Color.White;
            this.lb_NV.Location = new System.Drawing.Point(228, 19);
            this.lb_NV.Name = "lb_NV";
            this.lb_NV.Size = new System.Drawing.Size(336, 32);
            this.lb_NV.TabIndex = 0;
            this.lb_NV.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // dgv_NV
            // 
            this.dgv_NV.BackgroundColor = System.Drawing.Color.White;
            this.dgv_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NV.Location = new System.Drawing.Point(35, 86);
            this.dgv_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_NV.Name = "dgv_NV";
            this.dgv_NV.ReadOnly = true;
            this.dgv_NV.RowHeadersVisible = false;
            this.dgv_NV.RowHeadersWidth = 62;
            this.dgv_NV.RowTemplate.Height = 28;
            this.dgv_NV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NV.Size = new System.Drawing.Size(729, 225);
            this.dgv_NV.TabIndex = 1;
            // 
            // butt_Add
            // 
            this.butt_Add.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butt_Add.Location = new System.Drawing.Point(673, 329);
            this.butt_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butt_Add.Name = "butt_Add";
            this.butt_Add.Size = new System.Drawing.Size(91, 34);
            this.butt_Add.TabIndex = 2;
            this.butt_Add.Text = "Thêm";
            this.butt_Add.UseVisualStyleBackColor = false;
            this.butt_Add.Click += new System.EventHandler(this.butt_Add_Click);
            // 
            // butt_Del
            // 
            this.butt_Del.BackColor = System.Drawing.Color.LightCoral;
            this.butt_Del.Location = new System.Drawing.Point(566, 329);
            this.butt_Del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butt_Del.Name = "butt_Del";
            this.butt_Del.Size = new System.Drawing.Size(90, 34);
            this.butt_Del.TabIndex = 3;
            this.butt_Del.Text = "Xóa";
            this.butt_Del.UseVisualStyleBackColor = false;
            this.butt_Del.Click += new System.EventHandler(this.butt_Del_Click);
            // 
            // butt_Fix
            // 
            this.butt_Fix.BackColor = System.Drawing.Color.Moccasin;
            this.butt_Fix.Location = new System.Drawing.Point(461, 329);
            this.butt_Fix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butt_Fix.Name = "butt_Fix";
            this.butt_Fix.Size = new System.Drawing.Size(90, 34);
            this.butt_Fix.TabIndex = 4;
            this.butt_Fix.Text = "Sửa";
            this.butt_Fix.UseVisualStyleBackColor = false;
            this.butt_Fix.Click += new System.EventHandler(this.butt_Fix_Click);
            // 
            // panellabel
            // 
            this.panellabel.BackColor = System.Drawing.Color.DarkCyan;
            this.panellabel.Controls.Add(this.lb_NV);
            this.panellabel.Location = new System.Drawing.Point(2, 1);
            this.panellabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panellabel.Name = "panellabel";
            this.panellabel.Size = new System.Drawing.Size(806, 68);
            this.panellabel.TabIndex = 18;
            // 
            // butt_Re
            // 
            this.butt_Re.BackColor = System.Drawing.Color.LightSkyBlue;
            this.butt_Re.Location = new System.Drawing.Point(35, 329);
            this.butt_Re.Name = "butt_Re";
            this.butt_Re.Size = new System.Drawing.Size(116, 34);
            this.butt_Re.TabIndex = 27;
            this.butt_Re.Text = "Làm mới";
            this.butt_Re.UseVisualStyleBackColor = false;
            this.butt_Re.Click += new System.EventHandler(this.butt_Re_Click);
            // 
            // FormAdmin_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 384);
            this.Controls.Add(this.butt_Re);
            this.Controls.Add(this.butt_Fix);
            this.Controls.Add(this.butt_Del);
            this.Controls.Add(this.butt_Add);
            this.Controls.Add(this.dgv_NV);
            this.Controls.Add(this.panellabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAdmin_NV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin Nhân viên";
            this.Load += new System.EventHandler(this.FormAdmin_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).EndInit();
            this.panellabel.ResumeLayout(false);
            this.panellabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_NV;
        private System.Windows.Forms.DataGridView dgv_NV;
        private System.Windows.Forms.Button butt_Add;
        private System.Windows.Forms.Button butt_Del;
        private System.Windows.Forms.Button butt_Fix;
        private System.Windows.Forms.Panel panellabel;
        private System.Windows.Forms.Button butt_Re;
    }
}