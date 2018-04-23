using System.Windows;
using DevExpress.Xpf.Map;
using System;

namespace LocationAnimation {

    public partial class MainWindow : Window {
        Random rand = new Random((int)DateTime.Now.Ticks);

        public MainWindow() {
            InitializeComponent();
            SelectRandomLocation();
        }

        private void PushpinLocationAnimation_Completed(object sender, EventArgs e) {
            SelectRandomLocation();
        }

        void SelectRandomLocation() {
            pushpin.Location = (new GeoPoint(rand.NextDouble() * 40, rand.NextDouble() * 40));
        }
    }
}
