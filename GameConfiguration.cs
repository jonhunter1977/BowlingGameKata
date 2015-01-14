using System.ComponentModel;
using System.Configuration;
using Bowling.Interfaces;

namespace Bowling
{
    class GameConfiguration : IGameConfiguration
    {
        public T GetAppSetting<T>(string value)
        {
            var setting = ConfigurationManager.AppSettings[value];
            return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFrom(setting);
        }
    }
}
