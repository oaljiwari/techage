using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechAge.Common;
using Windows.UI.Xaml.Media;

namespace TechAge.DataModel
{
    public class FakeItem : BindableBase
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ImageSource Image { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
