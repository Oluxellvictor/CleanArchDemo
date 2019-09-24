using CleanArch.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interfaces
{
    interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
    }
}
