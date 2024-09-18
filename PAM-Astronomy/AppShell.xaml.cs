namespace PAM_Astronomy;
using PAM_Astronomy.Views;
using PAM_Astronomy.Services;
using PAM_Astronomy.Models;

 public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent(); 
            Routing.RegisterRoute("astronomicalbodydetails", typeof(AstronomicalBodyView));

        }
    }

