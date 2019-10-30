using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RobotControl
{

    public partial class Form1 : Form
        
    {
        ArduinoConnectSerial RobotArm;
        public Form1()
        {
            InitializeComponent();
            btnDisconnect.Visible = false;
            RobotArm = new ArduinoConnectSerial(btnConnect, 
                                                btnDisconnect,
                                                cBoxCOMPORT,
                                                turnLeft,
                                                turnRight,
                                                btn_dose,
                                                btn_dose2,
                                                btn_takestraw,
                                                btnForward,
                                                btnBackward,
                                                trackBarGeschwindigkeit,
                                                btn_grippingPosition,
                                                btn_up,
                                                btn_down,
                                                btn_linearctrl,
                                                btn_standardmvmnts,
                                                btn_stopmvmnt,
                                                panel_standardmvmnts,
                                                panel_linearmovement,
                                                panel_stopmvmnt,
                                                btn_back01,
                                                btn_back02
                                                );
        }

        
 
       private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);
        }

        private void btn_standardmvmnts_Click(object sender, EventArgs e)
        {
            panel_linearmovement.Visible = false;
            this.panel_standardmvmnts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_standardmvmnts.BringToFront();
            panel_standardmvmnts.Visible = true;
            btn_standardmvmnts.Visible = false;
        }

        private void btn_linearctrl_Click(object sender, EventArgs e)
        {
            panel_standardmvmnts.Visible = false;
            this.panel_linearmovement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_linearmovement.BringToFront();
            panel_linearmovement.Visible = true;
            btn_linearctrl.Visible = false;
            panel_stopmvmnt.BringToFront();
        }



        private void btn_back01_Click(object sender, EventArgs e)
        {
            panel_standardmvmnts.Visible = false;
            btn_standardmvmnts.Visible = true;
        }

        private void btn_back02_Click(object sender, EventArgs e)
        {
            panel_linearmovement.Visible = false;
            btn_linearctrl.Visible = true;
        }

        private void btn_stopmvmnt_Click(object sender, EventArgs e)
        {

        }
    }
}
