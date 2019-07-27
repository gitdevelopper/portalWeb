﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business.Model.Api;
using Data;

namespace Business.Data.Api
{
    public class PerfilData
    {
        /// <summary>
        /// Metodo que permite mostrar los datos generales del estudiante
        /// </summary>
        /// <param name="Enrollment"></param>
        /// <returns>Lista de tipo perfil</returns>
        public static List<PerfilModel> Mostrar(string Enrollment)
        {
            using (var Contexto = new AppTecBDEntities())
            {
                var Resultado = (from student in Contexto.Students
                                 join Uni in Contexto.Institutions on student.InstitutionID equals Uni.InstitutionID
                                 join Grade in Contexto.Degrees on student.DegreeId equals Grade.DegreeID
                                 join Grup in Contexto.Groups on student.GroupsID equals Grup.GroupsID
                                 where student.Enrollment.Equals(Enrollment) && student.Status == "1"
                                 select new PerfilModel
                                 {
                                     Enrollment = student.Enrollment,
                                     Name = student.Name,
                                     LastNameP = student.LastNameP,
                                     LastNameM = student.LastNameM,
                                     Grade = Grade.Name,
                                     Groups = Grup.Name,
                                     Institution = Uni.Name
                                 }).ToList();
                return Resultado;
            }
        }
    }
}