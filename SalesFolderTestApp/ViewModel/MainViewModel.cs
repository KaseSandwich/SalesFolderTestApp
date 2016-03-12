using GalaSoft.MvvmLight;

namespace SalesFolderTestApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public string WindowTitle { get; set; }

        public MainViewModel()
        {
            WindowTitle = "Sales Folder";

            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }
    }
}