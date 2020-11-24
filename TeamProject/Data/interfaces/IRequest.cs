using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.Models;

namespace TeamProject.Data.interfaces
{
    interface IRequest
    {
        IEnumerable<Request> Requests { get; }
        Request getObjectRequest(int requestId);
    }
}
