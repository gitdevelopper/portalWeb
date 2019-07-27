﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business.Model;
using Data;

namespace Business.Data
{
    public class DegreeData
    {
        /// <summary>
        /// Metodo que permite crear un grado
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="user"></param>
        /// <returns>Estado de la consulta true/false</returns>
        public static Boolean Crear(string Nombre,string user)
        {
            AppTecBDEntities data = new AppTecBDEntities();
            Boolean existe = false;
            var d = new Degree
            {
                Name = Nombre,
                DateTimeCreation = DateTime.Now,
                DateTimeModification = DateTime.Now,
                UserCreation = user,
                UserModification = user,
                Status = "1"
            };
            data.Degrees.Add(d);
            data.SaveChanges();

            if (d != null)
                existe = true;
            
            
            return existe;
        }

        /// <summary>
        /// metodo que permite mostrar informacion de  un grado segun su id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Lista tipo grado</returns>
        public static List<DegreeAllModel>MostrarUpdate(int Id)
        {
            AppTecBDEntities data = new AppTecBDEntities();
            var Resultado = (from degree in data.Degrees
                             where degree.DegreeID == Id
                             select new DegreeAllModel
                             {
                                 Id=degree.DegreeID,
                                 Nombre = degree.Name
                             }).ToList();
            return Resultado;
        }


        /// <summary>
        /// Metodoq ue permite actualizar un grado segun su id
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Nombre"></param>
        /// <param name="user"></param>
        /// <returns>Lista tipo id</returns>
        public static Boolean Actualizar(int Id, string Nombre,string user)
        {
            Boolean existe = false;

            AppTecBDEntities data = new AppTecBDEntities();
            var consulta = data.Degrees.First(d => d.DegreeID == Id);
            if (consulta != null)
            {
                consulta.Name = Nombre;
                consulta.DateTimeModification = DateTime.Now;
                consulta.UserModification = user;
                data.SaveChanges();
                existe = true;
            }
          
            return existe;
        }
        
        /// <summary>
        /// Metodo que permite mostrar los grados registrados
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Lista tipo grados</returns>
        public static List<DegreeAllModel> Mostrar(string user)
        {
            using (var Contexto = new AppTecBDEntities())
            {
                if (user.Equals("SuperPowerUser"))
                {
                    var Resultado = (from degree in Contexto.Degrees
                                     where degree.Status == "1"
                                     select new DegreeAllModel
                                     {
                                         Id = degree.DegreeID,
                                         Nombre = degree.Name
                                     }).ToList();
                    return Resultado;
                }
                else
                {
                    var Resultado = (from degree in Contexto.Degrees
                                     where degree.Status == "1" && degree.UserCreation.Equals(user)
                                     select new DegreeAllModel
                                     {
                                         Id = degree.DegreeID,
                                         Nombre = degree.Name
                                     }).ToList();
                    return Resultado;
                }
                
            }
        }

        /// <summary>
        /// metodo que permite eliminar un grado segun su id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Estado de la consulta true/false</returns>
        public static Boolean Eliminar(int Id)
        {
            Boolean existe = false;

            AppTecBDEntities data = new AppTecBDEntities();
            var consulta = data.Degrees.First(d => d.DegreeID == Id);
            if (consulta != null)
            {
                consulta.Status = "0";
                data.SaveChanges();
                existe = true;
            }
            return existe;
        }
    }
}
