using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

struct Battery_Parameter
{
    public float Voltage;
    public float Current;
    public float SOC;
    public float Temperature;
    public float Capacity;
    public float SOH;
    public float Cycle;
}

namespace Balancing_Project
{
    public partial class Form1 : Form
    {
        float[] VBATT = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

        float[] delta_VBATT = new float[15];

        Battery_Parameter Battery = new Battery_Parameter();


        string data_terima = " ";
        
        string data_buffer;

        public bool flag_data_terima=true, ReceiveComplete=false;

        public float AH_Consumption_D, AH_Consumption_C;

        public int DayLast;

        public double[] dataval_V = new double[20001];
        public double[] dataval_I = new double[20001];
        public double[] dataval_T = new double[20001];

        public Form1()
        {
            InitializeComponent();

            label_jam.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            label_tanggal.Text = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            for(int i=0;i<15;i++)
            {
                VBATT[i]=3.98f;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string DataReceived;
                DataReceived = serialPort1.ReadExisting();
                
                if(DataReceived == "#RUN")
                {
                    RunStopButton.Checked = true;
                    RunStopButton.Text = "STOP";
                }
                else if (DataReceived == "#STOP")
                {
                    RunStopButton.Checked = false;
                    RunStopButton.Text = "RUN";
                }
            }
        }


        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            /*
            if (flag_data_terima == true)
            {

                try
                {
                    data_terima = serialPort1.ReadExisting();
                    flag_data_terima = false;
                    this.Invoke(new EventHandler(ShowData));
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            }
             */ 
        }

        private void ShowData(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            Connect_btn.Enabled = true;
            Disconnect_btn.Enabled = false;
        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();
                Connect_btn.Enabled = false;
                Disconnect_btn.Enabled = true;
                led_blue.Value = true;
             }
             catch (Exception ex)
             {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connect_btn.Enabled = true;
                Disconnect_btn.Enabled = false;
                led_blue.Value = false;
             }

             try
             {
                serialPort1.Write("*1#\n");
             }
             catch (Exception x)
             {
                MessageBox.Show(x.Message.ToString());
             }
             
             string datawrite = "*W" + PIP_in.Value.ToString() + "&" + PEEP_in.Value.ToString() + "&" + VTe_in.Value.ToString() + "&" + RR_in.Value.ToString() + "&" + RRr_in.Value.ToString() + "#\n";

             try
             {
                serialPort1.Write(datawrite);
             }
             catch (Exception x)
             {
                MessageBox.Show(x.Message.ToString());
             }   
        }

        private void Disconnect_btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            try
            {
                serialPort1.Write("*0#\n");                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
            
            try
            {
                serialPort1.Close();
                Connect_btn.Enabled = true;
                Disconnect_btn.Enabled = false;
                led_blue.Value = false;
                RunStopButton.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connect_btn.Enabled = false;
                Disconnect_btn.Enabled = true;
                led_blue.Value = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("*0#\n");
                }
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }

        private void label61_Click(object sender, EventArgs e)
        {

        }


        private void CloseSerialOnExit()
        {

            try
            {

                serialPort1.Close(); //close the serial port

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); //catch any serial port closing error messages

            }

            this.Invoke(new EventHandler(NowClose)); //now close back in the main thread

        }

        private void NowClose(object sender, EventArgs e)
        {

            this.Close(); //now close the form

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }


        private void timer_logger_Tick(object sender, EventArgs e)
        {
            int DayCurrent;

            label_jam.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            label_tanggal.Text = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();

            string headerTeks = "Tanggal;Waktu;Tegangan;Arus;SOC;Temperature;VCell_Max;VCell_Min;Max_Del_V;Avg_Del_V" + Environment.NewLine;

            string logText = label_tanggal.Text+";"+ Environment.NewLine;

            string namaFile = label_tanggal.Text;
            DayCurrent = DateTime.Now.Day;

            if (DayCurrent != DayLast)
            {
                writeCSV(namaFile, headerTeks);
            }
            writeCSV(namaFile, logText);
            DayLast = DayCurrent;

           
             
        }

        private void writeCSV(string date, string teks)
        {
            string path = date + ".csv";
            string cureFIle = @path;
            if (!System.IO.File.Exists(cureFIle))//if file doesn't exist
            {
                System.IO.File.Create(cureFIle).Close();
            }

            try
            {
                System.IO.File.AppendAllText(cureFIle, teks);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + Environment.NewLine + "Can't access" + cureFIle + Environment.NewLine
                               + "This file maybe used by another application.", "Write File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer_Plotting_Tick(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= 20000; i++)
            {
                dataval_V[i - 1] = dataval_V[i];
                dataval_I[i - 1] = dataval_I[i];
                dataval_T[i - 1] = dataval_T[i];

            }

            dataval_V[20000] = Battery.Voltage;
            dataval_I[20000] = Battery.Current;
            dataval_T[20000] = Battery.Temperature;

            waveformGraph_Voltage.PlotY(dataval_V);
            //waveformGraph_Voltage.PlotYMultiple(dataval_V, dataval_V);
            waveformGraph_Current.PlotY(dataval_I);
            waveformGraph_Temperature.PlotY(dataval_T);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_tanggal_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_SettingParam_Click(object sender, EventArgs e)
        {       
            string datawrite = "*W" + PIP_in.Value.ToString() + "&" + PEEP_in.Value.ToString() + "&" + VTe_in.Value.ToString() + "&" + RR_in.Value.ToString() + "&" + RRr_in.Value.ToString() + "#\n";

            if(RunStopButton.Checked==true)
            {
                string message = "Device is running.";
                string title = "Warning";
                MessageBox.Show(message, title); 
            }
            else if (RunStopButton.Checked == false)
            {
                if (TuningSwitch.Checked == true)
                {
                    if (serialPort1.IsOpen)
                    {
                        try
                        {
                            serialPort1.Write(datawrite);
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message.ToString());
                        }
                    }
                }
                else if (TuningSwitch.Checked == false)
                {
                    string message = "Tuning control is disabled. Do you want to turn it on?";
                    string title = "Tuning Control";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        TuningSwitch.Checked = true;
                    }
                }
            }
            
        }

        private void led_green_StateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datawrite = "*W*P\n";

            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write(datawrite);

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string datawrite = "*W*Q\n";

            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write(datawrite);

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (RunStopButton.Checked == true)
            {
                string datawrite = "*W*R\n";
                try
                {
                    serialPort1.Write(datawrite);
                    RunStopButton.Text = "STOP";
                }
                catch (Exception x)
                {
                    RunStopButton.Checked = false;
                    RunStopButton.Text = "RUN";
                    MessageBox.Show(x.Message.ToString());
                }
            }
            else if (RunStopButton.Checked == false)
            {
                string datawrite = "*W*S\n";
                try
                {
                    RunStopButton.Text = "RUN";
                    serialPort1.Write(datawrite);
                }
                catch (Exception x)
                {
                    RunStopButton.Checked = true;
                    RunStopButton.Text = "STOP";
                    MessageBox.Show(x.Message.ToString());
                }
            }
        }

        private void TuningSwitch_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false; radioButton2.Checked = false; radioButton3.Checked = false;
            if (TuningSwitch.Checked == false)
            {
                if (serialPort1.IsOpen)
                {
                    try
                    {
                        string datawrite = "*W*T\n";
                        serialPort1.Write(datawrite);
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message.ToString());
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (TuningSwitch.Checked == true)
                {
                    string datawrite = "*W*M\n";
                    if (serialPort1.IsOpen)
                    {
                        try
                        {
                            serialPort1.Write(datawrite);
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message.ToString());
                        }
                    }
                }
                else if (TuningSwitch.Checked == false)
                {
                    string message = "Tuning control is disabled. Do you want to turn it on?";
                    string title = "Tuning Control";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        TuningSwitch.Checked = true;
                        radioButton1.Checked = false;
                    }
                    else
                    {
                        radioButton1.Checked = false;
                    }
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (TuningSwitch.Checked == true)
                {
                    string datawrite = "*W*N\n";
                    if (serialPort1.IsOpen)
                    {
                        try
                        {
                            serialPort1.Write(datawrite);
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message.ToString());
                        }
                    }
                }
                else if (TuningSwitch.Checked == false)
                {
                    string message = "Tuning control is disabled. Do you want to turn it on?";
                    string title = "Tuning Control";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        TuningSwitch.Checked = true;
                        radioButton2.Checked = false;
                    }
                    else
                    {
                        radioButton2.Checked = false;
                    }
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                if (TuningSwitch.Checked == true)
                {
                    string datawrite = "*W*O\n";
                    if (serialPort1.IsOpen)
                    {
                        try
                        {
                            serialPort1.Write(datawrite);
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message.ToString());
                        }
                    }
                }
                else if (TuningSwitch.Checked == false)
                {
                    string message = "Tuning control is disabled. Do you want to turn it on?";
                    string title = "Tuning Control";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        TuningSwitch.Checked = true;
                        radioButton3.Checked = false;
                    }
                    else
                    {
                        radioButton3.Checked = false;
                    }
                }
            }
        } 

        private void RR_in_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PIP_in_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PEEP_in_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RRr_in_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void VTe_in_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {

        }
    }
}
