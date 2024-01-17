using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace WinStyles
{
    public class WindowStyleDP
    {
        #region BackgroundCaption цвет фона заголовка окна
        public static readonly DependencyProperty BackgroundCaptionProperty =
            DependencyProperty.RegisterAttached(
                nameof(GetBackgroundCaption)[3..],
                typeof(SolidColorBrush),
                typeof(WindowStyleDP),
                new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#293955"))));

        public static SolidColorBrush GetBackgroundCaption(UIElement element) => (SolidColorBrush)element.GetValue(BackgroundCaptionProperty);

        public static void SetBackgroundCaption(UIElement element, SolidColorBrush value) => element.SetValue(BackgroundCaptionProperty, value);
        #endregion
    }
}