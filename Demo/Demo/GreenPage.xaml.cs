using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Demo
{
    public partial class GreenPage : ContentPage
    {
        private int _index = 0;
        private string[] _quote = new string[]
        {
            "Life is like riding a bicycle. To keep your balance, you must keep moving.",
            "You can't blame gravity for falling in love.",
            "Look deep into nature, and then you will understand everything better."
        };
        public GreenPage()
        {
            InitializeComponent();
            currentQoute.Text = _quote[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quote.Length)
                _index = 0;
            currentQoute.Text = _quote[_index];
        }
    }
}
