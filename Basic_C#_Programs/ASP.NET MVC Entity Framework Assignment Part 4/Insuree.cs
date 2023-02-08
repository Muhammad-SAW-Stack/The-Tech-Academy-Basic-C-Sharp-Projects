namespace Insurance.Controllers
{
    public class Insuree
    {
        public int Age { get; internal set; }
        public int CarYear { get; internal set; }
        public string CarMake { get; internal set; }
        public string CarModel { get; internal set; }
        public int SpeedingTickets { get; internal set; }
        public bool DUI { get; internal set; }
        public bool FullCoverage { get; internal set; }
    }
}