namespace Zeytinbey.SwiftExcelHelper;

[AttributeUsage(AttributeTargets.Property)]
public class ExcelColumnAttribute : System.Attribute
{
	public string? Header { get; set; }

	public double Width { get; set; }
}