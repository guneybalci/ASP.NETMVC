using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Card.Bll.Abstract;
using Card.Dal.Abstract;
using Card.Entities;

namespace Card.Bll.Concrete
{
    public class PersonManager : IPersonService
    {
        private IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public List<Person> GetAll()
        {

            return _personDal.GetAll();
        }

        public Person Get(int id)
        {
            return _personDal.Get(id);
        }

        public void Add(Person entity)
        {
            _personDal.Add(entity);
        }

        public void Delete(int id)
        {
            _personDal.Delete(id);
        }

        public void Update(Person entity)
        {
            _personDal.Update(entity);
        }
    }
}
