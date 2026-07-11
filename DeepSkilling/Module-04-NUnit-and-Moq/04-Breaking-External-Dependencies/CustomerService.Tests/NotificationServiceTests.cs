using Moq;
using NUnit.Framework;
using CustomerService;

namespace CustomerService.Tests;

[TestFixture]
public class NotificationServiceTests
{
    [Test]
    public void Notify_ShouldCallSendEmailOnce()
    {
        // Arrange
        var emailMock = new Mock<IEmailService>();

        var notification =
            new NotificationService(emailMock.Object);

        // Act
        notification.Notify("Bhavya");

        // Assert
        emailMock.Verify(
            x => x.SendEmail("Welcome Bhavya"),
            Times.Once);
    }
}