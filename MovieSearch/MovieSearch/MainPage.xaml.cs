using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MovieSearch
{
    public partial class MainPage : ContentPage
    {
        Class1 apicall = new Class1();
        public MainPage()
        {
            InitializeComponent();

        }

        private void btn_pesquisar_Clicked(object sender, EventArgs e)
        {
            string url = "http://www.omdbapi.com/?s=" + lbl_filme.Text;
            
        }

        private void btn_limpar_Clicked(object sender, EventArgs e)
        {
            lbl_filme.Text = "";
        }
    }
}
