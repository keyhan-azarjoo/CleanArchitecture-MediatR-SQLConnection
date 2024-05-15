using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Core.Domains;
using MediatR;

namespace Core.Queries;

public class GetLatestPostQuery : IRequest<List<Post>>
{
    public int Count { get; set; }
}

