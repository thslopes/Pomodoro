using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class FrmPomodoro : Form
    {
        delegate void SetTextCallback(string text);

        private System.Threading.Timer descansar;
        private System.Threading.Timer revisar;
        private System.Threading.Timer trabalhar;
        private bool running = false;
        private NotifyIcon notifyIcon = new NotifyIcon();
        private enum minutos { 
            Vinte =         1000 * 20 * 60, 
            VinteCinco =    1000 * 25 * 60, 
            Trinta =        1000 * 30 * 60 
        }

        public FrmPomodoro()
        {
            InitializeComponent();
        }

        private void FrmPomodoro_Load(object sender, EventArgs e)
        {
            IniciarTrabalho();
            notifyIcon.Icon = SystemIcons.Application;
        }

        private void IniciarTrabalho()
        {
            revisar = new System.Threading.Timer(MostrarRevisar, this, (int)minutos.Vinte, (int)minutos.Trinta);
            descansar = new System.Threading.Timer(MostrarDescansar, this, (int)minutos.VinteCinco, (int)minutos.Trinta);
            trabalhar = new System.Threading.Timer(MostrarTrabalhar, this, (int)minutos.Trinta, (int)minutos.Trinta);
            SetText("Trabalhar");
            running = true;
        }

        private void Zueira()
        {
            revisar.Dispose();
            descansar.Dispose();
            trabalhar.Dispose();
            SetText("Zuando");
            running = false;
        }

        private void MostrarTrabalhar(object state)
        {
            SetText("Trabalhar");
        }

        private void MostrarRevisar(object state)
        {
            SetText("Revisar");
        }

        private void MostrarDescansar(object state)
        {
            SetText("Descansar");
        }

        private void SetText(string text)
        {
            if (this.Label.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Label.Text = text;

                this.TopMost = true;
                this.Focus();
                this.BringToFront();

                notifyIcon.Visible = true;

                if (text != null)
                {
                    notifyIcon.BalloonTipTitle = text;
                }

                if (text != null)
                {
                    notifyIcon.BalloonTipText = text;
                }

                notifyIcon.ShowBalloonTip(3000);
            }
        }

        private void btnStSt_Click(object sender, EventArgs e)
        {
            if (running)
                Zueira();
            else
                IniciarTrabalho();
        }
    }
}
