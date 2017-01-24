using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Slate
{
    public partial class SlatePage : ContentPage
    {
        public SlatePage()
        {
            InitializeComponent();

            Device.OnPlatform(
                iOS: new Thickness(0, 20, 0, 0),
                Android: new Thickness(0, 0, 0, 0),
                WinPhone: new Thickness(0, 0, 0, 0)
                );
        }
    }
}
