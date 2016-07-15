using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entry_UITest.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        string _emailKeyboardEntryText, _textLabelText;

        public string EmailKeyboardEntryText
        {
            get { return _emailKeyboardEntryText; }
            set
            {
                SetProperty<string>(ref _emailKeyboardEntryText, value, "EmailKeyboardEntryText");
                SetProperty<string>(ref _textLabelText, value, "TextLabelText");
            }
        }

        public string TextLabelText
        {
            get { return _textLabelText; }
        }
    }
}
