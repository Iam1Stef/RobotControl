using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace RobotControl
{
    class ArduinoConnectSerial
    {
        private SerialPort verbindung;
        private Button ButtonConnect;
        private Button ButtonDisconnect;
        private Button ButtonMoveLeft;
        private Button ButtonMoveRight;
        private Button ButtonTrinken;
        private Button ButtonDoseAbsetzen;
        private Button ButtonStrohhalmNehmen;
        private Button ButtonMoveForward;
        private Button ButtonMoveBackward;
        private ComboBox ComboBoxPort;
        private TrackBar TrackBarGeschwindigkeit;
        private Button ButtonGreifPosi;
        private Button ButtonRauf;
        private Button ButtonRunter;
        private Button ButtonFeinsteuerung;
        private Button ButtonStandardFunktionen;
        private Button ButtonStopp;
        private Panel PanelStandard;
        private Panel PanelFeinBewegung;
        private Panel PanelStoppButton;
        private Button ButtonBack01;
        private Button ButtonBack02;


        Timer timer1 = new Timer(); //Timer f. freie Bewegungen wird instanziert
        private string message; //Hilfsvariable f. freie Bewegungen


        public ArduinoConnectSerial(object _ButtonConnect,
                                    object _ButtonDisconnect,
                                    object _ComboBoxPort,
                                    object _ButtonMoveLeft,
                                    object _ButtonMoveRight,
                                    object _btn_dose,
                                    object _btn_dose2,
                                    object _btn_takestraw,
                                    object _btnMoveForward,
                                    object _btnMoveBackward,
                                    object _trackBarGeschwindigkeit,
                                    object _btn_grippingPosi,
                                    object _btn_up,
                                    object _btn_down,
                                    object _btnLinearCtrl,
                                    object _btnStandardMovements,
                                    object _btnStopMovement,
                                    object _panelStandardMvmnts,
                                    object _panelLinMvmnt,
                                    object _panelStopButton,
                                    object _buttonBack01,
                                    object _buttonBack02
                                    )
        {
            ButtonConnect = (Button)_ButtonConnect;
            ButtonConnect.Click += new EventHandler(BtnConnect_Click);
            ButtonDisconnect = (Button)_ButtonDisconnect;
            ButtonDisconnect.Click += new EventHandler(BtnDisconnect_Click);
            ButtonMoveLeft = (Button)_ButtonMoveLeft;
            ButtonMoveLeft.Click += new EventHandler(TurnLeft_Click);
            ButtonMoveRight = (Button)_ButtonMoveRight;
            ButtonMoveRight.Click += new EventHandler(TurnRight_Click);
            ComboBoxPort = (ComboBox)_ComboBoxPort;
            ButtonTrinken = (Button)_btn_dose;
            ButtonTrinken.Click += new EventHandler(Btn_dose_Click);
            ButtonDoseAbsetzen = (Button)_btn_dose2;
            ButtonDoseAbsetzen.Click += new EventHandler(Btn_dose2_Click);
            ButtonStrohhalmNehmen = (Button)_btn_takestraw;
            ButtonStrohhalmNehmen.Click += new EventHandler(Btn_takestraw_Click);
            ButtonMoveForward = (Button)_btnMoveForward;
            ButtonMoveForward.Click += new EventHandler(BtnForward_Click);
            ButtonMoveBackward = (Button)_btnMoveBackward;
            ButtonMoveBackward.Click += new EventHandler(BtnBackward_Click);
            TrackBarGeschwindigkeit = (TrackBar)_trackBarGeschwindigkeit;
            TrackBarGeschwindigkeit.Scroll += new EventHandler(TrackBarGeschwindigkeit_Scroll);
            ButtonGreifPosi = (Button)_btn_grippingPosi;
            ButtonGreifPosi.Click += new EventHandler(btn_grippingPosition_Click);
            ButtonRauf = (Button)_btn_up;
            ButtonRauf.Click += new EventHandler(btn_up_Click);
            ButtonRunter = (Button)_btn_down;
            ButtonRunter.Click += new EventHandler(btn_down_Click);
            ButtonFeinsteuerung = (Button)_btnLinearCtrl;
            ButtonFeinsteuerung.Click += new EventHandler(btn_linearctrl_Click);
            ButtonStandardFunktionen = (Button)_btnStandardMovements;
            ButtonStandardFunktionen.Click += new EventHandler(btn_standardmvmnts_Click);
            ButtonStopp = (Button)_btnStopMovement;
            ButtonStopp.Click += new EventHandler(btn_stopmvmnt_Click);
            PanelStandard = (Panel)_panelStandardMvmnts;
            PanelFeinBewegung = (Panel)_panelLinMvmnt;
            PanelStoppButton = (Panel)_panelStopButton;

        }

        


        private void btn_stopmvmnt_Click(object sender, EventArgs e)
        {
            SendMessage("STOP");
        }


        private void btn_standardmvmnts_Click(object sender, EventArgs e)
        {
        }

        private void btn_linearctrl_Click(object sender, EventArgs e)
        {
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            message="nachvorne";
            SendMessage(message);

            /*timer1.Interval = TrackBarGeschwindigkeit.Value; // in milliseconds
            if (timer1.Enabled) /*falls timer läuft, timer wird beendet, Event wird gekillt.
                                  Ansonsten doppelt so schnell nach restart
            {
                timer1.Tick -= new EventHandler(Timer1_Tick);
                timer1.Stop();
            }
            else //Timer wird gestartet, Event erstellt.
            {
                timer1.Tick += new EventHandler(Timer1_Tick);
                timer1.Start();
            }*/
        }

        private void BtnBackward_Click(object sender, EventArgs e)
        {
            message="nachhinten";
            SendMessage(message);

            /*timer1.Interval = TrackBarGeschwindigkeit.Value; // in milliseconds
            if (timer1.Enabled) /*falls timer läuft, timer wird beendet, Event wird gekillt.
                                  Ansonsten doppelt so schnell nach restart
            {
                timer1.Tick -= new EventHandler(Timer1_Tick);
                timer1.Stop();
            }
            else //Timer wird gestartet, Event erstellt.
            {
                timer1.Tick += new EventHandler(Timer1_Tick);
                timer1.Start();
            }*/
        }

        private void Btn_takestraw_Click(object sender, EventArgs e)
        {
            SendMessage("strohhalm");
        }

        private void btn_grippingPosition_Click(object sender, EventArgs e)
        {
            SendMessage("greifposition");
        }

        private void Btn_dose2_Click(object sender, EventArgs e)
        {
            SendMessage("doseabsetzen");
        }

        private void Btn_dose_Click(object sender, EventArgs e)
        {
            SendMessage("dosenehmen");
        }

        private void TrackBarGeschwindigkeit_Scroll(object sender, EventArgs e)
        {
           // timer1.Interval = TrackBarGeschwindigkeit.Value;            
        }

        private void Timer1_Tick(object sender, EventArgs e) //bei jedem Tick wird SendMessage ausgeführt.

        {
            
            SendMessage(message);
        }

        private void TurnRight_Click(object sender, EventArgs e)
        {
            message = "moveRight";
            SendMessage(message);
            

            /*timer1.Interval = TrackBarGeschwindigkeit.Value; // in milliseconds
            if (timer1.Enabled) /*falls timer läuft, timer wird beendet, Event wird gekillt.
                                  Ansonsten doppelt so schnell nach restart
            {
                timer1.Tick -= new EventHandler(Timer1_Tick);
                timer1.Stop();
            }
            else //Timer wird gestartet, Event erstellt.
            {
                timer1.Tick += new EventHandler(Timer1_Tick);
                timer1.Start();
            }*/
            
        }

        

        private void TurnLeft_Click(object sender, EventArgs e)
        {
            message = "moveLeft";
            SendMessage(message);

            /*timer1.Interval = TrackBarGeschwindigkeit.Value; // in milliseconds
            if (timer1.Enabled) /*falls timer läuft, timer wird beendet, Event wird gekillt.
                                  Ansonsten doppelt so schnell nach restart
            {
                timer1.Tick -= new EventHandler(Timer1_Tick);
                timer1.Stop();
            }
            else //Timer wird gestartet, Event erstellt.
            {
                timer1.Tick += new EventHandler(Timer1_Tick);
                timer1.Start();
            }*/
        }


        private void btn_up_Click(object sender, EventArgs e)
        {
            message="nachoben";
            SendMessage(message);
            /*
            timer1.Interval = TrackBarGeschwindigkeit.Value; // in milliseconds
            if (timer1.Enabled) /*falls timer läuft, timer wird beendet, Event wird gekillt.
                                  Ansonsten doppelt so schnell nach restart
            {
                timer1.Tick -= new EventHandler(Timer1_Tick);
                timer1.Stop();
            }
            else //Timer wird gestartet, Event erstellt.
            {
                timer1.Tick += new EventHandler(Timer1_Tick);
                timer1.Start();
            }*/
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            message="nachunten";
            SendMessage(message);
            /*
            timer1.Interval = TrackBarGeschwindigkeit.Value; // in milliseconds
            if (timer1.Enabled) /*falls timer läuft, timer wird beendet, Event wird gekillt.
                                  Ansonsten doppelt so schnell nach restart
            {
                timer1.Tick -= new EventHandler(Timer1_Tick);
                timer1.Stop();
            }
            else //Timer wird gestartet, Event erstellt.
            {
                timer1.Tick += new EventHandler(Timer1_Tick);
                timer1.Start();
            }*/
        }



        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
            ButtonConnect.Visible = true;
            ButtonDisconnect.Visible = false;
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {

            try
            {
                Connect(ComboBoxPort.Text);
                ButtonConnect.Visible = false;
                ButtonFeinsteuerung.Visible = true;
                ButtonStandardFunktionen.Visible = true;
                ButtonDisconnect.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
        public void SendMessage(string message)
        {
            if (verbindung != null && verbindung.IsOpen)
            {
                verbindung.WriteLine(message);
            }
            else
            {
                MessageBox.Show("NICHT VERBUNDEN");
                
            }
        }
        public void Connect(string port)
        {
            verbindung = new SerialPort(port, 9600)
            {
                NewLine = "\n"
            };
            verbindung.Open();
            SendMessage("verbunden");
        }
        public void Disconnect()
        {
            if (verbindung != null && verbindung.IsOpen)
            {
                SendMessage("trennen");
                verbindung.Close();
            }
        }
    }
}
