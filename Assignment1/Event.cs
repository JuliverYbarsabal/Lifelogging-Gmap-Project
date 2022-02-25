using System;


namespace Assignment1
{
    class Instagram
    {
        private String eventID;
        private String text;
        private double lat;
        private double longi;
        private String dateTimeStamp;

        public Instagram(String eventID, String text, double lat, double longi, String dateTimeStamp)
        {
            this.eventID = eventID;
            this.text = text;
            this.lat = lat;
            this.longi = longi;
            this.dateTimeStamp = dateTimeStamp;
        }

        public String EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }

        public String Text
        {
            get { return text; }
            set { text = value; }
        }

        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        public double Longi
        {
            get { return longi; }
            set { longi = value; }
        }

        public String DateTimeStamp
        {
            get { return dateTimeStamp; }
            set { dateTimeStamp = value; }
        }
        public override string ToString()
        {
            return eventID + " " + text + " " + lat + " " + longi + " " + dateTimeStamp;
        }
    }

    class Tweet
    {
        private String eventID;
        private String text;
        private double lat;
        private double longi;
        private String dateTimeStamp;

        public Tweet(String eventID, String text, double lat, double longi, String dateTimeStamp)
        {
            this.eventID = eventID;
            this.text = text;
            this.lat = lat;
            this.longi = longi;
            this.dateTimeStamp = dateTimeStamp;
        }

        public String EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }

        public String Text
        {
            get { return text; }
            set { text = value; }
        }

        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        public double Longi
        {
            get { return longi; }
            set { longi = value; }
        }

        public String DateTimeStamp
        {
            get { return dateTimeStamp; }
            set { dateTimeStamp = value; }
        }
        public override string ToString()
        {
            return eventID + " " + text + " " + lat + " " + longi + " " + dateTimeStamp;
        }
    }

    class Photo
    {
        private String eventID;
        private String filePath;
        private double lat;
        private double longi;

        public Photo(String eventID, String filePath, double lat, double longi)
        {
            this.eventID = eventID;
            this.filePath = filePath;
            this.lat = lat;
            this.longi = longi;
        }

        public String EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }

        public String FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        public double Longi
        {
            get { return longi; }
            set { longi = value; }
        }

        public override string ToString()
        {
            return eventID + " " + filePath + " " + lat + " " + longi;
        }

    }

    class Video
    {
        private String eventID;
        private String filePath;
        private double lat;
        private double longi;

        public Video(String eventID, String filePath, double lat, double longi)
        {
            this.eventID = eventID;
            this.filePath = filePath;
            this.lat = lat;
            this.longi = longi;
        }

        public String EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }

        public String FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        public double Longi
        {
            get { return longi; }
            set { longi = value; }
        }

        public override string ToString()
        {
            return eventID + " " + filePath + " " + lat + " " + longi;
        }

    }

    class Tracklog
    {
        private String eventID;
        private String filePath;
        private double lat;
        private double longi;
        private double lat2;
        private double longi2;


        public Tracklog(String eventID, String filePath, double lat, double longi, double lat2, double longi2)
        {
            this.eventID = eventID;
            this.filePath = filePath;
            this.lat = lat;
            this.longi = longi;
            this.lat2 = lat2;
            this.longi2 = longi2;
        }

        public String EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }

        public String FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        public double Longi
        {
            get { return longi; }
            set { longi = value; }
        }

        public double Lat2
        {
            get { return lat2; }
            set { lat2 = value; }
        }

        public double Longi2
        {
            get { return longi2; }
            set { longi2 = value; }
        }

        public override string ToString()
        {
            return eventID + " " + filePath + " " + lat + " " + longi + " " + lat2 + " " + longi2;
        }

    }

    class Person
    {
        private String firstName;
        private String lastName;
        private String contact;
        private String streetNum;
        private String streetAdd;
        private double lat;
        private double longi;

        public Person(String firstName, String lastName, String contact, String streetNum, String streetAdd, double lat, double longi)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.contact = contact;
            this.streetNum = streetNum;
            this.streetAdd = streetAdd;
            this.lat = lat;
            this.longi = longi;
        }

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public String Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public String StreetNum
        {
            get { return streetNum; }
            set { streetNum = value; }
        }
        public String StreetAdd
        {
            get { return streetAdd; }
            set { streetAdd = value; }
        }

        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        public double Longi
        {
            get { return longi; }
            set { longi = value; }
        }

        public string Contactdetails { get; internal set; }

        public override string ToString()
        {
            return firstName + " " + lastName + " " + contact + " " + streetNum + " " + streetAdd + " " + lat + " " + longi;
        }
    }
}
