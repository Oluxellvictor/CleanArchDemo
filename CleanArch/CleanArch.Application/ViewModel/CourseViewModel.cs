using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.ViewModel
{
   public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
