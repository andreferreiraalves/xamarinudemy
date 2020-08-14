using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppQuantidade
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PlusButton_Clicked(object sender, EventArgs e)
        {
            lblQtd.Text = (int.Parse(lblQtd.Text) + 1).ToString();
        }

        private void DownButton_Clicked(object sender, EventArgs e)
        {
            var qtd = int.Parse(lblQtd.Text);

            if (qtd > 0)
                lblQtd.Text = (qtd- 1).ToString();
        }
    }
}
