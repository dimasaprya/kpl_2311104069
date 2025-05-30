using System;

class Program
{
    static void Main()
    {
        var config = new BankTransferConfig();

        // Lang prompt
        if (config.Lang == "en")
            Console.Write("Please insert the amount of money to transfer: ");
        else
            Console.Write("Masukkan jumlah uang yang akan di-transfer: ");

        int amount = int.Parse(Console.ReadLine());

        int fee = amount <= config.Transfer.Threshold ? config.Transfer.LowFee : config.Transfer.HighFee;
        int total = amount + fee;

        if (config.Lang == "en")
        {
            Console.WriteLine($"Transfer fee = {fee}");
            Console.WriteLine($"Total amount = {total}");
        }
        else
        {
            Console.WriteLine($"Biaya transfer = {fee}");
            Console.WriteLine($"Total biaya = {total}");
        }

        // Metode transfer
        if (config.Lang == "en")
            Console.WriteLine("Select transfer method:");
        else
            Console.WriteLine("Pilih metode transfer:");

        for (int i = 0; i < config.Methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.Methods[i]}");
        }

        Console.Write(">> ");
        Console.ReadLine(); // input metode transfer (tidak diproses lanjut)

        // Konfirmasi
        if (config.Lang == "en")
            Console.Write($"Please type \"{config.Confirmation.En}\" to confirm the transaction: ");
        else
            Console.Write($"Ketik \"{config.Confirmation.Id}\" untuk mengkonfirmasi transaksi: ");

        string confirm = Console.ReadLine();

        if ((config.Lang == "en" && confirm.ToLower() == config.Confirmation.En.ToLower()) ||
            (config.Lang == "id" && confirm.ToLower() == config.Confirmation.Id.ToLower()))
        {
            Console.WriteLine(config.Lang == "en" ? "The transfer is completed" : "Proses transfer berhasil");
        }
        else
        {
            Console.WriteLine(config.Lang == "en" ? "Transfer is cancelled" : "Transfer dibatalkan");
        }
    }
}
