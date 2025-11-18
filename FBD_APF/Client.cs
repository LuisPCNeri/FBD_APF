using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBD_APF
{
    class Client
    {
        private int NIF;
        private string email;
        private int pNumber;
        private int sId;
        private int? ptNIF;

        public Client() { }
        public Client(int NIF, string email, int pNumber, int sId, int? ptNIF)
        {
            this.NIF = NIF;
            this.email = email;
            this.pNumber = pNumber;
            this.sId = sId;
            this.ptNIF = ptNIF;
        }

        // GETTERS
        public int GetNIF() { return this.NIF; }
        public string GetEmail() { return this.email; }
        public int GetPNumber() { return this.pNumber; }
        public int GetSId() { return this.sId; }
        public int? GetClubNIF() { return this.ptNIF; }

        // SETTERS
        public void SetEmail(string email) { this.email = email; }
        public void SetPNumber(int pNumber) {
            if(pNumber.ToString().Length != 9){
                MessageBox.Show("Invalid Phone Number was given");
                return;
            }
            this.pNumber = pNumber; 
        }
        public void SetSId(int sId) { this.sId = sId; }
        public void SetPtNIF(int? ptNIF) { this.ptNIF = ptNIF; }

        public override string ToString()
        {
            return $"{this.NIF}, {this.email}, {this.pNumber}, {this.sId}, {this.ptNIF}";
        }
    }
}
