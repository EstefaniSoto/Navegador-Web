using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EstefaniFireFox : Form
    {

        List<string> Favoritos = new List<string>();
        public EstefaniFireFox()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            
            webBrowser1.GoBack();
            
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            
            webBrowser1.GoForward();
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        { 
            
            webBrowser1.Refresh();
           
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
            webBrowser1.GoHome();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

         
            
            webBrowser1.Navigate(toolStripTextBox1.Text);
           
             }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            Favoritos.Add(webBrowser1.Url.ToString());
                actualizarcmb();

            }

        private void actualizarcmb()
        {
            foreach (string direccion in Favoritos)
            {

                toolStripComboBox1.Items.Add(direccion);

            }


        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\CyberPunkE.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        
    }

}
