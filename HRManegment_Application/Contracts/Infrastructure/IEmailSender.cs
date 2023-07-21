using HRManegment_Application.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;
using System.Threading.Tasks;

namespace HRManegment_Application.Contracts.Infrastructure
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(Email email); 
    }
}
