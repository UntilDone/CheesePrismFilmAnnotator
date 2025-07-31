using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CheeseFilmAnalystics.ViewModel
{
    public class MainViewModel: INotifyPropertyChanged
    {
        private MovieData _currentMovie;
        public MovieData CurrentMovie
        {
            get => _currentMovie;
            set
            {
                _currentMovie = value;
                OnPropertyChanged(nameof(CurrentMovie));
            }
        }

        public ICommand OpenMovieCommand { get; }
        public ICommand ExtractLutCommand { get; }
        public ICommand AddEmotionTagCommand { get; }

        public MainViewModel()
        {
            CurrentMovie = new MovieData
            {
                ExtractedColors = new ObservableCollection<ColorData>(),
                EmotionTags = new ObservableCollection<EmotionTag>()
            };

            OpenMovieCommand = new RelayCommand(OpenMovie);
            ExtractLutCommand = new RelayCommand(ExtractLut);
            AddEmotionTagCommand = new RelayCommand(AddEmotionTag);
        }

        private void OpenMovie(object parameter) { /* 파일 다이얼로그 열기, CurrentMovie.ImagePath 설정 */ }
        private void ExtractLut(object parameter) { /* OpenCV/ImageSharp를 사용하여 LUT/색상 추출 로직 호출 */ }
        private void AddEmotionTag(object parameter) { /* 새 감정 태그 추가 로직 */ }

        // INotifyPropertyChanged 구현
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
