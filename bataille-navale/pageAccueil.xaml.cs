using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace bataille_navale
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class pageAccueil : Page
    {
        public pageAccueil()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pseudo.Text != null && !string.IsNullOrWhiteSpace(pseudo.Text))
            {
                String atransferer;
                atransferer = (String)pseudo.Text;
                Application.Current.Resources["monObjet"] = atransferer;
                Frame rootFrame = Window.Current.Content as Frame;
                Frame.Navigate(typeof(pageJeu));
            }
            else
            {
                erreur.Text = "Entrez un pseudo svp";
            }
        }
    }
}
