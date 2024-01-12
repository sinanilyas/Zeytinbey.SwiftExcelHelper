using SwiftExcel;
using System.Globalization;

namespace Zeytinbey.SwiftExcelHelper;

public static class ExcelWriterExtensions
{
	public static void WriteEnumerable<T>(this ExcelWriter excelWriter, IEnumerable<T> data) where T : class
	{
		var properties = typeof(T).GetProperties();
		var headers = properties.Select(propertyInfo =>
		{
			var attribute = propertyInfo.GetCustomAttributes(typeof(ExcelColumnAttribute), true).FirstOrDefault();
			return attribute is ExcelColumnAttribute excelColumnAttribute
				? excelColumnAttribute.Header
				: propertyInfo.Name;
		});

		var column = 1;
		foreach (var header in headers)  excelWriter.Write(header, column++, 1);

		var row = 2;
		column = 1;

		foreach (var item in data)
		{
			foreach (var propertyInfo in properties)
			{
				var value = propertyInfo.GetValue(item);
				var dataType = value is sbyte or byte or short or ushort or int or uint or long or ulong or float or double or decimal
					? DataType.Number
					: DataType.Text;
				var valueString = Convert.ToString(value, CultureInfo.InvariantCulture) ?? string.Empty;
				excelWriter.Write(valueString, column++, row, dataType);
			}

			row++;
			column = 1;
		}
	}
}