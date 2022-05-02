using Xamarin.Forms;

namespace ChatApp_Collado.CustomRenderers
{
    public class CustomButton : Button
    {
        public static readonly BindableProperty AutoCapitalizeProperty = BindableProperty.Create(nameof(AutoCapitalization),
            typeof(bool), typeof(CustomButton), false);
        public bool AutoCapitalization
        {
            get { return (bool)GetValue(AutoCapitalizeProperty); }
            set { SetValue(AutoCapitalizeProperty, value); }
        }
    }   
}
