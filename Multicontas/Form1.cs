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
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;

namespace Multicontas
{
    public partial class Multicontas : Form
    {
        public Multicontas()
        {
            InitializeComponent();
        }

        public void new_id(string id)
        {
            string userName = Environment.UserName;
            string[] path = { @"C:\Users", userName, "AppData", "Roaming", "Habbo Launcher", "downloads", "air", "8", "META-INF", "AIR", "application.xml" };
            string fullPath = Path.Combine(path);
            XmlDocument doc = new XmlDocument();
            doc.Load(fullPath);
            var elementos = doc.SelectNodes("//*");
            for (int i = 0; i < elementos.Count; i++)
            {
                var elemento = elementos[i];
                if (elemento.Name == "id")
                {
                    elemento.InnerText = id;
                }
            }
            doc.Save(fullPath);
        }
        
        public void open_game()
        {
            string userName = Environment.UserName;
            string[] path_app = { @"C:\Users", userName, "AppData", "Roaming", "Habbo Launcher", "downloads", "air", "8", "Habbo.exe" };
            string fullPath_app = Path.Combine(path_app);
            Process.Start(fullPath_app);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string new_id = "com.sulake.habboair.hhbr" + DateTimeOffset.Now.ToUnixTimeSeconds();
            this.new_id(new_id);
            this.open_game();
            this.new_id(new_id);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.new_id("com.sulake.habboair.hhbr");
            MessageBox.Show("Resetado com sucesso!", "Sucesso!");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Para poder abrir outra conta, clique em \"Nova Conta\", o Launcher se abrirá e basta você colar o código de login e clicar em \"Jogar!\".\nVocê pode repetir o processo quantas vezes quiser.\nAssim que terminar, clique em \"Resetar\" para colocar o id padrão novamente.", "Funcionamento");
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            string copyright = "© " + year + " Bruno Bonavigo.\nCriado como projeto de teste para C#.";
            MessageBox.Show(copyright, "Sobre");
        }
    }
}