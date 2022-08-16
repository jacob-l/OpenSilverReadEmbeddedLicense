using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace OpenSilverReadEmbeddedLicense
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Enter construction logic here...

            var resourceName = "EmbeddedFile.txt";
            var ea = System.Reflection.Assembly.GetEntryAssembly();
            if (ea == null) return;

            using (var stream = ea.GetManifestResourceStream(resourceName))
            {
                if (stream == null) return;

                using (var sr = new StreamReader(stream))
                {
                    TextBlock1.Text = sr.ReadToEnd();
                }
            }
        }
    }
}
