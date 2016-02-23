using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Employee
    {
        private string _fname;
        private string _ename;
        private string _socialnumber;
        private string _hourly_wage;



        public string FirstName
        {
            get { return _fname; }
            set { _fname = value; }
        }



        public string LastName
        {
            get { return _ename; }
            set { _ename = value; }
        }

        public string SocialSecurityNumber
        {
            get { return _socialnumber; }
            set { _socialnumber = value; }
        }

        public string Wage
        {
            get { return _hourly_wage; }
            set { _hourly_wage = value; }
        }

        public string FullName
        {
            get { return _fname + " " + _ename; }

        }
        public Employee()
        {//default
            this._fname = "Kalle";
            this._ename = "Svensson";
            this._socialnumber = "450505-4545";
            this._hourly_wage = "100";


        }
        public Employee(string firstName, string lastName, string ssn, string wage)
        {     // Save the variables into your properties here } 
            this._fname = firstName;
            this._ename = lastName;
            this._socialnumber = ssn;
            this._hourly_wage = wage;
        }
        public Employee(string ssn)
        {     // Save the variables into your properties here } 
            this._socialnumber = ssn;

        }

    }
}
