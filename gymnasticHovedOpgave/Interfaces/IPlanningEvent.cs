namespace gymnasticHovedOpgave.Interfaces
{
    public class PlanningEvent
    {
        public int Id { get; set; }
        public int CreatorId { get; set; }
        public string Name { get; set; }
        public int TeamId { get; set; }
        public List<int> InstructorsId { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public int VenueId { get; set; }
    }

}
