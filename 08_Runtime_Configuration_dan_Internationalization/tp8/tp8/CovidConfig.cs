using System.IO;
using System.Text.Json;

public class CovidConfig
{
    public string satuan_suhu { get; set; } = "celcius";
    public int batas_hari_deman { get; set; } = 14;
    public string pesan_ditolak { get; set; } = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
    public string pesan_diterima { get; set; } = "Anda dipersilahkan untuk masuk ke dalam gedung ini";

    private const string FileName = "covid_config.json";

    public static CovidConfig LoadConfig()
    {
        if (File.Exists(FileName))
        {
            var json = File.ReadAllText(FileName);
            return JsonSerializer.Deserialize<CovidConfig>(json);
        }
        else
        {
            var defaultConfig = new CovidConfig();
            File.WriteAllText(FileName, JsonSerializer.Serialize(defaultConfig, new JsonSerializerOptions { WriteIndented = true }));
            return defaultConfig;
        }
    }

    public void UbahSatuan()
    {
        satuan_suhu = satuan_suhu == "celcius" ? "fahrenheit" : "celcius";
        File.WriteAllText(FileName, JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true }));
    }
}
