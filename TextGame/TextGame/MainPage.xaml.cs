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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TextGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Npc npc1 = new Npc("Marcondes", "Pedreiro", 'M', true);

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btn_teste_Click(object sender, RoutedEventArgs e)
        {
            npc1.adicionarFala("Hello");

            for (int i = 0; i < npc1.Falas.Count; i++)
            {
                teste.Text += npc1.Falas[i].ToString();
            }           
        }
    }
}
