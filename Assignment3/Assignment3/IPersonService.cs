using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public interface IPersonService
    {
        void CalculateAge();
        void CalculateSalary();
    }

    public interface IStudentService : IPersonService
    {
        void CalculateGPA();
    }

    public interface IInstructorService : IPersonService
    {
        void CalculateBonus();
    }
}
