using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using PaintPartner.Commands;
using PaintPartner.DataModels;

namespace PaintPartner.ViewModels
{
    public class HeaderViewModel
    {
        private readonly ICommand mySelectedItemChangedCommand;

        public List<DataLanguage> Languages { get; set; }

        public DataLanguage SelectedLanguage { get; set; }

        public ICommand SelectedItemChangedCommand => mySelectedItemChangedCommand;

        public string ProfileName { get; set; }

        public string ProfileImage { get; set; }

        public HeaderViewModel()
        {
            mySelectedItemChangedCommand = new SimpleCommand<DataLanguage>( OnSelectedItemChanged, CanExecuteSelectedItemCommandChanged );
            ProfileName = "Anjan Kumar";
            ProfileImage = "../Resources/Common/Profile.jpg";
            SelectedLanguage = new DataLanguage()
            {
                    Code = "EN",
                    Language = "English"
            };
            Languages = new List<DataLanguage>()
            {
                   SelectedLanguage
            };
        }

        private void OnSelectedItemChanged( DataLanguage selectedDataLanguage )
        {
            SelectedLanguage = selectedDataLanguage;
        }

        private bool CanExecuteSelectedItemCommandChanged( DataLanguage selectedDataLanguage )
        {
            return true;
        }
    }
}
