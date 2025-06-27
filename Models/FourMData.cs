namespace MyAspNetApp.Models
{
    public class FourMData
    {
        public int Id { get; set; }
        public DateTime Time_Stamp { get; set; }
        public string? Pid { get; set; }
        public string? Source { get; set; }
        public string? SupplierName { get; set; }
        public string? Partcode { get; set; }
        public string? Partname { get; set; }
        public string? Description { get; set; }
        public string? ModelDescription { get; set; }
        public string? SourcingApproval { get; set; }
        public string? ManufacturingApproval { get; set; }
        public string? ProcurementApproval { get; set; }
        public string? SafetyApproval { get; set; }
        public string? RequiredApproval { get; set; }
        public string? PartDescription { get; set; }
        public string? Applicable { get; set; }
        public string? Location { get; set; }
        public string? SelectedDate { get; set; }
        public string? ChangeDetails { get; set; }
        public string? SelectedSub { get; set; }
        public string? BeforeChangeRemark { get; set; }
        public string? AfterChangeRemark { get; set; }
        public string? Initiatorid { get; set; }
        public string? Initiatormail { get; set; }
        public string? Initiatordept { get; set; }

        // Continue for all other columns like Sourcing, Manufacturing, etc.
    }
}
