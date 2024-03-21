using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TimeLineTool;

namespace WPF_test
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		ObservableCollection<ITimeLineDataItem> data = new ObservableCollection<ITimeLineDataItem>();
		public ObservableCollection<ITimeLineDataItem> t2Data = new ObservableCollection<ITimeLineDataItem>();
		public ObservableCollection<ITimeLineDataItem> t3Data = new ObservableCollection<ITimeLineDataItem>();
		public ObservableCollection<ITimeLineDataItem> t4Data = new ObservableCollection<ITimeLineDataItem>();
		public ObservableCollection<ITimeLineDataItem> t5Data = new ObservableCollection<ITimeLineDataItem>();
		ObservableCollection<ITimeLineDataItem> listboxData = new ObservableCollection<ITimeLineDataItem>();
		public MainWindow()
		{
			InitializeComponent();
			var tmp1 = new TempDataType()
			{
				StartTime = DateTime.Now.AddHours(3),
				EndTime = DateTime.Now.AddHours(18),
				TimelineViewExpanded = false,
				PUL = "901",
				SF = "1089",
				Color = Brushes.DarkBlue
			};
			var tmp2 = new TempDataType()
			{
				StartTime = DateTime.Now.AddHours(18),
				TimelineViewExpanded = true,
				EndTime = DateTime.Now.AddHours(33),
				PUL = "350",
				SF = "8975",
				Color = Brushes.DarkBlue
			};
			var temp3 = new TempDataType()
			{
				StartTime = DateTime.Now.AddHours(44),
				TimelineViewExpanded = true,
				EndTime = DateTime.Now.AddHours(60),
				PUL = "1057",
				SF = "336",
				Color = Brushes.DarkBlue
			};
			var temp4 = new TempDataType()
			{
				StartTime = DateTime.Now.AddHours(60),
				TimelineViewExpanded = false,
				EndTime = DateTime.Now.AddHours(70),
				PUL = "1056",
				SF = "436",
				Color = Brushes.DarkBlue
			};

			data.Add(tmp1);
			data.Add(tmp2);
			data.Add(temp3);
			data.Add(temp4);

			t2Data.Add(tmp1);
			t3Data.Add(tmp2);
			t4Data.Add(temp3);
			t5Data.Add(temp4);

			//TimeLine2.Items = data;
			TimeLine2.StartDate = DateTime.Now;
			TimeLine2.Items = t2Data;

			TimeLine3.StartDate = DateTime.Now;
			TimeLine3.Items = t3Data;

			TimeLine4.StartDate = DateTime.Now;
			TimeLine4.Items = t4Data;

			TimeLine5.StartDate = DateTime.Now;
			TimeLine5.Items = t5Data;

			//var lb1 = new TempDataType()
			//{
			//	Name = "ListBox 1"
			//};
			//var lb2 = new TempDataType()
			//{
			//	Name = "ListBox 2"
			//};
			//var lb3 = new TempDataType()
			//{
			//	Name = "ListBox 3"
			//};
			//var lb4 = new TempDataType()
			//{
			//	Name = "ListBox 4"
			//};
			
			//listboxData.Add(lb1);
			//listboxData.Add(lb2);
			//listboxData.Add(lb3);
			//listboxData.Add(lb4);

			//ListSrc.ItemsSource = listboxData;
		}


		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
		}

		private void Slider_Scale_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			TimeLine2.UnitSize = Slider_Scale.Value;
			TimeLine3.UnitSize = Slider_Scale.Value;
			TimeLine4.UnitSize = Slider_Scale.Value;
			TimeLine5.UnitSize = Slider_Scale.Value;
		}

	}
}