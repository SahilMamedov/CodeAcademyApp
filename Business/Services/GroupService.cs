using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
   public class GroupService : IGroup
    {
        public static int Count { get; set; }
        private GroupRepository _groupRepository;
        public GroupService()
        {
            _groupRepository = new GroupRepository();
        }

        public Group Create(Group group)
        {

            group.Id = Count;
            _groupRepository.Create(group);
            Count++;
            return group;
            
            
        }

        public Group Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Group GetGroup(string name)
        {
            return _groupRepository.GetOne();
        }

        public Group Update(int Id, Group group)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetAll()
        {
            return _groupRepository.GetAll();
        }
    }
}
