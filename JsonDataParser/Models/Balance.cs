using System.Text.Json.Serialization;

namespace JsonDataParser.Models
{
    public class Balance
    {
        [JsonPropertyName("in_balance")]
        public decimal In_balance { get; set; }
        [JsonPropertyName("calculation")]
        public decimal Calculation { get; set; }
        [JsonPropertyName("period")]
        public int Period { get; set; }
        [JsonPropertyName("account_id")]
        public int Account_id { get; set; }

        public override string ToString()
        {
            return $"{In_balance} {Calculation} {Period} {Account_id}";
        }


    }



}
