namespace RobotControl
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.turnRight = new System.Windows.Forms.Button();
            this.turnLeft = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btn_dose2 = new System.Windows.Forms.Button();
            this.btn_takestraw = new System.Windows.Forms.Button();
            this.btn_dose = new System.Windows.Forms.Button();
            this.trackBarGeschwindigkeit = new System.Windows.Forms.TrackBar();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btn_grippingPosition = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_standardmvmnts = new System.Windows.Forms.Button();
            this.btn_linearctrl = new System.Windows.Forms.Button();
            this.panel_linearmovement = new System.Windows.Forms.Panel();
            this.btn_back02 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_standardmvmnts = new System.Windows.Forms.Panel();
            this.btn_back01 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_opencan = new System.Windows.Forms.Button();
            this.panel_stopmvmnt = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_stopmvmnt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGeschwindigkeit)).BeginInit();
            this.panel_linearmovement.SuspendLayout();
            this.panel_standardmvmnts.SuspendLayout();
            this.panel_stopmvmnt.SuspendLayout();
            this.SuspendLayout();
            // 
            // turnRight
            // 
            this.turnRight.Location = new System.Drawing.Point(360, 150);
            this.turnRight.Name = "turnRight";
            this.turnRight.Size = new System.Drawing.Size(107, 52);
            this.turnRight.TabIndex = 0;
            this.turnRight.Text = "Rechtsdrehung";
            this.turnRight.UseVisualStyleBackColor = true;
            // 
            // turnLeft
            // 
            this.turnLeft.Location = new System.Drawing.Point(107, 150);
            this.turnLeft.Name = "turnLeft";
            this.turnLeft.Size = new System.Drawing.Size(108, 57);
            this.turnLeft.TabIndex = 1;
            this.turnLeft.Text = "Linksdrehung";
            this.turnLeft.UseVisualStyleBackColor = true;
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(141, 12);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(125, 21);
            this.cBoxCOMPORT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM PORT";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(161, 57);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnConnect.Size = new System.Drawing.Size(130, 26);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Verbinden";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(161, 103);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDisconnect.Size = new System.Drawing.Size(130, 53);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Trennen";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Visible = false;
            // 
            // btn_dose2
            // 
            this.btn_dose2.Location = new System.Drawing.Point(294, 45);
            this.btn_dose2.Name = "btn_dose2";
            this.btn_dose2.Size = new System.Drawing.Size(118, 91);
            this.btn_dose2.TabIndex = 11;
            this.btn_dose2.Text = "Dose absetzen";
            this.btn_dose2.UseVisualStyleBackColor = true;
            // 
            // btn_takestraw
            // 
            this.btn_takestraw.Location = new System.Drawing.Point(41, 162);
            this.btn_takestraw.Name = "btn_takestraw";
            this.btn_takestraw.Size = new System.Drawing.Size(113, 80);
            this.btn_takestraw.TabIndex = 10;
            this.btn_takestraw.Text = "Strohhalm";
            this.btn_takestraw.UseVisualStyleBackColor = true;
            // 
            // btn_dose
            // 
            this.btn_dose.Location = new System.Drawing.Point(160, 45);
            this.btn_dose.Name = "btn_dose";
            this.btn_dose.Size = new System.Drawing.Size(128, 91);
            this.btn_dose.TabIndex = 9;
            this.btn_dose.Text = "Trinken";
            this.btn_dose.UseVisualStyleBackColor = true;
            // 
            // trackBarGeschwindigkeit
            // 
            this.trackBarGeschwindigkeit.Location = new System.Drawing.Point(24, 348);
            this.trackBarGeschwindigkeit.Maximum = 250;
            this.trackBarGeschwindigkeit.Minimum = 20;
            this.trackBarGeschwindigkeit.Name = "trackBarGeschwindigkeit";
            this.trackBarGeschwindigkeit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarGeschwindigkeit.RightToLeftLayout = true;
            this.trackBarGeschwindigkeit.Size = new System.Drawing.Size(776, 45);
            this.trackBarGeschwindigkeit.TabIndex = 12;
            this.trackBarGeschwindigkeit.TickFrequency = 100;
            this.trackBarGeschwindigkeit.Value = 135;
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(220, 97);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(130, 48);
            this.btnForward.TabIndex = 13;
            this.btnForward.Text = "Vorwärts";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(220, 217);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(130, 47);
            this.btnBackward.TabIndex = 14;
            this.btnBackward.Text = "Rückwärts";
            this.btnBackward.UseVisualStyleBackColor = true;
            // 
            // btn_grippingPosition
            // 
            this.btn_grippingPosition.Location = new System.Drawing.Point(7, 134);
            this.btn_grippingPosition.Name = "btn_grippingPosition";
            this.btn_grippingPosition.Size = new System.Drawing.Size(85, 73);
            this.btn_grippingPosition.TabIndex = 15;
            this.btn_grippingPosition.Text = "Greifposi";
            this.btn_grippingPosition.UseVisualStyleBackColor = true;
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(518, 73);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(74, 60);
            this.btn_up.TabIndex = 16;
            this.btn_up.Text = "Nach oben";
            this.btn_up.UseVisualStyleBackColor = true;
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(518, 183);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(74, 60);
            this.btn_down.TabIndex = 17;
            this.btn_down.Text = "Nach unten";
            this.btn_down.UseVisualStyleBackColor = true;
            // 
            // btn_standardmvmnts
            // 
            this.btn_standardmvmnts.Location = new System.Drawing.Point(395, 127);
            this.btn_standardmvmnts.Name = "btn_standardmvmnts";
            this.btn_standardmvmnts.Size = new System.Drawing.Size(150, 88);
            this.btn_standardmvmnts.TabIndex = 20;
            this.btn_standardmvmnts.Text = "Standardfunktionen";
            this.btn_standardmvmnts.UseVisualStyleBackColor = true;
            this.btn_standardmvmnts.Visible = false;
            this.btn_standardmvmnts.Click += new System.EventHandler(this.btn_standardmvmnts_Click);
            // 
            // btn_linearctrl
            // 
            this.btn_linearctrl.Location = new System.Drawing.Point(588, 127);
            this.btn_linearctrl.Name = "btn_linearctrl";
            this.btn_linearctrl.Size = new System.Drawing.Size(150, 88);
            this.btn_linearctrl.TabIndex = 21;
            this.btn_linearctrl.Text = "Feinsteuerung";
            this.btn_linearctrl.UseVisualStyleBackColor = true;
            this.btn_linearctrl.Visible = false;
            this.btn_linearctrl.Click += new System.EventHandler(this.btn_linearctrl_Click);
            // 
            // panel_linearmovement
            // 
            this.panel_linearmovement.Controls.Add(this.btn_back02);
            this.panel_linearmovement.Controls.Add(this.label2);
            this.panel_linearmovement.Controls.Add(this.btnForward);
            this.panel_linearmovement.Controls.Add(this.turnLeft);
            this.panel_linearmovement.Controls.Add(this.trackBarGeschwindigkeit);
            this.panel_linearmovement.Controls.Add(this.btn_down);
            this.panel_linearmovement.Controls.Add(this.turnRight);
            this.panel_linearmovement.Controls.Add(this.btn_up);
            this.panel_linearmovement.Controls.Add(this.btnBackward);
            this.panel_linearmovement.Controls.Add(this.btn_grippingPosition);
            this.panel_linearmovement.Location = new System.Drawing.Point(65, 249);
            this.panel_linearmovement.Name = "panel_linearmovement";
            this.panel_linearmovement.Size = new System.Drawing.Size(885, 396);
            this.panel_linearmovement.TabIndex = 22;
            this.panel_linearmovement.Visible = false;
            // 
            // btn_back02
            // 
            this.btn_back02.Location = new System.Drawing.Point(693, 278);
            this.btn_back02.Name = "btn_back02";
            this.btn_back02.Size = new System.Drawing.Size(133, 67);
            this.btn_back02.TabIndex = 18;
            this.btn_back02.Text = "Zurück";
            this.btn_back02.UseVisualStyleBackColor = true;
            this.btn_back02.Click += new System.EventHandler(this.btn_back02_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Feinsteuerung";
            // 
            // panel_standardmvmnts
            // 
            this.panel_standardmvmnts.Controls.Add(this.btn_back01);
            this.panel_standardmvmnts.Controls.Add(this.label3);
            this.panel_standardmvmnts.Controls.Add(this.btn_opencan);
            this.panel_standardmvmnts.Controls.Add(this.btn_dose2);
            this.panel_standardmvmnts.Controls.Add(this.btn_takestraw);
            this.panel_standardmvmnts.Controls.Add(this.btn_dose);
            this.panel_standardmvmnts.Location = new System.Drawing.Point(730, 39);
            this.panel_standardmvmnts.Name = "panel_standardmvmnts";
            this.panel_standardmvmnts.Size = new System.Drawing.Size(197, 44);
            this.panel_standardmvmnts.TabIndex = 23;
            this.panel_standardmvmnts.Visible = false;
            // 
            // btn_back01
            // 
            this.btn_back01.Location = new System.Drawing.Point(642, 345);
            this.btn_back01.Name = "btn_back01";
            this.btn_back01.Size = new System.Drawing.Size(133, 67);
            this.btn_back01.TabIndex = 17;
            this.btn_back01.Text = "Zurück";
            this.btn_back01.UseVisualStyleBackColor = true;
            this.btn_back01.Click += new System.EventHandler(this.btn_back01_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Standardfunktionen";
            // 
            // btn_opencan
            // 
            this.btn_opencan.Location = new System.Drawing.Point(35, 45);
            this.btn_opencan.Name = "btn_opencan";
            this.btn_opencan.Size = new System.Drawing.Size(119, 91);
            this.btn_opencan.TabIndex = 12;
            this.btn_opencan.Text = "Dose öffnen";
            this.btn_opencan.UseVisualStyleBackColor = true;
            // 
            // panel_stopmvmnt
            // 
            this.panel_stopmvmnt.Controls.Add(this.label4);
            this.panel_stopmvmnt.Controls.Add(this.btn_stopmvmnt);
            this.panel_stopmvmnt.Location = new System.Drawing.Point(989, 157);
            this.panel_stopmvmnt.Name = "panel_stopmvmnt";
            this.panel_stopmvmnt.Size = new System.Drawing.Size(377, 270);
            this.panel_stopmvmnt.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "STOPP-Button";
            this.label4.Visible = false;
            // 
            // btn_stopmvmnt
            // 
            this.btn_stopmvmnt.Location = new System.Drawing.Point(85, 59);
            this.btn_stopmvmnt.Name = "btn_stopmvmnt";
            this.btn_stopmvmnt.Size = new System.Drawing.Size(241, 170);
            this.btn_stopmvmnt.TabIndex = 0;
            this.btn_stopmvmnt.Text = "STOPP";
            this.btn_stopmvmnt.UseVisualStyleBackColor = true;
            this.btn_stopmvmnt.Click += new System.EventHandler(this.btn_stopmvmnt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 632);
            this.Controls.Add(this.panel_stopmvmnt);
            this.Controls.Add(this.panel_standardmvmnts);
            this.Controls.Add(this.panel_linearmovement);
            this.Controls.Add(this.btn_linearctrl);
            this.Controls.Add(this.btn_standardmvmnts);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxCOMPORT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGeschwindigkeit)).EndInit();
            this.panel_linearmovement.ResumeLayout(false);
            this.panel_linearmovement.PerformLayout();
            this.panel_standardmvmnts.ResumeLayout(false);
            this.panel_standardmvmnts.PerformLayout();
            this.panel_stopmvmnt.ResumeLayout(false);
            this.panel_stopmvmnt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button turnRight;
        private System.Windows.Forms.Button turnLeft;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btn_dose2;
        private System.Windows.Forms.Button btn_takestraw;
        private System.Windows.Forms.Button btn_dose;
        private System.Windows.Forms.TrackBar trackBarGeschwindigkeit;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btn_grippingPosition;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_standardmvmnts;
        private System.Windows.Forms.Button btn_linearctrl;
        private System.Windows.Forms.Panel panel_linearmovement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_standardmvmnts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_opencan;
        private System.Windows.Forms.Button btn_back02;
        private System.Windows.Forms.Button btn_back01;
        private System.Windows.Forms.Panel panel_stopmvmnt;
        private System.Windows.Forms.Button btn_stopmvmnt;
        private System.Windows.Forms.Label label4;
    }
}

