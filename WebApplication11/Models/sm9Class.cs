using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Microsoft.Ajax.Utilities;
using System.Web.Script.Serialization;

namespace WebApplication11.Models
{
    public class sm9Class
    {
        public int Id { get; set; }
        public string Responsable { get; set; }
        public Nullable<System.DateTime> Date_Heure_d_ouverture { get; set; }
        public Nullable<System.DateTime> Date_Heure_de_résolution { get; set; }
        public Nullable<System.DateTime> Date_Heure_de_clôture { get; set; }
        public string ID_Incident { get; set; }
        public string Priorité { get; set; }
        public string État_de_l_alerte { get; set; }
        public string État { get; set; }
        public string CI_concerné { get; set; }
        public string Service_concerné_principal { get; set; }
        public string Titre { get; set; }
        public string Application { get; set; }
        public string Catégorie { get; set; }
        public string New_Cat { get; set; }
        public Nullable<System.DateTime> Start_Date_Cal { get; set; }
        public Nullable<System.DateTime> End_Date_Cal { get; set; }
        public Nullable<double> week_in { get; set; }
        public Nullable<double> week_out { get; set; }
        public Nullable<double> year_in { get; set; }
        public Nullable<double> year_out { get; set; }
        public string Year___Week_in { get; set; }
        public string Year___Week_Out { get; set; }
        public string P { get; set; }
        public string Slo { get; set; }
        public string Realisation { get; set; }
        public string SLA { get; set; }
        public string SR { get; set; }
        public Nullable<double> Best_effort { get; set; }
        public Nullable<double> M_D { get; set; }
    }

   
}