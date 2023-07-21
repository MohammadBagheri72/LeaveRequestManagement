using HRManegment_Application.Contracts.Infrastructure;
using HRManegment_Application.Models;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HRManegment_Infrastructure.Mail
{
    public class EmailSender : IEmailSender
    {
        private EmailSetting _emailSetting;
        public EmailSender(IOptions<EmailSetting> options)
        {
            _emailSetting= options.Value;
        }
        public async Task<bool> SendEmail(Email email)
        {
            var client = new SendGridClient(_emailSetting.ApiKey);
            var to = new EmailAddress(email.To);
            var from = new EmailAddress()
            {
                Email=_emailSetting.FromAddress,
                Name=_emailSetting.FromName
            };
            var message = MailHelper.CreateSingleEmail(from, to, email.Subject, email.Body, email.Body);

            var response = await client.SendEmailAsync(message);

            bool result = false;
            if(response.StatusCode==HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted)
            {
                result = true;
            }

            return result;

        }
    }
}
