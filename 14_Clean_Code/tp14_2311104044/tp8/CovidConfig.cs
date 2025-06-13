using System.IO;
using System.Text.Json;

public class CovidConfig
{
    public string SatuanSuhu { get; set; } = "celcius";
    public int BatasHariDemam { get; set; } = 14;
    public string PesanDitolak { get; set; } = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
    public string PesanDiterima { get; set; } = "Anda dipersilahkan untuk masuk ke dalam gedung ini";

    private const string FileName = "covid_config.json";

    /// <summary>
    /// Memuat konfigurasi dari file JSON, atau membuat file baru jika belum ada.
    /// </summary>
    public static CovidConfig LoadConfig()
    {
        if (File.Exists(FileName))
        {
            string json = File.ReadAllText(FileName);
            return JsonSerializer.Deserialize<CovidConfig>(json);
        }
        else
        {
            var defaultConfig = new CovidConfig();
            string json = JsonSerializer.Serialize(defaultConfig, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FileName, json);
            return defaultConfig;
        }
    }

    /// <summary>
    /// Mengubah satuan suhu antara celcius dan fahrenheit.
    /// </summary>
    public void UbahSatuan()
    {
        SatuanSuhu = SatuanSuhu == "celcius" ? "fahrenheit" : "celcius";
        string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FileName, json);
    }
}
