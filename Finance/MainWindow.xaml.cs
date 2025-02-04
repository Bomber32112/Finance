using System.Collections.ObjectModel;
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

namespace Finance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IncomeCategory incomeCategory = new IncomeCategory();
        public MainWindow()
        {
            InitializeComponent();
            NewCategory newCategory = new NewCategory();
            
            DataContext = this;
            newCategory.Close();
        }
    }
    public class Category 
    {
        public string Title { get; set; }
    }
    public class IncomeCategory : Category 
    {
       public ObservableCollection<SomeIncome> Incomes { get; set; } = new();
    }
    public class SomeIncome 
    {
        public string Name { get; set; }

    }
}