using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace runasdate_rng_addon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RunAsDateDirectoryLabel.Text = ConfigurationManager.AppSettings["RunAsDateDirectory"];
            VBADirectoryLabel.Text = ConfigurationManager.AppSettings["VBADirectory"];
        }

        private void SelectRunAsDateButton_Click(object sender, EventArgs e)
        {
            DialogResult result = SelectRunAsDateDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = SelectRunAsDateDialog.FileName;
                RunAsDateDirectoryLabel.Text = file;
                AddOrUpdateAppSettings("RunAsDateDirectory", file);
            }
        }

        private void SelectVBAButton_Click(object sender, EventArgs e)
        {
            DialogResult result = SelectVBADialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = SelectVBADialog.FileName;
                VBADirectoryLabel.Text = file;
                AddOrUpdateAppSettings("VBADirectory", file);
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            try
            {
                STime time = InitialSeedtoSTime((uint)InitialSeedInput.Value);
                System.Diagnostics.Process.Start(ConfigurationManager.AppSettings["RunAsDateDirectory"], "/immediate " + STimetoRunAsDateParam(time) + ConfigurationManager.AppSettings["VBADirectory"]);
            } catch
            {
                MessageBox.Show("An Error Occurred\nMake sure you have selected RunAsDate and VBA-rr correctly.");
            }
        }

        private STime InitialSeedtoSTime(uint seed)
        {
            int minDay = 0;
            int maxDay = 0;
            STime t;
            for (byte month = 1; month < 13; month++)
            {
                maxDay += DateTime.DaysInMonth(2000, month);
                for (int day = minDay; day < maxDay; day++)
                {
                    for (int hour = 0; hour < 24; hour++)
                    {
                        for (int minute = 0; minute < 60; minute++)
                        {
                            int v = 1440 * day + 960 * (hour / 10) + 60 * (hour % 10) + 16 * (minute / 10) + (minute % 10) + 0x5A0;
                            v = (v >> 16) ^ (v & 0xFFFF);
                            if (v == seed)
                            {
                                t = new STime
                                {
                                    Month = month,
                                    Day = day-minDay+1,
                                    Hour = hour,
                                    Minute = minute
                                };
                                return t;
                            }
                        }
                    }
                }
                minDay += DateTime.DaysInMonth(2000, month);
            }

            t = new STime
            {
                Month = 1,
                Day = 1,
                Hour = 0,
                Minute = 0
            };
            return t;
        }

        private string STimetoRunAsDateParam(STime time)
        {
            string s = time.Day.ToString("D2") + "/" + time.Month.ToString("D2") + "/2000 " + time.Hour.ToString("D2") + ":" + time.Minute.ToString("D2") + ":00 ";
            Console.WriteLine(s);
            return s;
        }

        public static void AddOrUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }
}
