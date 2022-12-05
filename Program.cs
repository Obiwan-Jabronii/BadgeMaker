using System; //This is the system namespace. Much like import or require in node
using System.Collections.Generic;

namespace CatWorx.BadgeMaker // name of the app, namespaces are the containers that hold members. Members can be another nested namespace, a method, or a class
{
    class Program
    {
        static List<Employee> GetEmployees(){
            List<Employee> employees = new List<Employee>();
            while(true) {
                Console.WriteLine("Please enter first name (Leave empty to finish): ");
                string firstName = Console.ReadLine() ?? "";
                if (firstName == "") {
                    break;
                }

                // add a Console.Readline for each value
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine() ?? "";
                Console.Write("Enter employee ID: ");
                int id = Int32.Parse(Console.ReadLine() ?? "");
                Console.Write("Enter Photo URL: ");
                string photoUrl = Console.ReadLine() ?? "";

                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }
            return employees;
        }

        static void Main(string[] args) //the Main method is the entry point to the application, void indicates the return of this method will be void and static implies that the scope of the method is class level, not object level
        {
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
        }

    }

}
// When variables for C# are declared, the datatype must be declared as well

/* Java Script
var carModel = "Explorer";
var modelYear = 2010;

C#
string carModel = "Explorer";
int modelYear = 2010; */

// -------------Basic Arithmetic------------------ 
// Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, *
// Console.WriteLine(10 % 3);        // Modulus Op => remainder of 10/3
// Console.WriteLine(1 + 2 * 3);     // order of operations
// Console.WriteLine(10 / 3.0);      // int's and doubles
// Console.WriteLine(10 / 3);        // int's 
// Console.WriteLine("12" + "3");    // What happens here?

// int num = 10;
// num += 100;
// Console.WriteLine(num);
// num ++;
// Console.WriteLine(num);

// ---------------Booleans------------------

// bool isCold = true;
// Console.WriteLine(isCold ? "drink" : "add ice");  // output: drink
// Console.WriteLine(!isCold ? "drink" : "add ice");  // output: add ice

// ---------------Converting Datatypes---------------

// string stringNum = "2";
// int intNum = Convert.ToInt32(stringNum);
// Console.WriteLine(intNum);
// Console.WriteLine(intNum.GetType());

//Dictionaries are similar to JavaScripts object literals in that they use a key value pair

// ----------------Declaring a Dictonary--------------
/* Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();

myScoreBoard.Add("firstInning", 10);
myScoreBoard.Add("secondInning", 20);

-------------------Or ---------------------------------

Dictionary<string, int> myscoreBoard = new Dictionary<string, int>(){
    { "firstInning", 10},
    {"secondInning", 20}
};  */

//-----------------Arrays-------------------------------
/* Arrays allow for only one datatype to be in the array at a time and the number of items in the array must be declared when the array is created.
This means that no new elements can be added or subtracted from the array. They are fixed, this makes them much more rigid than arrays in JS.

ex: string[] favFoods = new string[3] {"pizza", "icecream", "salad"};
string firstFood = favFoods[0];
string secondFood = favFoods[1];
string thirdFood = favFoods[2];
Console.WriteLine("I like {0}, {1}. and {2}", firstFood, secondFood, thirdFood ); */

/* -----------------Lists -------------------------------
Lists are more similar to JS arrays in that they do not have a set length and are stored in the System.Collections.Generic namespace. They still can only
hold a single datatype though.

ex: List<string> employees = new List<string>() { "adam", "amy" };

    employees.Add("barbara");
    employees.Add("billy");

    Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]); */

/* -------------------Loops-------------------------------
Loops in C# are very similar to JS loops. For loops are still used and even have very similar syntax

ex: for (int i = 0; i < employees.Count; i++) 
    {
    Console.WriteLine(employees[i]);
    }
*/