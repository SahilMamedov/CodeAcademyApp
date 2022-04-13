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
   public class GroupRepository:IRepository<Group>
    {
         public bool Create(Group entity)
        {
            try
            {
                DataContext.Groups.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Group entity)
        {

            try
            {
                DataContext.Groups.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Group> GetAll(Predicate<Group> filter = null)
        {
            try
            {

                return filter==null? DataContext.Groups.FindAll()
                return  DataContext.Groups.FindAll(filter);
                   
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Group GetOne(Predicate<Group> filter = null)
        {
            return filter == null ? DataContext.Groups[0] :
                DataContext.Groups.Find(filter);
            
        }

        public bool Update(Group entity)
        {
            try
            {
                Group isExist = GetOne(s => s.Id == entity.Id);
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
