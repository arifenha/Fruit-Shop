using FreshFruit.Controller;
using FreshFruit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller huda;
        public MainWindow()
        {
            InitializeComponent();

            Bucket KeranjangBuah = new Bucket(2);
            BucketController bucketController = new BucketController(KeranjangBuah, this);

            huda = new Seller("Huda", bucketController);

            listBoxBucket.ItemsSource = KeranjangBuah.findAll();
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }

        public void onSucceed(string message)
        {
            listBoxBucket.Items.Refresh();
        }

        private void OnButtonAddAnggurCliked(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            huda.addFruit(anggur);

            listBoxBucket.Items.Refresh();
        }

        private void OnButtonAddAppleCliked(object sender, RoutedEventArgs e)
        {
            Fruit apple = new Fruit("Apple");
            huda.addFruit(apple);

            listBoxBucket.Items.Refresh();
        }

        private void OnButtonAddBananaCliked(object sender, RoutedEventArgs e)
        {
            Fruit banana = new Fruit("Banana");
            huda.addFruit(banana);

            listBoxBucket.Items.Refresh();
        }

        private void OnButtonAddOrangeCliked(object sender, RoutedEventArgs e)
        {
            Fruit orange = new Fruit("Orange");
            huda.addFruit(orange);

            listBoxBucket.Items.Refresh();
        }
    }
}
