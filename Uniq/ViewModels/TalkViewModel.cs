using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Uniq.Models;
using Uniq.Views;
using Xamarin.Forms;

namespace Uniq.ViewModels
{
    public class TalkViewModel : BaseViewModel
    {
        public bool ShowScrollTap { get; set; } = false;
        public bool LastMessageVisible { get; set; } = true;
        public int PendingMessageCount { get; set; } = 0;
        public bool PendingMessageCountVisible { get { return PendingMessageCount > 0; } }

        public Queue<Message> DelayedMessages { get; set; } = new Queue<Message>();
        public ObservableCollection<Message> Messages { get; set; } = new ObservableCollection<Message>();
        public string TextToSend { get; set; }
        public ICommand OnSendCommand { get; set; }
        public ICommand MessageAppearingCommand { get; set; }
        public ICommand MessageDisappearingCommand { get; set; }

        public TalkViewModel() {
            Messages.Add(new Message() { Text = "Hello, how can I help you today?" });
            Messages.Add(new Message() { Text = "Hey. I'm having trouble with one of my classes...", User = App.User });

            MessageAppearingCommand = new Command<Message>(OnMessageAppearing);
            MessageDisappearingCommand = new Command<Message>(OnMessageDisappearing);

            OnSendCommand = new Command(() => {
                if (!string.IsNullOrEmpty(TextToSend)) {
                    Messages.Add(new Message() { Text = TextToSend, User = App.User });
                    TextToSend = string.Empty;
                }

            });



        }

        void OnMessageAppearing(Message message) {
            var idx = Messages.IndexOf(message);
            if (idx <= 6) {
                Device.BeginInvokeOnMainThread(() => {
                    while (DelayedMessages.Count > 0) {
                        Messages.Add(DelayedMessages.Dequeue());
                    }
                    ShowScrollTap = false;
                    LastMessageVisible = true;
                    PendingMessageCount = 0;
                });
            }
        }

        void OnMessageDisappearing(Message message) {
            var idx = Messages.IndexOf(message);
            if (idx >= 6) {
                Device.BeginInvokeOnMainThread(() => {
                    ShowScrollTap = true;
                    LastMessageVisible = false;
                });

            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
