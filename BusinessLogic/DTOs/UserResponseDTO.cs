using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class UserResponseDTO
    {
        public bool IsSuccesfulRegistration { get; set; }
        public IEnumerable<string>? Errors { get; set; }
    }
}
