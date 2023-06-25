
namespace QLKS.GUI
{
    partial class FormFeatures
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
            this.chkEmpty = new System.Windows.Forms.CheckBox();
            this.chkClean = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRooms
            // 
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(16, 48);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersWidth = 51;
            this.dgvRooms.RowTemplate.Height = 24;
            this.dgvRooms.Size = new System.Drawing.Size(744, 208);
            this.dgvRooms.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tra cứu và đặt phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkEmpty
            // 
            this.chkEmpty.AutoSize = true;
            this.chkEmpty.Location = new System.Drawing.Point(16, 32);
            this.chkEmpty.Name = "chkEmpty";
            this.chkEmpty.Size = new System.Drawing.Size(135, 21);
            this.chkEmpty.TabIndex = 0;
            this.chkEmpty.Text = "Phòng còn trống";
            this.chkEmpty.UseVisualStyleBackColor = true;
            this.chkEmpty.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // chkClean
            // 
            this.chkClean.AutoSize = true;
            this.chkClean.Location = new System.Drawing.Point(216, 32);
            this.chkClean.Name = "chkClean";
            this.chkClean.Size = new System.Drawing.Size(119, 21);
            this.chkClean.TabIndex = 1;
            this.chkClean.Text = "Phòng đã dọn";
            this.chkClean.UseVisualStyleBackColor = true;
            this.chkClean.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(640, 272);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(120, 64);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Đặt phòng";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkClean);
            this.groupBox1.Controls.Add(this.chkEmpty);
            this.groupBox1.Location = new System.Drawing.Point(16, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc phòng:";
            // 
            // FormFeatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 351);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRooms);
            this.MaximizeBox = false;
            this.Name = "FormFeatures";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đại lý";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFeatures_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkClean;
        private System.Windows.Forms.CheckBox chkEmpty;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}