using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Card.Dal.Abstract;
using Card.Entities;

namespace Card.Dal.Concrete.EntityFramework
{
    public class EfPersonDal : IPersonDal
    {
        private CardContext _context;

        public EfPersonDal()
        {
            _context = new CardContext();
        }

        public List<Person> GetAll()
        {
            return _context.Persons.ToList();
        }

        public Person Get(int id)
        {
            return _context.Persons.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Person entity)
        {
            _context.Persons.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Persons.Remove(_context.Persons.FirstOrDefault(x => x.Id == id));
            _context.SaveChanges();
        }

        public void Update(Person entity)
        {
            _context.Persons.AddOrUpdate(entity);
            _context.SaveChanges();
        }
    }
}
