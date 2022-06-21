﻿using System.Threading.Tasks;

namespace Email.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string body);
    }
}
