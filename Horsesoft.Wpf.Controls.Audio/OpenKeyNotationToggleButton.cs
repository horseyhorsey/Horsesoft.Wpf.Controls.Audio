using Horsesoft.Wpf.Controls.Audio.internals;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Horsesoft.Wpf.Controls.Audio
{
    public class OpenKeyNotationToggleButton : ToggleButton
    {
        static OpenKeyNotationToggleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(OpenKeyNotationToggleButton), new FrameworkPropertyMetadata(typeof(OpenKeyNotationToggleButton)));
        }

        public string WheelImage
        {
            get { return (string)GetValue(WheelImageProperty); }
            set { SetValue(WheelImageProperty, value); }
        }

        public static readonly DependencyProperty WheelImageProperty =
            DependencyProperty.Register("WheelImage", typeof(string), typeof(OpenKeyNotationToggleButton), new PropertyMetadata(null));

        public OpenKeyNotation OpenKey
        {
            get { return (OpenKeyNotation)GetValue(OpenKeyProperty); }
            set { SetValue(OpenKeyProperty, value); }
        }

        public static readonly DependencyProperty OpenKeyProperty =
            DependencyProperty.Register("OpenKey", typeof(OpenKeyNotation), typeof(OpenKeyNotationToggleButton), new PropertyMetadata(OpenKeyNotation.None));
    }
}
