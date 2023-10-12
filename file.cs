using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace creating_and_reading_a_file
{
    public class file
    {
        static void Main()

        {
            //Создание файла:
            string fileName = "example.txt";
            string content = "Это текст, который будет записан в файл.";

            // Запись содержимого в файл
            File.WriteAllText(fileName, content);

            Console.WriteLine($"Файл {fileName} успешно создан и заполнен.");

            //Чтение файла:
            

            // Проверка существования файла
            if (File.Exists(fileName))
            {
                // Чтение содержимого файла
                string content2 = File.ReadAllText(fileName);

                Console.WriteLine($"Содержимое файла {fileName}:");
                Console.WriteLine(content2);
            }
            else
            {
                Console.WriteLine($"Файл {fileName} не существует.");
            }
        }
    }


}
