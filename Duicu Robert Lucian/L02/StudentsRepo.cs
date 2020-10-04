using System;
using System.Collections.Generic;
namespace L02
{
    public class StudentsRepo{
        public List<Student> s= new List<Student>(){
            new Student(1,"Bob","AC",1),
            new Student(2,"Vasile","ETC",3),
            new Student(3,"Maria","AC",4),
            new Student(4,"Zamolxis","SC",2)
        };
    }
}