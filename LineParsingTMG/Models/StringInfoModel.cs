using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineParsingTMG.Models
{
    class StringInfoModel : INotifyPropertyChanged
    {
        private int _wordsQuantity;
        private int _vowelsQuantity;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int GetVowelsQuantity()
        {
            return _vowelsQuantity;
        }

        public int SetVowelsQuantity(int quantity)
        {
            _vowelsQuantity = quantity;
            return _vowelsQuantity;
        }

        public int GetWordsQuantity()
        {
            return _wordsQuantity;
        }

        public int SetWordsQuantity(int quantity)
        {
            _wordsQuantity = quantity;
            return _wordsQuantity;
        }
    }
}
