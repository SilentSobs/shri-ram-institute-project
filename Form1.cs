using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Shri_Ram_Institute_of_Technology
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Hxdbutton_Click(object sender, EventArgs e)
        {
            string hxdPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExternalTools", "HxD", "HxD64.exe");

            // Check if the file exists before attempting to launch
            if (File.Exists(hxdPath))
            {
                // Launch the HxD64.exe
                Process.Start(hxdPath);
                MessageBox.Show("HxD Hex Editor has been successfully launched.\n\nBrought to you by Shri Ram Institute of Technology.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: HxD Hex Editor not found. Please ensure the software is properly installed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uefiToolPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExternalTools", "UEFI", "UEFITool.exe");

            // Check if the file exists before attempting to launch
            if (File.Exists(uefiToolPath))
            {
                // Launch UEFITool.exe
                Process.Start(uefiToolPath);
                MessageBox.Show("UEFI Tool has been successfully launched.\n\nBrought to you by Shri Ram Institute of Technology.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: UEFI Tool not found. Please ensure the software is properly installed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UefiViewsbutton1_Click(object sender, EventArgs e)
        {
            string uefiViewsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExternalTools", "UEFI", "UEFI Views.exe");

            // Check if the file exists before attempting to launch
            if (File.Exists(uefiViewsPath))
            {
                // Launch UEFI Views.exe
                Process.Start(uefiViewsPath);
                MessageBox.Show("UEFI Views has been successfully launched.\n\nBrought to you by Shri Ram Institute of Technology.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: UEFI Views Tool not found. Please ensure the software is properly installed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MeAnalyzerbutton1_Click(object sender, EventArgs e)
        {

            string meAnalyzerPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExternalTools", "ME Analayzer", "mea.exe");

            // Check if the file exists before attempting to launch
            if (File.Exists(meAnalyzerPath))
            {
                // Launch ME Analyzer
                Process.Start(meAnalyzerPath);
                MessageBox.Show("ME Analyzer has been successfully launched.\n\nBrought to you by Shri Ram Institute of Technology.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: ME Analyzer not found. Please ensure the software is properly installed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string telegramUrl = "https://t.me/+Zr2FZFrL8yFiZTY1";

            // Open Telegram link in the browser
            Process.Start(new ProcessStartInfo
            {
                FileName = telegramUrl,
                UseShellExecute = true
            });
            MessageBox.Show("Opening Shri Ram Institute of Technology's Telegram channel.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ytbUrl = "https://www.youtube.com/@SHRIRAMINSTITUTEOFTECHNOLOGY";

            // Open YouTube channel in the browser
            Process.Start(new ProcessStartInfo
            {
                FileName = ytbUrl,
                UseShellExecute = true
            });
            MessageBox.Show("Opening Shri Ram Institute of Technology's YouTube channel.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
