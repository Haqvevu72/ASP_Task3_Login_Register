using Login_and_Register.Models;
namespace Login_and_Register.Services;

public static class Users
{
    public static List<User> users;

    static Users()
    {
        users = new()
        {
            new User() { name = "Elgun", surname = "Haqverdiyev", age = "19", username = "Haqve_vu72", password = "Sharingan2004" },
            new User() { name = "Ayla", surname = "Mammadova", age = "21", username = "AylaMv88", password = "Butterfly21" },
            new User() { name = "Orkhan", surname = "Valiyev", age = "22", username = "OrkhanVu90", password = "Wolverine22" },
            new User() { name = "Sara", surname = "Karimova", age = "20", username = "SaraK99", password = "Cherry2002" },
            new User() { name = "Ismayil", surname = "Nabiyev", age = "23", username = "IsmayilNa91", password = "Invoker2023" },
            new User() { name = "Leyla", surname = "Huseynova", age = "22", username = "LeylaHu89", password = "Moonlight22" },
            new User() { name = "Rashad", surname = "Ismayilov", age = "24", username = "RashadIsm94", password = "Sunshine24" },
            new User() { name = "Nigar", surname = "Rahimli", age = "25", username = "NigarRa95", password = "StarDust25" },
            new User() { name = "Samir", surname = "Mammadov", age = "26", username = "SamirMm96", password = "DeepOcean26" },
            new User() { name = "Zahra", surname = "Babayeva", age = "19", username = "ZahraBa73", password = "PinkRose19" },
            new User() { name = "Murad", surname = "Aliyev", age = "27", username = "MuradAl97", password = "HighPeak27" },
            new User() { name = "Gunay", surname = "Ibrahimova", age = "20", username = "GunayIb98", password = "LunarEclipse20" },
            new User() { name = "Emin", surname = "Huseynov", age = "23", username = "EminHu92", password = "ThunderStorm23" },
            new User() { name = "Fidan", surname = "Kerimli", age = "21", username = "FidanKe89", password = "SilentRiver21" },
            new User() { name = "Rufat", surname = "Aslanov", age = "25", username = "RufatAs95", password = "WildTiger25" },
            new User() { name = "Ulkar", surname = "Mehdiyeva", age = "22", username = "UlkarMh90", password = "CalmWind22" },
            new User() { name = "Tural", surname = "Mustafayev", age = "24", username = "TuralMu94", password = "StormBreaker24" },
            new User() { name = "Aynur", surname = "Guliyeva", age = "23", username = "AynurGu93", password = "GoldenSun23" },
            new User() { name = "Kamran", surname = "Hashimov", age = "22", username = "KamranHa89", password = "SilverMoon22" },
            new User() { name = "Sabina", surname = "Aliyeva", age = "20", username = "SabinaAl99", password = "QuietForest20" }
            
        };
    }
}