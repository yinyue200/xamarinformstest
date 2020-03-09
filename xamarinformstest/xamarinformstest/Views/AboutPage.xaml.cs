using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinformstest.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            var assembly = typeof(AboutPage).Assembly;
            logo.Source = ImageSource.FromStream(() =>
            {
                return assembly.GetManifestResourceStream("xamarinformstest.v2-adc33f3b65032caefd1155d4a8438564_r.jpg");
            });
        }
    }
}