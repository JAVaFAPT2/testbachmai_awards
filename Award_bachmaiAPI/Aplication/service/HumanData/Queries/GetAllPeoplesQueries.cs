﻿using MediatR;
using MongoDB.Driver;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain.Models;
using System.Security.Cryptography;

namespace Aplication.service.HumanData.Queries
{
    public class GetAllPeoplesQueries : IRequest<IEnumerable<Person>>
    {
    }
}