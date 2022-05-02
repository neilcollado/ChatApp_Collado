using Android.App;
using Android.Content;
using AndroidX.AppCompat.App;
using System.Threading.Tasks;

namespace ChatApp_Collado.Droid
{
    [Activity(Label = "ChatApp_Collado", Icon = "@mipmap/Fast_Logo", Theme = "@style/splashscreen", MainLauncher = true, NoHistory = true)]
    class SplashActivity : AppCompatActivity
    {
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }

        async void SimulateStartup()
        {
            await Task.Delay(1000); 
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}