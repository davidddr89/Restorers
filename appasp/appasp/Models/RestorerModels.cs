using EntityModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appasp.Models
{
    public class RestorerModels
    {
        public List<Job> getJobs()
        {
            EntityModel.DAL.RestorerContext DBContext = new EntityModel.DAL.RestorerContext();
            var jobs = DBContext.Jobs.ToList();
            return jobs;
        }

        public Job getJob(int id)
        {
            EntityModel.DAL.RestorerContext DBContext = new EntityModel.DAL.RestorerContext();
            return DBContext.Jobs.FirstOrDefault(f=>f.Id==id);
        }

    }

    
}