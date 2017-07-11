using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SQLBasicUwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        SampleServiceReference.SampleTableServiceClient sampleTable;
        ObservableCollection<SampleServiceReference.SampleTable> sampleList;

        public async void LoadData()
        {
            sampleTable = new SampleServiceReference.SampleTableServiceClient();
            sampleList = new ObservableCollection<SampleServiceReference.SampleTable>();

            foreach (var item in await sampleTable.GetSampleDataAsync())
                sampleList.Add(item);

        }

        public MainPage()
        {
            this.InitializeComponent();
            LoadData();
        }

        private async void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e.ClickedItem as SampleServiceReference.SampleTable;

            var returnValue = await sampleTable.DeleteSampleDataAsync(item);

            if (returnValue != null)
                sampleList.Remove(sampleList.Where(i => i.Id == returnValue.Id).Single());
        }

        private async void Submit_Click(object sender, RoutedEventArgs e)
        {
            var returnValue = await sampleTable.InsertSampleDataAsync(new SampleServiceReference.SampleTable
            {
                FirstName = FirstName.Text,
                LastName = LastName.Text
            });

            if (returnValue != null)
                sampleList.Add(returnValue);
        }
    }
}
