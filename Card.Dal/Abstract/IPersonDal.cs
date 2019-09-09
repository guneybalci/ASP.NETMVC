using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Card.Entities;

namespace Card.Dal.Abstract
{
   public interface IPersonDal
    {
        List<Person> GetAll();
        Person Get(int id);
        void Add(Person entity);
        void Delete(int id);
        void Update(Person entity);
    }
}
