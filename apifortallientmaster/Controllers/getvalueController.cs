using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apifortallientmaster.Models;

namespace apifortallientmaster.Controllers
{

    public class getvalueController : ApiController
    {
        // GET api/values
        V5Entities1 v5 = new V5Entities1();
       

        // GET api/values/5
        public List<apiclass> getedu()
        {

            var deslist = v5.HCM_EDUCATION.Select(x => new apiclass {
                rid = x.RID,
                title = x.Title
            }).ToList();
           
            return deslist;
            
        }
        public List<apiclass> getcurr()
        {

            var deslist = v5.HCM_CURRENCY.Select(x => new apiclass
            {
                rid = x.RID,
                title = x.Currency
            }).ToList();

            return deslist;

        }

        public List<apiclass> getdes()
        {

            var deslist = v5.HCM_DESIGNATIONS.Select(x => new apiclass
            {
                rid = x.RID,
                title = x.Title
            }).ToList();

            return deslist;

        }
        public List<apiclass> getcountry()
        {

            var deslist = v5.HCM_COUNTRY.Select(x => new apiclass
            {
                rid = x.RID,
                title = x.Title
            }).ToList();

            return deslist;

        }
        public List<apiclass> getloction()
        {

            var deslist = v5.HCM_LOCATIONS.Select(x => new apiclass
            {
                rid = x.RID,
                title = x.Title
            }).ToList();

            return deslist;

        }
        public List<apiclass> getskills()
        {

            var deslist = v5.HCM_SKILLS.Select(x => new apiclass
            {
                rid = x.RID,
                title = x.Title
            }).ToList();

            return deslist;

        }
        public List<apiclass> getuni()
        {

            var deslist = v5.HCM_UNIVERSITY_GROUP.Select(x => new apiclass
            {
                rid = x.RID,
                title = x.Title
            }).ToList();

            return deslist;

        }

        public List<apiclass> getfrequency()
        {
            var deslist = v5.HCM_COMMON_MASTER.Where(x=>x.RefType==53).Select(x => new apiclass
            {
                rid = x.ConstValue,
                title = x.Title
            }).ToList();

            return deslist;
        }

        public long getconfigid(string username)
        {
            var configid = v5.HC_USER_MAIN.Where(x=>x.UserName==username).Select(x=>x.ConfigTemplateID).FirstOrDefault();
            return configid;
        }
        public string gettitle(long rid,string table)
        {
            var title = "";
            if (table=="course")
            {
                title = v5.HCM_EDUCATION.Where(x => x.RID == rid).Select(x => x.Title).FirstOrDefault();
               
            }
            if (table == "uni")
            {
                title = v5.HCM_UNIVERSITY_GROUP.Where(x => x.RID == rid).Select(x => x.Title).FirstOrDefault();
            }
            if (table == "skill")
            {
                title = v5.HCM_SKILLS.Where(x => x.RID == rid).Select(x => x.Title).FirstOrDefault();
            }
            if (table == "role")
            {
                title = v5.HCM_DESIGNATIONS.Where(x => x.RID == rid).Select(x => x.Title).FirstOrDefault();
            }
            if (table == "position")
            {
                title = v5.HCM_DESIGNATIONS.Where(x => x.RID == rid).Select(x => x.Title).FirstOrDefault();

            }
            return title;

        }
   
      
    }
}
