using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Web;
using WebApplication11.Models;
using Microsoft.Ajax.Utilities;
using System.Web.Script.Serialization;

namespace WebApplication11.Controllers
{
    public class sm9Controller : ApiController
    {
        SM9_MANTISEntities sm = new SM9_MANTISEntities();
        public IHttpActionResult Getsm9()
        {
            
            var results = sm.SM9.ToList(); //.Take(3000)
            return Ok(results);
        }
        [HttpPost]
        public IHttpActionResult sm9Insert(SM9 sm9Insert)
        {
            sm.SM9.Add(sm9Insert);
            sm.SaveChanges();
            return Ok();
        }

        //get by id
        [HttpGet]
        public IHttpActionResult sm9GetId(int id)
        {

            sm9Class sm9Details = null;
            sm9Details = sm.SM9.Where(x => x.Id == id).Select(x => new sm9Class()
            {
                Id = x.Id,
                Responsable = x.Responsable,
                Date_Heure_d_ouverture = x.Date_Heure_d_ouverture,
                Date_Heure_de_résolution = x.Date_Heure_de_résolution,
                Date_Heure_de_clôture = x.Date_Heure_de_clôture,
                ID_Incident = x.ID_Incident,
                Priorité = x.Priorité,
                État_de_l_alerte = x.État_de_l_alerte,
                État = x.État,
                CI_concerné = x.CI_concerné,
                Service_concerné_principal = x.Service_concerné_principal,
                Titre = x.Titre,
                Application = x.Application,
                Catégorie = x.Catégorie,
                New_Cat = x.New_Cat,
                Start_Date_Cal = x.Start_Date_Cal,
                End_Date_Cal = x.End_Date_Cal,
                week_in = x.week_in,
                week_out = x.week_out,
                year_in = x.year_in,
                year_out = x.year_out,
                Year___Week_in = x.Year___Week_in,
                Year___Week_Out = x.Year___Week_Out,
                P = x.P,
                Slo = x.Slo,
                Realisation = x.Realisation,
                SLA = x.SLA,
                SR = x.SR,
                Best_effort = x.Best_effort,
                M_D = x.M_D,
            }).FirstOrDefault<sm9Class>();

            if (sm9Details==null)
            {
                return NotFound();
            }
           
            return Ok(sm9Details);
        }


        //update
        public IHttpActionResult put(sm9Class sc)
        {
            var updatesm9 = sm.SM9.Where(x => x.Id == sc.Id).FirstOrDefault<SM9>();
            if(updatesm9!=null)
            {
                updatesm9.Id = sc.Id;
                updatesm9.Responsable = sc.Responsable;
                updatesm9.Date_Heure_d_ouverture = sc.Date_Heure_d_ouverture;
                updatesm9.Date_Heure_de_résolution = sc.Date_Heure_de_résolution;
                updatesm9.Date_Heure_de_clôture = sc.Date_Heure_de_clôture;
                updatesm9.ID_Incident = sc.ID_Incident;
                updatesm9.Priorité = sc.Priorité;
                updatesm9.État_de_l_alerte = sc.État_de_l_alerte;
                updatesm9.État = sc.État;
                updatesm9.CI_concerné = sc.CI_concerné;
                updatesm9.Service_concerné_principal = sc.Service_concerné_principal;
                updatesm9.Titre = sc.Titre;
                updatesm9.Application = sc.Application;
                updatesm9.Catégorie = sc.Catégorie;
                updatesm9.New_Cat = sc.New_Cat;
                updatesm9.Start_Date_Cal = sc.Start_Date_Cal;
                updatesm9.End_Date_Cal = sc.End_Date_Cal;
                updatesm9.week_in = sc.week_in;
                updatesm9.week_out = sc.week_out;
                updatesm9.year_in = sc.year_in;
                updatesm9.year_out = sc.year_out;
                updatesm9.Year___Week_in = sc.Year___Week_in;
                updatesm9.Year___Week_Out = sc.Year___Week_Out;
                updatesm9.P = sc.P;
                updatesm9.Slo = sc.Slo;
                updatesm9.Realisation = sc.Realisation;
                updatesm9.SLA = sc.SLA;
                updatesm9.SR = sc.SR;
                updatesm9.Best_effort = sc.Best_effort;
                updatesm9.M_D = sc.M_D;
                sm.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
