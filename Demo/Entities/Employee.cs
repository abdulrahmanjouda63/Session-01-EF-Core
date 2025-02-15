using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    // EF Core Supports 4 Ways for Mapping Classes in Database : [Table, View, Function]
    // 1. By Convention [Default Behavior]
    // 2. By Data Annotation [Set of Attributes Used For Data Validation]
    // 3. By Fluent APIs
    // 4. By Class Configuration

    // Entity
    // POCO : (Plain Old CLR Object)
    //internal class Employee // Table
    //{
    //    public int Id { get; set; } // Public Numeric Property Named 'Id' | EmployeeId
    //    public string Name { get; set; } // Reference Type : Required [Not Allow Null] - nvarchar(max)
    //    public int Age { get; set; } // Value Type : int[Age] - Optional - [Allow Null]
    //    public double Salary { get; set; } // value Type : float[Salary] - Required
    //    public string Email { get; set; } // nvarchar(max) - optional
    //    public DateTime DateOfCreation { get; set; } // datetime2 - Required
    //}

    //// Data Annotation

    //[Table("Hamda", Schema = "dbo")]
    //internal class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int EmpId { get; set; }

    //    [Required]
    //    [Column("EmpName", TypeName = "varchar")]
    //    [MaxLength(50)]
    //    [StringLength(50, MinimumLength = 10)]
    //    public string? Name { get; set; }

    //    [Range(20, 60)]
    //    public int? Age { get; set; }

    //    [EmailAddress]
    //    public string Email { get; set; } // example@example.com

    //    [Phone]
    //    [DataType(DataType.PhoneNumber)]
    //    public string PhoneNumber { get; set; }

    //    [Column(TypeName = "money")]
    //    [DataType(DataType.Currency)]
    //    public double Salary { get; set; }

    //    [NotMapped]
    //    public double TotalSalary { get; set; }

    //    public string Password { get; set; }

    //}

    class Employee
    {
        public string EmpId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public DateTime DateOfCreation { get; set; }
    }

}
