using System.Text.Json;
using Microsoft.VisualBasic.Logging;

namespace AssettoServerBuilder.Serializer
{
    public static class Json
    {
        public static string Serialize<T>(T obj)
        {
            try
            {
                string result = JsonSerializer.Serialize(obj);
                return result;
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"Failed to serialize {obj}. See output.log for more information.", 
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Logger.Log($"{exception.Message}\n{exception}");
                return string.Empty;
            }
        }

        public static T? Deserialize<T>(string obj)
        {
            try
            {
                var result = JsonSerializer.Deserialize<T>(obj);
                return result;
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"Failed to deserialize '{obj}'. See output.log for more information.", 
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Logger.Log($"{exception.Message}\n{exception}");
                return default;
            }
        }
    }
}

