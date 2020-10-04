using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace L02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        StudentsRepo students = new StudentsRepo();
        private readonly ILogger<StudentsController> _logger;

        public StudentsController(ILogger<StudentsController> logger)
        {
            _logger = logger;
        }

             [HttpGet]
        public List<Student>Get()
        {
            return students.s;
        }

            [HttpGet("{id}")]
        public Student Get(int id)
        {
            foreach (Student student in students.s)
            {
                if(student.id == id)
                {
                    return student;
                }
            }
            return null;
        }
        
            [HttpPost]
        public List<Student> Post( [FromBody] Student student)
        {
            students.s.Add(student) ;
            return students.s;
        }

        
            [HttpPut("{id}")]
       public Student Update(int id,[FromBody] Student studentUpdate)
       {
           foreach(Student student in students.s)
           {
               if(student.id == id)
               {
                   student.nume=studentUpdate.nume;
                   student.facultate=studentUpdate.facultate;
                   student.an=studentUpdate.an;
                   return student;
               }
           }
           return null;
           
       }
          
            [HttpDelete("{id}")]
       public List<Student> Delete(int id)
        {
           foreach(Student student in students.s)
           {
               if(student.id == id)
               {
                   students.s.Remove(student);
                   return students.s;
               }
           }
           return null;
        }

    }
}

    

