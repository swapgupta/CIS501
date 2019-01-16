using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    public enum RebateState
    {
        None,
        Rebate,
        Generated
    }

    public class Sale
    {
        public int ID { get; set; }
        public RebateState RebateState { get; set; }
        public double RebateAmount { get; set; }
        public DateTime _date { get; set; }
        private Dictionary<string, Item> _items;

        public Sale(DateTime date)
        {
            _date = date;
            RebateState = RebateState.None;
            _items = new Dictionary<string, Item>();
        }

        public void AddItem(string name, double price, int quantity)
        {
            Item i = null;
            _items.TryGetValue(name, out i);

            if (i == null)
            {
                _items[name] = new Item(name, price, quantity);
            }
            else
            {
                _items[name].Quantity += quantity;
            }
        }

        public void ReturnItem(string name, int quantity)
        {
            Item i = _items[name];

            if (i != null)
            {
                _items[name].Quantity -= quantity;
            }

            if (i.Quantity <= 0)
            {
                _items.Remove(name);
            }
        }

        public List<Item> GetItems()
        {
            if (_items.Values == null)
            {
                return new List<Item>();
            }
            else
            {
                return _items.Values.ToList();
            }
        }

        public double Total()
        {
            double sum = 0;

            foreach (Item i in _items.Values)
            {
                sum += i.Price * i.Quantity;
            }

            return sum;
        }
    }
}
