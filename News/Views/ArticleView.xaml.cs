﻿using System.Web;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace News.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("Url", "url")]
    public partial class ArticleView : ContentPage
    {
        public string Url
        {
            set
            {
                BindingContext = new UrlWebViewSource
                {
                    Url = HttpUtility.UrlDecode(value)
                };
            }
        }

        public ArticleView()
        {
            InitializeComponent();
        }
    }
}