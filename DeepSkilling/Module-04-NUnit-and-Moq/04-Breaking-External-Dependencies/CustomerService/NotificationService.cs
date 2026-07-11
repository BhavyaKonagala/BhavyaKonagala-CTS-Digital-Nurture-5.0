namespace CustomerService;

public class NotificationService
{
    private readonly IEmailService emailService;

    public NotificationService(IEmailService emailService)
    {
        this.emailService = emailService;
    }

    public void Notify(string user)
    {
        emailService.SendEmail($"Welcome {user}");
    }
}