using Android.Content;
using Android.Graphics;
using Android.Util;
using ChatApp_Collado.CustomRenderers;
using ChatApp_Collado.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomBoxView), typeof(CustomBoxViewRenderer))]
namespace ChatApp_Collado.Droid.CustomRenderers
{
    class CustomBoxViewRenderer : BoxRenderer
    {
        private float _cornerRadius;
        private RectF _bounds;
        private Path _path;
        public CustomBoxViewRenderer(Context context) : base(context)
        {
            AutoPackage = false;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);
            if (Element == null)
            {
                return;
            }
            var element = (CustomBoxView)Element;
            _cornerRadius = TypedValue.ApplyDimension(ComplexUnitType.Dip, (float)element.CornerRadius, Context.Resources.DisplayMetrics);
        }
        protected override void OnSizeChanged(int w, int h, int oldw, int oldh)
        {
            base.OnSizeChanged(w, h, oldw, oldh);
            if (w != oldw && h != oldh)
            {
                _bounds = new RectF(0, 0, w, h);
            }
            _path = new Path();
            _path.Reset();
            _path.AddRoundRect(_bounds, _cornerRadius, _cornerRadius, Path.Direction.Cw);
            _path.Close();
        }
        public override void Draw(Canvas canvas)
        {
            canvas.Save();
            canvas.ClipPath(_path);
            base.Draw(canvas);
            canvas.Restore();
        }
    }
}