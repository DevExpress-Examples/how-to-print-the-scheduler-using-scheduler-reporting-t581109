﻿namespace PrintingExample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow {
        public MainWindow() {
            InitializeComponent();
            MyPrintHelper.mainWindow = this;
        }
    }
}
