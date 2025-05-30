using System.Text.Json;

public class CovidConfig
{
    private string configPath = "covid_config.json";

    public string SatuanSuhu { get; set; } = "celcius";
    public int BatasHariDemam { get; set; } = 14;
    public string PesanDitolak { get; set; } = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
    public string PesanDiterima { get; set; } = "Anda dipersilahkan untuk masuk ke dalam gedung ini";

    public CovidConfig()
    {
        LoadConfig();
    }

    public void LoadConfig()
    {
        // ... gunakan versi di atas dengan try-catch
    }

    public void SaveConfig()
    {
        var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(configPath, json);
    }

    public void UbahSatuan()
    {
        if (SatuanSuhu.ToLower() == "celcius")
            SatuanSuhu = "fahrenheit";
        else
            SatuanSuhu = "celcius";

        SaveConfig();
    }
}
