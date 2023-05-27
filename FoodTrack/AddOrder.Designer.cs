namespace FoodTrack
{
    partial class AddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblAddOrder = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cboProgress = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.radPaid = new System.Windows.Forms.RadioButton();
            this.radCOD = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.btnDisplayItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoodTrack.Properties.Resources.FoodTrack_Pic1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 117);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            this.btnLogout.TabIndex = 4;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.lblLogout.TabIndex = 5;
            this.lblLogout.Text = "Log-out";
            // 
            // lblAddOrder
            // 
            this.lblAddOrder.AutoSize = true;
            this.lblAddOrder.Font = new System.Drawing.Font("Glacial Indifference", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddOrder.Location = new System.Drawing.Point(25, 137);
            this.lblAddOrder.Name = "lblAddOrder";
            this.lblAddOrder.Size = new System.Drawing.Size(217, 48);
            this.lblAddOrder.TabIndex = 19;
            this.lblAddOrder.Text = "Add Order";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lblOrderNo.Font = new System.Drawing.Font("Glacial Indifference", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderNo.ForeColor = System.Drawing.Color.White;
            this.lblOrderNo.Location = new System.Drawing.Point(68, 205);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(124, 26);
            this.lblOrderNo.TabIndex = 20;
            this.lblOrderNo.Text = "Order No.: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lblDate.Font = new System.Drawing.Font("Glacial Indifference", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(68, 244);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(128, 26);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "Date:          ";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lblCustomer.Font = new System.Drawing.Font("Glacial Indifference", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(68, 284);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(125, 26);
            this.lblCustomer.TabIndex = 22;
            this.lblCustomer.Text = "Customer: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lblTotal.Font = new System.Drawing.Font("Glacial Indifference", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(476, 205);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(191, 26);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "Total Amount:      ";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lblPayment.Font = new System.Drawing.Font("Glacial Indifference", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPayment.ForeColor = System.Drawing.Color.White;
            this.lblPayment.Location = new System.Drawing.Point(476, 244);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(193, 26);
            this.lblPayment.TabIndex = 24;
            this.lblPayment.Text = "Payment Status:  ";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lblProgress.Font = new System.Drawing.Font("Glacial Indifference", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(476, 284);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(193, 26);
            this.lblProgress.TabIndex = 25;
            this.lblProgress.Text = "Progress:              ";
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lblOrderList.Font = new System.Drawing.Font("Glacial Indifference", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderList.ForeColor = System.Drawing.Color.White;
            this.lblOrderList.Location = new System.Drawing.Point(68, 332);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(142, 26);
            this.lblOrderList.TabIndex = 26;
            this.lblOrderList.Text = "Order Items:";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBack.Location = new System.Drawing.Point(58, 640);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(55, 24);
            this.lblBack.TabIndex = 27;
            this.lblBack.Text = "Back";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderNo.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrderNo.Location = new System.Drawing.Point(212, 205);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(250, 31);
            this.txtOrderNo.TabIndex = 28;
            // 
            // txtCustomer
            // 
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomer.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomer.Location = new System.Drawing.Point(212, 284);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(250, 31);
            this.txtCustomer.TabIndex = 29;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(688, 198);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(250, 31);
            this.txtTotal.TabIndex = 30;
            // 
            // cboProgress
            // 
            this.cboProgress.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboProgress.FormattingEnabled = true;
            this.cboProgress.Items.AddRange(new object[] {
            "Preparing",
            "In-Transit",
            "Completed"});
            this.cboProgress.Location = new System.Drawing.Point(688, 280);
            this.cboProgress.Name = "cboProgress";
            this.cboProgress.Size = new System.Drawing.Size(250, 32);
            this.cboProgress.TabIndex = 32;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Glacial Indifference", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.Location = new System.Drawing.Point(212, 244);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 25);
            this.dtpDate.TabIndex = 33;
            // 
            // radPaid
            // 
            this.radPaid.AutoSize = true;
            this.radPaid.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radPaid.Location = new System.Drawing.Point(688, 240);
            this.radPaid.Name = "radPaid";
            this.radPaid.Size = new System.Drawing.Size(69, 28);
            this.radPaid.TabIndex = 35;
            this.radPaid.TabStop = true;
            this.radPaid.Text = "Paid";
            this.radPaid.UseVisualStyleBackColor = true;
            // 
            // radCOD
            // 
            this.radCOD.AutoSize = true;
            this.radCOD.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radCOD.Location = new System.Drawing.Point(779, 240);
            this.radCOD.Name = "radCOD";
            this.radCOD.Size = new System.Drawing.Size(75, 28);
            this.radCOD.TabIndex = 36;
            this.radCOD.TabStop = true;
            this.radCOD.Text = "COD";
            this.radCOD.UseVisualStyleBackColor = true;
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
            this.btnBack.TabIndex = 37;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackgroundImage = global::FoodTrack.Properties.Resources.Add_Icon_Large;
            this.btnAddOrder.FlatAppearance.BorderSize = 0;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Location = new System.Drawing.Point(803, 382);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(135, 135);
            this.btnAddOrder.TabIndex = 42;
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lblAdd.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdd.ForeColor = System.Drawing.Color.White;
            this.lblAdd.Location = new System.Drawing.Point(801, 522);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(140, 24);
            this.lblAdd.TabIndex = 43;
            this.lblAdd.Text = "   ADD ORDER  ";
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackgroundImage = global::FoodTrack.Properties.Resources.AddItems;
            this.btnAddItems.FlatAppearance.BorderSize = 0;
            this.btnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItems.Location = new System.Drawing.Point(230, 325);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(138, 33);
            this.btnAddItems.TabIndex = 45;
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Location = new System.Drawing.Point(68, 364);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.RowHeadersWidth = 51;
            this.dgvOrderItems.RowTemplate.Height = 29;
            this.dgvOrderItems.Size = new System.Drawing.Size(710, 182);
            this.dgvOrderItems.TabIndex = 47;
            // 
            // btnDisplayItems
            // 
            this.btnDisplayItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDisplayItems.BackgroundImage")));
            this.btnDisplayItems.FlatAppearance.BorderSize = 0;
            this.btnDisplayItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayItems.Location = new System.Drawing.Point(374, 325);
            this.btnDisplayItems.Name = "btnDisplayItems";
            this.btnDisplayItems.Size = new System.Drawing.Size(179, 33);
            this.btnDisplayItems.TabIndex = 48;
            this.btnDisplayItems.UseVisualStyleBackColor = true;
            this.btnDisplayItems.Click += new System.EventHandler(this.btnDisplayItems_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btnDisplayItems);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnAddOrder);
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
            this.Controls.Add(this.lblAddOrder);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvOrderItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddOrder";
            this.Text = "Add Order";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnLogout;
        private Label lblLogout;
        private Label lblAddOrder;
        private Label lblOrderNo;
        private Label lblDate;
        private Label lblCustomer;
        private Label lblTotal;
        private Label lblPayment;
        private Label lblProgress;
        private Label lblOrderList;
        private Label lblBack;
        private TextBox txtOrderNo;
        private TextBox txtCustomer;
        private TextBox txtTotal;
        private ComboBox cboProgress;
        private DateTimePicker dtpDate;
        private RadioButton radPaid;
        private RadioButton radCOD;
        private Button btnBack;
        private Button btnAddOrder;
        private Label lblAdd;
        private Button btnAddItems;
        private DataGridView dgvOrderItems;
        private Button btnDisplayItems;
    }
}