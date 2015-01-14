namespace Bowling.Interfaces
{
    public interface IGameConfiguration
    {
        T GetAppSetting<T>(string value);
    }
}
