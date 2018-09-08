using ServiceApp.Exceptions;
using ServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Core
{
    public class InMemoryDbSet<T> : IDbSet<T> where T: Entity<T>
    {
        private static List<T> _items;

        static InMemoryDbSet()
        {
            _items = new List<T>();
        }

        public T Add(T item)
        {
            if (Exists(item) != null)
                throw new EntityExistsEcxeption("This entity already exists");
            _items.Add(item);
            return item;

        }

        public T Exists(Func<T,bool> predicate)
        {
            T newItem = null;
            
            foreach (T _item in _items)
            {
                if (predicate(_item))
                {
                    newItem = _item;
                }
            }
            return newItem;
        }

        public T Exists(T item)
        {
            T newItem = null;

            foreach (T _item in _items)
            {
                if (_item.Equals(item))
                {
                    newItem = _item;
                }
            }
            return newItem;
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Update(T item)
        {
            var existsItem = Exists(item);
            if (existsItem == null)
                throw new EntityNotExistsException("entity not exists for update!!!");
            
            existsItem.Update(item);

            var k = _items;
        }

        public T GetById(int Id)
        {
            T item = null;

            foreach (T _item in _items)
            {
                if (item.Id == Id)
                {
                    item = _item;
                }
            }
            return item;
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }
    }
}
