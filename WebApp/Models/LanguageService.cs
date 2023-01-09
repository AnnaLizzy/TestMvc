using Microsoft.Extensions.Localization;
using System.Reflection;

namespace WebApp.Models
{
    public class LanguageService
    {
        private readonly IStringLocalizer _stringLocalizer;
        public LanguageService(IStringLocalizerFactory factory)
        {
            var type = typeof(Resource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _stringLocalizer = factory.Create("Resource", assemblyName.Name);
        }
        public LocalizedString Getkey(string key)
        {
            return _stringLocalizer[key];
        }
    }
}
