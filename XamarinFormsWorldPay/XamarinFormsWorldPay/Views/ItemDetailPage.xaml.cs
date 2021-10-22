using System.ComponentModel;
using Xamarin.Forms;
using XamarinFormsWorldPay.ViewModels;

namespace XamarinFormsWorldPay.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}