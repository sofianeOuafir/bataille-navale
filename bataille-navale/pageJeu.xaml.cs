using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace bataille_navale
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class pageJeu : Page
    {
        Jeu monJeu;
        public pageJeu()
        {
            this.InitializeComponent();

            for (var i = 0; i < 6; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    Button unButton = new Button();
                    unButton.Width = 40;
                    unButton.Height = 40;
                    Grid.SetColumn(unButton, j);
                    Grid.SetRow(unButton, i);
                    unButton.Background = new SolidColorBrush(Colors.White);
                    unButton.BorderBrush = new SolidColorBrush(Colors.Black);
                    unButton.BorderThickness = new Thickness(1);
                    unButton.SetValue(Grid.ColumnProperty, j);
                    unButton.SetValue(Grid.RowProperty, i);
                    unButton.Click += colorButton;
                    myGrid.Children.Add(unButton);
                }
            }
            monJeu = new Jeu(6);
        }

        private void colorButton(object sender, RoutedEventArgs e)
        {
            bool touche = false;
            Button buttonClicked = (Button)sender;
            foreach(Bateau unBateau in monJeu.Bateaux)
            {
                if(buttonClicked.GetValue(Grid.RowProperty).ToString() == unBateau.Row.ToString() && buttonClicked.GetValue(Grid.ColumnProperty).ToString() == unBateau.Column.ToString())
                {
                    touche = true;
                }
            }

            if(touche)
            {
                buttonClicked.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 0, 0));
                myText.Text = "touché !";
            }
            else
            {
                buttonClicked.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 0, 255));
                myText.Text = "Coulé !";
            }
        }

    }
}
