﻿using AutoMapper;
using NGAccounts.Api.ViewModels;
using NGAccounts.Models;
using System.Collections.Generic; 

namespace NGAccounts.Api
{
    public class Mapping: IMapping
    {
        public MapperConfiguration GetMap<T1, T2>()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<T1, T2>();
            });
            return config;
        }

        public IMapper GetMapper<T1, T2>()
        {
            var config = new MapperConfiguration(cfg =>
            { 
                cfg.CreateMap<T1, T2>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        }
         
        public T2 GetSingleMapper<T1, T2>(T1 source)
        //where T2 : new()
        {
            T2 result;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<T1, T2>();
            });
            var mapper = config.CreateMapper();
            result = mapper.Map<T1, T2>(source);

            return result;
        }

        public IEnumerable<T2> GetMultiMapper<T1, T2>(IEnumerable<T1> source)
        //where T2 : new()
        {
            IEnumerable<T2> result;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<T1, T2>();
            });
            var mapper = config.CreateMapper();
            result = mapper.Map<IEnumerable<T1>, IEnumerable<T2>>(source);

            return result;
        }
    }

   
}
