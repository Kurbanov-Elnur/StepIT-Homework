using Microsoft.Win32;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Server
{
    public partial class MainWindow : Window
    {
        int port = 12345;
        IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelectMP3(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3";

            bool? result = openFileDialog.ShowDialog();

            if (result == true)
            {
                SendMP3(openFileDialog.FileName);
            }
        }

        private void SendMP3(string fileName)
        {
            try
            {
                // Читаем содержимое MP3 файла в виде массива байтов
                byte[] mp3Bytes = File.ReadAllBytes(fileName);

                // Определение размера блока для разделения файла на части
                int blockSize = 1024; // Размер блока (в байтах)
                int totalBlocks = (int)Math.Ceiling((double)mp3Bytes.Length / blockSize);

                // Отправка каждого блока по UDP
                using (UdpClient client = new UdpClient())
                {
                    IPEndPoint endPoint = new IPEndPoint(ipAddress, port);

                    for (int i = 0; i < totalBlocks; i++)
                    {
                        int offset = i * blockSize;
                        int length = Math.Min(blockSize, mp3Bytes.Length - offset);
                        byte[] block = new byte[length];
                        Buffer.BlockCopy(mp3Bytes, offset, block, 0, length);

                        // Сериализуем массив байтов блока в JSON и отправляем
                        string json = JsonConvert.SerializeObject(block);
                        byte[] jsonBytes = System.Text.Encoding.UTF8.GetBytes(json);
                        client.Send(jsonBytes, jsonBytes.Length, endPoint);
                    }

                    MessageBox.Show("Файл успешно отправлен.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

    }
}