using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication30.Shared.Entities;

namespace WebApplication30.Client.Repository
{
    interface IGenreRepository
    {
        Task CreateGenre(Online genre);
    }
}
