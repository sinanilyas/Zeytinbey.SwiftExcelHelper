using Zeytinbey.SwiftExcelHelper;

namespace Demo.Models;

internal class ExcelModel
{
	[ExcelColumn(Header = "Full Name", Width = 20)]
	public string? FullName { get; set; }

	[ExcelColumn(Header = "Total Payment", Width = 15)]
	public decimal TotalPayment { get; set; }
}