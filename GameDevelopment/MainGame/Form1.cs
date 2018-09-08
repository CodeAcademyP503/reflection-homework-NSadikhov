using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using GameDevelopmentExtension;

namespace MainGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var f = Directory.GetCurrentDirectory();

            string absolutePath = Path.Combine(f, "Extentions");

            DirectoryInfo directoryInfo = new DirectoryInfo(absolutePath);

            FileInfo[] fileInfo = directoryInfo.GetFiles("*.dll",SearchOption.TopDirectoryOnly);



            foreach (FileInfo file in fileInfo)
            {
               Assembly assembly = Assembly.LoadFile(file.FullName);

                if (assembly != null)
                {
                   Type[] types = assembly.GetTypes();

                    foreach (Type t in types)
                    {
                        Type interfaceType = t.GetInterface("IGameDevelopment");

                        if (interfaceType != null)
                        {
                            IGameDevelopment instance = Activator.CreateInstance(t) as IGameDevelopment;

                            Button btn = new Button();
                            btn.Text = instance.ButtonName;
                            btn.Click += instance.Click;
                            panel.Controls.Add(btn);
                        }
                    }
                }
            }
        }
    }
}
