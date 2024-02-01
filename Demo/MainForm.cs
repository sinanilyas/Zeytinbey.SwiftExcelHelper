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

		MessageBox.Show(@"File created.", @"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}

	private static IEnumerable<ExcelModel> GetData()
	{
		return new List<ExcelModel>
		{
			new() { JobTitle = "Software Engineer", FullName = "Peter Baker", TotalPayment = 200m, Age = 28 },
			new() { JobTitle = "Marketing Specialist", FullName = "Sarah Gordon", TotalPayment = 250m, Age = 35 },
			new() { JobTitle = "Financial Analyst", FullName = "John Smith", TotalPayment = 300m, Age = 42 },
			new() { JobTitle = "HR Manager", FullName = "Emma Johnson", TotalPayment = 150m, Age = 29 },
			new() { JobTitle = "Graphic Designer", FullName = "Michael Davis", TotalPayment = 500m, Age = 31 },
			new() { JobTitle = "Sales Representative", FullName = "Olivia Miller", TotalPayment = 450m, Age = 26 },
			new() { JobTitle = "Data Scientist", FullName = "David Brown", TotalPayment = 700m, Age = 38 },
			new() { JobTitle = "Project Manager", FullName = "Sophia Wilson", TotalPayment = 120m, Age = 45 },
			new() { JobTitle = "Customer Support Specialist", FullName = "Daniel Taylor", TotalPayment = 800m, Age = 32 },
			new() { JobTitle = "Product Manager", FullName = "Mia Anderson", TotalPayment = 350m, Age = 27 }
		};
	}
}