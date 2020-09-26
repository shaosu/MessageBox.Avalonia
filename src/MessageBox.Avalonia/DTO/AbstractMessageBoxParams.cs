using Avalonia.Controls;
using Avalonia.Media.Imaging;
using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.DTO
{
    public abstract class AbstractMessageBoxParams
    {
        public Icon Icon { get; set; } = Icon.None;
        public Bitmap WindowIcon { get; set; } = null;
        public Window Window { get; set; }
        public Style Style { get; set; } = Style.None;
        public bool CanResize { get; set; } = false;
        public string ContentTitle { get; set; } = string.Empty;
        public string ContentHeader { get; set; } = null;
        public int? MaxWidth { get; set; } = null;
        public WindowStartupLocation WindowStartupLocation { get; set; } = WindowStartupLocation.Manual;
    }
}