using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

public class SmsService
{
    public void SendSms(string toPhoneNumber, string body)
    {
        string accountSid = "YourTwilioAccountSID";
        string authToken = "YourTwilioAuthToken";
        string fromPhoneNumber = "YourTwilioPhoneNumber";

        TwilioClient.Init(accountSid, authToken);

        var message = MessageResource.Create(
            body: body,
            from: new PhoneNumber(fromPhoneNumber),
            to: new PhoneNumber(toPhoneNumber)
        );

        Console.WriteLine($"Sent message: {message.Sid}");
    }
}
public class SmsService : ISmsService
{
    public async Task SendSmsAsync(string phoneNumber, string message)
    {
        // Logic to send SMS using a service like Twilio
        await Task.CompletedTask;
    }
}

