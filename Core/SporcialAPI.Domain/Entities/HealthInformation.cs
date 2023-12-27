namespace SporcialAPI.Domain.Entities
{
    public class HealthInformation
    {
        public Guid HealthInformationId { get; set; }
        public float BMI { get; set; }
        public int StepCount { get; set; }
        public int ScreenTime { get; set; }
    }
}
