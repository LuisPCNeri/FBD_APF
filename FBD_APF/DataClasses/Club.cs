using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBD_APF.DataClasses
{
    class Club
    {
        private int id;
        private string locl;
        private string name;

        // CLUB constructor
        public Club() { }
        public Club(int id) {
            this.id = id;
        }

        // GETTERS
        public int getId(){
            return this.id;
        }
        public string getLocl(){
            return this.locl;
        }
        public string getName(){
            return this.name;
        }

        // SETTERS
        public void setLocl(string locl){
            this.locl = locl;
        }
        public void setName(string name){
            this.name = name;
        }

        override
        public String ToString()
        {
            return $"{this.id}, {this.locl}, {this.name}";
        }
    }   
}
