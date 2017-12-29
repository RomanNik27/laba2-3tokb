using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Encryption
    {
        // процедура шифрации и дефиврации методом XOR
        public static string Encrypt(string message, int key)
        {
            string result = "";
            for (int i = 0; i < message.Length; i++)
                result += (char)(message[i] ^ key);
            return result;
        }

        public static void new_password_key(string password)
        {
            // генерируем ключ
            int key = new Random().Next(1, 99);
            // Шифруем введенный пароль и преобразуем строку в байты
            byte[] pass = System.Text.Encoding.GetEncoding("windows-1251").GetBytes(Encrypt(password, key));
            // преобразуем ключ в байты
            byte[] key_byte = BitConverter.GetBytes(key);
            // запись ключ в файл
            using (FileStream fstream = new FileStream("password", FileMode.OpenOrCreate))
            {
                fstream.Write(key_byte, 0, key_byte.Length);
                // записываем пароль в файл
                fstream.Write(pass, 0, pass.Length);
                fstream.Flush();
                fstream.Close();
            }
        }

        public static bool Is_pass_eq(string password)
        {
            // для считывания ключа тип int32 занимает 4 байта
            byte[] key_byte = new byte[4];
            // для считывания пароля
            
            // читаем ключ
            using (FileStream fstream = new FileStream("password", FileMode.OpenOrCreate))
            { 
                fstream.Read(key_byte, 0, 4);
                // переводим
                int key = BitConverter.ToInt32(key_byte, 0);
                byte[] pass = new byte[fstream.Length - 4];
                // читаем пароль
                fstream.Read(pass, 0, pass.Length);
                fstream.Close();
            
               
            if (pass.SequenceEqual(Encoding.GetEncoding("windows-1251").GetBytes(Encrypt(password, key))))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


    }
}
