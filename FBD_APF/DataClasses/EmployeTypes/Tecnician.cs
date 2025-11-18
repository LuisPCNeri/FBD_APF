using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBD_APF.DataClasses.EmployeTypes
{
    class Tecnician : Employee
    {
        private int NIF;
        public Tecnician() { }
        public Tecnician(int NIF, string name, double salary, string workHours, int nClub) : base(NIF, name, salary, workHours, nClub)
        {
            this.NIF = NIF;
        }
        public int GetNIF() { return this.NIF; }
        public override string ToString()
        {
            return $"{this.NIF}, {this.getName()}, {this.getSalary()}, {this.getWorkHours()}, {this.getNClub()}";
        }
    }
}
