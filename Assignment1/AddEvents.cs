using System;
using System.Xml.Linq;
using System.Linq;

namespace Assignment1
{
    class AddEvents
    {
        XNamespace lle = "http://www.xyz.org/lifelogevents";
        XNamespace soapENV = "http://www.w3.org/2001/12/soap-envelope";

        String LifeLogPath = "..\\..\\XMLLifeLogEvents.xml";
        String PersonPath = "..\\..\\XMLAddedPerson.xml";
        String lastID = "";


        public void AddInstagram(String text, String date, double mouseX, double mouseY)
        {
            //retrieve file and load
            XElement lifelogxml = XElement.Load(LifeLogPath);

            var events = lifelogxml.Descendants(lle + "Event").Reverse().Take(1);

            foreach (var evs in events)
            {
                lastID = evs.Element(lle + "eventid").Value;
            }

            var newIDNum = Int16.Parse(lastID.Substring(lastID.Length - 2, 2)) + 1;
            var newID = ("ID" + newIDNum);

            var newEvent = new XElement(lle + "Event",
                           new XElement(lle + "eventid", newID),
                           new XElement(lle + "instagram-status",
                           new XElement(lle + "text", text),
                           new XElement(lle + "location",
                           new XElement(lle + "lat", mouseY),
                           new XElement(lle + "long", mouseX)),
                           new XElement(lle + "datetimestamp", date)));

            lifelogxml.Descendants(soapENV + "Body").Single().Add(newEvent);
            lifelogxml.Save(LifeLogPath);

        }

        public void AddTweet(String text, String date, double mouseX, double mouseY)
        {
            //retrieve file and load
            XElement lifelogxml = XElement.Load(LifeLogPath);

            var events = lifelogxml.Descendants(lle + "Event").Reverse().Take(1);

            foreach(var evs in events)
            {
                lastID = evs.Element(lle + "eventid").Value;
            }

            var newIDNum = Int16.Parse(lastID.Substring(lastID.Length - 2, 2)) + 1;
            var newID = ("ID" + newIDNum);

            var newEvent = new XElement(lle + "Event",
                           new XElement(lle + "eventid", newID),
                           new XElement(lle + "tweet",
                           new XElement(lle + "text", text),
                           new XElement(lle + "location",
                           new XElement(lle + "lat", mouseY),
                           new XElement(lle + "long", mouseX)),
                           new XElement(lle + "datetimestamp", date)));

            

            lifelogxml.Descendants(soapENV + "Body").Single().Add(newEvent);
            lifelogxml.Save(LifeLogPath);

        }

        public void AddPhoto(String text, double mouseX, double mouseY)
        {
            //retrieve file and load
            XElement lifelogxml = XElement.Load(LifeLogPath);

            var events = lifelogxml.Descendants(lle + "Event").Reverse().Take(1);

            foreach (var evs in events)
            {
                lastID = evs.Element(lle + "eventid").Value;
            }

            var newIDNum = Int16.Parse(lastID.Substring(lastID.Length - 2, 2)) + 1;
            var newID = ("ID" + newIDNum);

            var newEvent = new XElement(lle + "Event",
                           new XElement(lle + "eventid", newID),
                           new XElement(lle + "photo",
                           new XElement(lle + "filepath", text),
                           new XElement(lle + "location",
                           new XElement(lle + "lat", mouseY),
                           new XElement(lle + "long", mouseX))));

            lifelogxml.Descendants(soapENV + "Body").Single().Add(newEvent);
            lifelogxml.Save(LifeLogPath);

        }
        public void AddVideo(String text, double mouseX, double mouseY)
        {
            //retrieve file and load
            XElement lifelogxml = XElement.Load(LifeLogPath);

            var events = lifelogxml.Descendants(lle + "Event").Reverse().Take(1);

            foreach (var evs in events)
            {
                lastID = evs.Element(lle + "eventid").Value;
            }

            var newIDNum = Int16.Parse(lastID.Substring(lastID.Length - 2, 2)) + 1;
            var newID = ("ID" + newIDNum);

            var newEvent = new XElement(lle + "Event",
                           new XElement(lle + "eventid", newID),
                           new XElement(lle + "video",
                           new XElement(lle + "filepath", text),
                           new XElement(lle + "location",
                           new XElement(lle + "lat", mouseY),
                           new XElement(lle + "long", mouseX))));

            lifelogxml.Descendants(soapENV + "Body").Single().Add(newEvent);
            lifelogxml.Save(LifeLogPath);

        }

        public void AddTrackLog(String text, double mouseX, double mouseY, String lat2, String longi2)
        {
            //retrieve file and load
            XElement lifelogxml = XElement.Load(LifeLogPath);

            var events = lifelogxml.Descendants(lle + "Event").Reverse().Take(1);

            foreach (var evs in events)
            {
                lastID = evs.Element(lle + "eventid").Value;
            }

            var newIDNum = Int16.Parse(lastID.Substring(lastID.Length - 2, 2)) + 1;
            var newID = ("ID" + newIDNum);

            var newEvent = new XElement(lle + "Event",
                           new XElement(lle + "eventid", newID),
                           new XElement(lle + "tracklog",
                           new XElement(lle + "filepath", text),
                           new XElement(lle + "location",
                           new XElement(lle + "lat", mouseY),
                           new XElement(lle + "long", mouseX),
                           new XElement(lle + "lat2", lat2),
                           new XElement(lle + "longi2", longi2))));

            lifelogxml.Descendants(soapENV + "Body").Single().Add(newEvent);
            lifelogxml.Save(LifeLogPath);
        }

        public void AddPerson(String FirstName,String LastName, String Contact, String StreetNum, String StreetAdd,  double mouseX, double mouseY)
        {
            //retrieve file and load
            XElement lifelogxml = XElement.Load(PersonPath);

            var newEvent = new XElement(lle + "Person",
                           new XElement(lle + "firstname", FirstName),
                           new XElement(lle + "lastname", LastName),
                           new XElement(lle + "Information",
                           new XElement(lle + "Contactdetails", Contact),
                           new XElement(lle + "streetNum", StreetNum),
                           new XElement(lle + "StreetAdd", StreetAdd),
                           new XElement(lle + "lat", mouseY),
                           new XElement(lle + "long", mouseX)));

            lifelogxml.Descendants(soapENV + "Body").Single().Add(newEvent);
            lifelogxml.Save(PersonPath);
        }
    }
}
