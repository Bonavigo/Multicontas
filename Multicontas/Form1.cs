using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace Multicontas
{
    public partial class Multicontas : Form
    {
        public Multicontas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            string[] path = { @"C:\Users", userName, "AppData", "Local", "Sulake", "Habbo Launcher", "HabboFlash", "META-INF", "AIR", "application.xml" };
            string fullPath = Path.Combine(path);
            XmlDocument doc = new XmlDocument();
            doc.Load(fullPath);
            var elementos = doc.SelectNodes("//*");
            for (int i = 0; i < elementos.Count; i++)
            {
                var elemento = elementos[i];
                if (elemento.Name == "id")
                {
                    elemento.InnerText = "com.sulake.habboair" + DateTimeOffset.Now.ToUnixTimeSeconds();
                    MessageBox.Show("Arquivo alterado com sucesso!", "Sucesso!");
                }
            }
            doc.Save(fullPath);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            string[] path = { @"C:\Users", userName, "AppData", "Local", "Sulake", "Habbo Launcher", "HabboFlash", "META-INF", "AIR", "application.xml" };
            string fullPath = Path.Combine(path);
            XmlDocument doc = new XmlDocument();
            doc.Load(fullPath);
            var elementos = doc.SelectNodes("//*");
            for (int i = 0; i < elementos.Count; i++)
            {
                var elemento = elementos[i];
                if (elemento.Name == "id")
                {
                    elemento.InnerText = "com.sulake.habboair";
                    MessageBox.Show("Resetado com sucesso!", "Sucesso!");
                }
            }
            doc.Save(fullPath);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Para poder abrir outra conta, clique em \"Nova Conta\", logue no site do Habbo e abra o Launcher.\nVocê pode repetir o processo quantas vezes quiser.\nAssim que terminar, clique em \"Resetar\" para colocar o id padrão novamente.", "Funcionamento");
        }
    }
}