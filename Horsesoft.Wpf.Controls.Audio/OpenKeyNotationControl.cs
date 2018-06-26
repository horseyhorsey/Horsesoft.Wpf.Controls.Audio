using Horsesoft.Wpf.Controls.Audio.internals;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Horsesoft.Wpf.Controls.Audio
{

    public class OpenKeyNotationControl : ItemsControl
    {
        static OpenKeyNotationControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(OpenKeyNotationControl), new FrameworkPropertyMetadata(typeof(OpenKeyNotationControl)));
        }


        public OpenKeyNotationControl()
        {

        }

        public OpenKeyNotation SelectedOpenKeys
        {
            get { return (OpenKeyNotation)GetValue(SelectedOpenKeysProperty); }
            set { SetValue(SelectedOpenKeysProperty, value); }
        }

        public static readonly DependencyProperty SelectedOpenKeysProperty =
            DependencyProperty.Register("SelectedOpenKeys", typeof(OpenKeyNotation), typeof(OpenKeyNotationControl), new PropertyMetadata(OpenKeyNotation.None));

        private static bool _eventsAdded = false;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            //Hook up the check events
            if (!_eventsAdded)
            {
                var items = Items.SourceCollection.Cast<OpenKeyNotationToggleButton>();
                foreach (var item in items)
                {
                    item.Checked += Item_Checked;
                    item.Unchecked += Item_Unchecked;
                }

                _eventsAdded = true;
            }
        }

        private void Item_Checked(object sender, RoutedEventArgs e)
        {
            var button = sender as OpenKeyNotationToggleButton;
            if (button != null)
            {
                SelectedOpenKeys |= button.OpenKey;
            }
        }

        private void Item_Unchecked(object sender, RoutedEventArgs e)
        {
            var button = sender as OpenKeyNotationToggleButton;
            if (button != null)
            {
                SelectedOpenKeys -= button.OpenKey;
            }
        }
    }
}
