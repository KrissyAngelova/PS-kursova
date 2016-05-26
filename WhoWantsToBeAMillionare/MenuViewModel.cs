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
    public class MenuViewModel : INotifyPropertyChanged
    {
        public MenuViewModel()
        {
            StartGameCommand = new RelayCommand(param=>startGame());
            ExitGameCommand = new RelayCommand(param => exitGame());
        }

        private ICommand _StartGameCommand;
        public ICommand StartGameCommand
        {
            get
            {
                return _StartGameCommand;
            }
            set
            {
                _StartGameCommand = value;
                NotifyPropertyChanged();
            }
        }

        private ICommand _ExitGameCommand;
        public ICommand ExitGameCommand
        {
            get
            {
                return _ExitGameCommand;
            }
            set
            {
                _ExitGameCommand = value;
                NotifyPropertyChanged();
            }
        }
        private void startGame()
        {
            Game game = new Game();
            GameViewModel gameViewModel = new GameViewModel();
            game.DataContext = gameViewModel;
            game.ShowDialog();
            
        }

        private void exitGame()
        {
            Environment.Exit(0);
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName]String propName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new
               PropertyChangedEventArgs(propName));
            }
        }

    }
}
