using Acivator_Windows.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Acivator_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ActivateOffice_Click(object sender, EventArgs e)
        {
            if (rb_Ohook.Checked)
            {
                string filePathToOhookCmd = Path.Combine(Path.GetTempPath(), "ohook.cmd");
                File.WriteAllText(filePathToOhookCmd, Resources.Ohook_Activation_AIO);
                if (File.Exists(filePathToOhookCmd))
                {
                    var ohook = Process.Start(new ProcessStartInfo()
                    {
                        FileName = filePathToOhookCmd, //это как называется процесс, который запускаем. Не важно что не дописано .exe
                        UseShellExecute = false, // Это отрисовка оболочки (окна, формы). False - не надо отрисоывать, True - наоборот
                        CreateNoWindow = true, // Не создавать окно приложения, которое запускаем. Тут кривой перевод, создать НЕ окно, но сути не меняет
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        StandardErrorEncoding = System.Text.Encoding.UTF8

                    });
                }
            }
        }

        private void rb_hwid_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_hwid.Checked || rb_kms38.Checked)
            {
                btn_activateOffice.Enabled = false;
                btnActivateWindows.Enabled = true;
                btnActivateWindows.BackColor = Color.DodgerBlue;
                btn_activateOffice.BackColor = Color.Gray;
            }
        }

        private void btn_ActivateWindows_Click_1(object sender, EventArgs e)
        {
            if (rb_hwid.Checked)
            {

                string filePathToHwidCmd = Path.Combine(Path.GetTempPath(), "hwid.cmd");
                File.WriteAllText(filePathToHwidCmd, Resources.HWID_Activation);
                if (File.Exists(filePathToHwidCmd))
                {
                    var hwidProcess = Process.Start(new ProcessStartInfo()
                    {
                        FileName = filePathToHwidCmd, //это как называется процесс, который запускаем. Не важно что не дописано .exe
                        UseShellExecute = false, // Это отрисовка оболочки (окна, формы). False - не надо отрисоывать, True - наоборот
                        CreateNoWindow = true, // Не создавать окно приложения, которое запускаем. Тут кривой перевод, создать НЕ окно, но сути не меняет
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        StandardErrorEncoding = System.Text.Encoding.UTF8

                    });
                    //hwidProcess.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
                    string hwidLog = hwidProcess.StandardOutput.ReadToEnd();
                }

            }
            else if (rb_kms38.Checked)
            {
                string filePathToKMS38 = Path.Combine(Path.GetTempPath(), "kms38.cmd");
                File.WriteAllText(filePathToKMS38, Resources.KMS38_Activation);
                if (File.Exists(filePathToKMS38))
                {
                    var kms38proc = Process.Start(new ProcessStartInfo()
                    {
                        FileName = filePathToKMS38, //это как называется процесс, который запускаем. Не важно что не дописано .exe
                        UseShellExecute = false, // Это отрисовка оболочки (окна, формы). False - не надо отрисоывать, True - наоборот
                        CreateNoWindow = true, // Не создавать окно приложения, которое запускаем. Тут кривой перевод, создать НЕ окно, но сути не меняет
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        StandardErrorEncoding = System.Text.Encoding.UTF8

                    });
                }

            }
        }

        private void rb_Ohook_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rb_Ohook.Checked)
            {
                btn_activateOffice.Enabled = true;
                btnActivateWindows.Enabled = false;
                btn_activateOffice.BackColor = Color.OrangeRed;
                btnActivateWindows.BackColor = Color.Gray;
            }
        }
    }
}



