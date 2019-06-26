using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Repository
{
    interface IRepository<T,Tkey>
    {

        IEnumerable<T> GetItems();

        T GetItem(Tkey key);

        void AddNewItem(T newItem);

        void UpdateItem(T UpdatedItem);

        void UpdateItem(IEnumerable<T> updateItems);

        void DeleteItem(Tkey key);
    }
}
