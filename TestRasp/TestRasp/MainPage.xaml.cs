using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Vorlage "Leere Seite" ist unter http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 dokumentiert.

namespace TestRasp
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet werden kann oder auf die innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DispatcherTimer appTimer = new DispatcherTimer();
        int countTicks = 0;

        public MainPage()
        {
            this.InitializeComponent();
            appTimer.Interval = new TimeSpan(0, 0, 1);
            appTimer.Tick += appTimer_Tick;
        }

        private void btn_startTimer_Click(object sender, RoutedEventArgs e)
        {
            appTimer.Start();
        }


        private void appTimer_Tick(object sender, object e)
        {
            countTicks++;
            lbl_result.Text = "TimerTicks:= " + countTicks;

            if (countTicks >= 10)
            {
                appTimer.Stop();
                countTicks = 0;
            }
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
