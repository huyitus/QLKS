namespace QLKS.GUI
{
    partial class FormAdmin_QD
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
            this.lab_QD = new System.Windows.Forms.Label();
            this.dtg_QD = new System.Windows.Forms.DataGridView();
            this.butt_Fix = new System.Windows.Forms.Button();
            this.butt_Del = new System.Windows.Forms.Button();
            this.butt_Add = new System.Windows.Forms.Button();
            this.butt_Re = new System.Windows.Forms.Button();
            this.panellabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_QD)).BeginInit();
            this.SuspendLayout();
            // 
            // panellabel
            // 
            this.panellabel.BackColor = System.Drawing.Color.DarkCyan;
            this.panellabel.Controls.Add(this.lab_QD);
            this.panellabel.Location = new System.Drawing.Point(3, 1);
            this.panellabel.Name = "panellabel";
            this.panellabel.Size = new System.Drawing.Size(806, 67);
            this.panellabel.TabIndex = 20;
            // 
            // lab_QD
            // 
            this.lab_QD.AutoSize = true;
            this.lab_QD.BackColor = System.Drawing.Color.DarkCyan;
            this.lab_QD.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_QD.ForeColor = System.Drawing.Color.White;
            this.lab_QD.Location = new System.Drawing.Point(240, 17);
            this.lab_QD.Name = "lab_QD";
            this.lab_QD.Size = new System.Drawing.Size(332, 32);
            this.lab_QD.TabIndex = 1;
            this.lab_QD.Text = "QUY ĐỊNH KHÁCH SẠN";
            // 
            // dtg_QD
            // 
            this.dtg_QD.BackgroundColor = System.Drawing.Color.White;
            this.dtg_QD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_QD.Location = new System.Drawing.Point(33, 88);
            this.dtg_QD.Name = "dtg_QD";
            this.dtg_QD.ReadOnly = true;
            this.dtg_QD.RowHeadersVisible = false;
            this.dtg_QD.RowHeadersWidth = 62;
            this.dtg_QD.RowTemplate.Height = 28;
            this.dtg_QD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_QD.Size = new System.Drawing.Size(743, 255);
            this.dtg_QD.TabIndex = 21;
            this.dtg_QD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_QD_CellContentClick);
            // 
            // butt_Fix
            // 
            this.butt_Fix.BackColor = System.Drawing.Color.Moccasin;
            this.butt_Fix.Location = new System.Drawing.Point(461, 359);
            this.butt_Fix.Name = "butt_Fix";
            this.butt_Fix.Size = new System.Drawing.Size(90, 34);
            this.butt_Fix.TabIndex = 22;
            this.butt_Fix.Text = "Sửa";
            this.butt_Fix.UseVisualStyleBackColor = false;
            this.butt_Fix.Click += new System.EventHandler(this.butt_Fix_Click);
            // 
            // butt_Del
            // 
            this.butt_Del.BackColor = System.Drawing.Color.LightCoral;
            this.butt_Del.Location = new System.Drawing.Point(573, 359);
            this.butt_Del.Name = "butt_Del";
            this.butt_Del.Size = new System.Drawing.Size(90, 34);
            this.butt_Del.TabIndex = 23;
            this.butt_Del.Text = "Xóa";
            this.butt_Del.UseVisualStyleBackColor = false;
            this.butt_Del.Click += new System.EventHandler(this.butt_Del_Click);
            // 
            // butt_Add
            // 
            this.butt_Add.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butt_Add.Location = new System.Drawing.Point(685, 359);
            this.butt_Add.Name = "butt_Add";
            this.butt_Add.Size = new System.Drawing.Size(91, 34);
            this.butt_Add.TabIndex = 24;
            this.butt_Add.Text = "Thêm";
            this.butt_Add.UseVisualStyleBackColor = false;
            this.butt_Add.Click += new System.EventHandler(this.butt_Add_Click);
            // 
            // butt_Re
            // 
            this.butt_Re.BackColor = System.Drawing.Color.LightSkyBlue;
            this.butt_Re.Location = new System.Drawing.Point(33, 359);
            this.butt_Re.Name = "butt_Re";
            this.butt_Re.Size = new System.Drawing.Size(116, 34);
            this.butt_Re.TabIndex = 25;
            this.butt_Re.Text = "Làm mới";
            this.butt_Re.UseVisualStyleBackColor = false;
            this.butt_Re.Click += new System.EventHandler(this.butt_Re_Click);
            // 
            // FormAdmin_QD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 405);
            this.Controls.Add(this.butt_Re);
            this.Controls.Add(this.butt_Add);
            this.Controls.Add(this.butt_Del);
            this.Controls.Add(this.butt_Fix);
            this.Controls.Add(this.dtg_QD);
            this.Controls.Add(this.panellabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdmin_QD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quy định khách sạn";
            this.Load += new System.EventHandler(this.FormAdmin_QD_Load);
            this.panellabel.ResumeLayout(false);
            this.panellabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_QD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panellabel;
        private System.Windows.Forms.Label lab_QD;
        private System.Windows.Forms.DataGridView dtg_QD;
        private System.Windows.Forms.Button butt_Fix;
        private System.Windows.Forms.Button butt_Del;
        private System.Windows.Forms.Button butt_Add;
        private System.Windows.Forms.Button butt_Re;
    }
}