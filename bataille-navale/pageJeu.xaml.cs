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
using Windows.UI.Xaml.Shapes;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace bataille_navale
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class pageJeu : Page
    {
        public pageJeu()
        {
            this.InitializeComponent();

            for (var i = 0; i < 6; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    Rectangle unRectangle = new Rectangle();
                    unRectangle.Width = 40;
                    unRectangle.Height = 40;
                    unRectangle.Stroke = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 0, 0));
                    unRectangle.StrokeThickness = 1; 

                    Grid.SetRow(unRectangle, i);
                    Grid.SetColumn(unRectangle, j);
                    myGrid.Children.Add(unRectangle);
                }
            }
        }
    }
}
