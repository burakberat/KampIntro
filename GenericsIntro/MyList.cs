using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //herhangi bir değer verilebilir ve bu T yerine geçer. örn string int double.
    {
        T[] items;
        public MyList()
        {
            items = new T[0]; //array oluturuldu ve 0 elemanlı olarak başlatıldı.
        }
        //bir arrayın mutlaka newlenmesi gerekiyor ki referans oluşsun (referans tip)
        public void Add(T item) //item yerine başka bir şey de kullanabilirsin örn eleman.
        {
            T[] tempItems = items;
            items = new T[items.Length+1]; //her ekleme oldugunda diziyi 1 arttırır. ve her eklemede arrayı newler.
            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
            }
            items[items.Length - 1] = item;
        }

    }
}
