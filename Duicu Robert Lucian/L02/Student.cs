using System;
namespace L02
{
    public class Student
    {
        public int id{ get; set;}
        public string nume {get;set;}
        public string facultate{get;set;}//facultate
        public int an{get;set;}
        public Student(int i, string n, string f, int a){
            id=i;
            nume=n;
            facultate=f;
            an=a;
        }

    }
}