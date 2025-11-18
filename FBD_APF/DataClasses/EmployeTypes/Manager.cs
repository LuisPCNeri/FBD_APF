using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBD_APF.DataClasses.EmplooyeTypes
{
    class Manager : Employee
    {
        private int NIF;
        private int? cNIF;
        public Manager() { }
        
        public Manager(int NIF, string name, double salary, string workHours, int nClub) : base(NIF, name, salary, workHours, nClub)
        {
            this.NIF = NIF;
            this.cNIF = nClub;
        }

        public int GetNIF() { return this.NIF; }
        public int? GetClubNIF() { return this.cNIF; }

        public void SetClubNIF(int cNIF) { this.cNIF = cNIF; }

        public override string ToString()
        {
            return $"{this.NIF}, {this.getName()}, {this.getSalary()}, {this.getWorkHours()}, MANAGES: {this.cNIF}";
        }
    }
}
