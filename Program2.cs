using System;

namespace Project{
    class Student
    {
        private string name;
        private double gpa;

        public Student(string sName, double sGpa){
            name = sName;
            gpa = sGpa;
        }
        public string Name
        {
            get{ return name; }
            set 
            { 
                if(value!="Aleksa"){
                name = "Change";
            } else {
                name = value;
            } 
            }
        }
       

    }
    class Book{
        
        public Book(){
            System.Console.WriteLine("Book!");
        }
        public void SayHello()
        {
            System.Console.WriteLine("Hello");
        }
    }
}