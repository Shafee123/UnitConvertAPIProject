namespace UnitConverterApi.Models.Request
{
	public class ConversionRequest
	{
		public int SourceValue { get; set; }
		public int SourceUnitId { get; set; }
		public int TargetUnitId { get; set; }
	}
}
