using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Table
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        Picker picker;
        Editor editor;
        DatePicker dpicker;
        public Page1()
        {
            Grid gr = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition{Height =new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height =new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height =new GridLength(1,GridUnitType.Star)},
                },
                ColumnDefinitions =
                {
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                }
            };
            picker = new Picker
            {
                Title = "Keeled"
            };
            picker.Items.Add("C#");
            picker.Items.Add("Python");
            picker.Items.Add("C++");
            picker.Items.Add("VisualBasic");
            picker.Items.Add("Java");

            gr.Children.Add(picker, 0, 0);
            picker.SelectedIndexChanged += Picker_SelectedIndexChanged;

            editor = new Editor { Placeholder = "Vali keel \nnimekirjast" };
            gr.Children.Add(editor, 1, 0);

            dpicker = new DatePicker
            {
                Format = "D",
                MinimumDate = DateTime.Now.AddDays(-10),
                MaximumDate = DateTime.Now.AddDays(10),
            }; Content = gr;
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            editor.Text = "Oli valitud: " + picker.Items[picker.SelectedIndex];
        }
    }
}
