using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace JamCalculator
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]

    public class MainActivity : AppCompatActivity
    {
        private TextView txtNum1;
        private TextView txtNum2;

        private double Num1;
        private double Num2;
        private double Result;

        private Button btnPlus;
        private Button btnMinus;
        private Button btnMul;
        private Button btnDivide;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            IntializeControls();


            //  Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            // SetSupportActionBar(toolbar);

            //  FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            //fab.Click += FabOnClick;
        }

       
       
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View)sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }


        void IntializeControls()
        {
            btnPlus = FindViewById<Button>
                (Resource.Id.btnplus);
            btnMinus = FindViewById<Button>
               (Resource.Id.btnminus);
            btnMul = FindViewById<Button>
               (Resource.Id.btnmul);
            btnDivide = FindViewById<Button>
               (Resource.Id.btnDivide);
            txtNum1 = FindViewById<TextView>(Resource.Id.txtNum1);
           txtNum2 = FindViewById<TextView>
               (Resource.Id.txtNum2);
            btnPlus.Click += onBtnPlus_Click;
            btnMinus.Click += onBtnMinus_Click;
            btnMul.Click += onBtnMul_Click;
            btnDivide.Click += onBtnDivide_Click;


        }
       
        private void onBtnDivide_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(txtNum1.Text);
            Num2 = Convert.ToDouble(txtNum2.Text);
            Result = Num1 / Num2;//* for multipication
            string result = (Num1 + "divide by" + Num2 + " = " + Result).ToString();
            Toast.MakeText(this, "This Result is" + result, ToastLength.Long).Show();
        }

        private void onBtnMul_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(txtNum1.Text);
            Num2 = Convert.ToDouble(txtNum2.Text);
            Result = Num1 * Num2;//* for multipication
            string result = (Num1 + "Mul by" + Num2 + " = " + Result).ToString();
            Toast.MakeText(this, "This Result is" + result, ToastLength.Long).Show();
        }

        private void onBtnMinus_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void onBtnPlus_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
