namespace Assignment1
{
    partial class ActionEvent
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
            this.radioIns = new System.Windows.Forms.RadioButton();
            this.radioTweet = new System.Windows.Forms.RadioButton();
            this.radioPhoto = new System.Windows.Forms.RadioButton();
            this.radioVideo = new System.Windows.Forms.RadioButton();
            this.radioTrack = new System.Windows.Forms.RadioButton();
            this.panelIns = new System.Windows.Forms.Panel();
            this.textFbDate = new System.Windows.Forms.TextBox();
            this.labelFbDate = new System.Windows.Forms.Label();
            this.LabelFbText = new System.Windows.Forms.Label();
            this.textFbText = new System.Windows.Forms.TextBox();
            this.panelTwitter = new System.Windows.Forms.Panel();
            this.textTwitterDate = new System.Windows.Forms.TextBox();
            this.labelTwitterDate = new System.Windows.Forms.Label();
            this.labelTwitterText = new System.Windows.Forms.Label();
            this.textTwitterText = new System.Windows.Forms.TextBox();
            this.panelPhoto = new System.Windows.Forms.Panel();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.textPhotoFilePath = new System.Windows.Forms.TextBox();
            this.panelVideo = new System.Windows.Forms.Panel();
            this.panelAddPerson = new System.Windows.Forms.Panel();
            this.textBoxStreetNameAddPerson = new System.Windows.Forms.TextBox();
            this.textBoxStreetNumberAddPerson = new System.Windows.Forms.TextBox();
            this.textBoxContactAddPerson = new System.Windows.Forms.TextBox();
            this.textBoxLastNameAddPerson = new System.Windows.Forms.TextBox();
            this.textBoxFirstNameAddPerson = new System.Windows.Forms.TextBox();
            this.StreetNameAddPerson = new System.Windows.Forms.Label();
            this.StreetNumberAddPerson = new System.Windows.Forms.Label();
            this.ContactAddPerson = new System.Windows.Forms.Label();
            this.LastNameAddPerson = new System.Windows.Forms.Label();
            this.FirstNameAddPerson = new System.Windows.Forms.Label();
            this.labelVideoFilePath = new System.Windows.Forms.Label();
            this.textBoxVideoFilePath = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panelTrackLog = new System.Windows.Forms.Panel();
            this.labelLongi2Tracklog = new System.Windows.Forms.Label();
            this.textBoxLongi2Tracklog = new System.Windows.Forms.TextBox();
            this.textBoxLat2Tracklog = new System.Windows.Forms.TextBox();
            this.labelLat2Tracklog = new System.Windows.Forms.Label();
            this.labelFilepathTracklog = new System.Windows.Forms.Label();
            this.textBoxFilepathTracklog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioAddPerson = new System.Windows.Forms.RadioButton();
            this.panelIns.SuspendLayout();
            this.panelTwitter.SuspendLayout();
            this.panelPhoto.SuspendLayout();
            this.panelVideo.SuspendLayout();
            this.panelAddPerson.SuspendLayout();
            this.panelTrackLog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioIns
            // 
            this.radioIns.AutoSize = true;
            this.radioIns.Location = new System.Drawing.Point(7, 22);
            this.radioIns.Margin = new System.Windows.Forms.Padding(4);
            this.radioIns.Name = "radioIns";
            this.radioIns.Size = new System.Drawing.Size(135, 21);
            this.radioIns.TabIndex = 1;
            this.radioIns.TabStop = true;
            this.radioIns.Text = "Instagram Status";
            this.radioIns.UseVisualStyleBackColor = true;
            this.radioIns.CheckedChanged += new System.EventHandler(this.InsChecked);
            // 
            // radioTweet
            // 
            this.radioTweet.AutoSize = true;
            this.radioTweet.Location = new System.Drawing.Point(7, 51);
            this.radioTweet.Margin = new System.Windows.Forms.Padding(4);
            this.radioTweet.Name = "radioTweet";
            this.radioTweet.Size = new System.Drawing.Size(67, 21);
            this.radioTweet.TabIndex = 2;
            this.radioTweet.TabStop = true;
            this.radioTweet.Text = "Tweet";
            this.radioTweet.UseVisualStyleBackColor = true;
            this.radioTweet.CheckedChanged += new System.EventHandler(this.tweetChecked);
            // 
            // radioPhoto
            // 
            this.radioPhoto.AutoSize = true;
            this.radioPhoto.Location = new System.Drawing.Point(7, 80);
            this.radioPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.radioPhoto.Name = "radioPhoto";
            this.radioPhoto.Size = new System.Drawing.Size(66, 21);
            this.radioPhoto.TabIndex = 3;
            this.radioPhoto.TabStop = true;
            this.radioPhoto.Text = "Photo";
            this.radioPhoto.UseVisualStyleBackColor = true;
            this.radioPhoto.CheckedChanged += new System.EventHandler(this.photoChecked);
            // 
            // radioVideo
            // 
            this.radioVideo.AutoSize = true;
            this.radioVideo.Location = new System.Drawing.Point(178, 23);
            this.radioVideo.Margin = new System.Windows.Forms.Padding(4);
            this.radioVideo.Name = "radioVideo";
            this.radioVideo.Size = new System.Drawing.Size(65, 21);
            this.radioVideo.TabIndex = 4;
            this.radioVideo.TabStop = true;
            this.radioVideo.Text = "Video";
            this.radioVideo.UseVisualStyleBackColor = true;
            this.radioVideo.CheckedChanged += new System.EventHandler(this.videoChecked);
            // 
            // radioTrack
            // 
            this.radioTrack.AutoSize = true;
            this.radioTrack.Location = new System.Drawing.Point(178, 52);
            this.radioTrack.Margin = new System.Windows.Forms.Padding(4);
            this.radioTrack.Name = "radioTrack";
            this.radioTrack.Size = new System.Drawing.Size(84, 21);
            this.radioTrack.TabIndex = 5;
            this.radioTrack.TabStop = true;
            this.radioTrack.Text = "Tracklog";
            this.radioTrack.UseVisualStyleBackColor = true;
            this.radioTrack.CheckedChanged += new System.EventHandler(this.tracklogChecked);
            // 
            // panelIns
            // 
            this.panelIns.Controls.Add(this.textFbDate);
            this.panelIns.Controls.Add(this.labelFbDate);
            this.panelIns.Controls.Add(this.LabelFbText);
            this.panelIns.Controls.Add(this.textFbText);
            this.panelIns.Location = new System.Drawing.Point(29, 158);
            this.panelIns.Margin = new System.Windows.Forms.Padding(4);
            this.panelIns.Name = "panelIns";
            this.panelIns.Size = new System.Drawing.Size(479, 210);
            this.panelIns.TabIndex = 6;
            // 
            // textFbDate
            // 
            this.textFbDate.Location = new System.Drawing.Point(89, 41);
            this.textFbDate.Margin = new System.Windows.Forms.Padding(4);
            this.textFbDate.Name = "textFbDate";
            this.textFbDate.Size = new System.Drawing.Size(132, 22);
            this.textFbDate.TabIndex = 3;
            // 
            // labelFbDate
            // 
            this.labelFbDate.AutoSize = true;
            this.labelFbDate.Location = new System.Drawing.Point(21, 49);
            this.labelFbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFbDate.Name = "labelFbDate";
            this.labelFbDate.Size = new System.Drawing.Size(42, 17);
            this.labelFbDate.TabIndex = 2;
            this.labelFbDate.Text = "Date:";
            // 
            // LabelFbText
            // 
            this.LabelFbText.AutoSize = true;
            this.LabelFbText.Location = new System.Drawing.Point(17, 9);
            this.LabelFbText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFbText.Name = "LabelFbText";
            this.LabelFbText.Size = new System.Drawing.Size(39, 17);
            this.LabelFbText.TabIndex = 1;
            this.LabelFbText.Text = "Text:";
            // 
            // textFbText
            // 
            this.textFbText.Location = new System.Drawing.Point(89, 5);
            this.textFbText.Margin = new System.Windows.Forms.Padding(4);
            this.textFbText.Name = "textFbText";
            this.textFbText.Size = new System.Drawing.Size(132, 22);
            this.textFbText.TabIndex = 0;
            // 
            // panelTwitter
            // 
            this.panelTwitter.Controls.Add(this.textTwitterDate);
            this.panelTwitter.Controls.Add(this.labelTwitterDate);
            this.panelTwitter.Controls.Add(this.labelTwitterText);
            this.panelTwitter.Controls.Add(this.textTwitterText);
            this.panelTwitter.Location = new System.Drawing.Point(25, 158);
            this.panelTwitter.Margin = new System.Windows.Forms.Padding(4);
            this.panelTwitter.Name = "panelTwitter";
            this.panelTwitter.Size = new System.Drawing.Size(479, 210);
            this.panelTwitter.TabIndex = 7;
            // 
            // textTwitterDate
            // 
            this.textTwitterDate.Location = new System.Drawing.Point(89, 41);
            this.textTwitterDate.Margin = new System.Windows.Forms.Padding(4);
            this.textTwitterDate.Name = "textTwitterDate";
            this.textTwitterDate.Size = new System.Drawing.Size(132, 22);
            this.textTwitterDate.TabIndex = 3;
            // 
            // labelTwitterDate
            // 
            this.labelTwitterDate.AutoSize = true;
            this.labelTwitterDate.Location = new System.Drawing.Point(21, 49);
            this.labelTwitterDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTwitterDate.Name = "labelTwitterDate";
            this.labelTwitterDate.Size = new System.Drawing.Size(42, 17);
            this.labelTwitterDate.TabIndex = 2;
            this.labelTwitterDate.Text = "Date:";
            // 
            // labelTwitterText
            // 
            this.labelTwitterText.AutoSize = true;
            this.labelTwitterText.Location = new System.Drawing.Point(17, 9);
            this.labelTwitterText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTwitterText.Name = "labelTwitterText";
            this.labelTwitterText.Size = new System.Drawing.Size(39, 17);
            this.labelTwitterText.TabIndex = 1;
            this.labelTwitterText.Text = "Text:";
            // 
            // textTwitterText
            // 
            this.textTwitterText.Location = new System.Drawing.Point(89, 5);
            this.textTwitterText.Margin = new System.Windows.Forms.Padding(4);
            this.textTwitterText.Name = "textTwitterText";
            this.textTwitterText.Size = new System.Drawing.Size(132, 22);
            this.textTwitterText.TabIndex = 0;
            // 
            // panelPhoto
            // 
            this.panelPhoto.Controls.Add(this.labelPhoto);
            this.panelPhoto.Controls.Add(this.textPhotoFilePath);
            this.panelPhoto.Location = new System.Drawing.Point(25, 152);
            this.panelPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.panelPhoto.Name = "panelPhoto";
            this.panelPhoto.Size = new System.Drawing.Size(479, 208);
            this.panelPhoto.TabIndex = 8;
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(17, 9);
            this.labelPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(67, 17);
            this.labelPhoto.TabIndex = 1;
            this.labelPhoto.Text = "FilePath: ";
            this.labelPhoto.Click += new System.EventHandler(this.labelPhoto_Click);
            // 
            // textPhotoFilePath
            // 
            this.textPhotoFilePath.Location = new System.Drawing.Point(89, 5);
            this.textPhotoFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.textPhotoFilePath.Name = "textPhotoFilePath";
            this.textPhotoFilePath.Size = new System.Drawing.Size(132, 22);
            this.textPhotoFilePath.TabIndex = 0;
            this.textPhotoFilePath.TextChanged += new System.EventHandler(this.textPhotoFilePath_TextChanged);
            // 
            // panelVideo
            // 
            this.panelVideo.Controls.Add(this.panelAddPerson);
            this.panelVideo.Controls.Add(this.labelVideoFilePath);
            this.panelVideo.Controls.Add(this.textBoxVideoFilePath);
            this.panelVideo.Location = new System.Drawing.Point(21, 152);
            this.panelVideo.Margin = new System.Windows.Forms.Padding(4);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(479, 212);
            this.panelVideo.TabIndex = 9;
            // 
            // panelAddPerson
            // 
            this.panelAddPerson.Controls.Add(this.textBoxStreetNameAddPerson);
            this.panelAddPerson.Controls.Add(this.textBoxStreetNumberAddPerson);
            this.panelAddPerson.Controls.Add(this.textBoxContactAddPerson);
            this.panelAddPerson.Controls.Add(this.textBoxLastNameAddPerson);
            this.panelAddPerson.Controls.Add(this.textBoxFirstNameAddPerson);
            this.panelAddPerson.Controls.Add(this.StreetNameAddPerson);
            this.panelAddPerson.Controls.Add(this.StreetNumberAddPerson);
            this.panelAddPerson.Controls.Add(this.ContactAddPerson);
            this.panelAddPerson.Controls.Add(this.LastNameAddPerson);
            this.panelAddPerson.Controls.Add(this.FirstNameAddPerson);
            this.panelAddPerson.Location = new System.Drawing.Point(3, 0);
            this.panelAddPerson.Name = "panelAddPerson";
            this.panelAddPerson.Size = new System.Drawing.Size(483, 212);
            this.panelAddPerson.TabIndex = 12;
            this.panelAddPerson.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAddPerson_Paint);
            // 
            // textBoxStreetNameAddPerson
            // 
            this.textBoxStreetNameAddPerson.Location = new System.Drawing.Point(118, 145);
            this.textBoxStreetNameAddPerson.Name = "textBoxStreetNameAddPerson";
            this.textBoxStreetNameAddPerson.Size = new System.Drawing.Size(139, 22);
            this.textBoxStreetNameAddPerson.TabIndex = 20;
            // 
            // textBoxStreetNumberAddPerson
            // 
            this.textBoxStreetNumberAddPerson.Location = new System.Drawing.Point(118, 112);
            this.textBoxStreetNumberAddPerson.Name = "textBoxStreetNumberAddPerson";
            this.textBoxStreetNumberAddPerson.Size = new System.Drawing.Size(139, 22);
            this.textBoxStreetNumberAddPerson.TabIndex = 19;
            // 
            // textBoxContactAddPerson
            // 
            this.textBoxContactAddPerson.Location = new System.Drawing.Point(106, 84);
            this.textBoxContactAddPerson.Name = "textBoxContactAddPerson";
            this.textBoxContactAddPerson.Size = new System.Drawing.Size(151, 22);
            this.textBoxContactAddPerson.TabIndex = 18;
            // 
            // textBoxLastNameAddPerson
            // 
            this.textBoxLastNameAddPerson.Location = new System.Drawing.Point(106, 52);
            this.textBoxLastNameAddPerson.Name = "textBoxLastNameAddPerson";
            this.textBoxLastNameAddPerson.Size = new System.Drawing.Size(152, 22);
            this.textBoxLastNameAddPerson.TabIndex = 17;
            // 
            // textBoxFirstNameAddPerson
            // 
            this.textBoxFirstNameAddPerson.Location = new System.Drawing.Point(106, 18);
            this.textBoxFirstNameAddPerson.Name = "textBoxFirstNameAddPerson";
            this.textBoxFirstNameAddPerson.Size = new System.Drawing.Size(152, 22);
            this.textBoxFirstNameAddPerson.TabIndex = 16;
            // 
            // StreetNameAddPerson
            // 
            this.StreetNameAddPerson.AutoSize = true;
            this.StreetNameAddPerson.Location = new System.Drawing.Point(13, 148);
            this.StreetNameAddPerson.Name = "StreetNameAddPerson";
            this.StreetNameAddPerson.Size = new System.Drawing.Size(87, 17);
            this.StreetNameAddPerson.TabIndex = 15;
            this.StreetNameAddPerson.Text = "StreetName:";
            // 
            // StreetNumberAddPerson
            // 
            this.StreetNumberAddPerson.AutoSize = true;
            this.StreetNumberAddPerson.Location = new System.Drawing.Point(9, 111);
            this.StreetNumberAddPerson.Name = "StreetNumberAddPerson";
            this.StreetNumberAddPerson.Size = new System.Drawing.Size(100, 17);
            this.StreetNumberAddPerson.TabIndex = 14;
            this.StreetNumberAddPerson.Text = "StreetNumber:";
            // 
            // ContactAddPerson
            // 
            this.ContactAddPerson.AutoSize = true;
            this.ContactAddPerson.Location = new System.Drawing.Point(21, 84);
            this.ContactAddPerson.Name = "ContactAddPerson";
            this.ContactAddPerson.Size = new System.Drawing.Size(60, 17);
            this.ContactAddPerson.TabIndex = 13;
            this.ContactAddPerson.Text = "Contact:";
            this.ContactAddPerson.Click += new System.EventHandler(this.label3_Click);
            // 
            // LastNameAddPerson
            // 
            this.LastNameAddPerson.AutoSize = true;
            this.LastNameAddPerson.Location = new System.Drawing.Point(13, 52);
            this.LastNameAddPerson.Name = "LastNameAddPerson";
            this.LastNameAddPerson.Size = new System.Drawing.Size(76, 17);
            this.LastNameAddPerson.TabIndex = 1;
            this.LastNameAddPerson.Text = "LastName:";
            this.LastNameAddPerson.Click += new System.EventHandler(this.label2_Click);
            // 
            // FirstNameAddPerson
            // 
            this.FirstNameAddPerson.AutoSize = true;
            this.FirstNameAddPerson.Location = new System.Drawing.Point(13, 18);
            this.FirstNameAddPerson.Name = "FirstNameAddPerson";
            this.FirstNameAddPerson.Size = new System.Drawing.Size(76, 17);
            this.FirstNameAddPerson.TabIndex = 0;
            this.FirstNameAddPerson.Text = "FirstName:";
            this.FirstNameAddPerson.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelVideoFilePath
            // 
            this.labelVideoFilePath.AutoSize = true;
            this.labelVideoFilePath.Location = new System.Drawing.Point(17, 9);
            this.labelVideoFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVideoFilePath.Name = "labelVideoFilePath";
            this.labelVideoFilePath.Size = new System.Drawing.Size(67, 17);
            this.labelVideoFilePath.TabIndex = 1;
            this.labelVideoFilePath.Text = "FilePath: ";
            // 
            // textBoxVideoFilePath
            // 
            this.textBoxVideoFilePath.Location = new System.Drawing.Point(89, 5);
            this.textBoxVideoFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVideoFilePath.Name = "textBoxVideoFilePath";
            this.textBoxVideoFilePath.Size = new System.Drawing.Size(132, 22);
            this.textBoxVideoFilePath.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(262, 397);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 28);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtnClick);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(71, 397);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtnClick);
            // 
            // panelTrackLog
            // 
            this.panelTrackLog.Controls.Add(this.labelLongi2Tracklog);
            this.panelTrackLog.Controls.Add(this.textBoxLongi2Tracklog);
            this.panelTrackLog.Controls.Add(this.textBoxLat2Tracklog);
            this.panelTrackLog.Controls.Add(this.labelLat2Tracklog);
            this.panelTrackLog.Controls.Add(this.labelFilepathTracklog);
            this.panelTrackLog.Controls.Add(this.textBoxFilepathTracklog);
            this.panelTrackLog.Location = new System.Drawing.Point(21, 156);
            this.panelTrackLog.Margin = new System.Windows.Forms.Padding(4);
            this.panelTrackLog.Name = "panelTrackLog";
            this.panelTrackLog.Size = new System.Drawing.Size(475, 212);
            this.panelTrackLog.TabIndex = 10;
            this.panelTrackLog.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTrackLog_Paint);
            // 
            // labelLongi2Tracklog
            // 
            this.labelLongi2Tracklog.AutoSize = true;
            this.labelLongi2Tracklog.Location = new System.Drawing.Point(9, 75);
            this.labelLongi2Tracklog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLongi2Tracklog.Name = "labelLongi2Tracklog";
            this.labelLongi2Tracklog.Size = new System.Drawing.Size(123, 17);
            this.labelLongi2Tracklog.TabIndex = 5;
            this.labelLongi2Tracklog.Text = "Second Longitude";
            // 
            // textBoxLongi2Tracklog
            // 
            this.textBoxLongi2Tracklog.Location = new System.Drawing.Point(143, 70);
            this.textBoxLongi2Tracklog.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLongi2Tracklog.Name = "textBoxLongi2Tracklog";
            this.textBoxLongi2Tracklog.Size = new System.Drawing.Size(100, 22);
            this.textBoxLongi2Tracklog.TabIndex = 4;
            // 
            // textBoxLat2Tracklog
            // 
            this.textBoxLat2Tracklog.Location = new System.Drawing.Point(143, 41);
            this.textBoxLat2Tracklog.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLat2Tracklog.Name = "textBoxLat2Tracklog";
            this.textBoxLat2Tracklog.Size = new System.Drawing.Size(100, 22);
            this.textBoxLat2Tracklog.TabIndex = 3;
            // 
            // labelLat2Tracklog
            // 
            this.labelLat2Tracklog.AutoSize = true;
            this.labelLat2Tracklog.Location = new System.Drawing.Point(9, 41);
            this.labelLat2Tracklog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLat2Tracklog.Name = "labelLat2Tracklog";
            this.labelLat2Tracklog.Size = new System.Drawing.Size(110, 17);
            this.labelLat2Tracklog.TabIndex = 2;
            this.labelLat2Tracklog.Text = "Second lattitude";
            this.labelLat2Tracklog.Click += new System.EventHandler(this.labelLat2Tracklog_Click);
            // 
            // labelFilepathTracklog
            // 
            this.labelFilepathTracklog.AutoSize = true;
            this.labelFilepathTracklog.Location = new System.Drawing.Point(9, 12);
            this.labelFilepathTracklog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilepathTracklog.Name = "labelFilepathTracklog";
            this.labelFilepathTracklog.Size = new System.Drawing.Size(67, 17);
            this.labelFilepathTracklog.TabIndex = 1;
            this.labelFilepathTracklog.Text = "FilePath: ";
            // 
            // textBoxFilepathTracklog
            // 
            this.textBoxFilepathTracklog.Location = new System.Drawing.Point(135, 6);
            this.textBoxFilepathTracklog.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFilepathTracklog.Name = "textBoxFilepathTracklog";
            this.textBoxFilepathTracklog.Size = new System.Drawing.Size(132, 22);
            this.textBoxFilepathTracklog.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioAddPerson);
            this.groupBox1.Controls.Add(this.radioIns);
            this.groupBox1.Controls.Add(this.radioTweet);
            this.groupBox1.Controls.Add(this.radioPhoto);
            this.groupBox1.Controls.Add(this.radioVideo);
            this.groupBox1.Controls.Add(this.radioTrack);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 126);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioAddPerson
            // 
            this.radioAddPerson.AutoSize = true;
            this.radioAddPerson.Location = new System.Drawing.Point(178, 80);
            this.radioAddPerson.Name = "radioAddPerson";
            this.radioAddPerson.Size = new System.Drawing.Size(103, 21);
            this.radioAddPerson.TabIndex = 6;
            this.radioAddPerson.TabStop = true;
            this.radioAddPerson.Text = "Add Person";
            this.radioAddPerson.UseVisualStyleBackColor = true;
            this.radioAddPerson.CheckedChanged += new System.EventHandler(this.radioAddPerson_CheckedChanged);
            // 
            // ActionEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 465);
            this.Controls.Add(this.panelVideo);
            this.Controls.Add(this.panelPhoto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTrackLog);
            this.Controls.Add(this.panelTwitter);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panelIns);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ActionEvent";
            this.Text = "Form2";
            this.panelIns.ResumeLayout(false);
            this.panelIns.PerformLayout();
            this.panelTwitter.ResumeLayout(false);
            this.panelTwitter.PerformLayout();
            this.panelPhoto.ResumeLayout(false);
            this.panelPhoto.PerformLayout();
            this.panelVideo.ResumeLayout(false);
            this.panelVideo.PerformLayout();
            this.panelAddPerson.ResumeLayout(false);
            this.panelAddPerson.PerformLayout();
            this.panelTrackLog.ResumeLayout(false);
            this.panelTrackLog.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioIns;
        private System.Windows.Forms.RadioButton radioTweet;
        private System.Windows.Forms.RadioButton radioPhoto;
        private System.Windows.Forms.RadioButton radioVideo;
        private System.Windows.Forms.RadioButton radioTrack;
        private System.Windows.Forms.Panel panelIns;
        private System.Windows.Forms.Label LabelFbText;
        private System.Windows.Forms.TextBox textFbText;
        private System.Windows.Forms.TextBox textFbDate;
        private System.Windows.Forms.Label labelFbDate;
        private System.Windows.Forms.Panel panelTwitter;
        private System.Windows.Forms.TextBox textTwitterDate;
        private System.Windows.Forms.Label labelTwitterDate;
        private System.Windows.Forms.Label labelTwitterText;
        private System.Windows.Forms.TextBox textTwitterText;
        private System.Windows.Forms.Panel panelPhoto;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.TextBox textPhotoFilePath;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel panelVideo;
        private System.Windows.Forms.Label labelVideoFilePath;
        private System.Windows.Forms.TextBox textBoxVideoFilePath;
        private System.Windows.Forms.Panel panelTrackLog;
        private System.Windows.Forms.Label labelLat2Tracklog;
        private System.Windows.Forms.Label labelFilepathTracklog;
        private System.Windows.Forms.TextBox textBoxFilepathTracklog;
        private System.Windows.Forms.TextBox textBoxLat2Tracklog;
        private System.Windows.Forms.Label labelLongi2Tracklog;
        private System.Windows.Forms.TextBox textBoxLongi2Tracklog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelAddPerson;
        private System.Windows.Forms.Label FirstNameAddPerson;
        private System.Windows.Forms.Label StreetNameAddPerson;
        private System.Windows.Forms.Label StreetNumberAddPerson;
        private System.Windows.Forms.Label ContactAddPerson;
        private System.Windows.Forms.Label LastNameAddPerson;
        private System.Windows.Forms.TextBox textBoxStreetNameAddPerson;
        private System.Windows.Forms.TextBox textBoxStreetNumberAddPerson;
        private System.Windows.Forms.TextBox textBoxContactAddPerson;
        private System.Windows.Forms.TextBox textBoxLastNameAddPerson;
        private System.Windows.Forms.TextBox textBoxFirstNameAddPerson;
        private System.Windows.Forms.RadioButton radioAddPerson;
    }
}