using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Media;
using System.Linq;

namespace F1vsGT3Avalonia
{
    public partial class MainWindow : Window
    {
        private MainViewModel vm;

        public MainWindow()
        {
            InitializeComponent();
            vm = new MainViewModel();
            DataContext = vm;
            SetupUI();
        }

        private void SetupUI()
        {
            var panel = this.FindControl<StackPanel>("LeftPanel");

            // Car Class
            var carClassText = new TextBlock
            {
                Text = "Select Car Class",
                Foreground = Brushes.Gold,
                FontSize = 22,
                Margin = new Avalonia.Thickness(0, 0, 0, 15),
                HorizontalAlignment = HorizontalAlignment.Center,
                TextAlignment = TextAlignment.Center
            };
            panel.Children.Add(carClassText);

            var carClassStack = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Avalonia.Thickness(0, 10, 0, 15)
            };
            panel.Children.Add(carClassStack);

            foreach (var cls in new string[] { "F1", "GT3" })
            {
                var btn = new Button
                {
                    Content = cls,
                    Width = 200,
                    Height = 65,
                    Margin = new Avalonia.Thickness(10, 0, 10, 0),
                    FontSize = 22,
                    FontWeight = FontWeight.Bold,
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    VerticalContentAlignment = VerticalAlignment.Center
                };
                btn.Click += (s, e) =>
                {
                    vm.SelectedCarClass = cls;
                    UpdateCarClassButtons(carClassStack);
                };
                carClassStack.Children.Add(btn);
            }

            UpdateCarClassButtons(carClassStack);

            // Tracks
            var trackText = new TextBlock
            {
                Text = "Select Track",
                Foreground = Brushes.Gold,
                FontSize = 22,
                Margin = new Avalonia.Thickness(0, 20, 0, 15),
                HorizontalAlignment = HorizontalAlignment.Center,
                TextAlignment = TextAlignment.Center
            };
            panel.Children.Add(trackText);

            var trackScroll = new ScrollViewer { Height = 350 };
            var trackGrid = new UniformGrid { Columns = 2, HorizontalAlignment = HorizontalAlignment.Center };
            trackScroll.Content = trackGrid;
            panel.Children.Add(trackScroll);

            foreach (var track in vm.Tracks)
            {
                var btn = new Button
                {
                    Content = track,
                    Margin = new Avalonia.Thickness(8),
                    FontSize = 18,
                    FontWeight = FontWeight.SemiBold,
                    Width = 400,  // ширше, щоб назви вміщались
                    Height = 55,
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    VerticalContentAlignment = VerticalAlignment.Center
                };
                btn.Click += (s, e) =>
                {
                    vm.SelectedTrack = track;
                    UpdateTrackButtons(trackGrid);
                };
                trackGrid.Children.Add(btn);
            }

            UpdateTrackButtons(trackGrid);

            // Compare button
            var compareBtn = new Button
            {
                Content = "Compare",
                Background = new SolidColorBrush(Color.Parse("#FF4500")),
                Foreground = Brushes.White,
                FontSize = 24,
                FontWeight = FontWeight.Bold,
                Height = 70,
                Margin = new Avalonia.Thickness(0, 30, 0, 0),
                HorizontalAlignment = HorizontalAlignment.Center,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center
            };
            compareBtn.Click += (s, e) => ShowResults();
            panel.Children.Add(compareBtn);
        }

        private void UpdateCarClassButtons(StackPanel stack)
        {
            foreach (Button btn in stack.Children)
            {
                btn.Background = vm.SelectedCarClass == (string)btn.Content ?
                    (btn.Content.ToString() == "F1" ? Brushes.Red : Brushes.DeepSkyBlue) : Brushes.Gray;
                btn.Foreground = Brushes.White;
            }
        }

        private void UpdateTrackButtons(UniformGrid grid)
        {
            foreach (Button btn in grid.Children)
            {
                btn.Background = vm.SelectedTrack == (string)btn.Content ? Brushes.OrangeRed : Brushes.DimGray;
                btn.Foreground = Brushes.White;
            }
        }

        private void ShowResults()
        {
            vm.Compare();
            this.FindControl<TextBlock>("SpeedText").Text = vm.SpeedResult;
            this.FindControl<TextBlock>("DriverText").Text = vm.DriverResult;
            this.FindControl<TextBlock>("TeamText").Text = vm.TeamResult;
            this.FindControl<TextBlock>("YearText").Text = vm.YearResult;
        }
    }
}
