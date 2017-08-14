using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Home : Form
    {
        public MemoryStream memBuf;
        public Home()
        {
            InitializeComponent();
            memBuf = new MemoryStream();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Text = "Connecting....";
            connectDevice();
            btnConnect.Text = "Connected";
            button2.Enabled = true;
            

        }
        private void connectDevice()
        {
            int portNo = 0;
            string devModel = "";
            int devNo = 0;
            string ipAdd = "";
            int comm = 0;
            string sdkVer = "test";
            string firmware = "";
            string sdk = "";
            string firm = "";
            string time = "";

            int yr = 0;
            int mth = 0;
            int day_Renamed = 0;
            int hr = 0;
            int min = 0;
            int sec = 0;
            int commPort = 0;
            int baudRate = 0;
            int i = 0;

            devModel = txtModel.Text;
            devNo = Convert.ToInt32(1);
            ipAdd = txtIPAdd.Text;
            portNo = Convert.ToInt32(txtPort.Text);
            comm = Convert.ToInt32(txtCommKey.Text);
            commPort = Convert.ToInt32(txtCommPort.Text);
            baudRate = Convert.ToInt32(txtBaudRate.Text);

            //option to connect to ip address
            if (rBtnIP.Checked)
            {
                string sError = axBioBridgeSDKv3lib1.Connect_TCPIP(devModel, devNo, ipAdd, portNo, comm).ToString();
                Console.WriteLine("return code : " + sError);
                if (sError == "0")
                {
                    RegisterEvent();

                    btnConnect.Enabled = false;

                    txtIPAdd.Enabled = false;
                    txtPort.Enabled = false;

                    if (axBioBridgeSDKv3lib1.GetSDKVersion(ref sdkVer, 0) == 0)
                    {
                        sdk = "SDK Version: " + sdkVer;
                    }
                    else
                    {
                        sdk = "SDK Version Error";
                    }

                    if (axBioBridgeSDKv3lib1.GetFirmwareVersion(ref firmware) == 0)
                    {
                        firm = "Firmware Version: " + firmware;
                    }
                    else
                    {
                        firm = "Firmware Error";
                    }

                    if (axBioBridgeSDKv3lib1.GetDeviceTime(ref yr, ref mth, ref day_Renamed, ref hr, ref min, ref sec) == 0)
                    {
                        time = "Device Date and Time: " + Convert.ToString(day_Renamed) + "/" + Convert.ToString(mth) + "/" + Convert.ToString(yr) + " " + Convert.ToString(hr) + ":" + Convert.ToString(min) + ":" + Convert.ToString(sec);
                    }
                    else
                    {
                        time = "!Date and Time";
                    }
                    List1.Items.Add(("-------------------------------------------------------------------"));
                    List1.Items.Add((sdk));
                    List1.Items.Add((firm));
                    List1.Items.Add((time));
                    List1.Items.Add(("Manufacturer: " + axBioBridgeSDKv3lib1.VC));
                    List1.Items.Add(("Serial No: " + axBioBridgeSDKv3lib1.SN));
                    List1.Items.Add(("Mac Add: " + axBioBridgeSDKv3lib1.MAC));
                    List1.Items.Add(("Model Name: " + axBioBridgeSDKv3lib1.DC));

                    Console.WriteLine((sdk));
                    Console.WriteLine((firm));
                    Console.WriteLine((time));
                    Console.WriteLine(("Manufacturer: " + axBioBridgeSDKv3lib1.VC));
                    Console.WriteLine(("Serial No: " + axBioBridgeSDKv3lib1.SN));
                    Console.WriteLine(("Mac Add: " + axBioBridgeSDKv3lib1.MAC));
                    Console.WriteLine(("Model Name: " + axBioBridgeSDKv3lib1.DC));

                    if (axBioBridgeSDKv3lib1.Finger10 == 1)
                    {
                        List1.Items.Add(("This is a FP10 reader"));
                    }
                    else
                    {
                        List1.Items.Add(("This is not a FP10 reader"));
                    }

                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(1, ref i) == 0)
                    {
                        List1.Items.Add(("Administrator: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(2, ref i) == 0)
                    {
                        List1.Items.Add(("Users: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(3, ref i) == 0)
                    {
                        List1.Items.Add(("Fingerprints: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(4, ref i) == 0)
                    {
                        List1.Items.Add(("Passwords: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(6, ref i) == 0)
                    {
                        List1.Items.Add(("Logs: " + Convert.ToString(i)));
                    }

                    List1.Items.Add(("------------------------------------------------------------------"));



                }
                else
                {
                    List1.Items.Add(("Unable to Connect to IP Address!!"));
                    List1.Items.Add(("Error: " + axBioBridgeSDKv3lib1.VC));
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            button2.Text = "Syncing....";
            StartTimer();
        }
        public async System.Threading.Tasks.Task StartTimer()
        {

            await Task.Run(async () =>
            {
                while (true)
                {
                    initSync();
                    await Task.Delay(10000);

                }
            });

        }
        private bool flagRecord(int EnrolNo)
        {
            using (MySqlConnection conn = new MySqlConnection("Persist Security Info=False;server=localhost;database=test;uid=root;password="))
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    try
                    {
                        conn.Open();
                        cmd.CommandText = "UPDATE tblcards SET Processed = @processed WHERE NO = @NO";
                        cmd.Parameters.AddWithValue("@processed", 'Y');
                        cmd.Parameters.AddWithValue("@NO", EnrolNo);
                        cmd.ExecuteNonQuery();
                        
                    } catch(Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                    finally
                    {
                        conn.Close();                        
                    }
                    return true;
                }
            }
        }

        private void initSync()
        {
            using (MySqlConnection conn = new MySqlConnection("Persist Security Info=False;server=localhost;database=test;uid=root;password="))
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tblcards WHERE Processed = @Processed";
                    cmd.Parameters.AddWithValue("@Processed", 'N');

                    try
                    {
                        conn.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {

                            int enrollNo = 0;
                            int level = 0;
                            string name_Renamed = "";
                            string pwd = "";
                            int cardNo = 0;
                            Boolean status = false;

                            if (reader.GetString(0) != null)
                            {

                                Console.WriteLine(reader.GetInt32(0));

                                enrollNo = Convert.ToInt32(reader.GetInt32(0));
                                name_Renamed = reader.GetString(2);
                                pwd = null;
                                level = Convert.ToInt32(0);
                                status = Convert.ToBoolean(true);
                                cardNo = Convert.ToInt32(reader.GetInt32(10));
                                axBioBridgeSDKv3lib1.SetCardNo(cardNo.ToString()); // = cardNo;

                                if (axBioBridgeSDKv3lib1.SetUserInfo(enrollNo, name_Renamed, pwd, level, status) == 0)
                                {
                                    if (flagRecord(reader.GetInt32(0)) == true) {
                                        List2.Invoke(t => t.Items.Add(reader.GetString(0) + " Record Synced!!"));                                     
                                        Console.WriteLine("added : " + reader.GetString(0));
                                    }
                                }

                            }
                            else
                            {
                                List2.Invoke(t => t.Items.Add(reader.GetString(0) + " Record Synced!!"));
                                
                            }

                        }

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

         
        }
        private void RegisterEvent()
        {
            axBioBridgeSDKv3lib1.OnConnect += axBioBridgeSDKv3lib1_OnConnected;
            axBioBridgeSDKv3lib1.OnDisConnect += axBioBridgeSDKv3lib1_OnDisConnected;
            axBioBridgeSDKv3lib1.OnFinger += axBioBridgeSDKv3lib1_OnFinger;
            axBioBridgeSDKv3lib1.OnAttTransactionEx += axBioBridgeSDKv3lib1_OnAttTransactionEx; ;
            axBioBridgeSDKv3lib1.OnDoor += axBioBridgeSDKv3lib1_OnDoor;
            axBioBridgeSDKv3lib1.OnAlarm += axBioBridgeSDKv3lib1_OnAlarm;
        }

        private void axBioBridgeSDKv3lib1_OnFinger(object sender, EventArgs e)
        {
            Console.WriteLine("On Finger Event!!!");
           
            //ThreadProcSafe("On Finger Event!!!");
        }

        private void axBioBridgeSDKv3lib1_OnDisConnected(object sender, EventArgs e)
        {
            Console.WriteLine("On Disconnect!!!");

        }

        private void axBioBridgeSDKv3lib1_OnConnected(object sender, EventArgs e)
        {
            Console.WriteLine("On DisConnectconnect!!!");

        }

        private void axBioBridgeSDKv3lib1_OnAttTransactionEx(object sender, AxBioBridgeSDKv3.IBioBridgeSDKv3libEvents_OnAttTransactionExEvent e)
        {
            string smessage = string.Empty;
            string date = e.year + "-" + e.month + "-" + e.day + " " + e.hour + ":" + e.minute + ":" + e.second;
            smessage = "On Transaction Event:- Date=" + date + " ,EnrollNo=" + e.enrollNo + " ,AttState=" + e.attState + " ,IsInValid=" + e.isInValid + " ,VerifyMode=" + e.verifyMode + " ,WorkCode=" + e.workCode;
            //listBox3.Items.Add("On Transaction Event:- Date=" + date + " ,EnrollNo=" + e.enrollNo + " ,AttState=" + e.attState + " ,IsInValid=" + e.isInValid + " ,VerifyMode=" + e.verifyMode + " ,WorkCode=" + e.workCode );
            
        }

        private void axBioBridgeSDKv3lib1_OnAlarm(object sender, AxBioBridgeSDKv3.IBioBridgeSDKv3libEvents_OnAlarmEvent e)
        {
            Console.WriteLine("On Alarm!!!");

        }

        private void axBioBridgeSDKv3lib1_OnDoor(object sender, AxBioBridgeSDKv3.IBioBridgeSDKv3libEvents_OnDoorEvent e)
        {
            Console.WriteLine("On Door!!!");

        }

       
    }
}

public static class Extensions
{
    public static void Invoke<TControlType>(this TControlType control, Action<TControlType> del)
        where TControlType : Control
    {
        if (control.InvokeRequired)
            control.Invoke(new Action(() => del(control)));
        else
            del(control);
    }
}
