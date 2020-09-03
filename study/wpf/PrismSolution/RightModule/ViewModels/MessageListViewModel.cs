using Prism.Events;
using Prism.Mvvm;
using PrismApp.Core;
using RightModule.Views;
using System.Collections.ObjectModel;

namespace RightModule.ViewModels
{
    public class MessageListViewModel : BindableBase
    {
        IEventAggregator _ea;

        private ObservableCollection<string> _messages;
        public ObservableCollection<string> Messages
        {
            get => _messages;
            set => SetProperty(ref _messages, value);
        }

        public MessageListViewModel(IEventAggregator ea)
        {
            _ea = ea;
            Messages = new ObservableCollection<string>();

            //_ea.GetEvent<MessageSentEvent>().Subscribe(MessageReceived);
            _ea.GetEvent<MessageSentEvent>().Subscribe(MessageReceived, ThreadOption.PublisherThread, false, (filter) => filter.Contains("Prism"));

            
        }

        private void MessageReceived(string message)
        {
            Messages.Add(message);
        }
    }
}
