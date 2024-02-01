using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Zeytinbey.SwiftExcelHelper;

namespace Demo.Models;

internal class ExcelModel
{
	[ExcelColumn(Header = "Job Title", Width = 27)]
	public string? JobTitle { get; set; }

	[Display(Name = "Full Name")]
	[ExcelColumn(Width = 16)]
	public string? FullName { get; set; }

	[DisplayName("Total Payment")]
	[ExcelColumn(Width = 15)]
	public decimal TotalPayment { get; set; }

	public int Age { get; set; }
}