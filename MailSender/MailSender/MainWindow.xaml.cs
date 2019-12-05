using System;
using System.Net;
using System.Windows;
using System.Net.Mail;
using MailSenderLib;

namespace MailSender
{
	partial class MainWindow : Window
    {
        Control control = new Control();
		public MainWindow() => InitializeComponent();

	    void Button_Click(object sender, RoutedEventArgs e) => control.Send(UserNameTextBox.Text, PasswordEdit.Password);	    
	}
}


