using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_Adv01.NewFolder
{
    public class MyCache<TKey, TValue>
    {
     private Dictionary<TKey, (TValue value, DateTime expiry)> _storage = new Dictionary<TKey, (TValue, DateTime)>();

        //----------------

        public void Add(TKey key, TValue value, int seconds)
        {
            DateTime expiryTime = DateTime.Now.AddSeconds(seconds);
            _storage[key] = (value, expiryTime);
        }

        //-------------

        public TValue Get(TKey key)
        {
            if (_storage.ContainsKey(key))
            {
                var item = _storage[key];
               
                if (DateTime.Now < item.expiry)
                {
                    return item.value;
                }
                else
                {
                    _storage.Remove(key); 
                }
            }
            return default(TValue); 
        }


    }
}
