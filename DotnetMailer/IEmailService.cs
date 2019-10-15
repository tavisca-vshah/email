using DotnetMailer.Models;
using System.Collections.Generic;

namespace DotnetMailer
{
    public interface IEmailService
    {
        void Send(EmailMessage emailMessage);
    }
}