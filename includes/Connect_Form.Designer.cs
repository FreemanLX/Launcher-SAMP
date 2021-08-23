namespace LauncherSAMPInt
{
    partial class Connect_Form
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


        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ServerList = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Basename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Players = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gamemode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefreshAllButton = new MetroFramework.Controls.MetroButton();
            this.DeleteSelectedServerButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.NicknameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ServerList)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerList
            // 
            this.ServerList.AllowUserToAddRows = false;
            this.ServerList.AllowUserToDeleteRows = false;
            this.ServerList.AllowUserToResizeColumns = false;
            this.ServerList.AllowUserToResizeRows = false;
            this.ServerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServerList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ServerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ServerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ServerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.Basename,
            this.Players,
            this.Ping,
            this.Gamemode,
            this.IP});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ServerList.DefaultCellStyle = dataGridViewCellStyle2;
            this.ServerList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ServerList.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ServerList.Location = new System.Drawing.Point(13, 104);
            this.ServerList.MultiSelect = false;
            this.ServerList.Name = "ServerList";
            this.ServerList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ServerList.RowHeadersVisible = false;
            this.ServerList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ServerList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ServerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServerList.ShowCellErrors = false;
            this.ServerList.ShowCellToolTips = false;
            this.ServerList.ShowEditingIcon = false;
            this.ServerList.ShowRowErrors = false;
            this.ServerList.Size = new System.Drawing.Size(814, 300);
            this.ServerList.TabIndex = 9;
            this.ServerList.TabStop = false;
            this.ServerList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServerList_CellDoubleClick);
            this.ServerList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServerList_CellDoubleClick);
            this.ServerList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ServerList_CellMouseDown);
            // 
            // Status
            // 
            this.Status.FillWeight = 25F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Basename
            // 
            this.Basename.HeaderText = "Hostname";
            this.Basename.Name = "Basename";
            // 
            // Players
            // 
            this.Players.FillWeight = 30F;
            this.Players.HeaderText = "Players";
            this.Players.Name = "Players";
            // 
            // Ping
            // 
            this.Ping.FillWeight = 18F;
            this.Ping.HeaderText = "Ping";
            this.Ping.Name = "Ping";
            // 
            // Gamemode
            // 
            this.Gamemode.FillWeight = 60F;
            this.Gamemode.HeaderText = "Gamemode";
            this.Gamemode.Name = "Gamemode";
            // 
            // IP
            // 
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.Visible = false;
            // 
            // RefreshAllButton
            // 
            this.RefreshAllButton.Location = new System.Drawing.Point(234, 53);
            this.RefreshAllButton.Name = "RefreshAllButton";
            this.RefreshAllButton.Size = new System.Drawing.Size(90, 23);
            this.RefreshAllButton.TabIndex = 8;
            this.RefreshAllButton.Text = "Refresh All";
            this.RefreshAllButton.Click += new System.EventHandler(this.RefreshAllButton_Click);
            // 
            // DeleteSelectedServerButton
            // 
            this.DeleteSelectedServerButton.Location = new System.Drawing.Point(3, 53);
            this.DeleteSelectedServerButton.Name = "DeleteSelectedServerButton";
            this.DeleteSelectedServerButton.Size = new System.Drawing.Size(90, 23);
            this.DeleteSelectedServerButton.TabIndex = 7;
            this.DeleteSelectedServerButton.Text = "Delete";
            this.DeleteSelectedServerButton.Click += new System.EventHandler(this.DeleteSelectedServerButton_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(3, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Username";
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(120, 53);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(90, 23);
            this.metroButton4.TabIndex = 10;
            this.metroButton4.Text = "Add server";
            this.metroButton4.Click += new System.EventHandler(this.AddServerButton_Click);
            // 
            // NicknameTextBox
            // 
            this.NicknameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.NicknameTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NicknameTextBox.Location = new System.Drawing.Point(98, 12);
            this.NicknameTextBox.Name = "NicknameTextBox";
            this.NicknameTextBox.Size = new System.Drawing.Size(213, 24);
            this.NicknameTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.NicknameTextBox.TabIndex = 11;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.RefreshAllButton);
            this.metroPanel1.Controls.Add(this.DeleteSelectedServerButton);
            this.metroPanel1.Controls.Add(this.NicknameTextBox);
            this.metroPanel1.Controls.Add(this.metroButton4);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(13, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(495, 95);
            this.metroPanel1.TabIndex = 12;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Connect_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.ServerList);
            this.Name = "Connect_Form";
            this.Size = new System.Drawing.Size(839, 407);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServerList)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ServerList;
        private MetroFramework.Controls.MetroButton RefreshAllButton;
        private MetroFramework.Controls.MetroButton DeleteSelectedServerButton;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroTextBox NicknameTextBox;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Basename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Players;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ping;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gamemode;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
    }
}
