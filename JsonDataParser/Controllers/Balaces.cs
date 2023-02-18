using JsonDataParser.Models;

using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonDataParser.Controllers
{
   public class Balances
    {
        private List<Balance> deserializedBalances;

        [JsonPropertyName("balance")]
        public List<Balance> DeserializedBalances { get => deserializedBalances; set => deserializedBalances = value; }

        public static Balances GetJson()
        {
            string json = File.ReadAllText("D:\\Documents\\GitHub\\ЖилфондСервис\\JSON\\TestTaskForJKH\\JsonDataParser\\Models\\Data\\balance_202105270825.json");

            return JsonSerializer.Deserialize<Balances>(json) ?? new Balances();
        }
        public static Balances GetJson(string fileName)
        {
          string json = File.ReadAllText($"{Environment.CurrentDirectory}\\Models\\Data\\{fileName}");

           return JsonSerializer.Deserialize<Balances>(json) ?? new Balances();
        }
        static Balances GetJson(FileInfo file)
        {
            string json = File.ReadAllText(file.FullName);

            return JsonSerializer.Deserialize<Balances>(json) ?? new Balances();
        }




    }
}
