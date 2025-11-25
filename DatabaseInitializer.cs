using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

public static class DatabaseInitializer
{
    public static void EnsureDatabaseFileExists()
    {
        // 1. Определение путей
        string executionPath = Assembly.GetExecutingAssembly().Location;
        string executionDirectory = Path.GetDirectoryName(executionPath);

        const string databaseFileName = "database";
        const string templateFileName = "database_template";

        string destinationFilePath = Path.Combine(executionDirectory, databaseFileName);
        string sourceFilePath = Path.Combine(executionDirectory, templateFileName);

        if (!File.Exists(destinationFilePath))
        {
            if (File.Exists(sourceFilePath))
            {
                try
                {
                    long sourceLength = new FileInfo(sourceFilePath).Length;
                    if (sourceLength == 0)
                    {
                        MessageBox.Show($"Ошибка: Исходный файл-шаблон '{templateFileName}' пуст (размер 0 байт).");
                        return;
                    }

                    File.Copy(sourceFilePath, destinationFilePath);

                    long destinationLength = new FileInfo(destinationFilePath).Length;
                    if (destinationLength == sourceLength)
                    {
                        MessageBox.Show($"Файл '{databaseFileName}' успешно скопирован.");
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка: Файл '{databaseFileName}' скопирован, но его размер ({destinationLength} байт) не совпадает с размером шаблона ({sourceLength} байт). Возможно, проблема с правами.");
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Ошибка: Отказано в доступе. Недостаточно прав для копирования файла в папку /bin/Debug.");
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Произошла ошибка ввода-вывода при копировании: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Непредвиденная ошибка: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show($"Ошибка: Файл-шаблон '{templateFileName}' не найден по пути: {sourceFilePath}");
            }
        }
    }
}