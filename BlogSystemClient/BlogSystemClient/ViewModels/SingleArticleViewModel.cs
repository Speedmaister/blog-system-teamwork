using BlogSystemClient.Data;
using BlogSystemClient.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BlogSystemClient.ViewModels
{
    public class SingleArticleViewModel : ViewModelBase, IPageViewModel
    {
        private static int currentImageNumber = 1;
        public Article Article
        {
            get;
            set;
        }

        public SingleArticleViewModel(Article article)
        {
            this.Article = article;
            this.SaveImageToComputer();
        }

        private void SaveImageToComputer()
        {
            string savePath = @"..\..\Images\" + currentImageNumber+".jpg";
            var url = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), savePath);
            MemoryStream stream = new MemoryStream(this.Article.Images[0].Image);
            var image = Image.FromStream(stream);
            image.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            this.Article.ImageSource = url;
        }

        public string Name
        {
            get;
            set;
        }
    }
}
