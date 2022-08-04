using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TechJobsPersistentAutograded.Data;
using TechJobsPersistentAutograded.Models;

// i don't think i need this, but not removing until the very end.  for now, it will remain commented out.

namespace TechJobsPersistentAutograded.Tests
{
    /*public class TestEmployerRepository : JobRepository
    {
        //setup
        public TestEmployerRepository() { }

        private readonly JobDbContext _context;

        public TestEmployerRepository(JobDbContext context)
        {
            _context = context;
        }

       // private List<Employer> data = new List<Employer>();


        //methods
        public override IEnumerable<Employer> GetAllEmployers()
        {
            return _context.Employers.ToList();
        }

        public override Employer FindEmployerById(int id)
        {
            return data.Find(m => m.Id == id);
        }

        public override void AddNewEmployer(Employer newEmployer)
        {
            _context.Employers.Add(newEmployer);
        }

        public void AddNewJob(Job newJob)
        {
            _context.Jobs.Add(newJob);
        }

        public void AddNewJobSkill(JobSkill newJobSkill)
        {
            _context.JobSkills.Add(newJobSkill);
        }

        public void AddNewSkill(Skill newSkill)
        {
            _context.Skills.Add(newSkill);
        }

        public Job FindJobById(int id)
        {
            return _context.Jobs.Include(j => j.Employer).Single(j => j.Id == id);
        }

        public Job FindJobByJobSkill(int id)
        {
            return _context.Jobs
                .Include(j => j.Employer)
                .Single(j => j.Id == id);
        }

        public List<Job> FindJobsByEmployer(string value)
        {
            return _context.Jobs
                       .Include(j => j.Employer)
                       .Where(j => j.Employer.Name == value)
                       .ToList();
        }

        public List<JobSkill> FindJobSkillsById(int id)
        {
            return _context.JobSkills
                .Where(js => js.SkillId == id)
                .Include(js => js.Job)
                .Include(js => js.Skill)
                .ToList();
        }

        public List<JobSkill> FindJobSkillsBySkill(string value)
        {
            return _context.JobSkills
                .Where(j => j.Skill.Name == value)
                .Include(j => j.Job)
                .ToList();
        }

        public List<JobSkill> FindJobsSkillsBySkillAndJob(int jobId, int skillId)
        {
            return _context.JobSkills
                    .Where(js => js.JobId == jobId)
                    .Where(js => js.SkillId == skillId)
                    .ToList();
        }

        public List<JobSkill> FindSkillsForJob(int id)
        {
            return _context.JobSkills
                .Where(js => js.JobId == id)
                .Include(js => js.Skill)
                .ToList();
        }

        
        public List<Job> GetAllJobs()
        {
            return _context.Jobs.Include(j => j.Employer).Include(j => j.JobSkills).ToList();
        }

        public List<Job> GetAllJobsEmployer()
        {
            return _context.Jobs
                .Include(j => j.Employer)
                .ToList();
        }

        public List<Skill> GetAllSkills()
        {
            return _context.Skills.ToList();
        }

        public override void SaveChanges()
        {
            _context.SaveChanges();
        }
    }*/
}
