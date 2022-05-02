using Xamarin.Forms;

namespace ChatApp_Collado.CustomRenderers
{
    public class CustomBoxView : BoxView
    {
        public static new readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(nameof(CornerRadius), 
            typeof(double), typeof(CustomBoxView), 0.0);
        public new double CornerRadius
        {
            get{ return (double)GetValue(CornerRadiusProperty); }
            set{ SetValue(CornerRadiusProperty, value); }
        }
    }
}
