﻿namespace DutchTreat.Services
{
    public interface IMailService
    {
        void SendMail(string to, string message, string subject);
    }
}