using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Seminar7
{
    internal class Exercise4
    {
        private String file = (@"G:\VisualStudioHomework\Seminar7\exercise4.xml");

        public void CreateXML(String fullname, String streetname, String housename, String flatnum, String phonenum, String flatphone)
        {
            XElement myPerson = new XElement("Person");

            XElement myAdress = new XElement("Adress");
            XElement myStreet = new XElement("Street", streetname);
            XElement myHouseNumber = new XElement("HouseNumber", housename);
            XElement myFlatNumber = new XElement("FlatNumber", flatnum);

            XElement myPhones = new XElement("Phones");
            XElement myMobilePhone = new XElement("MobilePhone", phonenum);
            XElement myFlatPhone = new XElement("FlatPhone", flatphone);

            XAttribute xAttributePersonName = new XAttribute("name", fullname);
            myPerson.Add(xAttributePersonName);

            myPerson.Add(myAdress);
            myAdress.Add(myStreet);
            myAdress.Add(myHouseNumber);
            myAdress.Add(myFlatNumber);

            myPerson.Add(myPhones);
            myPhones.Add(myMobilePhone);
            myPhones.Add(myFlatPhone);

            myPerson.Save(file);

        }
    }
}
