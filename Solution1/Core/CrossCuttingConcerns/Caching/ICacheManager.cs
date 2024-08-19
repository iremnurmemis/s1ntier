

namespace Core
{
    public interface ICacheManager
    {
        void Add(string key, object value,int duration); //ne kadar kalcak

        T Get<T>(string key);//cache den getirirken hangi tiple çalısıyorum

        object Get(string key);

        bool IsAdd(string key); //cache de var mı diye kontrol et yoksa database den getir cache ekle varsa cache den getir

        void Remove(string key);

        void RemoveByPattern(string pattern);
    }
}
