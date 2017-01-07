using System.Reflection;

namespace AppSyndication.UserService.Model
{
    public class ModelVersion
    {
        public ModelVersion()
        {
            var attribute = typeof(ModelVersion).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            this.Version = attribute?.InformationalVersion;
        }

        public string Version { get; }
    }
}
