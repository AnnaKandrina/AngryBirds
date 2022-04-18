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

        public Birds_Visual()
        {
            Title = "Angry birds";
            TextBox tb_angle = new TextBox();

            TextBox tb_velocity = new TextBox();

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

        void ButtonOnClick(object sender, RoutedEventArgs agrs)
        {
            MessageBox.Show("Result", "text");
        }
    }
}