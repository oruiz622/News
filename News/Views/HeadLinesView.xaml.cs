using News.ViewModels;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace News.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeadLinesView : ContentPage
    {
        public HeadLinesView()
        {
            InitializeComponent();
            Task.Run(async () => await Initialize("Headlines"));
        }

        public HeadLinesView(string scope)
        {
            InitializeComponent();
            Title = $"{scope} news";
            Task.Run(async () => await Initialize(scope));
        }

        private async Task Initialize(string scope)
        {
            var viewModel = Resolver.Resolve<HeadLinesViewModel>();
            BindingContext = viewModel;
            await viewModel.Initialize(scope);
        }
    }
}