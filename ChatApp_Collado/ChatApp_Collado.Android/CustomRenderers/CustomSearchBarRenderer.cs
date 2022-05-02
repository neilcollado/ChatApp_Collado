using Android.Content;
using Android.Graphics.Drawables;
using ChatApp_Collado.CustomRenderers;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using ChatApp_Collado.Droid.CustomRenderers;

[assembly: ExportRenderer(typeof(CustomSearchBar), typeof(CustomSearchBarRenderer))]
namespace ChatApp_Collado.Droid.CustomRenderers
{
    class CustomSearchBarRenderer : SearchBarRenderer
    {
        public CustomSearchBarRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(20f);
                gradientDrawable.SetStroke(5, Android.Graphics.Color.Black);
                gradientDrawable.SetColor(Android.Graphics.Color.Transparent);
                Control.SetBackground(gradientDrawable);

                Control.SetPadding(20, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);
            }

            var searchView = base.Control as SearchView;
            int searchIconId = Context.Resources.GetIdentifier("android:id/search_mag_icon", null, null);
            ImageView searchViewIcon = (ImageView)searchView.FindViewById<ImageView>(searchIconId);
            searchViewIcon.SetImageDrawable(null);
           
        }
    }
}