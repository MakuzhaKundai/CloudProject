namespace EventEaseBookingSystem.Models
{
    public class ErrorViewModel
{
    public string RequestId { get; set; } = string.Empty; // Default value to avoid null issues

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
}