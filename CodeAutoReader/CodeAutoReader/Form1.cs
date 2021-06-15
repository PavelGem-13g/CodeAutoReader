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

namespace CodeAutoReader
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog folderBrowserDialog;
        string folderName;
        string[] extensionsArray;

        string text;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderName = folderBrowserDialog.SelectedPath;
                extensionsArray = extensions.Text.Split(',');
                text = GetCodeFromDirectory(folderName);
                result.Text = text;
            }
        }
        string GetCodeFromDirectory(string direcotyPath) 
        {
            string result = "";
            foreach (var item in Directory.GetDirectories(direcotyPath))
            {
                result += GetCodeFromDirectory(item);
            }
            foreach (var item in Directory.GetFiles(direcotyPath))
            {
                if (extensionsArray.Contains(Path.GetExtension(item)))
                {
                    result += GetCodeFromFile(item);
                }
            }
            return result;
        }
        string GetCodeFromFile(string filePath) 
        {
            string result = "";
            using (StreamReader file = new StreamReader(filePath))
            {
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    result += ln+"\n";
                }
                file.Close();
            }
            return result;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(text);
        }
    }
}
