﻿using MadeFyCRUD.Domain.Models;
using System.Collections.Generic;

namespace MadeFyCRUD.Infrastructure.Interfaces
{
    public interface ICategoriaRepository
    {
        List<Categoria> GetAll();
        Categoria GetById(int id);
        void Add(Categoria categoria);
        void Update(Categoria categoria);
        void Delete(int id);
    }
}
