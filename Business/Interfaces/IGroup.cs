using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
   public interface IGroup
    {
        Group Create(Group group);
        Group Update(int Id, Group group);
        Group Delete(int Id);
        Group GetGroup(string name);

        List<Group> GetAll();
    }
}
