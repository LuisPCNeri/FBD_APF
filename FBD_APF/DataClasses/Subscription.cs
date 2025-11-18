using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBD_APF.DataClasses
{
    class Subscription
    {
        private int sId;
        private int fullAccess;
        private string accessHours;
        private double price;
        private int cNIF;

        public Subscription() { }

        public Subscription(int sId, bool fullAccess, string accessHours, double price, int cNIF)
        {
            this.sId = sId;
            this.fullAccess = fullAccess ? 1 : 0;
            SetAccessHours(accessHours);
            this.price = price;
            this.cNIF = cNIF;
        }

        // GETTERS
        public int GetSId() { return this.sId; }
        public int GetFullAccess() { return this.fullAccess; }
        public string GetAccessHours() { return this.accessHours; }
        public double GetPrice() { return this.price; }
        public int GetClubNIF() { return this.cNIF; }

        // SETTERS
        public void SetFullAccess(bool fullAccess) { this.fullAccess = fullAccess ? 1 : 0; }
        public void SetAccessHours(string accessHours) {
            Regex regex = new Regex("[00-24]-[00-24]");
            // workHours field validation
            if (!regex.IsMatch(accessHours))
            {
                MessageBox.Show("Invalid Access Hours were given");
                return;
            }
            this.accessHours = accessHours; 
        }
        public void SetPrice(double price) { this.price = price; }
        public void SetClubNIF(int cNIF) { this.cNIF = cNIF; }

        public override string ToString()
        {
            return $"{this.sId}, {this.fullAccess}, {this.accessHours}, {this.price}, {this.cNIF}";
        }
    }
}
