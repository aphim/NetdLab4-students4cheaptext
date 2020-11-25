// Program: NetdLab4_students4cheaptext
// Name: Jacky Yuan
// Date: Nov 17,2020
// Change log: N/A

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetdLab4_students4cheaptext.Models
{
    public class textbook
    {
        //creates getters and setters for each textbook attribute
        public string textTitle { get; set; }

        public Int64 textISBN { get; set; }

        public double textVersion { get; set; }

        public double textPrice { get; set; }

        public string textCondition { get; set; }

        //default constructor
        public textbook()
        {

        }

        //parameterized constructor
        public textbook(string textTitle, Int64 textISBN, double textVersion, double textPrice, string textCondition)
        {
            this.textTitle = textTitle;
            this.textISBN = textISBN;
            this.textVersion = textVersion;
            this.textPrice = textPrice;
            this.textCondition = textCondition;
        }

        //function for calculating the value of a textbook
        public double calcValue(double textPrice, string textCondition)
        {
            //for like new condition
            if (textCondition == "likeNew")
            {
                return Math.Round(textPrice/2, 2);
            }
            //for good condition
            else if (textCondition == "good") 
            {
                return Math.Round(textPrice/3, 2);
            }
            //for bad condition
            else 
            {
                return Math.Round(textPrice/4, 2);
            }
        }

        public override string ToString()
        {
            return "Your textbook: "+ textTitle+", Version:" +textVersion+" was appraised at: $" + calcValue(textPrice, textCondition);
        }


    }

}
