using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using vragenlijst.Domain;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using System;
using System.Windows;

namespace vragenlijst.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<QuestionVM> Questions { get; set; }
        private List<QuestionTypes> _questionTypes = new List<QuestionTypes>();
        public List<QuestionTypes> QuestionType
        {
            get 
            { 
                return _questionTypes;
            }
            set
            {
                _questionTypes = value;
                RaisePropertyChanged("QuestionType");
            }
        }

        private QuestionTypes _selectedType = QuestionTypes.SliderQuestion;
        public QuestionTypes SelectedType
        {
            get
            {
                return _selectedType;
            }
            set
            {
                _selectedType = value;
                RaisePropertyChanged("SelectedTypes");
            }
        }

        private Visibility _newQuestionVisibility = Visibility.Collapsed;
        public Visibility NewQuestionVisibility
        {
            get
            {
                return _newQuestionVisibility;
            }
            set
            {
                _newQuestionVisibility = value;
                RaisePropertyChanged("NewQuestionVisibility");
            }
        }
        public ICommand NewQuestionBtn { get; set; }
        public MainViewModel()
        {

            foreach(QuestionTypes q in Enum.GetValues(typeof(QuestionTypes)))
            {
                QuestionType.Add(q);
            }
            NewQuestionBtn = new RelayCommand(OpenQuestion );
            

        }
        private void OpenQuestion()
        {
            NewQuestionVisibility = Visibility.Visible;
        }
    }
}