using System;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;


namespace names
{
    public class Birds_Visual : Window
    {


        [STAThread]

        public static void Main()
        {
            Application app = new Application();
            app.Run(new Birds_Visual());
        }

        TextBox tb_angle = new TextBox();

        TextBox tb_velocity = new TextBox();
        public Birds_Visual()
        {
            Title = "Angry birds";


            Label lbl_angle = new Label();
            lbl_angle.Foreground = Brushes.White;
            lbl_angle.Content = "Angle";
            lbl_angle.FontSize = 30;
            lbl_angle.HorizontalAlignment = HorizontalAlignment.Center;

            Label lbl_velocity = new Label();
            lbl_velocity.Foreground = Brushes.White;
            lbl_velocity.Content = "Start velocity";
            lbl_velocity.FontSize = 30;
            lbl_velocity.HorizontalAlignment = HorizontalAlignment.Center;

            Label lbl_Title = new Label();
            lbl_Title.Foreground = Brushes.White;
            lbl_Title.Content = "Add the data";
            lbl_Title.FontSize = 50;
            lbl_Title.HorizontalAlignment = HorizontalAlignment.Center;

            Button btn = new Button();
            btn.Content = "Calculate";
            btn.Margin = new Thickness(192, 384, 192, 288);
            btn.Width = 384;
            btn.FontSize = 30;
            btn.Click += ButtonOnClick;

            StackPanel stack = new StackPanel();
            stack.Background = Brushes.Black;
            stack.Children.Add(lbl_Title);
            stack.Children.Add(lbl_angle);
            stack.Children.Add(tb_angle);
            stack.Children.Add(lbl_velocity);
            stack.Children.Add(tb_velocity);
            stack.Children.Add(btn);
            Content = stack;

        }


        void ButtonOnClick(object sender, RoutedEventArgs args)
        {
            Button btn = args.Source as Button;
            const double g = 9.80665;
            double x = 0;
            double y = 0;
            double t = 0;
            double v0 = Convert.ToDouble(tb_velocity.Text);
            double cosa = Math.Cos(Convert.ToDouble(tb_angle.Text) * Math.PI / 180);
            double sina = Math.Sin(Convert.ToDouble(tb_angle.Text) * Math.PI / 180);
            ValueTuple<double, double> coords = new ValueTuple<double, double>(x, y);

            while (y >= 0)
            {
                coords.Item1 = x;
                coords.Item2 = y;
                t += 0.01;
                x = v0 * cosa * t;
                y = v0 * sina * t - g * t * t / 2;
            }

            MessageBox.Show(Convert.ToString(coords), "Trown object fell in");
        }

    }
}