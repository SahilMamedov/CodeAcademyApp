using DataAccess;
using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        public bool Create(Student entity)
        {
            try
            {
                DataContext.Students.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Student entity)
        {

            try
            {
                DataContext.Students.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Student> GetAll(Predicate<Student> filter = null)
        {
            try
            {


                return  DataContext.Students.FindAll(filter);
                   
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Student GetOne(Predicate<Student> filter = null)
        {
            return filter == null ? DataContext.Students[0] :
                DataContext.Students.Find(filter);
            
        }

        public bool Update(Student entity)
        {
            try
            {
                Student isExist = GetOne(s => s.Id == entity.Id);
                isExist = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
