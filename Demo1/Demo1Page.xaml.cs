using Xamarin.Forms;
using Demo1.ViewModels;
namespace Demo1
{
    public partial class Demo1Page : ContentPage
    {
        public Demo1Page()
        {
            InitializeComponent();
            this.BindingContext = new DemoViewModel();

            this.EntryTel.Text = "zhangsan";
            //this.EntryTel.BackgroundColor = Color.Accent;
        }

    }
}
