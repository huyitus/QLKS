namespace QLKS.GUI
{
    partial class FormAdmin_DT
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
            this.panellabel = new System.Windows.Forms.Panel();
            this.lb_DT = new System.Windows.Forms.Label();
            this.dgv_DT = new System.Windows.Forms.DataGridView();
            this.butt_Add = new System.Windows.Forms.Button();
            this.butt_Del = new System.Windows.Forms.Button();
            this.butt_Fix = new System.Windows.Forms.Button();
            this.butt_Re = new System.Windows.Forms.Button();
            this.panellabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DT)).BeginInit();
            this.SuspendLayout();
            // 
            // panellabel
            // 
            this.panellabel.BackColor = System.Drawing.Color.DarkCyan;
            this.panellabel.Controls.Add(this.lb_DT);
            this.panellabel.Location = new System.Drawing.Point(3, 1);
            this.panellabel.Name = "panellabel";
            this.panellabel.Size = new System.Drawing.Size(806, 67);
            this.panellabel.TabIndex = 19;
            // 
            // lb_DT
            // 
            this.lb_DT.AutoSize = true;
            this.lb_DT.BackColor = System.Drawing.Color.DarkCyan;
            this.lb_DT.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DT.ForeColor = System.Drawing.Color.White;
            this.lb_DT.Location = new System.Drawing.Point(228, 19);
            this.lb_DT.Name = "lb_DT";
            this.lb_DT.Size = new System.Drawing.Size(295, 32);
            this.lb_DT.TabIndex = 0;
            this.lb_DT.Text = "THÔNG TIN ĐỐI TÁC";
            // 
            // dgv_DT
            // 
            this.dgv_DT.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DT.Location = new System.Drawing.Point(33, 88);
            this.dgv_DT.Name = "dgv_DT";
            this.dgv_DT.RowHeadersVisible = false;
            this.dgv_DT.RowHeadersWidth = 62;
            this.dgv_DT.RowTemplate.Height = 28;
            this.dgv_DT.RowTemplate.ReadOnly = true;
            this.dgv_DT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DT.Size = new System.Drawing.Size(729, 226);
            this.dgv_DT.TabIndex = 20;
            // 
            // butt_Add
            // 
            this.butt_Add.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butt_Add.Location = new System.Drawing.Point(671, 338);
            this.butt_Add.Name = "butt_Add";
            this.butt_Add.Size = new System.Drawing.Size(91, 34);
            this.butt_Add.TabIndex = 21;
            this.butt_Add.Text = "Thêm";
            this.butt_Add.UseVisualStyleBackColor = false;
            this.butt_Add.Click += new System.EventHandler(this.butt_Add_Click);
            // 
            // butt_Del
            // 
            this.butt_Del.BackColor = System.Drawing.Color.LightCoral;
            this.butt_Del.Location = new System.Drawing.Point(561, 338);
            this.butt_Del.Name = "butt_Del";
            this.butt_Del.Size = new System.Drawing.Size(90, 34);
            this.butt_Del.TabIndex = 22;
            this.butt_Del.Text = "Xóa";
            this.butt_Del.UseVisualStyleBackColor = false;
            this.butt_Del.Click += new System.EventHandler(this.butt_Del_Click);
            // 
            // butt_Fix
            // 
            this.butt_Fix.BackColor = System.Drawing.Color.Moccasin;
            this.butt_Fix.Location = new System.Drawing.Point(455, 338);
            this.butt_Fix.Name = "butt_Fix";
            this.butt_Fix.Size = new System.Drawing.Size(90, 34);
            this.butt_Fix.TabIndex = 23;
            this.butt_Fix.Text = "Sửa";
            this.butt_Fix.UseVisualStyleBackColor = false;
            this.butt_Fix.Click += new System.EventHandler(this.butt_Fix_Click);
            // 
            // butt_Re
            // 
            this.butt_Re.BackColor = System.Drawing.Color.LightSkyBlue;
            this.butt_Re.Location = new System.Drawing.Point(33, 338);
            this.butt_Re.Name = "butt_Re";
            this.butt_Re.Size = new System.Drawing.Size(116, 34);
            this.butt_Re.TabIndex = 27;
            this.butt_Re.Text = "Làm mới";
            this.butt_Re.UseVisualStyleBackColor = false;
            this.butt_Re.Click += new System.EventHandler(this.butt_Re_Click);
            // 
            // FormAdmin_DT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 395);
            this.Controls.Add(this.butt_Re);
            this.Controls.Add(this.butt_Fix);
            this.Controls.Add(this.butt_Del);
            this.Controls.Add(this.butt_Add);
            this.Controls.Add(this.dgv_DT);
            this.Controls.Add(this.panellabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdmin_DT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin đối tác";
            this.Load += new System.EventHandler(this.FormAdmin_DT_Load);
            this.panellabel.ResumeLayout(false);
            this.panellabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panellabel;
        private System.Windows.Forms.Label lb_DT;
        private System.Windows.Forms.DataGridView dgv_DT;
        private System.Windows.Forms.Button butt_Add;
        private System.Windows.Forms.Button butt_Del;
        private System.Windows.Forms.Button butt_Fix;
        private System.Windows.Forms.Button butt_Re;
    }
}