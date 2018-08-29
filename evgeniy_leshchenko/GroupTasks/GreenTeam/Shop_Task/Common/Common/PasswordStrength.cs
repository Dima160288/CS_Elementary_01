﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    // взято с cyberforum с небольшими правками.
    public class PasswordStrength
    {

        //public static string[] badPasswords = new string[]
        //{
        //    "123456", "123456789", "qwerty", "111111", "1234567", "666666", "12345678", "7777777", "123321", "0", "654321", "1234567890", "123123", "555555", "vkontakte", "gfhjkm", "159753", "777777", "TempPassWord", "qazwsx", "1q2w3e", "1234", "112233", "121212", "qwertyuiop", "qq18ww899", "987654321", "12345", "zxcvbn", "zxcvbnm", "999999", "samsung", "ghbdtn", "1q2w3e4r", "1111111", "123654", "159357", "131313", "qazwsxedc", "123qwe", "222222", "asdfgh", "333333", "9379992", "asdfghjkl", "4815162342", "12344321", "любовь", "88888888", "11111111", "knopka", "пароль", "789456", "qwertyu", "1q2w3e4r5t", "iloveyou", "vfhbyf", "marina", "password", "qweasdzxc", "10203", "987654", "yfnfif", "cjkysirj", "nikita", "888888", "йцукен", "vfrcbv", "k.,jdm", "qwertyuiop[]", "qwe123", "qweasd", "natasha", "123123123", "fylhtq", "q1w2e3", "stalker", "1111111111", "q1w2e3r4", "nastya", "147258369", "147258", "fyfcnfcbz", "1234554321", "1qaz2wsx", "andrey", "111222", "147852", "genius", "sergey", "7654321", "232323", "123789", "fktrcfylh", "spartak", "admin", "test", "123", "azerty", "abc123", "lol123", "easytocrack1", "hello", "saravn", "holysh!t", "1", "Test123", "tundra_cool2", "456", "dragon", "thomas", "killer", "root", "1111", "pass", "master", "aaaaaa", "a", "monkey", "daniel", "asdasd", "e10adc3949ba59abbe56e057f20f883e", "changeme", "computer", "jessica", "letmein", "mirage", "loulou", "lol", "superman", "shadow", "admin123", "secret", "administrator", "sophie", "kikugalanetroot", "doudou", "liverpool", "hallo", "sunshine", "charlie", "parola", "100827092", "/", "michael", "andrew", "password1", "fuckyou", "matrix", "cjmasterinf", "internet", "hallo123", "eminem", "demo", "gewinner", "pokemon", "abcd1234", "guest", "ngockhoa", "martin", "sandra", "asdf", "hejsan", "george", "qweqwe", "lollipop", "lovers", "q1q1q1", "tecktonik", "naruto", "12", "password12", "password123", "password1234", "password12345", "password123456", "password1234567", "password12345678", "password123456789", "000000", "maximius", "123abc", "baseball1", "football1", "soccer", "princess", "slipknot", "11111", "nokia", "super", "star", "666999", "12341234", "1234321", "135790", "159951", "212121", "zzzzzz", "121314", "134679", "142536", "19921992", "753951", "7007", "1111114", "124578", "19951995", "258456", "qwaszx", "zaqwsx", "55555", "77777", "54321", "qwert", "22222", "33333", "99999", "88888", "66666",
        //    "iloveu", "пароль"
        //};

        public enum Strength { Короткий =0, Низкий, Средний, Высокий, Отличный, Параноик };

        public static Strength CheckPasswordStrength(string password)
        {
            int score = 0;
            Dictionary<string, int> patterns = new Dictionary<string, int> { { @"\d", 10 }, //включает цифры
                                                                         { @"[a-z]", 5 }, //буквы низ. регистра
                                                                         { @"[A-Z]", 10 }, //буквы выс. регистра
                                                                         { @"\W", 10 },  //символы
                                                                         { @"[¶©]", 15} }; //Спецсимволы

            if (password.Length >= 6)
            {
                foreach (var pattern in patterns)
                    if (Regex.Matches(password, pattern.Key).Count > 0) { score += pattern.Value; }
            }
            else
                return Strength.Короткий;



            Strength result;
            switch (score / 10)
            {
                case 0: result = Strength.Низкий; break;
                case 1: result = Strength.Средний; break;
                case 2: result = Strength.Высокий; break;
                case 3: result = Strength.Отличный; break;
                default: result = Strength.Параноик; break;
            }
            return result;
        }
    }
}
