﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication30.Client.Helpers;
using WebApplication30.Shared.Entities;

namespace WebApplication30.Client.Repository
{
    public class GenreRepository:IGenreRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/genres";
        public GenreRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task CreateGenre(Online genre)
        {
            var response = await httpService.Post(url,genre);
            if(!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }



    }
    
}
