namespace FoodTrack
{
    partial class EditOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOrder));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogout = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblEditOrder = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.radCOD = new System.Windows.Forms.RadioButton();
            this.radPaid = new System.Windows.Forms.RadioButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cboProgress = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDisplayInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoodTrack.Properties.Resources.FoodTrack_Pic1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 117);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lblLogout.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogout.ForeColor = System.Drawing.Color.White;
            this.lblLogout.Location = new System.Drawing.Point(908, 68);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(77, 24);
            this.lblLogout.TabIndex = 9;
            this.lblLogout.Text = "Log-out";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.btnLogout.BackgroundImage = global::FoodTrack.Properties.Resources.Logout;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(924, 28);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(42, 45);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblEditOrder
            // 
            this.lblEditOrder.AutoSize = true;
            this.lblEditOrder.Font = new System.Drawing.Font("Glacial Indifference", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEditOrder.Location = new System.Drawing.Point(25, 137);
            this.lblEditOrder.Name = "lblEditOrder";
            this.lblEditOrder.Size = new System.Drawing.Size(210, 48);
            this.lblEditOrder.TabIndex = 21;
            this.lblEditOrder.Text = "Edit Order";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::FoodTrack.Properties.Resources.Back1;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(56, 576);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 61);
            this.btnBack.TabIndex = 64;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // radCOD
            // 
            this.radCOD.AutoSize = true;
            this.radCOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(192)))), ((int)(((byte)(138)))));
            this.radCOD.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radCOD.Location = new System.Drawing.Point(784, 222);
            this.radCOD.Name = "radCOD";
            this.radCOD.Size = new System.Drawing.Size(75, 28);
            this.radCOD.TabIndex = 63;
            this.radCOD.TabStop = true;
            this.radCOD.Text = "COD";
            this.radCOD.UseVisualStyleBackColor = false;
            // 
            // radPaid
            // 
            this.radPaid.AutoSize = true;
            this.radPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(192)))), ((int)(((byte)(138)))));
            this.radPaid.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radPaid.Location = new System.Drawing.Point(693, 222);
            this.radPaid.Name = "radPaid";
            this.radPaid.Size = new System.Drawing.Size(69, 28);
            this.radPaid.TabIndex = 62;
            this.radPaid.TabStop = true;
            this.radPaid.Text = "Paid";
            this.radPaid.UseVisualStyleBackColor = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Glacial Indifference", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.Location = new System.Drawing.Point(221, 228);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 25);
            this.dtpDate.TabIndex = 61;
            // 
            // cboProgress
            // 
            this.cboProgress.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboProgress.FormattingEnabled = true;
            this.cboProgress.Items.AddRange(new object[] {
            "Preparing",
            "In-Transit",
            "Completed"});
            this.cboProgress.Location = new System.Drawing.Point(693, 262);
            this.cboProgress.Name = "cboProgress";
            this.cboProgress.Size = new System.Drawing.Size(245, 32);
            this.cboProgress.TabIndex = 60;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(289, 511);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(250, 31);
            this.txtTotal.TabIndex = 59;
            // 
            // txtCustomer
            // 
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomer.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomer.Location = new System.Drawing.Point(221, 268);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(250, 31);
            this.txtCustomer.TabIndex = 58;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderNo.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrderNo.Location = new System.Drawing.Point(693, 155);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(82, 31);
            this.txtOrderNo.TabIndex = 57;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBack.Location = new System.Drawing.Point(58, 640);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(55, 24);
            this.lblBack.TabIndex = 56;
            this.lblBack.Text = "Back";
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lblOrderList.Font = new System.Drawing.Font("Glacial Indifference", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderList.ForeColor = System.Drawing.Color.White;
            this.lblOrderList.Location = new System.Drawing.Point(77, 316);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(142, 26);
            this.lblOrderList.TabIndex = 55;
            this.lblOrderList.Text = "Order Items:";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lblProgress.Font = new System.Drawing.Font("Glacial Indifference", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(481, 266);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(193, 26);
            this.lblProgress.TabIndex = 54;
            this.lblProgress.Text = "Progress:              ";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lblPayment.Font = new System.Drawing.Font("Glacial Indifference", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPayment.ForeColor = System.Drawing.Color.White;
            this.lblPayment.Location = new System.Drawing.Point(481, 226);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(193, 26);
            this.lblPayment.TabIndex = 53;
            this.lblPayment.Text = "Payment Status:  ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lblTotal.Font = new System.Drawing.Font("Glacial Indifference", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(77, 518);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(191, 26);
            this.lblTotal.TabIndex = 52;
            this.lblTotal.Text = "Total Amount:      ";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lblCustomer.Font = new System.Drawing.Font("Glacial Indifference", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(77, 268);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(125, 26);
            this.lblCustomer.TabIndex = 51;
            this.lblCustomer.Text = "Customer: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lblDate.Font = new System.Drawing.Font("Glacial Indifference", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(77, 228);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(128, 26);
            this.lblDate.TabIndex = 50;
            this.lblDate.Text = "Date:          ";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lblOrderNo.Font = new System.Drawing.Font("Glacial Indifference", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderNo.ForeColor = System.Drawing.Color.White;
            this.lblOrderNo.Location = new System.Drawing.Point(563, 159);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(124, 26);
            this.lblOrderNo.TabIndex = 49;
            this.lblOrderNo.Text = "Order No.: ";
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Location = new System.Drawing.Point(77, 345);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.RowHeadersWidth = 51;
            this.dgvOrderItems.RowTemplate.Height = 29;
            this.dgvOrderItems.Size = new System.Drawing.Size(485, 160);
            this.dgvOrderItems.TabIndex = 67;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lblAdd.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdd.ForeColor = System.Drawing.Color.White;
            this.lblAdd.Location = new System.Drawing.Point(763, 510);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(158, 24);
            this.lblAdd.TabIndex = 69;
            this.lblAdd.Text = "SAVE CHANGES";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(192)))), ((int)(((byte)(138)))));
            this.btnSaveChanges.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveChanges.BackgroundImage")));
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Location = new System.Drawing.Point(773, 372);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(135, 135);
            this.btnSaveChanges.TabIndex = 70;
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(192)))), ((int)(((byte)(138)))));
            this.pictureBox2.Location = new System.Drawing.Point(68, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(883, 355);
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // btnDisplayInfo
            // 
            this.btnDisplayInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDisplayInfo.BackgroundImage")));
            this.btnDisplayInfo.FlatAppearance.BorderSize = 0;
            this.btnDisplayInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayInfo.Location = new System.Drawing.Point(781, 155);
            this.btnDisplayInfo.Name = "btnDisplayInfo";
            this.btnDisplayInfo.Size = new System.Drawing.Size(172, 32);
            this.btnDisplayInfo.TabIndex = 72;
            this.btnDisplayInfo.UseVisualStyleBackColor = true;
            this.btnDisplayInfo.Click += new System.EventHandler(this.btnDisplayInfo_Click);
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btnDisplayInfo);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.radCOD);
            this.Controls.Add(this.radPaid);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cboProgress);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblOrderList);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.dgvOrderItems);
            this.Controls.Add(this.lblEditOrder);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditOrder";
            this.Text = "EditOrder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLogout;
        private Button btnLogout;
        private Label lblEditOrder;
        private Button btnBack;
        private RadioButton radCOD;
        private RadioButton radPaid;
        private DateTimePicker dtpDate;
        private ComboBox cboProgress;
        private TextBox txtTotal;
        private TextBox txtCustomer;
        private TextBox txtOrderNo;
        private Label lblBack;
        private Label lblOrderList;
        private Label lblProgress;
        private Label lblPayment;
        private Label lblTotal;
        private Label lblCustomer;
        private Label lblDate;
        private Label lblOrderNo;
        private DataGridView dgvOrderItems;
        private Label lblAdd;
        private Button btnSaveChanges;
        private PictureBox pictureBox2;
        private Button btnDisplayInfo;
    }
}