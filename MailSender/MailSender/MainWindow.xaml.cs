using System;
using System.Net;
using System.Windows;
using System.Net.Mail;
using MailSenderLib;
using System.ComponentModel;

namespace MailSender
{
	partial class MainWindow : Window, INotifyPropertyChanged
    {
        Control control = new Control();

        string subject = "";
        string body = "";

        public string Subject 
        { 
            get => subject;
            set
            {
                if(value != subject)
                {
                    subject = value;
                    NotifyPropertyChanged("Subject");
                }
            }
        }
        public string Body
        { 
            get => body;
            set 
            { 
                if(value != body )
                {
                    body = value;
                    NotifyPropertyChanged("Body");
                }
            }
        }

        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }
               
        public void OnWindowClosing(object sender, CancelEventArgs e)
        {
            if (!Model.close)
            {
                (new MassageExit(this)).Show();
                e.Cancel = true;
            }
        }

        void Button_Click(object sender, RoutedEventArgs e) => control.Send(UserNameTextBox.Text, PasswordEdit.Password);

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}


