using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBD_APF.DataClasses
{
    class Equipment
    {
        private int id;
        private string name;
        private string state;
        private int amount;
        private int cNIF;
        private int tNIF;
        public Equipment() { }
        public Equipment(int id, string name, string state, int amount, int cNIF, int tNIF)
        {
            this.id = id;
            this.name = name;
            this.state = state;
            this.amount = amount;
            this.cNIF = cNIF;
            this.tNIF = tNIF;
        }

        public int GetId() { return this.id; } 
        public string GetName() { return this.name; }
        public string GetState() { return this.state; }
        public int GetAmount() { return this.amount; }
        public int GetClubNIF() { return this.cNIF; }

        public void SetName(string name) { this.name = name; }
        public void SetState(string state) { this.state = state; }
        public void SetAmount(int amount) {
            if (amount < 0) { 
                MessageBox.Show("Invalid Amount was given");
                return;
            }
            this.amount = amount; 
        }
        public void SetClubNIF(int cNIF) { this.cNIF = cNIF; }
        public void SetTecnicianNIF(int tNIF) { this.tNIF = tNIF; }

        public override string ToString()
        {
            return $"{this.id}, {this.name}, {this.state}, {this.amount}, {this.cNIF}, {this.tNIF}";
        }
    }
}
