using Android.Content;
using Android.Graphics.Drawables;
using ChatApp_Collado.CustomRenderers;
using ChatApp_Collado.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntryField), typeof(CustomEntryFieldRenderer))]
namespace ChatApp_Collado.Droid.CustomRenderers
{
    class CustomEntryFieldRenderer : EntryRenderer
    {
        public CustomEntryFieldRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
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

            e.NewElement.Focused += (sender, evt) =>
            {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(20f);
                gradientDrawable.SetStroke(5, Android.Graphics.Color.Black);
                gradientDrawable.SetColor(Android.Graphics.Color.Transparent);
                Control.SetBackground(gradientDrawable);

                Control.SetPadding(20, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);
            };


        }
    }
}