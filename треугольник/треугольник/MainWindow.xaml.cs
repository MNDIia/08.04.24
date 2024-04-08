using System;
using System.Windows;

namespace TriangleAreaCalculation
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateArea_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtSideA.Text, out double sideA) &&
                double.TryParse(txtSideB.Text, out double sideB) &&
                double.TryParse(txtSideC.Text, out double sideC))
            {
                double s = (sideA + sideB + sideC) / 2;
                double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
                txtResult.Text = "Area of the triangle: " + area.ToString();
            }
            else
            {
                txtResult.Text = "Please enter valid side lengths for the triangle.";
            }
        }
    }
}