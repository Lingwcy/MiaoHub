using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiaoHub.WPF.Config;

namespace MiaoHub.WPF.Services
{
    public class ConfigService
    {
        private readonly IConfiguration _configuration;

        public ConfigService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public AllConfigOption? GetAllConfig()
        {
            return GetConfig<AllConfigOption>();
        }

        //顶级key
        public T? GetConfig<T>() where T : class, new()
        {
            string typeName = typeof(T).Name;
            string configKey = typeName.EndsWith("Option") ? typeName.Substring(0, typeName.Length - 6) : typeName;

            return _configuration.GetSection(configKey).Get<T>();
        }
        //子key
        public T? GetConfig<T>(string path) where T : class, new()
        {
            return _configuration.GetSection(path).Get<T>();
        }


        public bool WrireConfig<T>(T config) where T : class, new()
        {
            string typeName = typeof(T).Name;
            string configKey = typeName.EndsWith("Option") ? typeName.Substring(0, typeName.Length - 6) : typeName;

            return true;
        }
    }
}
