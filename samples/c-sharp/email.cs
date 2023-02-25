// Install MailKit via NuGet
// .NET Core CLI = dotnet add package MailKit
// or 
// Package Manager Console = Install-Package MailKit

// HTML Email
var email = new MimeMessage();
email.From.Add(MailboxAddress.Parse("from_address@example.com"));
email.To.Add(MailboxAddress.Parse("to_address@example.com"));
email.Subject = "Test Email Subject";
email.Body = new TextPart(TextFormat.Html) { Text = "<h1>Example HTML Message Body</h1>" };

using var smtp = new SmtpClient();
smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
smtp.Authenticate("[USERNAME]", "[PASSWORD]");
smtp.Send(email);
smtp.Disconnect(true);

// Plain Text Email

var email = new MimeMessage();
email.From.Add(MailboxAddress.Parse("from_address@example.com"));
email.To.Add(MailboxAddress.Parse("to_address@example.com"));
email.Subject = "Test Email Subject";
email.Body = new TextPart(TextFormat.Plain) { Text = "Example Plain Text Message Body" };

using var smtp = new SmtpClient();
smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
smtp.Authenticate("[USERNAME]", "[PASSWORD]");
smtp.Send(email);
smtp.Disconnect(true);

// Send From Gmail
smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

// Send From Hotmail
smtp.Connect("smtp.live.com", 587, SecureSocketOptions.StartTls);

// Send From Microsoft 365
smtp.Connect("smtp.office365.com", 587, SecureSocketOptions.StartTls);

// Send From Amazon SES
smtp.Connect("email-smtp.[AWS REGION].amazonaws.com", 587, SecureSocketOptions.StartTls);