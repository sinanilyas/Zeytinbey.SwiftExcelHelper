using Demo.Models;
using Zeytinbey.SwiftExcelHelper;

namespace Demo;

public partial class MainForm : Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	private void CreateButton_Click(object sender, EventArgs e)
	{
		var data = GetData();
		var file = @$"{Application.StartupPath}\Payments.xlsx";
		
		SwiftExcelHelper.WriteEnumerable(data, file, "Total Payments");

		MessageBox.Show("File created.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}

	private static IEnumerable<ExcelModel> GetData()
	{
		return new List<ExcelModel>
		{
			new() { FullName = "Peter Baker", TotalPayment = 200m },
			new() { FullName = "Sarah Gordon", TotalPayment = 250m },
			new() { FullName = "John Smith", TotalPayment = 300m },
			new() { FullName = "Emma Johnson", TotalPayment = 150m },
			new() { FullName = "Michael Davis", TotalPayment = 500m },
			new() { FullName = "Olivia Miller", TotalPayment = 450m },
			new() { FullName = "David Brown", TotalPayment = 700m },
			new() { FullName = "Sophia Wilson", TotalPayment = 120m },
			new() { FullName = "Daniel Taylor", TotalPayment = 800m },
			new() { FullName = "Mia Anderson", TotalPayment = 350m }
		};
	}
}