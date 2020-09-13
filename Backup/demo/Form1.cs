using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;


namespace demo
{
    unsafe public partial class Form1 : Form
    {


        // 初始化设备(Initialize device, call it when your app stars)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_Init")]
        public static extern int AD800_Init();

        // 释放设备(Free device, call it when your app closes)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_Free")]
        public static extern void AD800_Free();

        // 有两种方式收DLL状态，一种是通过消息，别一种是回调函数(There are two way to get status, one is windows message, another is callback function)
        // 设置回送消息句柄(windows message mode, set handle to receive message)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_SetMsgHwnd")]
        public static extern void AD800_SetMsgHwnd(int hWnd);

        // 设置回调函数(callback function mode, set function address)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_SetCallbackFun")]
        public static extern void AD800_SetCallbackFun(IntPtr fun);

        // 得到设备数(Get the number of devices)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_GetTotalDev")]
        public static extern int AD800_GetTotalDev();

        // 得到通道数(Get the number of channels)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_GetTotalCh")]
        public static extern int AD800_GetTotalCh();

        // 读取外线状态(Get line status of the channel)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_GetChState")]
        public static extern int AD800_GetChState(int iChannel);

        // 读取来电号码(Get caller id number of the channel)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_GetCallerId", CharSet=CharSet.Ansi)]
        public static extern int AD800_GetCallerId(int iChannel, StringBuilder szBuff, uint iLen);

        // 读取拨号(Get dialed number of the channel)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_GetDialed", CharSet=CharSet.Ansi)]
        public static extern int AD800_GetDialed(int iChannel, StringBuilder szBuff, uint iLen);

        // 读取版本号(Get device version)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_GetVer")]
        public static extern void AD800_GetVer(int iDevice, StringBuilder szBuff, uint iLen);

        // 读取设备序号(Get device serial no.)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_GetDevSN")]
        public static extern int AD800_GetDevSN(int iDevice);

        // 设置/读取 提机，挂机信号侦测参数(默认电压范围是 3 - 20v 3到20之间就认为是提机，大于20就认为是挂机, 侦测时间是提机500ms, 挂机300ms, 掉电200ms)
        //(Set/Get hook detection voltage setting(default range: 3v-20v), if line voltage is less then 3, line status is power off, 
        // if line voltage is between 3 and 20, line status is hook off(pickup), if line voltage is bigger then 20, line status is hook on(hangup) )
        // default hook off detecting time(means voltage continuance time) is 500ms, hook on is 300ms
        [DllImport("AD800Device.dll", EntryPoint = "AD800_SetHookVoltage")]
        public static extern int AD800_SetHookVoltage(int iChannel, byte szHookOffVol, byte szHookOnVol);

        [DllImport("AD800Device.dll", EntryPoint = "AD800_SetHookTime")]
        public static extern int AD800_SetHookTime(int iChannel, int iHookOffTime, int iHookOnTime, int iPowerOffTime);

        [DllImport("AD800Device.dll", EntryPoint = "AD800_GetHookVoltage")]
        public static extern void AD800_GetHookVoltage(int iChannel, ref byte szHookOffVol, ref byte szHookOnVol);

        [DllImport("AD800Device.dll", EntryPoint = "AD800_GetHookTime")]
        public static extern void AD800_GetHookTime(int iChannel, ref int iHookOffTime, ref int iHookOnTime, ref int iPowerOffTime);

        // 设置/读取 来电号码结束时间(默认时间是200ms)(Get/Set caller id end time for receive DTMF caller id, calculate time from last received digit)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_SetRevCIDTime")]
        public static extern int AD800_SetRevCIDTime(int iChannel, int iCIDTime);

        [DllImport("AD800Device.dll", EntryPoint = "AD800_GetRevCIDTime")]
        public static extern void AD800_GetRevCIDTime(int iChannel, ref int iCIDTime);

        // 设置录音和放间音量(Set volume of recording/playback)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_SetRecVolume")]
        public static extern int AD800_SetRecVolume(int iChannel, int iVol);

        [DllImport("AD800Device.dll", EntryPoint = "AD800_SetPlaybackVolume")]
        public static extern int AD800_SetPlaybackVolume(int iChannel, int iVol);

        // 得到当前的音量值(Get current volume of recording/playback)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_GetRecVolume")]
        public static extern int AD800_GetRecVolume(int iChannel);

        [DllImport("AD800Device.dll", EntryPoint = "AD800_GetPlaybackVolume")]
        public static extern int AD800_GetPlaybackVolume(int iChannel);
      
        // 开始录音(Recording API,file recording and memory recording, 
        // file recording, just give a file name, then DLL will save voice data to the file,
        // memory recording, give a memory buffer, DLL save voice data to buffer, when buffer is buff, DLL will send full status)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_StartFileRec", CharSet=CharSet.Ansi)]
        public static extern int AD800_StartFileRec(int iChannel, StringBuilder szFile);

        [DllImport("AD800Device.dll", EntryPoint = "AD800_StartMemRec")]
        public static extern int AD800_StartMemRec(int iChannel, byte *pszBuff, uint iLen);

        // 内存录音时，得到当前录音缓存里存了多少个BYTE的数据(memory recording, get the number of bytes in memory buff)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_GetMemRecBytes")]
        public static extern int AD800_GetMemRecBytes(int iChannel);

        // 停止录音(Stop recording)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_StopRec")]
        public static extern int AD800_StopRec(int iChannel);

        // 放音(Play voice, the same as recording, there are file mode and memory buffer mode)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_PlayFile",CharSet=CharSet.Ansi)]
        public static extern int AD800_PlayFile(int iChannel, StringBuilder szFile);

        [DllImport("AD800Device.dll", EntryPoint = "AD800_PlayMem")]
        public static extern int AD800_PlayMem(int iChannel, byte *pszBuff, uint iLen);

        // 停止放音(Stop playback)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_StopPlay")]
        public static extern void AD800_StopPlay(int iChannel);

        // 语音触发(Enable voice trigger, after enabled voice trigger, if voice reachs the set threshold, DLL will send trigger status)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_VoiceTrigger")]
        public static extern int AD800_VoiceTrigger(int iChannel);

        // 停止语音触发(Disable voice trigger)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_StopVoiceTrigger")]
        public static extern void AD800_StopVoiceTrigger(int iChannel);

        // 语音触发参数(Set/Get voice trigger parameters, voice/silence threshold, voice/silence continuance time)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_SetVoiceThreshold")]
        public static extern int AD800_SetVoiceThreshold(int iChannel, int iTime, int iLevel);

        [DllImport("AD800Device.dll", EntryPoint = "AD800_SetSilenceThreshold")]
        public static extern int AD800_SetSilenceThreshold(int iChannel, int iTime, int iLevel);

        [DllImport("AD800Device.dll", EntryPoint = "AD800_GetVoiceThreshold")]
        public static extern void AD800_GetVoiceThreshold(int iChannel, ref int iTime, ref int iLevel);

        [DllImport("AD800Device.dll", EntryPoint = "AD800_GetSilenceThreshold")]
        public static extern void AD800_GetSilenceThreshold(int iChannel, ref int iTime, ref int iLevel);

        // 忙音侦测(Start detecting busy tone)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_DetBusyTone")]
        public static extern int AD800_DetBusyTone(int iChannel);

        // 停止忙音侦测(Stop detecting busy tone)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_StopDetBusyTone")]
        public static extern void AD800_StopDetBusyTone(int iChannel);

        // 停止忙音侦测(Stop detecting busy tone)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_SendDTMF", CharSet=CharSet.Ansi)]
        public static extern int AD800_SendDTMF(int iChannel, StringBuilder szBuff, uint iLen);

        // 提挂和挂机(Pickup/Hangup line, line you pickup/huangup phone)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_PickUp")]
        public static extern int AD800_PickUp(int iChannel);

        [DllImport("AD800Device.dll", EntryPoint = "AD800_HangUp")]
        public static extern int AD800_HangUp(int iChannel);

        // 切断和连接电话机(Disconnect/Connect phone, Cut/Connect connection between phone and line)
        [DllImport("AD800Device.dll", EntryPoint = "AD800_DisconnectPhone")]
        public static extern int AD800_DisconnectPhone(int iChannel);

        [DllImport("AD800Device.dll", EntryPoint = "AD800_ConnectPhone")]
        public static extern int AD800_ConnectPhone(int iChannel);



        // windows消息(windows message definition)
        public const int WM_AD800MSG = 1024 + 1800;

        // 端口状态(All Channel Status)
        public enum AD800_STATUS : int
        {
            AD800_DEVICE_CONNECTION = 0,	// 设备连接状态(Device connection status)

            AD800_LINE_STATUS, // 外线状态(Line Status e.g pickup,hangup,ringing,power off)

            AD800_LINE_VOLTAGE, // 外线电压(Line voltage)

            AD800_LINE_POLARITY, // 外线极性(Line Polarity Changed)

            AD800_LINE_CALLERID, // 外线来电号码(Caller Id number)

            AD800_LINE_DTMF, // 电话机拨号(Dialed number)

            AD800_REC_DATA,	// 录音数据(Recording data)

            AD800_PLAY_FINISHED, // 放音完成(Playback finished)

            AD800_VOICETRIGGER, // 语音触发状态(Voice trigger status)

            AD800_BUSYTONE,	// 忙音状态(Busy tone status)

            AD800_DTMF_FINISHED // DTMF发送完成(Send DTMF finished)

        };

        // 设备连接状态(Device Connection Status Definition)
        public enum AD800_CONNECTION : int
        {
            AD800DEVICE_DISCONNECTED = 0,	// 断开(Device connected)
            AD800DEVICE_CONNECTED			// 连上(Device disconnected)
        };

        // 外线状态(Line Status Definition)
        public enum AD800_LINESTATUS : int
        {
            AD800LINE_POWEROFF = 0, // 掉电(Power off/no line)
            AD800LINE_HOOKOFF,		// 提机(Pick up)
            AD800LINE_HOOKON,		// 挂机(Hang up)
            AD800LINE_RING		// 响铃(Ringing)
        };


        public enum LIST_COLUMN : int
        {
            LISTCOL_CH = 0,
            LISTCOL_SN,
            LISTCOL_LINESTATUS,
            LISTCOL_VOLTAGE,
            LISTCOL_VOICETRIGGER,
            LISTCOL_CALLERID,
            LISTCOL_DIALED,
            LISTCOL_VER
        };

        public struct CHSTATUS
        {
            public bool bRecord;
            public bool bPlay;
            public bool bLineBusy;
            public bool bDisPhone;
            public bool bDial;
            public bool bVoiceTrigger;
            public bool bDetBusytone;

            public int dwLost;
            public int dwAdd;

            public int dwBlock;
            public int dwBlockACK;

            public int iRecVol;
            public int iPlayVol;
        };

        public const int MAX_CH = 32;

        CHSTATUS[] m_tagCHState = new CHSTATUS[MAX_CH];

        public bool m_bClickRecVol = false;
        public bool m_bClickPlayVol = false;


        private void SetLanguage(bool bEng)
        {

            if (bEng)
            {
                listView1.Columns[0].Text = "Channel";
                listView1.Columns[1].Text = "Device SN";
                listView1.Columns[2].Text = "Line Status";
                listView1.Columns[3].Text = "Line Voltage";
                listView1.Columns[4].Text = "Voice Trigger";
                listView1.Columns[5].Text = "Caller Id";
                listView1.Columns[6].Text = "Dialed";
                listView1.Columns[7].Text = "Device Ver";

                button_StartRec.Text = "Start Rec";
                button_StopRec.Text = "Stop Rec";

                button_StartPlay.Text = "Start Play";
                button_StopPlay.Text = "Stop Play";

                button_LineBusy.Text = "Line Busy";
                button_LineFree.Text = "Line Free";

                button_DisconnectPhone.Text = "Disconnect Phone";
                button_ConnectPhone.Text = "Connect Phone";

                button_Dial.Text = "Dial";

                checkBox_DetBusytone.Text = "Detect Busytone";

                checkBox_Chinese.Text = "Language(Chinese)";

                groupBox_VolSetting.Text = "Volume Setting";
                label_RecVol.Text = "Rec Vol:";
                label_PlayVol.Text = "Play Vol:";

                groupBox_VoiceTriggerSetting.Text = "Voice Trigger Setting";
                checkBox_VoiceTrigger.Text = "Voice Trigger";
                label_VoiceLevel.Text = "Voice level:";
                label_SilenceLevel.Text = "Silence Level:";
                label_TimeDetVoice.Text = "Time(Det voice)(100MS):";
                label_TimeDetSilence.Text = "Time(Det silence)(S):";
                button_Set.Text = "Set";
            }

            else
            {
                listView1.Columns[0].Text = "端口";
                listView1.Columns[1].Text = "设备号";
                listView1.Columns[2].Text = "外线状态";
                listView1.Columns[3].Text = "外线电压";
                listView1.Columns[4].Text = "语音触发";
                listView1.Columns[5].Text = "来电号码";
                listView1.Columns[6].Text = "拨号";
                listView1.Columns[7].Text = "设备版本";

                button_StartRec.Text = "录音";
                button_StopRec.Text = "停止录音";

                button_StartPlay.Text = "放音";
                button_StopPlay.Text = "停止放音";

                button_LineBusy.Text = "占线";
                button_LineFree.Text = "空闲";

                button_DisconnectPhone.Text = "切断电话机";
                button_ConnectPhone.Text = "连通电话机";

                button_Dial.Text = "拨号";

                checkBox_DetBusytone.Text = "侦测忙音";

                checkBox_Chinese.Text = "语言(中文)";

                groupBox_VolSetting.Text = "音量设定";
                label_RecVol.Text = "录音音量:";
                label_PlayVol.Text = "放音音量:";

                groupBox_VoiceTriggerSetting.Text = "语音触发设定";
                checkBox_VoiceTrigger.Text = "语音触发";
                label_VoiceLevel.Text = "触发等级:";
                label_SilenceLevel.Text = "无声等级:";
                label_TimeDetVoice.Text = "触发时间(100MS):";
                label_TimeDetSilence.Text = "无声时间(S):";
                button_Set.Text = "设置参数";
            }

        }

        public void EnableCtrls(bool bEnable)
        {
            button_StartRec.Enabled = bEnable;
            button_StopRec.Enabled = bEnable;

            button_StartPlay.Enabled = bEnable;
            button_StopPlay.Enabled = bEnable;

            button_LineBusy.Enabled = bEnable;
            button_LineFree.Enabled = bEnable;

            button_DisconnectPhone.Enabled = bEnable;
            button_ConnectPhone.Enabled = bEnable;

            textBox_Num.Enabled = bEnable;
            button_Dial.Enabled = bEnable;

            checkBox_DetBusytone.Enabled = bEnable;

            checkBox_Chinese.Enabled = bEnable;

            groupBox_VolSetting.Enabled = bEnable;
            label_RecVol.Enabled = bEnable;
            label_PlayVol.Enabled = bEnable;
            comboBox_RecVol.Enabled = bEnable;
            comboBox_PlayVol.Enabled = bEnable;

            groupBox_VoiceTriggerSetting.Enabled = bEnable;
            checkBox_VoiceTrigger.Enabled = bEnable;
            label_VoiceLevel.Enabled = bEnable;
            label_SilenceLevel.Enabled = bEnable;
            comboBox_VoiceLevel.Enabled = bEnable;
            comboBox_SilenceLevel.Enabled = bEnable;
            label_TimeDetVoice.Enabled = bEnable;
            label_TimeDetSilence.Enabled = bEnable;
            textBox_TimeDetVoice.Enabled = bEnable;
            textBox_TimeDetSilence.Enabled = bEnable;
            button_Set.Enabled = bEnable;

        }

        public void ChangeCtrlStatus(int iChannel)
        {
            if (iChannel < 0 || iChannel >= MAX_CH) return;

            if (m_tagCHState[iChannel].bRecord)
            {
                button_StartRec.Enabled = false;
                button_StopRec.Enabled = true;
            }

            else
            {
                button_StartRec.Enabled = true;
                button_StopRec.Enabled = false;
            }

            if (m_tagCHState[iChannel].bPlay)
            {
                button_StartPlay.Enabled = false;
                button_StopPlay.Enabled = true;
            }

            else
            {
                button_StartPlay.Enabled = true;
                button_StopPlay.Enabled = false;
            }

            if (m_tagCHState[iChannel].bLineBusy)
            {
                button_LineBusy.Enabled = false;
                button_LineFree.Enabled = true;
            }

            else
            {
                button_LineBusy.Enabled = true;
                button_LineFree.Enabled = false;
            }

            if (m_tagCHState[iChannel].bDisPhone)
            {
                button_DisconnectPhone.Enabled = false;
                button_ConnectPhone.Enabled = true;
            }

            else
            {
                button_DisconnectPhone.Enabled = true;
                button_ConnectPhone.Enabled = false;
            }

            button_Dial.Enabled = !m_tagCHState[iChannel].bDial;

            checkBox_VoiceTrigger.Checked = m_tagCHState[iChannel].bVoiceTrigger;
            checkBox_DetBusytone.Checked = m_tagCHState[iChannel].bDetBusytone;

            int iVol = 0;

            iVol = AD800_GetRecVolume(iChannel);
            comboBox_RecVol.SelectedIndex = iVol - 1;

            iVol = AD800_GetPlaybackVolume(iChannel);
            comboBox_PlayVol.SelectedIndex = iVol - 1;

            int iTime = 0;
            int iLevel = 0;

            AD800_GetVoiceThreshold(iChannel, ref iTime, ref iLevel);
            textBox_TimeDetVoice.Text = iTime.ToString();
            comboBox_VoiceLevel.SelectedIndex = iLevel - 1;

            AD800_GetSilenceThreshold(iChannel, ref iTime, ref iLevel);
            textBox_TimeDetSilence.Text = iTime.ToString();
            comboBox_SilenceLevel.SelectedIndex = iLevel - 1;
        }

        public void ClearStatus(int iChannel)
        {
            if (iChannel < 0 || iChannel >= MAX_CH) return;

            m_tagCHState[iChannel].bRecord = false;
            m_tagCHState[iChannel].bPlay = false;
            m_tagCHState[iChannel].bLineBusy = false;
            m_tagCHState[iChannel].bDisPhone = false;
            m_tagCHState[iChannel].bDial = false;
            m_tagCHState[iChannel].bVoiceTrigger = false;
            m_tagCHState[iChannel].bDetBusytone = false;

            m_tagCHState[iChannel].dwLost = 0;
            m_tagCHState[iChannel].dwAdd = 0;

            m_tagCHState[iChannel].dwBlock = 0;
            m_tagCHState[iChannel].dwBlockACK = 0;

            m_tagCHState[iChannel].iRecVol = 0;
            m_tagCHState[iChannel].iPlayVol = 0;
        }
           

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetLanguage(true);
            EnableCtrls(false);

            textBox_Num.Text = "123456789*0#";

            string strText;

            for (int i = 0; i < 32; i++)
            {
                strText = string.Format("{0:D}", i+1);

                comboBox_RecVol.Items.Add(strText);
                comboBox_PlayVol.Items.Add(strText);
                comboBox_VoiceLevel.Items.Add(strText);
                comboBox_SilenceLevel.Items.Add(strText);
            }

            comboBox_RecVol.SelectedIndex = 9;
            comboBox_PlayVol.SelectedIndex = 9;
            comboBox_VoiceLevel.SelectedIndex = 9;
            comboBox_SilenceLevel.SelectedIndex = 9;

            textBox_TimeDetVoice.Text = "5";
            textBox_TimeDetSilence.Text = "5";


            AD800_SetMsgHwnd(Handle.ToInt32());

            if ( 0 == AD800_Init( ))
            {
               MessageBox.Show("Initialize device failed!");
            }
        }

        private void OnDeviceMsg(IntPtr wParam, IntPtr lParam)
        {
            int iEvent = new int();
            int iChannel = new int();

            iEvent = wParam.ToInt32() % 65536;
            iChannel = wParam.ToInt32() / 65536;


            switch (iEvent)
            {
                case (int)AD800_STATUS.AD800_DEVICE_CONNECTION:
                    {
                        if ((int)AD800_CONNECTION.AD800DEVICE_CONNECTED == lParam.ToInt32())
                        {
                            EnableCtrls(true);

                            int iDev = iChannel;
                            StringBuilder szVer = new StringBuilder(32);
                            AD800_GetVer(iDev, szVer, 20);

                            string strSN;
                            strSN = string.Format("{0:D}", AD800_GetDevSN(iDev));


			                int iCount = listView1.Items.Count;


			                string strCH;

                            for (int i = iCount; i < iCount + 8; i++)
                            {
                                strCH = string.Format("{0:D}", i + 1);
                                listView1.Items.Add(strCH);

                                listView1.Items[i].SubItems.Add("");
                                listView1.Items[i].SubItems.Add("");
                                listView1.Items[i].SubItems.Add("");
                                listView1.Items[i].SubItems.Add("");
                                listView1.Items[i].SubItems.Add("");
                                listView1.Items[i].SubItems.Add("");
                                listView1.Items[i].SubItems.Add("");

                                if (iCount == i)
                                {
                                    listView1.Items[i].SubItems[(int)LIST_COLUMN.LISTCOL_SN].Text = strSN;
                                    listView1.Items[i].SubItems[(int)LIST_COLUMN.LISTCOL_VER].Text = szVer.ToString();
                                }

                                if (i == 0)
                                {
                                    listView1.Items[i].Selected = true;
                                }
                            }
			         
                        }

                        else
                        {
                            EnableCtrls(false);
                            listView1.Items.Clear();
                            m_bClickRecVol = false;
                            m_bClickPlayVol = false;

                            for (int i = 0; i < MAX_CH; i++)
                            {
                                ClearStatus(i);
                            }
                         }
                    }
                    break;


                case (int)AD800_STATUS.AD800_LINE_STATUS:
                    {
                        switch (lParam.ToInt32())
                        {
                            case (int)AD800_LINESTATUS.AD800LINE_POWEROFF:
                                listView1.Items[iChannel].SubItems[(int)LIST_COLUMN.LISTCOL_LINESTATUS].Text = "Power Off";
                                break;

                            case (int)AD800_LINESTATUS.AD800LINE_HOOKOFF:
                                listView1.Items[iChannel].SubItems[(int)LIST_COLUMN.LISTCOL_LINESTATUS].Text = "Hook Off";
                                listView1.Items[iChannel].SubItems[(int)LIST_COLUMN.LISTCOL_CALLERID].Text = "";
                                listView1.Items[iChannel].SubItems[(int)LIST_COLUMN.LISTCOL_DIALED].Text = "";
                                break;

                            case (int)AD800_LINESTATUS.AD800LINE_HOOKON:
                                listView1.Items[iChannel].SubItems[(int)LIST_COLUMN.LISTCOL_LINESTATUS].Text = "Hook On";
                                break;

                            case (int)AD800_LINESTATUS.AD800LINE_RING:
                                listView1.Items[iChannel].SubItems[(int)LIST_COLUMN.LISTCOL_LINESTATUS].Text = "Ringing";
                                break;

                            default:
                                break;
                        }
                    }
                    break;

                case (int)AD800_STATUS.AD800_LINE_VOLTAGE:
                    {
                        string strText;
                        strText = string.Format("{0:D}V", lParam);
                        listView1.Items[iChannel].SubItems[(int)LIST_COLUMN.LISTCOL_VOLTAGE].Text = strText;
                    }
                    break;

                case (int)AD800_STATUS.AD800_LINE_CALLERID:
                    {
                        StringBuilder szBuff = new StringBuilder(128);
			            AD800_GetCallerId(iChannel, szBuff, 64);
                        listView1.Items[iChannel].SubItems[(int)LIST_COLUMN.LISTCOL_CALLERID].Text = szBuff.ToString();
                    }
                    break;


                case (int)AD800_STATUS.AD800_LINE_DTMF:
		            {
			            StringBuilder szBuff = new StringBuilder(128);
                        szBuff.Length = 0;
			            AD800_GetDialed(iChannel, szBuff, 64);
                        listView1.Items[iChannel].SubItems[(int)LIST_COLUMN.LISTCOL_DIALED].Text = szBuff.ToString();
		            }
		            break;


                case (int)AD800_STATUS.AD800_PLAY_FINISHED:
                    {
                        AD800_StopPlay(iChannel);

                        m_tagCHState[iChannel].bPlay = false;
                    }
                    break;

                case (int)AD800_STATUS.AD800_VOICETRIGGER:
                    {
                        if (0 == lParam.ToInt32())
                        {
                            listView1.Items[iChannel].SubItems[(int)LIST_COLUMN.LISTCOL_VOICETRIGGER].Text = "";
                         }

                        else if (1 == lParam.ToInt32())
                        {
                            listView1.Items[iChannel].SubItems[(int)LIST_COLUMN.LISTCOL_VOICETRIGGER].Text = "Voice";
                        }

                    }
                    break;

                case (int)AD800_STATUS.AD800_BUSYTONE:
                    {
                        listView1.Items[iChannel].SubItems[(int)LIST_COLUMN.LISTCOL_LINESTATUS].Text = "Busy Tone";
                    }
                    break;

                case (int)AD800_STATUS.AD800_DTMF_FINISHED:
                    {
                        m_tagCHState[iChannel].bDial = false;
                        button_Dial.Enabled = true;
                    }
                    break;

                case (int)AD800_STATUS.AD800_REC_DATA:
                    break;

                default:
                    break;

            }


        }


        protected override void DefWndProc(ref System.Windows.Forms.Message m)
        {
            switch (m.Msg)
            {
                case WM_AD800MSG:
                    OnDeviceMsg(m.WParam, m.LParam);
                    break;
                default:
                    base.DefWndProc(ref m);
                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            AD800_Free();
        }


        private void button_StartRec_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedIndices.Count < 1) return;

            StringBuilder szFile = new StringBuilder(256);
            DateTime dt;
            int iChannel = 0;

            for ( int i=0; i<listView1.SelectedIndices.Count; i++ )
            {
                iChannel = listView1.SelectedIndices[i];
                dt = DateTime.Now;
                szFile.Append(string.Format("{0:D}-", iChannel) + dt.ToString("yyMMddHHmmss", DateTimeFormatInfo.InvariantInfo) + ".wav");

                if (0 != AD800_StartFileRec(iChannel, szFile))
                {
                    m_tagCHState[iChannel].bRecord = true;

                    button_StartRec.Enabled = false;
                    button_StopRec.Enabled = true;
                }
            }

        }

        private void button_StopRec_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedIndices.Count < 1) return;

            int iChannel = 0;

            for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                iChannel = listView1.SelectedIndices[i];

                AD800_StopRec(iChannel);

                m_tagCHState[iChannel].bRecord = false;

                button_StartRec.Enabled = true;
                button_StopRec.Enabled = false;
            }

        }


        private void button_StartPlay_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedIndices.Count < 1) return;

            StringBuilder szFile = new StringBuilder(256);
             int iChannel = 0;

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Wav Files|*.wav";

            if (fileDialog.ShowDialog() != DialogResult.OK )
            {
                return;
            }

            szFile.Append(fileDialog.FileName);


            for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                iChannel = listView1.SelectedIndices[i];

                if (0 != AD800_PlayFile(iChannel, szFile))
                {
                    m_tagCHState[iChannel].bPlay = true;

                    button_StartPlay.Enabled = false;
                    button_StopPlay.Enabled = true;
                }
            }

        }

        private void button_StopPlay_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedIndices.Count < 1) return;

            int iChannel = 0;

            for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                iChannel = listView1.SelectedIndices[i];

                AD800_StopPlay(iChannel);

                m_tagCHState[iChannel].bPlay = false;

                button_StartPlay.Enabled = true;
                button_StopPlay.Enabled = false;
            }

        }

        private void button_LineBusy_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedIndices.Count < 1) return;

            int iChannel = 0;

            for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                iChannel = listView1.SelectedIndices[i];

                if (0 != AD800_PickUp(iChannel))
                {
                    m_tagCHState[iChannel].bLineBusy = true;

                    button_LineBusy.Enabled = false;
                    button_LineFree.Enabled = true;
                }

            }

        }

        private void button_LineFree_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedIndices.Count < 1) return;

            int iChannel = 0;

            for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                iChannel = listView1.SelectedIndices[i];

                if (0 != AD800_HangUp(iChannel))
                {
                    m_tagCHState[iChannel].bLineBusy = false;

                    button_LineBusy.Enabled = true;
                    button_LineFree.Enabled = false;
                }

            }

        }

        private void button_DisconnectPhone_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedIndices.Count < 1) return;

            int iChannel = 0;

            for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                iChannel = listView1.SelectedIndices[i];

                if (0 != AD800_DisconnectPhone(iChannel))
                {
                    m_tagCHState[iChannel].bDisPhone = true;

                    button_DisconnectPhone.Enabled = false;
                    button_ConnectPhone.Enabled = true;
                }

            }

        }

        private void button_ConnectPhone_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedIndices.Count < 1) return;

            int iChannel = 0;

            for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                iChannel = listView1.SelectedIndices[i];

                if (0 != AD800_ConnectPhone(iChannel))
                {
                    m_tagCHState[iChannel].bDisPhone = false;

                    button_DisconnectPhone.Enabled = true;
                    button_ConnectPhone.Enabled = false;
                }

            }

        }

        private void button_Dial_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedIndices.Count < 1) return;

            int iChannel = 0;
            StringBuilder szNum = new StringBuilder(128);
            string strNum = textBox_Num.Text;

            if (strNum.Length < 0 || strNum.Length > 32) return;

            szNum.Append(strNum);

            for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                iChannel = listView1.SelectedIndices[i];

                if (0 != AD800_SendDTMF(iChannel, szNum, (uint)strNum.Length))
                {
                    m_tagCHState[iChannel].bDial = false;

                    button_Dial.Enabled = false;
                }

            }

        }

        private void comboBox_RecVol_Click(object sender, EventArgs e)
        {
            m_bClickRecVol = true;
        }

        private void comboBox_RecVol_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ( !m_bClickRecVol )  return;

            if (listView1.SelectedIndices.Count < 1) return;

            int iChannel = 0;
            int iVol = comboBox_RecVol.SelectedIndex;

            for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                iChannel = listView1.SelectedIndices[i];

                AD800_SetRecVolume(iChannel, iVol+1);
            }

            m_bClickRecVol = false;
        }

        private void comboBox_PlayVol_Click(object sender, EventArgs e)
        {
            m_bClickPlayVol = true;
        }

        private void comboBox_PlayVol_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!m_bClickPlayVol) return;
            if (listView1.SelectedIndices.Count < 1) return;

            int iChannel = 0;
            int iVol = comboBox_PlayVol.SelectedIndex;

            for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                iChannel = listView1.SelectedIndices[i];

                AD800_SetPlaybackVolume(iChannel, iVol+1);
            }

            m_bClickPlayVol = false;
        }

        private void checkBox_VoiceTrigger_CheckedChanged(object sender, EventArgs e)
        {

            if (listView1.SelectedIndices.Count < 1) return;

            int iChannel = 0;
            bool bCheck = checkBox_VoiceTrigger.Checked;

            for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                iChannel = listView1.SelectedIndices[i];

                m_tagCHState[iChannel].bVoiceTrigger = bCheck;

                if (bCheck)
                {
                    AD800_VoiceTrigger(iChannel);
                }

                else
                {
                    AD800_StopVoiceTrigger(iChannel);
                }
            }

        }

        private void button_Set_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedIndices.Count < 1) return;

            int iChannel = 0;
            int iVoiceLevel = comboBox_VoiceLevel.SelectedIndex;
            int iSilenceLevel = comboBox_SilenceLevel.SelectedIndex;
            int iVoiceTime = Convert.ToInt32(textBox_TimeDetVoice.Text);
            int iSilenceTime = Convert.ToInt32(textBox_TimeDetSilence.Text);

            for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                iChannel = listView1.SelectedIndices[i];

                AD800_SetVoiceThreshold(iChannel, iVoiceTime, iVoiceLevel + 1);
                AD800_SetSilenceThreshold(iChannel, iSilenceTime, iSilenceLevel + 1);
            }

        }

        private void checkBox_Chinese_CheckedChanged(object sender, EventArgs e)
        {
            bool bEng = !checkBox_Chinese.Checked;
            SetLanguage(bEng);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                ChangeCtrlStatus(listView1.SelectedIndices[0]);
            }

        }



    }
}