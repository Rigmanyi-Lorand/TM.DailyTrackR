namespace TM.DailyTrackR.ViewModel
{
    using Prism.Commands;
    using Prism.Mvvm;
    using System;
    using TM.DailyTrackR.Common;
    using TM.DailyTrackR.Logic;

    public sealed class MainWindowViewModel : BindableBase
    {
        private User user;
        private int number = 1;
        private List<string> listOfNumber;
       

        public List<string> ListOfNumber
        {
            get => listOfNumber;
            set => this.SetProperty(ref listOfNumber, value);
        }

        public MainWindowViewModel()
        {
            this.user = new User { Username = "marcel", Password = "pita" };
            this.listOfNumber = new List<string>
            {
                "1",
                "2",
                "3",
            };

            this.Username = this.user.Username;
            this.Password = this.user.Password;
            IncreaseNumber = new DelegateCommand(IncreaseNumberExecute);
            NewWindowCommand = new DelegateCommand(NewWindowExecute);
            DeleteElementFromIndex = new DelegateCommand(DeleteElementFromIndexExecute);
        }

        private void DeleteElementFromIndexExecute()
        {
            this.ListOfNumber.RemoveAt(2);
        }

        public DelegateCommand IncreaseNumber { get; }
        public DelegateCommand NewWindowCommand { get; }

        public DelegateCommand DeleteElementFromIndex { get; }

        private string username;
        public string Username
        {
            get => this.username;
            set => SetProperty(ref this.username, value);
        }

        private string password;
        public string Password
        {
            get => this.password;
            private set => SetProperty(ref this.password, value);
        }

        public int Number
        {
            get => this.number;
            set => this.SetProperty(ref number, value);
        }

        

        private void IncreaseNumberExecute() => number++;

        private void NewWindowExecute()
        {
            ViewService.Instance.ShowWindow(new MainWindowViewModel());
        }

    }
}
