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
        public SliderQuestionVM sliderQuestion { get; set; }
        public TextQuestionVM textQuestion { get; set; }

        public ObservableCollection<Question> Questions { get; set; }
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

        private Question _selectedQuestion;
        public Question SelectedQuestion { get
            {
                return _selectedQuestion;
            }set
            {
                _selectedQuestion = value;
            }
        }


        private QuestionTypes _selectedType = QuestionTypes.TextQuestion;
        public QuestionTypes SelectedType
        {
            get
            {
                return _selectedType;
            }
            set
            {
                _selectedType = value;
                if (_selectedType == QuestionTypes.TextQuestion)
                {
                    SliderQuestionVisibility = Visibility.Collapsed;
                    TextQuestionVisibility = Visibility.Visible;
                }
                else
                {
                    SliderQuestionVisibility = Visibility.Visible;
                    TextQuestionVisibility = Visibility.Collapsed;
                }

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

        private Visibility _editQuestionVisibility = Visibility.Collapsed;
        public Visibility EditQuestionVisibility
        {
            get
            {
                return _editQuestionVisibility;
            }
            set
            {
                _editQuestionVisibility = value;
                RaisePropertyChanged("EditQuestionVisibility");
            }
        }

        private Visibility _textQuestionVisibity = Visibility.Visible;
        public Visibility TextQuestionVisibility
        {
            get
            {
                return _textQuestionVisibity;
            }
            set
            {
                _textQuestionVisibity = value;
                RaisePropertyChanged("TextQuestionVisibility");
            }
        }
        private Visibility _sliderQuestionVisibity = Visibility.Collapsed;
        public Visibility SliderQuestionVisibility
        {
            get
            {
                return _sliderQuestionVisibity;
            }
            set
            {
                _sliderQuestionVisibity = value;
                RaisePropertyChanged("SliderQuestionVisibility");
            }
        }

        public ICommand SwitchNewQuestionVisibility { get; set; }
        public ICommand SwitchEditQuestionVisibility { get; set; }
        public ICommand SaveNewTextQuestion { get; set; }
        public ICommand SaveNewSliderQuestion { get; set; }


        public ICommand DeleteSelectedQuestion { get; set; }
        public ICommand EditSelectedItem { get; set; }


        //TODO questionnumber, make question string separate
        public MainViewModel()
        {
            textQuestion = new TextQuestionVM();
            sliderQuestion = new SliderQuestionVM();
            Questions = new ObservableCollection<Question>();

            foreach(QuestionTypes q in Enum.GetValues(typeof(QuestionTypes)))
            {
                QuestionType.Add(q);
            }


            SwitchNewQuestionVisibility = new RelayCommand(SwitchQuestionVisibility );
            SwitchEditQuestionVisibility = new RelayCommand(SwitchEditQVisibility);
            SaveNewTextQuestion = new RelayCommand(SaveTextQuestion);
            SaveNewSliderQuestion = new RelayCommand(SaveSliderQuestion);
            DeleteSelectedQuestion = new RelayCommand(DeleteQuestion);
            EditSelectedItem = new RelayCommand(EditQuestion);
        }
        private void SwitchEditQVisibility()
        {
            {
                base.RaisePropertyChanged("Questions");
                if (EditQuestionVisibility == Visibility.Collapsed)
                {
                    EditQuestionVisibility = Visibility.Visible;
                }
                else
                {
                    EditQuestionVisibility = Visibility.Collapsed;
                    textQuestion = new TextQuestionVM();
                    sliderQuestion = new SliderQuestionVM();
                    base.RaisePropertyChanged("textQuestion");
                    base.RaisePropertyChanged("sliderQuestion");
                }
            }
        }
        private void EditQuestion()
        {
            SwitchEditQVisibility();
            base.RaisePropertyChanged("Questions");
        }

        private void SaveSliderQuestion()
        {
            Questions.Add(sliderQuestion.ToModel());
            SwitchQuestionVisibility();
        }

        private void SaveTextQuestion()
        {
            Questions.Add(textQuestion.ToModel());
            SwitchQuestionVisibility();
        }

        private void SwitchQuestionVisibility()
        {
            base.RaisePropertyChanged("Questions");
            if(NewQuestionVisibility == Visibility.Collapsed)
            {
                NewQuestionVisibility = Visibility.Visible;
            }
            else
            {
                NewQuestionVisibility = Visibility.Collapsed;
                textQuestion = new TextQuestionVM();
                sliderQuestion = new SliderQuestionVM();
                base.RaisePropertyChanged("textQuestion");
                base.RaisePropertyChanged("sliderQuestion");
            }
        }
        private void DeleteQuestion()
        {
            Questions.Remove(_selectedQuestion);
            base.RaisePropertyChanged("Questions");
        }
    }
}