using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Assignment1
{
    public partial class Gmap : Form
    {
        private PointLatLng sp;
        public PointLatLng SelectedPoint { get => sp; set => sp = value; }

        public Gmap()
        {
            InitializeComponent();
            InitMap();   
        }
        public void InitMap()
        {

            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;
            map.Position = new PointLatLng(-31.953512, 115.857048);
            map.DragButton = MouseButtons.Right;
            map.MinZoom = 2;
            map.MaxZoom = 22;
            map.Zoom = 11.5;

        }

        public void AddMarker(double lat, double longi, String text, String date, Bitmap img)
        {
            PointLatLng point = new PointLatLng(lat, longi);
            Console.WriteLine(lat + " \n" + longi);
            GMapMarker marker = new GMarkerGoogle(point, img);
            GMapOverlay markers = new GMapOverlay("Markers");
            if (!date.Equals(""))
            {
                marker.ToolTipText = $"INFO: \n Text: {text} \n Date: {date}";
            }
            else
            {
                marker.ToolTipText = $"file path: {text}";
            }

            var toolTip = new GMapToolTip(marker);
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.Stroke = Pens.Black;
            marker.ToolTip.TextPadding = new Size(30, 30);


            markers.Markers.Add(marker);
            map.Overlays.Add(markers);

        }

        public void AddMarkerPerson(double lat, double longi, String firstName, String lastName, String contact, String streetNum, String streetAdd, Bitmap img)
        {
            PointLatLng point = new PointLatLng(lat, longi);
            Console.WriteLine(lat + " \n" + longi);
            GMapMarker marker = new GMarkerGoogle(point, img);
            GMapOverlay markers = new GMapOverlay("Markers");
            //Console.WriteLine($"firstName: {firstName} \n lastName: {lastName} \n contact: {contact} \n streetNumber: {streetNum} \n streetAddress: {streetAdd}");
            marker.ToolTipText = $"firstName: {firstName} \n lastName: {lastName} \n contact: {contact} \n streetNumber: {streetNum} \n streetAddress: {streetAdd}";

            var toolTip = new GMapToolTip(marker);
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.Stroke = Pens.Black;
            marker.ToolTip.TextPadding = new Size(40, 40);


            markers.Markers.Add(marker);
            map.Overlays.Add(markers);

        }

        public void AddTracklog(double lat, double longi, double lat2, double longi2, String text)
        {
            GMapOverlay polygons = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(lat, longi));
            points.Add(new PointLatLng(lat2, longi2));
            GMapPolygon polygon = new GMapPolygon(points, "tracklog");

            polygon.Stroke = new Pen(Color.Red, 1);

            PointLatLng point = new PointLatLng(lat, longi);
            PointLatLng point2 = new PointLatLng(lat2, longi2);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
            GMapMarker marker2 = new GMarkerGoogle(point2, GMarkerGoogleType.red_pushpin);
            GMapOverlay markers = new GMapOverlay("Markers");
            marker.ToolTipText = $"Tracklog Name: {text}";
            
            var toolTip = new GMapToolTip(marker);
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.Stroke = Pens.Black;
            marker.ToolTip.TextPadding = new Size(30, 30);


            markers.Markers.Add(marker);
            markers.Markers.Add(marker2);
            map.Overlays.Add(markers);
            polygons.Polygons.Add(polygon);
            map.Overlays.Add(polygons);

        }


        private void click(object sender, MouseEventArgs e)
        {
            var point = map.FromLocalToLatLng(e.X, e.Y);
            double lat = point.Lat;
            double longi = point.Lng;
            if(e.Button == MouseButtons.Left)
            {
                Form f = new ActionEvent(longi, lat);
                f.Show();
            }

        }

        private void MapMouseMove(object sender, MouseEventArgs e)
        {
            //3RD-PARTY CODE REFFERENCE
            // link.awgm.co/5 
            base.OnMouseMove(e);
            sp = new PointLatLng();

            double X = map.FromLocalToLatLng(e.X, e.Y).Lng;
            double Y = map.FromLocalToLatLng(e.X, e.Y).Lat;

            string longitude = X.ToString();
            string latitude = Y.ToString();
            lbl_long_Value.Text = longitude;
            sp.Lng = X;
            lbl_lat_value.Text = latitude;
            sp.Lat = Y;
            //Console.WriteLine(SelectedPoint.ToString());
            //Console.WriteLine(sp.ToString());
            SelectedPoint = sp;
        }

        //for the calendar
        private void btnHide_Click(object sender, EventArgs e)
        {
            calender.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            calender.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calender.Text = monthCalendar1.SelectionStart.ToString();
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            calender.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void lbl_lat_value_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Lat_Click(object sender, EventArgs e)
        {

        }

        private void Gmap_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
