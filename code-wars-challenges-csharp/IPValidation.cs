using System.Text.RegularExpressions;
using System.Net;
using System.Linq;

/*
link: https://www.codewars.com/kata/515decfd9dcfc23bb6000006/csharp

max 3 dots
always 4 blocks
max len 15
min len 7
values between 0 and 255
split by dots?
is there build in method?

regex help: https://www.regextester.com/

*/

namespace IPValidation;

public class Kata
{
    public static bool is_valid_IP_regex(string ipAddres)
    {
        int ipMaxLenth = 15;

        string allowedRegex = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";

        Regex check = new Regex(allowedRegex);

        if (ipAddres == null || ipAddres.Length == 0 || ipAddres.Length > ipMaxLenth)
        {
            return false;
        }

        bool isMatch = check.IsMatch(ipAddres, 0);

        return isMatch;
    }

    public static bool is_valid_IP_system(string ipAddres)
    {
        IPAddress ip;
        bool isValid = IPAddress.TryParse(ipAddres, out ip);
        return isValid && ip.ToString() == ipAddres;
    }

    public static bool is_valid_IP_mine(string ipAddres)
    {
        const int minLenth = 7;
        const int maxLenth = 15;
        const int maxNumber = 255;
        const int dotsPossible = 3;
        int countDots = ipAddres.Count(x => x == '.');

        if (ipAddres == null
            || ipAddres.Length < minLenth
            || ipAddres.Length > maxLenth
            || ipAddres.StartsWith(".")
            || ipAddres.EndsWith(".")
            || countDots != dotsPossible
            )
        {
            return false;
        }

        var octets = ipAddres.Split('.');

        foreach (var oct in octets)
        {
            int digits;
            if (!int.TryParse(oct, out digits)
                || digits > maxNumber
                || oct.Length > 3
                || oct.Length >= 2 && oct.StartsWith("0")
                || oct.Any(x => x == '-' || x == ' ')
                )
            {
                return false;
            }
        }

        return true;
    }

}
