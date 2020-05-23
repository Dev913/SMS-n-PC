// Idea by Dev913
// Developed by Dev913
// Year 2020
// Add more commands if you wish
// I can not wait to see where this idea goes

using System;
using System.Configuration;
using System.Diagnostics;
using System.Threading;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace SMS_N_PC
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Thread.Sleep(1000);
                {
                    string SID = ConfigurationSettings.AppSettings.Get("sid");
                    string AUTH = ConfigurationSettings.AppSettings.Get("auth");
                    TwilioClient.Init(SID, AUTH);
                    var messages = MessageResource.Read(limit: 1, dateSent: DateTime.Now);
                    foreach (var record in messages)
                    {
                        string Body = record.Body.ToString();
                        if (Body.StartsWith("Shutdown PC"))
                        {
                            Process shutdown = new Process();
                            shutdown.StartInfo.FileName = "shutdown.exe";
                            shutdown.StartInfo.Arguments = "/s /f /t 0";
                            shutdown.Start();
                        }
                        if (Body.StartsWith("shutdown /s /f /t 0"))
                        {
                            Process shutdown = new Process();
                            shutdown.StartInfo.FileName = "shutdown.exe";
                            shutdown.StartInfo.Arguments = "/s /f /t 0";
                            shutdown.Start();
                        }
                        if (Body.StartsWith("Restart PC"))
                        {
                            Process restart = new Process();
                            restart.StartInfo.FileName = "shutdown.exe";
                            restart.StartInfo.Arguments = "/r /f /t 0";
                            restart.Start();
                        }
                        if (Body.StartsWith("shutdown /r /f /t 0"))
                        {
                            Process restart = new Process();
                            restart.StartInfo.FileName = "shutdown.exe";
                            restart.StartInfo.Arguments = "/r /f /t 0";
                            restart.Start();
                        }
                        if (Body.StartsWith("Hibernate PC"))
                        {
                            Process hibernate = new Process();
                            hibernate.StartInfo.FileName = "shutdown.exe";
                            hibernate.StartInfo.Arguments = "/h";
                            hibernate.Start();
                        }
                        if (Body.StartsWith("shutdown /h"))
                        {
                            Process hibernate = new Process();
                            hibernate.StartInfo.FileName = "shutdown.exe";
                            hibernate.StartInfo.Arguments = "/h";
                            hibernate.Start();
                        }
                        if (Body.StartsWith("Shutdown PC on next boot"))
                        {
                            Process g = new Process();
                            g.StartInfo.FileName = "shutdown.exe";
                            g.StartInfo.Arguments = "/g";
                        }
                        if (Body.StartsWith("shutdown /g"))
                        {
                            Process g = new Process();
                            g.StartInfo.FileName = "shutdown.exe";
                            g.StartInfo.Arguments = "/g";
                        }
                        if (Body.StartsWith("Shutdown PC and go to firmware settings"))
                        {
                            Process fw = new Process();
                            fw.StartInfo.FileName = "shutdown.exe";
                            fw.StartInfo.Arguments = "/fw";
                        }
                        if (Body.StartsWith("shutdown /fw"))
                        {
                            Process fw = new Process();
                            fw.StartInfo.FileName = "shutdown.exe";
                            fw.StartInfo.Arguments = "/fw";
                        }
                    }
                }
            }
        }
    }
}
