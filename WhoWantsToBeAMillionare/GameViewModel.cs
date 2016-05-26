using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WhoWantsToBeAMillionare
{
    class GameViewModel : INotifyPropertyChanged
    {

        public static string fiftyJockerImage = "/Images/1.png";
        public static string friendJockerImage = "/Images/2.png";
        public static string publicJockerImage = "/Images/3.png";
        private static Boolean fiftyJockerAvailability = true;
        private static Boolean friendJockerAvailability = true;
        private static Boolean publicJockerAvailability = true;
        private ICommand answerCommand { get; set; }
        public ICommand AnswerCommand
        {
            get
            {
                return answerCommand;
            }
            set
            {
                answerCommand = value;
            }
        }

        private ICommand fiftyJockerCommand { get; set; }
        public ICommand FiftyJockerCommand
        {
            get
            {
                return fiftyJockerCommand;
            }
            set
            {
                fiftyJockerCommand = value;
            }
        }

        private ICommand friendJockerCommand { get; set; }
        public ICommand FriendJockerCommand
        {
            get
            {
                return friendJockerCommand;
            }
            set
            {
                friendJockerCommand = value;
            }
        }

        private ICommand publicJockerCommand { get; set; }
        public ICommand PublicJockerCommand
        {
            get
            {
                return publicJockerCommand;
            }
            set
            {
                publicJockerCommand = value;
            }
        }
        private QuizEntities ctx;
        public GameViewModel()
        {
            ctx = new QuizEntities();
            AnswerCommand = new RelayCommand(param => this.Answer(param));
            FriendJockerCommand = new RelayCommand(param => this.FriendJocker());
            FiftyJockerCommand = new RelayCommand(param => this.FiftyJocker());
            PublicJockerCommand = new RelayCommand(param => this.PublicJocker());
            loadLevel(1);
        }

        private void Answer(object ans)
        {

            if (ans.ToString().Equals(CurrentLevel.correct))
            {
                handleCorrect();
            }
            else
            {
                handleWrong();
            }
        }

        private void FriendJocker()
        {
            Random rand = new Random();
            int x = rand.Next(21);
            if (x % 2 == 0){
                switch (CurrentLevel.correct)
                {
                    case "A": 
                        System.Windows.MessageBox.Show("I think the right answer is " + CurrentLevel.aA);
                        friendJockerImage = "/Images/2.1.png";
                        friendJockerAvailability = false;
                        NotifyPropertyChanged("FriendJockerCommand");
                        NotifyPropertyChanged("CurrentLevel");
                        break;
                    case "B":
                        System.Windows.MessageBox.Show("I think the right answer is " + CurrentLevel.aB);
                        friendJockerImage = "/Images/2.1.png";
                        friendJockerAvailability = false;
                        NotifyPropertyChanged("FriendJockerCommand");
                        NotifyPropertyChanged("CurrentLevel");
                        break;
                    case "C":
                        System.Windows.MessageBox.Show("I think the right answer is " + CurrentLevel.aC);
                        friendJockerImage = "/Images/2.1.png";
                        friendJockerAvailability = false;
                        NotifyPropertyChanged("FriendJockerCommand");
                        NotifyPropertyChanged("CurrentLevel");
                        break;
                    case "D":
                        System.Windows.MessageBox.Show("I think the right answer is " + CurrentLevel.aD);
                        friendJockerImage = "/Images/2.1.png";
                        friendJockerAvailability = false;
                        NotifyPropertyChanged("FriendJockerCommand");
                        NotifyPropertyChanged("CurrentLevel");
                        break;
                }
            }
                
            else
                System.Windows.MessageBox.Show("I don't know the answer!! ;(");
                friendJockerImage = "/Images/2.1.png";
                friendJockerAvailability = false;
                NotifyPropertyChanged("FriendJockerCommand");
                NotifyPropertyChanged("CurrentLevel");
        }

        private void FiftyJocker()
        {
            switch (CurrentLevel.correct)
            {
                case "A":
                    CurrentLevel.aB = " ";
                    CurrentLevel.aD = " ";
                    fiftyJockerImage = "/Images/1.1.png";
                    fiftyJockerAvailability = false;
                    NotifyPropertyChanged("FiftyJockerCommand");
                    NotifyPropertyChanged("CurrentLevel");
                    break;
                case "B":
                    CurrentLevel.aA = " ";
                    CurrentLevel.aD = " ";
                    fiftyJockerImage = "/Images/1.1.png";
                    fiftyJockerAvailability = false;
                    NotifyPropertyChanged("FiftyJockerCommand");
                    NotifyPropertyChanged("CurrentLevel");
                    break;
                case "C":
                    CurrentLevel.aB = " ";
                    CurrentLevel.aD = " ";
                    fiftyJockerImage = "/Images/1.1.png";
                    fiftyJockerAvailability = false;
                    NotifyPropertyChanged("FiftyJockerCommand");
                    NotifyPropertyChanged("CurrentLevel");
                    break;
                case "D":
                    CurrentLevel.aB = " ";
                    CurrentLevel.aC = " ";
                    fiftyJockerImage = "/Images/1.1.png";
                    fiftyJockerAvailability = false;
                    NotifyPropertyChanged("FiftyJockerCommand");
                    NotifyPropertyChanged("CurrentLevel");
                    break;
            }
        }

        private void PublicJocker()
        {
             Random rand = new Random();
             double x = rand.NextDouble();
            
                switch (CurrentLevel.correct)
                {
                    case "A":
                        string str1 = "72%  --- " + CurrentLevel.aA + "\n11% --- " + CurrentLevel.aB + "\n8% --- " + CurrentLevel.aC + "\n9% --- " + CurrentLevel.aD;
                        System.Windows.MessageBox.Show(str1);
                        publicJockerImage = "/Images/3.1.png";
                        publicJockerAvailability = false;
                        NotifyPropertyChanged("PublicJockerCommand");
                        NotifyPropertyChanged("CurrentLevel");
                        break;
                    case "B":
                        string str2 = "16%  --- " + CurrentLevel.aA + "\n64% --- " + CurrentLevel.aB + "\n10% --- " + CurrentLevel.aC + "\n10% --- " + CurrentLevel.aD;
                        System.Windows.MessageBox.Show(str2);
                        publicJockerImage = "/Images/3.1.png";
                        publicJockerAvailability = false;
                        NotifyPropertyChanged("PublicJockerCommand");
                        NotifyPropertyChanged("CurrentLevel");
                        break;
                    case "C":
                        string str3 = "21%  --- " + CurrentLevel.aA + "\n19% --- " + CurrentLevel.aB + "\n58% --- " + CurrentLevel.aC + "\n2% --- " + CurrentLevel.aD;
                        System.Windows.MessageBox.Show(str3);
                        publicJockerImage = "/Images/3.1.png";
                        publicJockerAvailability = false;
                        NotifyPropertyChanged("PublicJockerCommand");
                        NotifyPropertyChanged("CurrentLevel");
                        break;
                    case "D":
                        string str4 = "5%  --- " + CurrentLevel.aA + "\n15% --- " + CurrentLevel.aB + "\n15% --- " + CurrentLevel.aC + "\n65% --- " + CurrentLevel.aD;
                        System.Windows.MessageBox.Show(str4);
                        publicJockerImage = "/Images/3.1.png";
                        publicJockerAvailability = false;
                        NotifyPropertyChanged("PublicJockerCommand");
                        NotifyPropertyChanged("CurrentLevel");
                        break;
                }
        }
        private void handleCorrect()
        {
            short num = (Int16)(CurrentLevel.number + 1);
            if (num == 16)
            {
                System.Windows.MessageBox.Show("You win!.");
                Environment.Exit(0);
            }
            else
            {
                loadLevel(num);
            }
        }

        private void handleWrong()
        {
            System.Windows.MessageBox.Show("Wrong answer.You loooooooose!!!");
            Environment.Exit(0);
           
        }

        private Levels _currentLevel;
        public Levels CurrentLevel
        {
            get { return _currentLevel; }
            set
            {
                _currentLevel = value;
            }
        }
        
        private void loadLevel(short number = 1)
        {
            var q = (from a in ctx.Levels
                     where a.number == number
                     select a ).ToList();
            this.CurrentLevel = q.First();
            this.CurrentLevel.fiftyJockerImgSource = fiftyJockerImage;
            this.CurrentLevel.friendJockerImgSource = friendJockerImage;
            this.CurrentLevel.publicJockerImgSource = publicJockerImage;
            this.CurrentLevel.fiftyJockerIsEnable = fiftyJockerAvailability;
            this.CurrentLevel.friendJockerIsEnable = friendJockerAvailability;
            this.CurrentLevel.publicJockerIsEnable = publicJockerAvailability;
            NotifyPropertyChanged("CurrentLevel");
        }
    
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
       
    }
}
