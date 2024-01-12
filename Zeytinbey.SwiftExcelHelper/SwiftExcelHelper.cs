using SwiftExcel;

namespace Zeytinbey.SwiftExcelHelper;

public static class SwiftExcelHelper
{
	public static void WriteEnumerable<T>(IEnumerable<T> data, string file, string sheetName = "Sheet1") where T : class
	{
		var sheet = new Sheet
		{
			Name = sheetName,
			ColumnsWidth = GetColumnWidths(typeof(T)).ToList()
		};

		using var ew = new ExcelWriter(file, sheet);
		ew.WriteEnumerable(data);
	}

	private static IEnumerable<double> GetColumnWidths(Type type)
	{
		const double defaultWidth = 8.43;
		return type.GetProperties().Select(x =>
		{
			var attribute = x.GetCustomAttributes(typeof(ExcelColumnAttribute), true).FirstOrDefault();
			return attribute is ExcelColumnAttribute excelColumnAttribute
				? excelColumnAttribute.Width
				: defaultWidth;
		});
	}
}