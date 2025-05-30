using System.Text.Json;
using System.Text.Json.Serialization;

public class BankTransferConfig
{
    public string Lang { get; set; }
    public TransferConfig Transfer { get; set; }
    public List<string> Methods { get; set; }
    public ConfirmationConfig Confirmation { get; set; }

    private const string FilePath = "bank_transfer_config.json";

    public BankTransferConfig()
    {
        if (File.Exists(FilePath))
        {
            string json = File.ReadAllText(FilePath);
            var config = JsonSerializer.Deserialize<BankTransferConfig>(json);
            Lang = config.Lang;
            Transfer = config.Transfer;
            Methods = config.Methods;
            Confirmation = config.Confirmation;
        }
        else
        {
            // Default values
            Lang = "en";
            Transfer = new TransferConfig
            {
                Threshold = 25000000,
                LowFee = 6500,
                HighFee = 15000
            };
            Methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
            Confirmation = new ConfirmationConfig
            {
                En = "yes",
                Id = "ya"
            };

            // Simpan ke file
            string defaultJson = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, defaultJson);
        }
    }

    public class TransferConfig
    {
        [JsonPropertyName("threshold")]
        public int Threshold { get; set; }

        [JsonPropertyName("low_fee")]
        public int LowFee { get; set; }

        [JsonPropertyName("high_fee")]
        public int HighFee { get; set; }
    }

    public class ConfirmationConfig
    {
        public string En { get; set; }
        public string Id { get; set; }
    }
}
