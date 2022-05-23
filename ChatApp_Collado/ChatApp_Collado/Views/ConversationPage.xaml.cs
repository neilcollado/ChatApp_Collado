using ChatApp_Collado.Models;
using ChatApp_Collado.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp_Collado.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConversationPage : ContentPage
    {
        public ConversationPage(User user, User current_user)
        {
            InitializeComponent();
            this.BindingContext = new ConversationPageViewModel(user);
        }

        private async void CloseConversation(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}