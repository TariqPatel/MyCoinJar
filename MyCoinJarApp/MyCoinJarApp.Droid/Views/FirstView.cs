using Android.App;
using Android.OS;

namespace MyCoinJarApp.Droid.Views
{
    [Activity(Label = "My Coin Jar")]
    public class FirstView : BaseView
    {
        protected override int LayoutResource => Resource.Layout.FirstView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
        }
    }
}
