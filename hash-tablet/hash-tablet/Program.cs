using System;
using System.Collections;
namespace hash_tablet
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash_table = new Hashtable();
            hash_table.Add("it is my hash", "really yours?");
            //var hashValue = hash_table["it is my hash"];
            //Console.WriteLine(hashValue);
            Console.WriteLine(ContainsKey(hash_table));
            Console.WriteLine(ContainsValue(hash_table));
            Console.WriteLine(Count(hash_table));
            Console.WriteLine(GetValue(hash_table));
            Console.WriteLine(Remove(hash_table));
            Console.WriteLine(Count(hash_table));
            Console.WriteLine(Clear(hash_table));
            Console.ReadLine();
        }
        static bool ContainsKey(Hashtable hashtable)
        {
            //первая строка ключ,вторая значение
            // ourHash.Contains  если есть такой ключ - вернуть истину
            return hashtable.Contains("it is my hash");
        }
        static bool ContainsValue(Hashtable hashtable)
        {
            // ourHash.ContainsValue если есть такой значение - вернуть истину
            return hashtable.ContainsValue("really yours?") ;
        }
        static bool Remove(Hashtable hashtable)
        {
            hashtable.Remove("it is my hash");
            return hashtable.Contains("it is my hash");
        }
        static int Count(Hashtable hashtable)
        {
            // мы получим 0 так как ранее мы вызывали метод удаляющий хэш-ключ , и так как Hashtable - ссылочный тип данных изначальная переменная приняла изменения
            return hashtable.Count;
        } 
        static string GetValue(Hashtable hashtable)
        {
            //Console.ForegroundColor=ConsoleColor.DarkRed;
            var hashValue = hashtable["it is my hash"];
            // отличный метод резервирования хэш-значения
            //Console.WriteLine(Convert.ToString(hashValue));
            return Convert.ToString(hashValue);
        }
        static int Clear(Hashtable hashtable)
        {
            hashtable.Add('0','0');
            hashtable.Add('1','1');
            hashtable.Clear();
            return hashtable.Count;
        }
        // поиск по значению значительно медленне поиска по ключу. Почему? 
        // наверное потому что хэш-функцие приходиться перебирать все ключи и сверять значения(при условии , что нет функции, обратной хэш(скорее всего)) O(n)
    }
}
