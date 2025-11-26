using AppjogoForca.Libraries.Text;
using AppjogoForca.Models;
using AppjogoForca.Repositories;
using System.Threading.Tasks;

namespace AppjogoForca
{
    public partial class MainPage : ContentPage
    {
        private Word _word;
        private int _erros;

        public MainPage()
        {
            InitializeComponent();
            ResetScreen();

        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            button.IsEnabled = false;

            String letter = button.Text;

            var positions = _word.Text.GetPositions(letter);

            if (positions.Count == 0)
            {
                ErrorHandler(button);

                await IsGameOver();
                return;
            }
            ReplaceLetter(letter, positions);
            button.Style = (Style?)App.Current.Resources.MergedDictionaries.ElementAt(1)["Success"];

            await HasWinner();

        }
        private void OnButtonClickedResetGame(object sender, EventArgs e)
        {
            ResetScreen();
        }

        private async Task HasWinner()
        {
            if (!LblText.Text.Contains("_"))
            {
                await DisplayAlert("Parabéns!", "Você ganhou o jogo!", "Novo jogo");
                ResetScreen();
            }
        }

        private void ReplaceLetter(string letter, List<int> positions)
        {
            foreach (int position in positions)
            {
                LblText.Text = LblText.Text.Remove(position, 1).Insert(position, letter);
            }
        }

        private void ErrorHandler(Button button)
        {
            _erros++;
            ImgMain.Source = ImageSource.FromFile($"forca{_erros + 1}.png");
            button.Style = (Style?)App.Current.Resources.MergedDictionaries.ElementAt(1)["Fail"];
        }

        private async Task IsGameOver()
        {
            if (_erros == 6)
            {
                await DisplayAlert("Perdeu!", "Você foi enforcado!", "Novo Jogo");
                ResetScreen();
            }
        }

        private void ResetScreen()
        {
            ResetVirtualKeyboard();
            ResetErros();
            GenerateNewWords();
         
           
        }

        private void GenerateNewWords()
        {
            var repository = new WordRepositories();
            _word = repository.GetWordRandom();
            LblTips.Text = _word.Tips;
            LblText.Text = new string('_', _word.Text.Length);

        }

        private void ResetErros()
        {
            _erros = 0;
            ImgMain.Source = ImageSource.FromFile("forca1.png");
        }

        private void ResetVirtualKeyboard()
        {
            ReserVirtuallines((HorizontalStackLayout)KeyboardContainer.Children[0]);
            ReserVirtuallines((HorizontalStackLayout)KeyboardContainer.Children[1]);
            ReserVirtuallines((HorizontalStackLayout)KeyboardContainer.Children[2]);
        }

        private void ReserVirtuallines(HorizontalStackLayout horizontal)
        {
            foreach (Button button in horizontal.Children)
            {
                button.IsEnabled = true;
                button.Style = null;
            }

        }
        }
    }
