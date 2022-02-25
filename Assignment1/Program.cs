using System;
using System.Drawing;
using System.Windows.Forms;


namespace Assignment1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ReadEvent readEvent = new ReadEvent();
            readEvent.ReadXML();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Gmap Form1 = new Gmap();

            Console.WriteLine("Start of program...");

            foreach (var pair in readEvent.TweetDict)
            {

                Console.WriteLine("TWITTER");
                double longi = readEvent.TweetDict[pair.Key].Longi;
                double lat = readEvent.TweetDict[pair.Key].Lat;
                String text = readEvent.TweetDict[pair.Key].Text;
                String date = readEvent.TweetDict[pair.Key].DateTimeStamp;

                string path = "img/twitterIcon.png";

                Bitmap twitterMarker = (Bitmap)Image.FromFile(path);

                Form1.AddMarker(lat, longi, text, date, twitterMarker);
            }

            foreach (var pair in readEvent.InstagramDict)
            {
                Console.WriteLine("INSTAGRAM");
                double longi = readEvent.InstagramDict[pair.Key].Longi;
                double lat = readEvent.InstagramDict[pair.Key].Lat;
                String text = readEvent.InstagramDict[pair.Key].Text;
                String date = readEvent.InstagramDict[pair.Key].DateTimeStamp;

                string path = @"img/InstagramIcon.png";

                Bitmap InsMarker = (Bitmap)Image.FromFile(path);

                Form1.AddMarker(lat, longi, text, date, InsMarker);
            }

            foreach (var pair in readEvent.PhotoDict)
            {
                Console.WriteLine("PHOTO");
                double longi = readEvent.PhotoDict[pair.Key].Longi;
                double lat = readEvent.PhotoDict[pair.Key].Lat;
                String text = readEvent.PhotoDict[pair.Key].FilePath;
                String date = "";

                string path = @"img/photoIcon.png";

                Bitmap photoMarker = (Bitmap)Image.FromFile(path);

                Form1.AddMarker(lat, longi, text, date, photoMarker);
            }

            foreach (var pair in readEvent.VideoDict)
            {
                Console.WriteLine("VIDEO");
                double longi = readEvent.VideoDict[pair.Key].Longi;
                double lat = readEvent.VideoDict[pair.Key].Lat;
                String text = readEvent.VideoDict[pair.Key].FilePath;
                String date = "";

                string path = @"img/videoIcon.png";

                Bitmap videoMarker = (Bitmap)Image.FromFile(path);

                Form1.AddMarker(lat, longi, text, date, videoMarker);
            }

            foreach (var pair in readEvent.TrackLogDict)
            {
                Console.WriteLine("TRACKLOG");
                double longi = readEvent.TrackLogDict[pair.Key].Longi;
                double lat = readEvent.TrackLogDict[pair.Key].Lat;
                double longi2 = readEvent.TrackLogDict[pair.Key].Longi2;
                double lat2 = readEvent.TrackLogDict[pair.Key].Lat2;
                String text = readEvent.TrackLogDict[pair.Key].FilePath;

                Form1.AddTracklog(lat, longi, lat2, longi2, text);
            }

            foreach (var pair in readEvent.PersonDict)
            {
                Console.WriteLine("PERSON");
                String firstname = readEvent.PersonDict[pair.Key].FirstName;
                String lastname = readEvent.PersonDict[pair.Key].LastName;
                String contact = readEvent.PersonDict[pair.Key].Contact;
                String streetNum = readEvent.PersonDict[pair.Key].StreetNum;
                String streetAdd = readEvent.PersonDict[pair.Key].StreetAdd;
                double longi = readEvent.PersonDict[pair.Key].Longi;
                double lat = readEvent.PersonDict[pair.Key].Lat;

                Console.WriteLine(firstname);

                string path = @"img/personIcon.png";

                Bitmap personMarker = (Bitmap)Image.FromFile(path);

                Form1.AddMarkerPerson(lat, longi, firstname, lastname, contact, streetNum, streetAdd, personMarker);
            }

            Application.Run(Form1);
        }
    }
}
