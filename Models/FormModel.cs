namespace MyAspNetApp.Models
{
    public class FormModel
    {
        public int Id { get; set; }  // Primary Key
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Remarks { get; set; }
    }
}