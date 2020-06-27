﻿using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;


namespace Academia.Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        public UsuarioLogic()
        {

        }
        public UsuarioAdapter UsuarioData
        {
            get => default;
            set
            {
                GetAll();
            }

        }

        public UsuarioLogic(Data.Database.UsuarioAdapter u)
        {
            this.UsuarioData = u;
        }

        public List<Usuario> GetAll()
        {
            return UsuarioData.GetAll();
        }

        public Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }

        public void Save(Usuario u)
        {
            UsuarioData.Save(u);
        }

        public void Delete(int id)
        {
            UsuarioData.Delete(id);
        }
    }
}
