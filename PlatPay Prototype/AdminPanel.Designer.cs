namespace PlatPay_Prototype
{
    partial class AdminPanel
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Id");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("FirstName");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("LastName");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("CardId");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Cvv");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("ExpiredDate");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Balance");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("CreatedAt");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("isDeleted");
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.FirstName = new System.Windows.Forms.ColumnHeader();
            this.LastName = new System.Windows.Forms.ColumnHeader();
            this.Cardld = new System.Windows.Forms.ColumnHeader();
            this.Cvv = new System.Windows.Forms.ColumnHeader();
            this.ExpiredDate = new System.Windows.Forms.ColumnHeader();
            this.Balance = new System.Windows.Forms.ColumnHeader();
            this.CreatedAt = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.Cardld,
            this.Cvv,
            this.ExpiredDate,
            this.Balance,
            this.CreatedAt});
            listViewItem2.IndentCount = 2;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.listView1.Location = new System.Drawing.Point(29, 40);
            this.listView1.Margin = new System.Windows.Forms.Padding(5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(613, 389);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 697);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader Id;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader Cardld;
        private ColumnHeader Cvv;
        private ColumnHeader ExpiredDate;
        private ColumnHeader Balance;
        private ColumnHeader CreatedAt;
    }
}