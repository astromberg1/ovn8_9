using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise9
{
    class EmployeeRegister
    {
        private Logger _lg; 
        public List<Employee> EmpRegister { get; private set; }

        public EmployeeRegister(Logger lg)
        {
            EmpRegister = new List<Employee>();
            _lg = lg;
        }

        public void AddEmployee(string fnamn, string enamn, string socialnumber, string wage)
        {

            Employee emp = new Employee(fnamn, enamn, socialnumber, wage);

            EmpRegister.Add(emp);


            _lg.Log(DateTime.Now + "| message" + " Add employee " + fnamn + ";" + enamn + ";" + socialnumber + ";" + wage);
            

        }

        public bool RemoveEmployee(string socialnumber)
        {
            var temp = new Employee();
            var flag = false;

            foreach (var emp in EmpRegister)
            {
                if (emp != null)
                {
                    if (emp.SocialSecurityNumber.Equals(socialnumber))
                    {
                        temp = emp;
                        flag = true;
                    }
                }
            }
            if (flag)
            {
                EmpRegister.Remove(temp);
                _lg.Log(DateTime.Now + "| message" + " Remove employee " + temp.FirstName + ";" + temp.LastName + ";" + temp.SocialSecurityNumber + ";" + temp.Wage);
            }
            temp = null;
            return flag;


            
            
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            //       
            string menyalt = "1";
            bool flag = true;
            var myLogger = new Logger();
            EmployeeRegister ereg = new EmployeeRegister(myLogger);
            



            // Front End
            while (flag)
            {
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. Remove employee");
                Console.WriteLine("3. Print entiry Registry");
                Console.WriteLine("4. Exit");
                Console.WriteLine("");
                Console.WriteLine("Enter a choice(1,2,3,4)");

                menyalt = Console.ReadLine();
                menyalt = menyalt.Trim();
               


                switch (menyalt)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Add employee");
                        Console.WriteLine("Forname:");
                        var fnamn = Console.ReadLine();
                        Console.WriteLine("LastName:");
                        var ename = Console.ReadLine();
                        Console.WriteLine("SocialNumber(YYMMDD-XXXX)");
                        var socialnumber = Console.ReadLine();
                        Console.WriteLine("Hourly wage");
                        var wage = Console.ReadLine();
                        ereg.AddEmployee(fnamn, ename, socialnumber, wage);
                        


                        break;

                    case "2":
                        // remove item

                        
                        Console.Clear();
                        Console.WriteLine("Remove employee");
                        Console.WriteLine("Write the employees SocialNumber(YYMMDD-XXXX) that you want to remove");
                        //var Removesocialnumber = Console.ReadLine();
                        if (!ereg.RemoveEmployee(Console.ReadLine()))
                            Console.WriteLine("Cant find any");
                        else
                            Console.WriteLine("Succesfully removed");
                        Console.ReadKey();
                        break;

                    case "3":
                        // print ut

                        //for (int i = 0; i < ereg.EmpRegister.Count; i++)
                        //{
                        //   if (lista[i] != null)
                        //       Console.WriteLine(lista[i].FirstName + " " + lista[i].LastName + " " + lista[i]._socialnumber + " " + lista[i]._hourly_wage);
                        // }
                        if (ereg.EmpRegister.Count > 0)
                        {
                            foreach (Employee emp in ereg.EmpRegister)
                            {
                                if (emp != null)
                                    Console.WriteLine(emp.FirstName + " " + emp.LastName + " " + emp.SocialSecurityNumber + " " + emp.Wage);

                            }
                        }
                        else
                            Console.WriteLine("The Register is empty");


                            Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Bye Bye");
                        flag = false;


                        break;



                    default:
                        Console.WriteLine("Wrong Choice");


                        break;

                }
            }
                System.Diagnostics.Debugger.Break();
        }
        }
}

