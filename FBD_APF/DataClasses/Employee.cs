using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FBD_APF.DataClasses
{
    class Employee
    {
        private int NIF;
        private string name;
        private double salary;
        private string workHours;
        private int? nClub;

        public Employee() { }
        public Employee(int NIF, string name, double salary, string workHours, int nClub)
        {
            this.NIF = NIF;
            this.name = name;
            this.salary = salary;  
            this.workHours = workHours;
            this.nClub = nClub;
        }

        public int getNIF() { return this.NIF; }
        public string getName() { return this.name; }
        public double getSalary() { return this.salary; }
        public string getWorkHours() {  return this.workHours; }
        public int? getNClub() { return this.nClub; }

        public void setName(string name) { this.name = name; }
        public void setSalary(double salary) { this.salary = salary; }
        public void setWorkHours(string workHours) {
            Regex regex = new Regex("[00-24]-[00-24]");
            // workHours field validation
            if (!regex.IsMatch(workHours)) {
                MessageBox.Show("Invalid Work Hours were given");
                return;
            }
            this.workHours = workHours; 
        }

        public void setClubNIF(int NIF) { this.nClub =  NIF; }

        public override string ToString()
        {
            return $"{this.NIF,5:F1}, {this.name,5:F1}, {this.salary,5:F1}, {this.workHours,5:F1}, {this.nClub,5:F1}";
        }
    }
}
