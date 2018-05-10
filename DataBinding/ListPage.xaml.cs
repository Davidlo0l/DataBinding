

namespace DataBinding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPage : ContentPage
	{
        public ListPage()
        {
            InitializeComponent();
            Paginas = new List<Page>()
            {
                new BindingList(),
                new MainPage()

            };
            this.BindingContext = this;
            list.ItemSelected += List_ItemSelected;
           
        }

        private void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                this.Navigation.PushAsync((Page)e.SelectedItem);
            }
            list.SelectedItem = null;
        }

        public List<Page> Paginas { get; set; }

      
    }
}