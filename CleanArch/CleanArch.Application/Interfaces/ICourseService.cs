using CleanArch.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        //adjust from Ienumerable to courseviewmodel
        CourseViewModel GetCourses();
    }
}
