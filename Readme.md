# Zeytinbey.SwiftExcelHelper

## About

Zeytinbey.SwiftExcelHelper is an easy-to-use package that streamlines SwiftExcel tasks. Create Excel files effortlessly with handy helper classes and extension methods, making your workflow simpler and more efficient.

## Usage

### Create Model Class

```c#
public class ExcelModel()
{
	[ExcelColumn(Header = "Full Name", Width = 20)]
	public string? FullName { get; set; }

	[ExcelColumn(Header = "Total Payment", Width = 15)]
	public decimal TotalPayment { get; set; }
}
```

### Get Data

```c#
var data = new List<ExcelModel>{
	// Populate data
}
```

### Create Excel File

```c#
SwiftExcelHelper.WriteEnumerable(data, @"C:\File.xslx", "Sheet Name");
```

## Dependencies

SwiftExcel (>= 1.1.3) 

## Legal Information and Credits

Written by [Sinan İLYAS](https://www.sinanilyas.com). It's licensed under [MIT](https://licenses.nuget.org/MIT).