using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;

namespace Core
{
    public class CacheRemoveAspect : MethodInterception
    {

        // yeni data eklenirse güncellenirse silinirse 
        private string _pattern;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        public override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}