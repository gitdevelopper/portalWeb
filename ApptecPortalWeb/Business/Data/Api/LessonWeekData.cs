﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business.Model.Api;
using Data;

namespace Business.Data.Api
{
    public class LessonWeekData
    {
        /// <summary>
        /// Metodo que permite obtener el horario de un estudiante semanal
        /// </summary>
        /// <param name="Enrollment"></param>
        /// <param name="dia"></param>
        /// <returns>Lista de tipo horario semanal</returns>
        public static List<LessonWeekModel> Week(string Enrollment)
        {
            using (var Contexto = new AppTecBDEntities())
            {

                var Resultado = (from student in Contexto.Students

                                 join degree in Contexto.Degrees on student.DegreeId equals degree.DegreeID
                                 join DegSubj in Contexto.DegreeSubjects on degree.DegreeID equals DegSubj.DegreeID
                                 join Subj in Contexto.Subjects on DegSubj.SubjectsID equals Subj.SubjectsID
                                 join less in Contexto.Lessons on Subj.SubjectsID equals less.SubjectsID
                                 join groups in Contexto.Groups on student.GroupsID equals groups.GroupsID
                                 join emplo in Contexto.Employers on less.EmployersID equals emplo.EmployersID
                                 join Clsroom in Contexto.Classrooms on less.ClassroomID equals Clsroom.ClassroomID
                                 where student.Enrollment.Equals(Enrollment) && student.Status.Equals("True")
                                 select new LessonWeekModel
                                 {
                                     Enrollment = student.Enrollment,
                                     StudenName = student.Name,
                                     StudenFirstNP = student.LastNameP,
                                     StudenLastNM = student.LastNameM,
                                     Grade = degree.Name,
                                     SubjectsKey = Subj.Clave,
                                     SubjectsName = Subj.Name,
                                     Days = less.Days,
                                     HoursStart = less.HousStart,
                                     HoursFinished = less.HourFinish,
                                     Grou = groups.Name,
                                     EmplyerName = emplo.Name,
                                     EmplyerFirstNP = emplo.LastNameP,
                                     EmplyerFirstNM = emplo.LastNameM,
                                     Clssroom = Clsroom.Name


                                 }).ToList();



                return Resultado;
            }


        }

        /// <summary>
        /// Metodo que permite obtener el horario de un estudiante por dia especifico
        /// </summary>
        /// <param name="Enrollment"></param>
        /// <param name="dia"></param>
        /// <returns>Lista de tipo horario semanal</returns>
        public static List<LessonDayModel> Days(string Enrollment)
        {
            string dia;
            
            var day = DateTime.Now.DayOfWeek.ToString();

            if (day == "Monday")
            {
                dia = "Lunes";
            }
            else if (day == "Tuesday")
            {
                dia = "Martes";
            }
            else if (day == "Wednesday")
            {
                dia = "Miercoles";
            }
            else if (day == "Thursday")
            {
                dia = "Jueves";
            }
            else if (day == "Friday")
            {
                dia = "Viernes";
            }
            else if(day.Equals("Saturday"))
            {
                dia = "Sabado";
            }
            else
            {
                dia = "Domingo";
            }

            //string mat = Enrrollment(token);
            using (var Contexto = new AppTecBDEntities())
            {

               var Resultado = (from student in Contexto.Students

                                 join degree in Contexto.Degrees on student.DegreeId equals degree.DegreeID
                                 join DegSubj in Contexto.DegreeSubjects on degree.DegreeID equals DegSubj.DegreeID
                                 join Subj in Contexto.Subjects on DegSubj.SubjectsID equals Subj.SubjectsID
                                 join less in Contexto.Lessons on Subj.SubjectsID equals less.SubjectsID
                                 join groups in Contexto.Groups on student.GroupsID equals groups.GroupsID
                                 join emplo in Contexto.Employers on less.EmployersID equals emplo.EmployersID
                                 join Clsroom in Contexto.Classrooms on less.ClassroomID equals Clsroom.ClassroomID
                                 where student.Enrollment.Equals(Enrollment) && less.Days.Equals(dia)
                                select new LessonDayModel
                                {
                                    salon = Clsroom.Name,
                                    mat = Subj.Name,
                                    horain = less.HousStart,
                                    horafin = less.HourFinish,
                                    estud = "",
                                    nom = emplo.Name,
                                    ap = emplo.LastNameP,
                                    am = emplo.LastNameM


                                }).ToList();

                return Resultado;
            }
        }

        /// <summary>
        /// Metodo que permite obtener el horario de un estudiante por dia
        /// </summary>
        /// <param name="Enrollment"></param>
        /// <param name="dia"></param>
        /// <returns>Lista de tipo horario semanal</returns>
        public static List<LessonModel> Day(string Enrollment,string dia)
        {
            
            //string mat = Enrrollment(token);
            using (var Contexto = new AppTecBDEntities())
            {

                var Resultado = (from student in Contexto.Students

                                 join degree in Contexto.Degrees on student.DegreeId equals degree.DegreeID
                                 join DegSubj in Contexto.DegreeSubjects on degree.DegreeID equals DegSubj.DegreeID
                                 join Subj in Contexto.Subjects on DegSubj.SubjectsID equals Subj.SubjectsID
                                 join less in Contexto.Lessons on Subj.SubjectsID equals less.SubjectsID
                                 join groups in Contexto.Groups on student.GroupsID equals groups.GroupsID
                                 join emplo in Contexto.Employers on less.EmployersID equals emplo.EmployersID
                                 join Clsroom in Contexto.Classrooms on less.ClassroomID equals Clsroom.ClassroomID
                                 where student.Enrollment.Equals(Enrollment) && less.Days.Equals(dia)
                                 select new LessonModel
                                 {
                                     estudios = "",
                                     nombre = emplo.Name,
                                     apep = emplo.LastNameP,
                                     apem = emplo.LastNameM,
                                     salon = Clsroom.Name,
                                     materia = Subj.Name,
                                     dia = less.Days,
                                     horain = less.HousStart,
                                     horafin = less.HourFinish,
                                     credito = Subj.Credits,
                                     clavemat = Subj.Clave,
                                     opcioncur = ""


                                 }).ToList();

                return Resultado;
            }
        }

        /// <summary>
        /// Metodo que permite obtener la matricula de un alumno registrado
        /// </summary>
        /// <param name="token"></param>
        /// <returns>Matricula del alumno</returns>
        public static string Enrrollment(string token)
        {
            Comps com = new Comps();
            using (var Contexto = new AppTecBDEntities())
            {

                var matricula = (from b in Contexto.Autentications
                                 where b.Token.Equals(token)
                                 select new Comps
                                 {
                                     Matricula = b.User
                                 }).FirstOrDefault();

                string a = matricula.Matricula;
                return a;
            }
        }
    }
}