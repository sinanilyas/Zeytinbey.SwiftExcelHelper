# Zeytinbey.SwiftExcelHelper

## About

Zeytinbey.SwiftExcelHelper is an easy-to-use package that streamlines SwiftExcel tasks. Create Excel files effortlessly with handy helper classes and extension methods, making your workflow simpler and more efficient.

## Usage

### Create Model Class

```c#
public class ExcelModel()
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
```

### Get Data

```c#
var data = new List<ExcelModel>
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
```

### Create Excel File

```c#
SwiftExcelHelper.WriteEnumerable(data, @"C:\File.xslx", "Sheet Name");
```

## Dependencies

SwiftExcel (>= 1.1.3) 

## Legal Information and Credits

Written by [Sinan İLYAS](https://www.sinanilyas.com). It's licensed under [MIT](https://licenses.nuget.org/MIT).