namespace Prototype
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.txtFriendSearch = new System.Windows.Forms.TextBox();
            this.lstUserList = new System.Windows.Forms.ListBox();
            this.lstUserFriends = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFacebookInfo = new System.Windows.Forms.TabPage();
            this.lbUserInfoWork = new System.Windows.Forms.Label();
            this.lbUserInfoUni = new System.Windows.Forms.Label();
            this.lstUserMessages = new System.Windows.Forms.ListBox();
            this.lbUserInfoHometown = new System.Windows.Forms.Label();
            this.lbUserInfoCity = new System.Windows.Forms.Label();
            this.lbUserInfoGender = new System.Windows.Forms.Label();
            this.lbUserInfoName = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabFacebookInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Location = new System.Drawing.Point(12, 12);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(185, 20);
            this.txtUserSearch.TabIndex = 0;
            // 
            // txtFriendSearch
            // 
            this.txtFriendSearch.Location = new System.Drawing.Point(199, 6);
            this.txtFriendSearch.Name = "txtFriendSearch";
            this.txtFriendSearch.Size = new System.Drawing.Size(192, 20);
            this.txtFriendSearch.TabIndex = 2;
            // 
            // lstUserList
            // 
            this.lstUserList.FormattingEnabled = true;
            this.lstUserList.Location = new System.Drawing.Point(12, 38);
            this.lstUserList.Name = "lstUserList";
            this.lstUserList.Size = new System.Drawing.Size(185, 316);
            this.lstUserList.TabIndex = 4;
            this.lstUserList.SelectedIndexChanged += new System.EventHandler(this.lstUserList_SelectedIndexChanged);
            // 
            // lstUserFriends
            // 
            this.lstUserFriends.FormattingEnabled = true;
            this.lstUserFriends.Location = new System.Drawing.Point(199, 32);
            this.lstUserFriends.Name = "lstUserFriends";
            this.lstUserFriends.Size = new System.Drawing.Size(192, 134);
            this.lstUserFriends.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFacebookInfo);
            this.tabControl1.Location = new System.Drawing.Point(203, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(405, 342);
            this.tabControl1.TabIndex = 6;
            // 
            // tabFacebookInfo
            // 
            this.tabFacebookInfo.Controls.Add(this.lbUserInfoWork);
            this.tabFacebookInfo.Controls.Add(this.lbUserInfoUni);
            this.tabFacebookInfo.Controls.Add(this.lstUserMessages);
            this.tabFacebookInfo.Controls.Add(this.lbUserInfoHometown);
            this.tabFacebookInfo.Controls.Add(this.lbUserInfoCity);
            this.tabFacebookInfo.Controls.Add(this.lbUserInfoGender);
            this.tabFacebookInfo.Controls.Add(this.lbUserInfoName);
            this.tabFacebookInfo.Controls.Add(this.lstUserFriends);
            this.tabFacebookInfo.Controls.Add(this.txtFriendSearch);
            this.tabFacebookInfo.Location = new System.Drawing.Point(4, 22);
            this.tabFacebookInfo.Name = "tabFacebookInfo";
            this.tabFacebookInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabFacebookInfo.Size = new System.Drawing.Size(397, 316);
            this.tabFacebookInfo.TabIndex = 0;
            this.tabFacebookInfo.Text = "Info";
            this.tabFacebookInfo.UseVisualStyleBackColor = true;
            // 
            // lbUserInfoWork
            // 
            this.lbUserInfoWork.AutoSize = true;
            this.lbUserInfoWork.Location = new System.Drawing.Point(3, 132);
            this.lbUserInfoWork.Name = "lbUserInfoWork";
            this.lbUserInfoWork.Size = new System.Drawing.Size(0, 13);
            this.lbUserInfoWork.TabIndex = 15;
            // 
            // lbUserInfoUni
            // 
            this.lbUserInfoUni.AutoSize = true;
            this.lbUserInfoUni.Location = new System.Drawing.Point(3, 107);
            this.lbUserInfoUni.Name = "lbUserInfoUni";
            this.lbUserInfoUni.Size = new System.Drawing.Size(0, 13);
            this.lbUserInfoUni.TabIndex = 14;
            // 
            // lstUserMessages
            // 
            this.lstUserMessages.FormattingEnabled = true;
            this.lstUserMessages.Location = new System.Drawing.Point(6, 172);
            this.lstUserMessages.Name = "lstUserMessages";
            this.lstUserMessages.Size = new System.Drawing.Size(385, 134);
            this.lstUserMessages.TabIndex = 10;
            // 
            // lbUserInfoHometown
            // 
            this.lbUserInfoHometown.AutoSize = true;
            this.lbUserInfoHometown.Location = new System.Drawing.Point(3, 83);
            this.lbUserInfoHometown.Name = "lbUserInfoHometown";
            this.lbUserInfoHometown.Size = new System.Drawing.Size(0, 13);
            this.lbUserInfoHometown.TabIndex = 9;
            // 
            // lbUserInfoCity
            // 
            this.lbUserInfoCity.AutoSize = true;
            this.lbUserInfoCity.Location = new System.Drawing.Point(3, 57);
            this.lbUserInfoCity.Name = "lbUserInfoCity";
            this.lbUserInfoCity.Size = new System.Drawing.Size(0, 13);
            this.lbUserInfoCity.TabIndex = 8;
            // 
            // lbUserInfoGender
            // 
            this.lbUserInfoGender.AutoSize = true;
            this.lbUserInfoGender.Location = new System.Drawing.Point(3, 32);
            this.lbUserInfoGender.Name = "lbUserInfoGender";
            this.lbUserInfoGender.Size = new System.Drawing.Size(0, 13);
            this.lbUserInfoGender.TabIndex = 7;
            // 
            // lbUserInfoName
            // 
            this.lbUserInfoName.AutoSize = true;
            this.lbUserInfoName.Location = new System.Drawing.Point(3, 6);
            this.lbUserInfoName.Name = "lbUserInfoName";
            this.lbUserInfoName.Size = new System.Drawing.Size(0, 13);
            this.lbUserInfoName.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 356);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lstUserList);
            this.Controls.Add(this.txtUserSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Facebook Info";
            this.tabControl1.ResumeLayout(false);
            this.tabFacebookInfo.ResumeLayout(false);
            this.tabFacebookInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.TextBox txtFriendSearch;
        private System.Windows.Forms.ListBox lstUserList;
        private System.Windows.Forms.ListBox lstUserFriends;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFacebookInfo;
        private System.Windows.Forms.Label lbUserInfoHometown;
        private System.Windows.Forms.Label lbUserInfoCity;
        private System.Windows.Forms.Label lbUserInfoGender;
        private System.Windows.Forms.Label lbUserInfoName;
        private System.Windows.Forms.ListBox lstUserMessages;
        private System.Windows.Forms.Label lbUserInfoWork;
        private System.Windows.Forms.Label lbUserInfoUni;
    }
}

