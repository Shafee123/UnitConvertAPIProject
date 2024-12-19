using System.ComponentModel.DataAnnotations;

namespace UnitConverterApi.Models
{
    public class UnitCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Unit> Units { get; set; }
    }

    public class Unit
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int UnitCategoryId { get; set; }
        public UnitCategory UnitCategory { get; set; }
    }

    public class ConversionRate
    {
        [Key]
        public int Id { get; set; }
        public int FromUnitId { get; set; }
        public int ToUnitId { get; set; }
        public double Rate { get; set; }
    }

    public class ConversionHistory
    {
        [Key]
        public int Id { get; set; }
        public double FromValue { get; set; }
        public int FromUnitId { get; set; }
        public int ToUnitId { get; set; }
        public double ToValue { get; set; }
        public DateTime ConversionDate { get; set; }
    }
}
