using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace Assignment1
{
    public partial class ActionEvent : Form
    {
        private double mouseX;
        private double mouseY;
        private String eventType = "twitter";

        public ActionEvent()
        {
            InitializeComponent();
        }

        public ActionEvent(double mouseX, double mouseY)
        {
            InitializeComponent();
            this.mouseX = mouseX;
            this.mouseY = mouseY;
        }

        public String EventType
        {
            get { return eventType; }
            set { eventType = value; }
        }

        public double MouseX
        {
            get { return mouseX; }
            set { mouseX = value; }
        }

        public double MouseY
        {
            get { return mouseY; }
            set { mouseY = value; }
        }

        private void InsChecked(object sender, EventArgs e)
        {
            panelTwitter.Visible = false;
            panelPhoto.Visible = false;
            panelVideo.Visible = false;
            panelTrackLog.Visible = false;
            panelAddPerson.Visible = false;

            panelIns.Visible = true;
            panelIns.BringToFront();

            eventType = "instagram";

            String a = mouseX.ToString();
            String b = mouseY.ToString();

        }

        private void tweetChecked(object sender, EventArgs e)
        {
            panelIns.Visible = false;
            panelPhoto.Visible = false;
            panelVideo.Visible = false;
            panelTrackLog.Visible = false;
            panelAddPerson.Visible = false;

            panelTwitter.Visible = true;
            panelTwitter.BringToFront();

            eventType = "twitter";
        }

        private void photoChecked(object sender, EventArgs e)
        {
            panelIns.Visible = false;
            panelTwitter.Visible = false;
            panelVideo.Visible = false;
            panelTrackLog.Visible = false;
            panelAddPerson.Visible = false;

            panelPhoto.Visible = true;
            panelPhoto.BringToFront();

            eventType = "photo";
        }

        private void videoChecked(object sender, EventArgs e)
        {
            panelIns.Visible = false;
            panelTwitter.Visible = false;
            panelPhoto.Visible = false;
            panelTrackLog.Visible = false;
            panelAddPerson.Visible = false;

            panelVideo.Visible = true;
            panelVideo.BringToFront();

            eventType = "video";
        }

        private void tracklogChecked(object sender, EventArgs e)
        {
            panelIns.Visible = false;
            panelTwitter.Visible = false;
            panelVideo.Visible = false;
            panelPhoto.Visible = false;
            panelAddPerson.Visible = false;

            panelTrackLog.Visible = true;
            panelTrackLog.BringToFront();

            eventType = "tracklog";
        }

        private void radioAddPerson_CheckedChanged(object sender, EventArgs e)
        {
            panelAddPerson.Visible = false;
            panelAddPerson.Visible = false;
            panelAddPerson.Visible = false;
            panelAddPerson.Visible = false;
            panelTrackLog.Visible = false;

            panelAddPerson.Visible = true;
            panelAddPerson.BringToFront();

            eventType = "addPerson";

        }

        private void cancelBtnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtnClick(object sender, EventArgs e)
        {
            AddEvents addEvent = new AddEvents();

            if(eventType == "twitter")
            {
                
                addEvent.AddTweet(textTwitterText.Text, textTwitterDate.Text, MouseX, MouseY);
                Application.Restart();
                Console.WriteLine("RESTART");
            }
            else if(eventType == "instagram")
            {
                addEvent.AddInstagram(textFbText.Text, textFbDate.Text, MouseX, MouseY);
                Application.Restart();
            }
            else if(eventType == "photo")
            {
                addEvent.AddPhoto(textPhotoFilePath.Text, MouseX, MouseY);
                Application.Restart();
            }
            else if (eventType == "video")
            {
                addEvent.AddVideo(textBoxVideoFilePath.Text, MouseX, MouseY);
                Application.Restart();
            }
            else if (eventType == "tracklog")
            {
                addEvent.AddTrackLog(textBoxFilepathTracklog.Text, MouseX, MouseY, textBoxLat2Tracklog.Text, textBoxLongi2Tracklog.Text);
                Application.Restart();
            }
            else if (eventType == "addPerson")
            {
                addEvent.AddPerson(textBoxFirstNameAddPerson.Text, textBoxLastNameAddPerson.Text, textBoxContactAddPerson.Text, textBoxStreetNumberAddPerson.Text, textBoxStreetNameAddPerson.Text, MouseX, MouseY);
                Application.Restart();
            }
            else
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelLat2Tracklog_Click(object sender, EventArgs e)
        {

        }

        private void panelTrackLog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelAddPerson_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelPhoto_Click(object sender, EventArgs e)
        {

        }

        private void textPhotoFilePath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
