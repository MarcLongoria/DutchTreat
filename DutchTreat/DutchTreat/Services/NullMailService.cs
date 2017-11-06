using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Services
{
    public class NullMailService : IMailService
    {
        public readonly ILogger<NullMailService> _logger;

        public NullMailService(ILogger<NullMailService> logger )
        {
            _logger = logger;
        }

        public void SendMail(string to, string message, string subject)
        {
            
        }
    }
}
