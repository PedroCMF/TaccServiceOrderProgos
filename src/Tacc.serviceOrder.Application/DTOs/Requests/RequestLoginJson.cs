using System;
using System.Collections.Generic;
using System.Text;

namespace Tacc.serviceOrder.Application.DTOs.Requests
{
    public class RequestLoginJson //para login no formato json
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } =  string.Empty;
    }
}
