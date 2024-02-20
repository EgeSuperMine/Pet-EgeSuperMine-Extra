// This is the C# Code used on Pet EgeSuperMine 1.7 for the Main Window.
// [i] Some parts of this Code is Erased.
// :3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Windows.Threading;
using System.Runtime.InteropServices;

namespace Pet_EgeSuperMine
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isDragging = false;
        private Point offset;
        private readonly DispatcherTimer gravityTimer;
        readonly Random rnd = new Random();
        string ESM_Name = "EgeSuperMine :3";
        int ESM_Size = 100;
        bool ESM_MovementAllowed = true;
        sbyte SkinCode = 0;
        bool ESM_Reversed = false;
        bool ESM_Gravity = true;
        double ESM_GravitySpeed = 7;
        bool ESM_NoBelowTaskbar = true;
        string EventCode = "{None}";

#pragma warning disable IDE0044
        string cuteface1 = Directory.GetCurrentDirectory() + @"/resources/cuteface1.png";
        string cuteface2 = Directory.GetCurrentDirectory() + @"/resources/cuteface2.png";
        string cuteface3 = Directory.GetCurrentDirectory() + @"/resources/cuteface3.png";
        string cuteface4 = Directory.GetCurrentDirectory() + @"/resources/cuteface4.png";
        string cuteface5 = Directory.GetCurrentDirectory() + @"/resources/cuteface5.png";
        string cuteface6 = Directory.GetCurrentDirectory() + @"/resources/cuteface6.png";
        string cuteface7 = Directory.GetCurrentDirectory() + @"/resources/cuteface7.png";
        string cuteface8 = Directory.GetCurrentDirectory() + @"/resources/cuteface8.png";
        string cuteface9 = Directory.GetCurrentDirectory() + @"/resources/cuteface9.png";
        string cuteface10 = Directory.GetCurrentDirectory() + @"/resources/cuteface10.png";
        string cuteface11 = Directory.GetCurrentDirectory() + @"/resources/cuteface11.png";
        string cuteface12 = Directory.GetCurrentDirectory() + @"/resources/cuteface12.png";
        string cuteface13 = Directory.GetCurrentDirectory() + @"/resources/cuteface13.png";
        string cuteface14 = Directory.GetCurrentDirectory() + @"/resources/cuteface14.png";
        string cuteface15 = Directory.GetCurrentDirectory() + @"/resources/cuteface15.png";
        string cuteface16 = Directory.GetCurrentDirectory() + @"/resources/cuteface16.png";
        string cuteface17 = Directory.GetCurrentDirectory() + @"/resources/cuteface17.png";
        string cuteface18 = Directory.GetCurrentDirectory() + @"/resources/cuteface18.png";
        string cuteface19 = Directory.GetCurrentDirectory() + @"/resources/cuteface19.png";
        string cuteface20 = Directory.GetCurrentDirectory() + @"/resources/cuteface20.png";
        string cuteface21 = Directory.GetCurrentDirectory() + @"/resources/cuteface21.png";
        string cuteface22 = Directory.GetCurrentDirectory() + @"/resources/cuteface22.png";
        string cuteface23 = Directory.GetCurrentDirectory() + @"/resources/cuteface23.png";
        string cuteface24 = Directory.GetCurrentDirectory() + @"/resources/cuteface24.png";
        string cuteface25 = Directory.GetCurrentDirectory() + @"/resources/cuteface25.png";
        string cuteface26 = Directory.GetCurrentDirectory() + @"/resources/cuteface26.png";
        string cuteface27 = Directory.GetCurrentDirectory() + @"/resources/cuteface27.png";
        string cuteface28 = Directory.GetCurrentDirectory() + @"/resources/cuteface28.png";
        string cuteface29 = Directory.GetCurrentDirectory() + @"/resources/cuteface29.png";
        string cuteface30 = Directory.GetCurrentDirectory() + @"/resources/cuteface30.png";

        string cuteface1r = Directory.GetCurrentDirectory() + @"/resources/cuteface1r.png";
        string cuteface2r = Directory.GetCurrentDirectory() + @"/resources/cuteface2r.png";
        string cuteface3r = Directory.GetCurrentDirectory() + @"/resources/cuteface3r.png";
        string cuteface4r = Directory.GetCurrentDirectory() + @"/resources/cuteface4r.png";
        string cuteface5r = Directory.GetCurrentDirectory() + @"/resources/cuteface5r.png";
        string cuteface6r = Directory.GetCurrentDirectory() + @"/resources/cuteface6r.png";
        string cuteface7r = Directory.GetCurrentDirectory() + @"/resources/cuteface7r.png";
        string cuteface8r = Directory.GetCurrentDirectory() + @"/resources/cuteface8r.png";
        string cuteface9r = Directory.GetCurrentDirectory() + @"/resources/cuteface9r.png";
        string cuteface10r = Directory.GetCurrentDirectory() + @"/resources/cuteface10r.png";
        string cuteface11r = Directory.GetCurrentDirectory() + @"/resources/cuteface11r.png";
        string cuteface12r = Directory.GetCurrentDirectory() + @"/resources/cuteface12r.png";
        string cuteface13r = Directory.GetCurrentDirectory() + @"/resources/cuteface13r.png";
        string cuteface14r = Directory.GetCurrentDirectory() + @"/resources/cuteface14r.png";
        string cuteface15r = Directory.GetCurrentDirectory() + @"/resources/cuteface15r.png";
        string cuteface16r = Directory.GetCurrentDirectory() + @"/resources/cuteface16r.png";
        string cuteface17r = Directory.GetCurrentDirectory() + @"/resources/cuteface17r.png";
        string cuteface18r = Directory.GetCurrentDirectory() + @"/resources/cuteface18r.png";
        string cuteface19r = Directory.GetCurrentDirectory() + @"/resources/cuteface19r.png";
        string cuteface20r = Directory.GetCurrentDirectory() + @"/resources/cuteface20r.png";
        string cuteface21r = Directory.GetCurrentDirectory() + @"/resources/cuteface21r.png";
        string cuteface22r = Directory.GetCurrentDirectory() + @"/resources/cuteface22r.png";
        string cuteface23r = Directory.GetCurrentDirectory() + @"/resources/cuteface23r.png";
        string cuteface24r = Directory.GetCurrentDirectory() + @"/resources/cuteface24r.png";
        string cuteface25r = Directory.GetCurrentDirectory() + @"/resources/cuteface25r.png";
        string cuteface26r = Directory.GetCurrentDirectory() + @"/resources/cuteface26r.png";
        string cuteface27r = Directory.GetCurrentDirectory() + @"/resources/cuteface27r.png";
        string cuteface28r = Directory.GetCurrentDirectory() + @"/resources/cuteface28r.png";
        string cuteface29r = Directory.GetCurrentDirectory() + @"/resources/cuteface29r.png";
        string cuteface30r = Directory.GetCurrentDirectory() + @"/resources/cuteface30r.png";

        string settingsfile = Directory.GetCurrentDirectory() + @"/settings.ini";
#pragma warning restore IDE0044

        public MainWindow()
        {
            InitializeComponent();

            gravityTimer = new DispatcherTimer();
            gravityTimer.Tick += GravityTimer_Tick;
            gravityTimer.Interval = TimeSpan.FromMilliseconds(5);
        }

        private void StartMovement()
        {
            Thread MovementThread = new Thread(t =>
            {
                Random rnd = new Random();
                while (true)
                {
                    double nextLeft = double.NaN;
                    try { nextLeft = rnd.Next(0, (int)this.Width); } catch (Exception) { }
                    try { this.Left = nextLeft; } catch (Exception) { }
                    Thread.Sleep(rnd.Next(5000, 10000));
                }
            }); MovementThread.Start();
        }

        private void GravityTimer_Tick(object sender, EventArgs e)
        {
            if (ESM_Gravity && !isDragging)
            {
                double targetTop = SystemParameters.WorkArea.Bottom - this.Height;
                if (this.Top < targetTop)
                {
                    this.Top = Math.Min(this.Top + ESM_GravitySpeed, targetTop);
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Left = SystemParameters.PrimaryScreenWidth / 10;
            this.Top = SystemParameters.WorkArea.Bottom - this.Height;
            Topmost = true;

            try
            {
                StreamReader reader = new StreamReader(settingsfile);
                reader.ReadLine();
                ESM_Name = reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                ESM_Size = Convert.ToInt32(reader.ReadLine());
                this.Width = ESM_Size; this.Height = ESM_Size; EgeSuperMine.Width = ESM_Size; EgeSuperMine.Height = ESM_Size;
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                ESM_MovementAllowed = Convert.ToBoolean(reader.ReadLine());
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                SkinCode = Convert.ToSByte(reader.ReadLine());
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                ESM_Reversed = Convert.ToBoolean(reader.ReadLine());
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                ESM_Gravity = Convert.ToBoolean(reader.ReadLine());
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                ESM_GravitySpeed = Convert.ToDouble(reader.ReadLine());
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                ESM_NoBelowTaskbar = Convert.ToBoolean(reader.ReadLine());
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                ShowInTaskbar = Convert.ToBoolean(reader.ReadLine());
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                EventCode = Convert.ToString(reader.ReadLine());
                reader.Close();
                reader.Dispose();
            } catch (Exception) { Process.GetCurrentProcess().Kill(); }

            if (SkinCode > 30 || SkinCode < -1) { Process.GetCurrentProcess().Kill(); }
            if (SkinCode == -1) { EgeSuperMine.Visibility = Visibility.Hidden; }
            if (ESM_Size < 50) { Process.GetCurrentProcess().Kill(); }
            if (ESM_MovementAllowed) { StartMovement(); }
            gravityTimer.Start();
            this.Title = ESM_Name;

            try
            {
                if (ESM_Reversed)
                {
                    if (SkinCode == 0) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface1r)); }
                    if (SkinCode == 1) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface1r)); }
                    if (SkinCode == 2) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface2r)); }
                    if (SkinCode == 3) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface3r)); }
                    if (SkinCode == 4) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface4r)); }
                    if (SkinCode == 5) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface5r)); }
                    if (SkinCode == 6) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface6r)); }
                    if (SkinCode == 7) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface7r)); }
                    if (SkinCode == 8) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface8r)); }
                    if (SkinCode == 9) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface9r)); }
                    if (SkinCode == 10) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface10r)); }
                    if (SkinCode == 11) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface11r)); }
                    if (SkinCode == 12) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface12r)); }
                    if (SkinCode == 13) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface13r)); }
                    if (SkinCode == 14) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface14r)); }
                    if (SkinCode == 15) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface15r)); }
                    if (SkinCode == 16) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface16r)); }
                    if (SkinCode == 17) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface17r)); }
                    if (SkinCode == 18) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface18r)); }
                    if (SkinCode == 19) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface19r)); }
                    if (SkinCode == 20) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface20r)); }
                    if (SkinCode == 21) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface21r)); }
                    if (SkinCode == 22) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface22r)); }
                    if (SkinCode == 23) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface23r)); }
                    if (SkinCode == 24) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface24r)); }
                    if (SkinCode == 25) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface25r)); }
                    if (SkinCode == 26) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface26r)); }
                    if (SkinCode == 27) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface27r)); }
                    if (SkinCode == 28) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface28r)); }
                    if (SkinCode == 29) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface29r)); }
                    if (SkinCode == 30) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface30r)); }
                }
                else
                {
                    if (SkinCode == 0) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface1)); }
                    if (SkinCode == 1) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface1)); }
                    if (SkinCode == 2) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface2)); }
                    if (SkinCode == 3) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface3)); }
                    if (SkinCode == 4) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface4)); }
                    if (SkinCode == 5) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface5)); }
                    if (SkinCode == 6) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface6)); }
                    if (SkinCode == 7) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface7)); }
                    if (SkinCode == 8) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface8)); }
                    if (SkinCode == 9) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface9)); }
                    if (SkinCode == 10) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface10)); }
                    if (SkinCode == 11) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface11)); }
                    if (SkinCode == 12) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface12)); }
                    if (SkinCode == 13) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface13)); }
                    if (SkinCode == 14) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface14)); }
                    if (SkinCode == 15) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface15)); }
                    if (SkinCode == 16) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface16)); }
                    if (SkinCode == 17) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface17)); }
                    if (SkinCode == 18) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface18)); }
                    if (SkinCode == 19) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface19)); }
                    if (SkinCode == 20) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface20)); }
                    if (SkinCode == 21) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface21)); }
                    if (SkinCode == 22) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface22)); }
                    if (SkinCode == 23) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface23)); }
                    if (SkinCode == 24) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface24)); }
                    if (SkinCode == 25) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface25)); }
                    if (SkinCode == 26) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface26)); }
                    if (SkinCode == 27) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface27)); }
                    if (SkinCode == 28) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface28)); }
                    if (SkinCode == 29) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface29)); }
                    if (SkinCode == 30) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface30)); }
                }
            }
            catch (Exception ex)
            {   
                MessageBox.Show($"Something went wrong :(\n\n{ex}", ":(", MessageBoxButton.OK, MessageBoxImage.Error);
                Process.GetCurrentProcess().Kill(); return;
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete) { Process.GetCurrentProcess().Kill(); }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.E) { return; }
            if (e.Key == Key.G)
            {
                if (ESM_Gravity) { ESM_Gravity = false; return; }
                if (!ESM_Gravity) { ESM_Gravity = true; return; }
            }
            if (e.Key == Key.P)
            {
                if (ESM_NoBelowTaskbar) { ESM_NoBelowTaskbar = false; return; }
                if (!ESM_NoBelowTaskbar) { ESM_NoBelowTaskbar = true; return; }
            }
            if (e.Key == Key.R)
            {
                try
                {
                    if (ESM_Reversed)
                    {
                        if (SkinCode == 0) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface1r)); }
                        if (SkinCode == 1) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface1r)); }
                        if (SkinCode == 2) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface2r)); }
                        if (SkinCode == 3) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface3r)); }
                        if (SkinCode == 4) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface4r)); }
                        if (SkinCode == 5) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface5r)); }
                        if (SkinCode == 6) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface6r)); }
                        if (SkinCode == 7) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface7r)); }
                        if (SkinCode == 8) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface8r)); }
                        if (SkinCode == 9) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface9r)); }
                        if (SkinCode == 10) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface10r)); }
                        if (SkinCode == 11) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface11r)); }
                        if (SkinCode == 12) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface12r)); }
                        if (SkinCode == 13) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface13r)); }
                        if (SkinCode == 14) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface14r)); }
                        if (SkinCode == 15) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface15r)); }
                        if (SkinCode == 16) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface16r)); }
                        if (SkinCode == 17) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface17r)); }
                        if (SkinCode == 18) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface18r)); }
                        if (SkinCode == 19) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface19r)); }
                        if (SkinCode == 20) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface20r)); }
                        if (SkinCode == 21) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface21r)); }
                        if (SkinCode == 22) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface22r)); }
                        if (SkinCode == 23) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface23r)); }
                        if (SkinCode == 24) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface24r)); }
                        if (SkinCode == 25) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface25r)); }
                        if (SkinCode == 26) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface26r)); }
                        if (SkinCode == 27) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface27r)); }
                        if (SkinCode == 28) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface28r)); }
                        if (SkinCode == 29) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface29r)); }
                        if (SkinCode == 30) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface30r)); }
                    }
                    else
                    {
                        if (SkinCode == 0) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface1)); }
                        if (SkinCode == 1) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface1)); }
                        if (SkinCode == 2) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface2)); }
                        if (SkinCode == 3) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface3)); }
                        if (SkinCode == 4) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface4)); }
                        if (SkinCode == 5) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface5)); }
                        if (SkinCode == 6) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface6)); }
                        if (SkinCode == 7) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface7)); }
                        if (SkinCode == 8) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface8)); }
                        if (SkinCode == 9) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface9)); }
                        if (SkinCode == 10) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface10)); }
                        if (SkinCode == 11) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface11)); }
                        if (SkinCode == 12) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface12)); }
                        if (SkinCode == 13) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface13)); }
                        if (SkinCode == 14) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface14)); }
                        if (SkinCode == 15) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface15)); }
                        if (SkinCode == 16) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface16)); }
                        if (SkinCode == 17) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface17)); }
                        if (SkinCode == 18) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface18)); }
                        if (SkinCode == 19) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface19)); }
                        if (SkinCode == 20) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface20)); }
                        if (SkinCode == 21) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface21)); }
                        if (SkinCode == 22) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface22)); }
                        if (SkinCode == 23) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface23)); }
                        if (SkinCode == 24) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface24)); }
                        if (SkinCode == 25) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface25)); }
                        if (SkinCode == 26) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface26)); }
                        if (SkinCode == 27) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface27)); }
                        if (SkinCode == 28) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface28)); }
                        if (SkinCode == 29) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface29)); }
                        if (SkinCode == 30) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface30)); }
                    }

                    if (ESM_Reversed) { ESM_Reversed = false; return; }
                    if (!ESM_Reversed) { ESM_Reversed = true; return; }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong :(\n\n{ex}", ":(", MessageBoxButton.OK, MessageBoxImage.Error);
                    Process.GetCurrentProcess().Kill(); return;
                }
            }
            if (e.Key == Key.S)
            {
                try
                {
                    SkinCode += 1;
                    if (SkinCode > 30) { SkinCode = 0; }

                    if (!ESM_Reversed)
                    {
                        if (SkinCode == 0) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface1r)); }
                        if (SkinCode == 1) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface1r)); }
                        if (SkinCode == 2) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface2r)); }
                        if (SkinCode == 3) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface3r)); }
                        if (SkinCode == 4) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface4r)); }
                        if (SkinCode == 5) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface5r)); }
                        if (SkinCode == 6) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface6r)); }
                        if (SkinCode == 7) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface7r)); }
                        if (SkinCode == 8) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface8r)); }
                        if (SkinCode == 9) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface9r)); }
                        if (SkinCode == 10) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface10r)); }
                        if (SkinCode == 11) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface11r)); }
                        if (SkinCode == 12) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface12r)); }
                        if (SkinCode == 13) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface13r)); }
                        if (SkinCode == 14) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface14r)); }
                        if (SkinCode == 15) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface15r)); }
                        if (SkinCode == 16) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface16r)); }
                        if (SkinCode == 17) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface17r)); }
                        if (SkinCode == 18) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface18r)); }
                        if (SkinCode == 19) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface19r)); }
                        if (SkinCode == 20) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface20r)); }
                        if (SkinCode == 21) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface21r)); }
                        if (SkinCode == 22) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface22r)); }
                        if (SkinCode == 23) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface23r)); }
                        if (SkinCode == 24) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface24r)); }
                        if (SkinCode == 25) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface25r)); }
                        if (SkinCode == 26) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface26r)); }
                        if (SkinCode == 27) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface27r)); }
                        if (SkinCode == 28) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface28r)); }
                        if (SkinCode == 29) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface29r)); }
                        if (SkinCode == 30) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface30r)); }
                    }
                    else
                    {
                        if (SkinCode == 0) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface1)); }
                        if (SkinCode == 1) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface1)); }
                        if (SkinCode == 2) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface2)); }
                        if (SkinCode == 3) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface3)); }
                        if (SkinCode == 4) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface4)); }
                        if (SkinCode == 5) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface5)); }
                        if (SkinCode == 6) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface6)); }
                        if (SkinCode == 7) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface7)); }
                        if (SkinCode == 8) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface8)); }
                        if (SkinCode == 9) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface9)); }
                        if (SkinCode == 10) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface10)); }
                        if (SkinCode == 11) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface11)); }
                        if (SkinCode == 12) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface12)); }
                        if (SkinCode == 13) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface13)); }
                        if (SkinCode == 14) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface14)); }
                        if (SkinCode == 15) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface15)); }
                        if (SkinCode == 16) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface16)); }
                        if (SkinCode == 17) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface17)); }
                        if (SkinCode == 18) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface18)); }
                        if (SkinCode == 19) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface19)); }
                        if (SkinCode == 20) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface20)); }
                        if (SkinCode == 21) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface21)); }
                        if (SkinCode == 22) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface22)); }
                        if (SkinCode == 23) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface23)); }
                        if (SkinCode == 24) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface24)); }
                        if (SkinCode == 25) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface25)); }
                        if (SkinCode == 26) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface26)); }
                        if (SkinCode == 27) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface27)); }
                        if (SkinCode == 28) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface28)); }
                        if (SkinCode == 29) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface29)); }
                        if (SkinCode == 30) { EgeSuperMine.Source = new BitmapImage(new Uri(cuteface30)); }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong :(\n\n{ex}", ":(", MessageBoxButton.OK, MessageBoxImage.Error);
                    Process.GetCurrentProcess().Kill(); return;
                }
            }
            if (e.Key == Key.T)
            {
                double targetTop = SystemParameters.WorkArea.Bottom - this.Height;

                this.Left = rnd.Next(0, (int)SystemParameters.PrimaryScreenWidth);
                this.Top = rnd.Next(0, (int)SystemParameters.PrimaryScreenHeight - (int)this.Height);
                if (ESM_NoBelowTaskbar && this.Top > targetTop)
                {
                    this.Top = targetTop;
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true; return;
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point mousePos = e.GetPosition(null);
                double newX = mousePos.X - offset.X + this.Left;
                double newY = mousePos.Y - offset.Y + this.Top;
                double targetTop = SystemParameters.WorkArea.Bottom - this.Height;

                this.Left = newX;
                this.Top = newY;

                if (ESM_NoBelowTaskbar && this.Top > targetTop)
                {
                    this.Top = targetTop;
                }
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                isDragging = true;
                offset = e.GetPosition(this);
                this.CaptureMouse();
            }
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                isDragging = false;
                this.ReleaseMouseCapture();
            }
        }

        private void Window_MouseRightButtonUp(object sender, MouseButtonEventArgs e) { }
    }
}
