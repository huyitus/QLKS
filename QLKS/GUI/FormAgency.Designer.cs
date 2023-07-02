
namespace QLKS.GUI
{
    partial class FormAgency
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
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.chkClean = new System.Windows.Forms.CheckBox();
            this.chkEmpty = new System.Windows.Forms.CheckBox();
            this.panellabel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRooms
            // 
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(16, 48);
            this.dgvRooms.MultiSelect = false;
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersWidth = 51;
            this.dgvRooms.RowTemplate.Height = 24;
            this.dgvRooms.Size = new System.Drawing.Size(765, 210);
            this.dgvRooms.TabIndex = 0;
            this.dgvRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellContentClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tra cứu và đặt phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBooking
            // 
            this.btnOrder.Location = new System.Drawing.Point(584, 248);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(112, 40);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Đặt phòng";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.ButtonOrder_Click);
            // 
            // chkClean
            // 
            this.chkClean.AutoSize = true;
            this.chkClean.Location = new System.Drawing.Point(16, 272);
            this.chkClean.Name = "chkClean";
            this.chkClean.Size = new System.Drawing.Size(134, 24);
            this.chkClean.TabIndex = 14;
            this.chkClean.Text = "Phòng đã dọn";
            this.chkClean.UseVisualStyleBackColor = true;
            this.chkClean.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // chkEmpty
            // 
            this.chkEmpty.AutoSize = true;
            this.chkEmpty.Location = new System.Drawing.Point(16, 248);
            this.chkEmpty.Name = "chkEmpty";
            this.chkEmpty.Size = new System.Drawing.Size(152, 24);
            this.chkEmpty.TabIndex = 13;
            this.chkEmpty.Text = "Phòng còn trống";
            this.chkEmpty.UseVisualStyleBackColor = true;
            this.chkEmpty.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // panellabel
            // 
            this.panellabel.BackColor = System.Drawing.Color.DarkCyan;
            this.panellabel.Location = new System.Drawing.Point(1, 1);
            this.panellabel.Name = "panellabel";
            this.panellabel.Size = new System.Drawing.Size(806, 67);
            this.panellabel.TabIndex = 20;
            // 
            // FormAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 306);
            this.Controls.Add(this.chkClean);
            this.Controls.Add(this.chkEmpty);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRooms);
            this.MaximizeBox = false;
            this.Name = "FormAgency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện cho đại lý";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAgency_FormClosing);
            this.Load += new System.EventHandler(this.FormAgency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.CheckBox chkClean;
        private System.Windows.Forms.CheckBox chkEmpty;
        private System.Windows.Forms.Panel panellabel;
    }
}