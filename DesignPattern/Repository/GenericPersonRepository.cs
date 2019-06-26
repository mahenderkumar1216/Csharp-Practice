using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Common;

namespace DesignPattern.Repository
{
    public class GenericPersonRepository : IRepository<Person, string>
    {
        public void AddNewItem(Person newItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(string key)
        {
            throw new NotImplementedException();
        }

        public Person GetItem(string key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetItems()
        {
            return People.GetGenericPeople();
        }

        public void UpdateItem(Person UpdatedItem)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(IEnumerable<Person> updateItems)
        {
            throw new NotImplementedException();
        }
    }
}
