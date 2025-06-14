﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            UpdateBackground();
        }

        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateBackground();
        }

        private void UpdateBackground()
        {
            byte r = (byte)SliderR.Value;
            byte g = (byte)SliderG.Value;
            byte b = (byte)SliderB.Value;

            this.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }
    }

}