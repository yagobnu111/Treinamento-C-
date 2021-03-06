﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloresLibrary.Model;

namespace FloresLibrary.Controller
{
    public class FlorController
    {
        FloresContext contextDB = new FloresContext();

        public IQueryable<Flor> GetFlores()
        {
            return contextDB.Flores;
        }
        public void AddFlores(Flor flor)
        {
            contextDB.Flores.Add(flor);
            contextDB.SaveChanges();
        }
        public int TotalFlores()
        {
            return GetFlores().Sum(x => x.Quantidade);
        }

        public List<Flor> FloresOrdenadasPorQuantidade()
        {
            return GetFlores().OrderByDescending(x => x.Quantidade).ToList();
        }

    }
}
