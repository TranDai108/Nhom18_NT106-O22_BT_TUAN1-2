using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer_UI


{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private string selectedFilePath;  // Biến lưu trữ đường dẫn tệp hoặc thư mục được chọn



        private bool selectingFile = false; // Biến để phân biệt giữa việc chọn file và chọn thư mục
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectingFile = true; // Đánh dấu rằng đang chọn file

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị đường dẫn file trong TextBox2
                textBox2.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
{
    selectingFile = false; // Đánh dấu rằng đang chọn thư mục

    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
    {
        // Lấy đường dẫn thư mục đã chọn
        string selectedFolderPath = folderBrowserDialog1.SelectedPath;

        // Hiển thị đường dẫn thư mục trong TextBox2
        textBox2.Text = selectedFolderPath;
    }
}

        private void button3_Click(object sender, EventArgs e)
        {
            string sourcePath = textBox2.Text;
            string destinationPath = textBox3.Text;

            // Kiểm tra nếu nguồn là tệp
            if (File.Exists(sourcePath))
            {
                string fileName = Path.GetFileName(sourcePath);
                string destFilePath = Path.Combine(destinationPath, fileName);

                // Kiểm tra xem tệp đích đã tồn tại chưa
                if (File.Exists(destFilePath))
                {
                    // Nếu tệp đích đã tồn tại, tìm tên mới cho tệp
                    int count = 1;
                    string extension = Path.GetExtension(fileName);
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
                    string newFileName = fileName;

                    while (File.Exists(destFilePath))
                    {
                        newFileName = fileNameWithoutExtension + " (" + count.ToString() + ")" + extension;
                        destFilePath = Path.Combine(destinationPath, newFileName);
                        count++;
                    }

                    // Copy tệp sang đích với tên mới
                    File.Copy(sourcePath, destFilePath);
                    MessageBox.Show("File copied successfully");
                }
                else
                {
                    // Nếu tệp đích không tồn tại, copy tệp sang đích
                    File.Copy(sourcePath, destFilePath);
                    MessageBox.Show("File copied successfully");
                }
            }
            // Kiểm tra nếu nguồn là thư mục
            else if (Directory.Exists(sourcePath))
            {
                string folderName = new DirectoryInfo(sourcePath).Name;
                string destFolderPath = Path.Combine(destinationPath, folderName);

                // Kiểm tra xem thư mục đích đã tồn tại chưa
                if (Directory.Exists(destFolderPath))
                {
                    // Nếu thư mục đích đã tồn tại, tìm tên mới cho thư mục
                    int count = 1;
                    string newFolderName = folderName;

                    while (Directory.Exists(destFolderPath))
                    {
                        newFolderName = folderName + " (" + count.ToString() + ")";
                        destFolderPath = Path.Combine(destinationPath, newFolderName);
                        count++;
                    }

                    // Copy thư mục sang đích với tên mới
                    DirectoryCopy(sourcePath, destFolderPath);
                    MessageBox.Show("Folder copied successfully");
                }
                else
                {
                    // Nếu thư mục đích không tồn tại, copy thư mục sang đích
                    DirectoryCopy(sourcePath, destFolderPath);
                    MessageBox.Show("Folder copied successfully");
                }
            }
            else
            {
                MessageBox.Show("Invalid source path.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sourcePath = textBox2.Text;
            string destinationPath = textBox3.Text;

            // Kiểm tra nếu nguồn là tệp
            if (File.Exists(sourcePath))
            {
                string fileName = Path.GetFileName(sourcePath);
                string destFilePath = Path.Combine(destinationPath, fileName);

                // Kiểm tra xem tệp đích đã tồn tại chưa
                if (File.Exists(destFilePath))
                {
                    // Nếu tệp đích đã tồn tại, xóa tệp cũ trước khi cắt
                    File.Delete(destFilePath);
                }

                // Di chuyển tệp sang đích
                File.Move(sourcePath, destFilePath);
                MessageBox.Show("File moved successfully");
            }
            // Kiểm tra nếu nguồn là thư mục
            else if (Directory.Exists(sourcePath))
            {
                string folderName = new DirectoryInfo(sourcePath).Name;
                string destFolderPath = Path.Combine(destinationPath, folderName);

                // Kiểm tra xem thư mục đích đã tồn tại chưa
                if (Directory.Exists(destFolderPath))
                {
                    // Nếu thư mục đích đã tồn tại, xóa thư mục cũ trước khi cắt
                    Directory.Delete(destFolderPath, true);
                }

                // Di chuyển thư mục sang đích
                Directory.Move(sourcePath, destFolderPath);
                MessageBox.Show("Folder moved successfully");
            }
            else
            {
                MessageBox.Show("Invalid source path.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string selectedPath = textBox2.Text;

            if (File.Exists(selectedPath))
            {
                // Nếu là một tệp tin, xóa tệp tin
                File.Delete(selectedPath);
                MessageBox.Show("File deleted successfully");
            }
            else if (Directory.Exists(selectedPath))
            {
                // Nếu là một thư mục, xóa thư mục và tất cả các tệp con bên trong (nếu có)
                try
                {
                    Directory.Delete(selectedPath, true);
                    MessageBox.Show("Folder deleted successfully");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selected item is neither a file nor a folder");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = openFileDialog1.FileName;

                if (File.Exists(selectedPath))
                {
                    
                    textBox2.Text = selectedPath;
                }
                else if (Directory.Exists(selectedPath))
                {
                    
                    textBox2.Text = selectedPath;
                }
                else
                {
                    MessageBox.Show("Selected path is neither a file nor a folder");
                }
            }
            else
            {
                MessageBox.Show("No file selected");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void DirectoryCopy(string sourceDirName, string destDirName)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Tạo thư mục đích nếu nó không tồn tại
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Sao chép tất cả các tệp trong thư mục nguồn vào thư mục đích
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // Sao chép tất cả các thư mục con vào thư mục đích
            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(destDirName, subdir.Name);
                DirectoryCopy(subdir.FullName, temppath);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file đã chọn
                string selectedPath = openFileDialog1.FileName;

                // Kiểm tra xem là file hay thư mục
                if (File.Exists(selectedPath))
                {
                    // Nếu là file, hiển thị tên file vào textBox1 và đường dẫn vào textBox2
                   
                    textBox2.Text = selectedPath;

                    // Ẩn textBox3 nếu đang hiển thị
                    textBox3.Visible = false;
                }
                else if (Directory.Exists(selectedPath))
                {
                    // Nếu là thư mục, hiển thị tên thư mục vào textBox1 và đường dẫn vào textBox2
                    
                    textBox2.Text = selectedPath;

                    // Ẩn textBox3 nếu đang hiển thị
                    textBox3.Visible = false;
                }
            }
            else if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn thư mục đã chọn
                string selectedPath = folderBrowserDialog1.SelectedPath;

                // Hiển thị tên thư mục vào textBox1 và đường dẫn vào textBox2
                
                textBox2.Text = selectedPath;

                // Ẩn textBox3 nếu đang hiển thị
                textBox3.Visible = false;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn thư mục đã chọn
                string selectedPath = folderBrowserDialog1.SelectedPath;

                // Hiển thị đường dẫn thư mục trong textBox3
                textBox3.Text = selectedPath;
            }
        }

       
    }


}
        


