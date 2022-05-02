using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Text.RegularExpressions;
using ChatApp_Collado.Models;

namespace ChatApp_Collado.ViewModels
{
    class CreateAccountPageViewModel : BindableObject, CustomAlertMessage
    {

        public CreateAccountPageViewModel()
        {
            ToggleShowHide = new Command(ShowHide);
            ToggleShowHide1 = new Command(ShowHide1);
            ToggleSignupVerify = new Command(SignupVerify);
            ToggleRedirectToSignup = new Command(RedirectToSignup);
        }

        public static string Message = "Show";
        public static string Message1 = "Show";
        public bool isHide = true;
        public bool isHide1 = true;
        readonly Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        public ICommand ToggleShowHide { get; }
        public ICommand ToggleShowHide1 { get; }
        public ICommand ToggleSignupVerify { get; }
        public ICommand ToggleRedirectToSignup { get; }

        private static string Username = "";
        private static string Email = "";
        private static string Pass = "";
        private static string CPass = "";

        public string UsernameEntry { get => Username; set { Username = value; OnPropertyChanged(); } }
        public string EmailEntry { get => Email; set { Email = value; OnPropertyChanged(); } }
        public string PassEntry { get => Pass; set { Pass = value; OnPropertyChanged(); } }
        public string CPassEntry { get => CPass; set { CPass = value; OnPropertyChanged(); } }

        public async void SignupVerify()
        {
            if (!HasError())
            {
                if (ValidateEmail())
                {
                    if (PasswordMatch())
                    {
                        await ShowAsync("Success", "Sign up successful. Verification email sent");
                        await Application.Current.MainPage.Navigation.PopAsync();
                    }
                    else
                    {
                        await ShowAsync("Error", "Password does not match");
                    }
                }
                else
                {
                    await ShowAsync("Error", "Email is Invalid");
                }
            }
            else
            {
                await ShowAsync("Error", "Missing fields");
            }
        }

        public async void RedirectToSignup()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        private bool HasError()
        {
            return string.IsNullOrWhiteSpace(EmailEntry) || string.IsNullOrWhiteSpace(UsernameEntry) || string.IsNullOrWhiteSpace(PassEntry) || string.IsNullOrWhiteSpace(CPassEntry);
        }

        private bool ValidateEmail()
        {
            return EmailRegex.IsMatch(EmailEntry);
        }

        private bool PasswordMatch()
        {
            return string.Compare(PassEntry, CPassEntry) == 0;
        }

        public async Task ShowAsync(string title, string message)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, "OKAY");
        }

        /* Toggle Show/Hide Code */
        public bool HidePassword
        {
            get => isHide;
            set
            {
                if (value != isHide)
                {
                    isHide = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool HidePassword1
        {
            get => isHide1;
            set
            {
                if (value != isHide1)
                {
                    isHide1 = value;
                    OnPropertyChanged();
                }
            }
        }

        public string ShowHidePass
        {
            get => Message;
            set
            {
                if (value == Message)
                    return;
                Message = value;
                OnPropertyChanged();
            }
        }

        public string ShowHidePass1
        {
            get => Message1;
            set
            {
                if (value == Message1)
                    return;
                Message1 = value;
                OnPropertyChanged();
            }
        }

        public void ShowHide()
        {
            ShowHidePass = HidePassword ? "Hide" : "Show";
            HidePassword = !HidePassword;
        }
        public void ShowHide1()
        {
            ShowHidePass1 = HidePassword1 ? "Hide" : "Show";
            HidePassword1 = !HidePassword1;

        }

    }
}
