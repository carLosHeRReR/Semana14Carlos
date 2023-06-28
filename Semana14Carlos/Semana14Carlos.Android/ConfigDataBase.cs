using Semana14Carlos.Droid;
using Semana14Carlos.Interface;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace Semana14Carlos.Droid
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), databaseFileName);
        }
    }
}