using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly DevFreelaDbContext _dbContext;
        public ProjectService(DevFreelaDbContext dbContext) 
        { 
            _dbContext = dbContext;
        }
        public int Create(NewProjectInputModel inputModel)
        {
            var project = new Project(inputModel.title, inputModel.description, inputModel.idClient
                , inputModel.idFreelancer, inputModel.TotalCost);
            _dbContext.projects.Add(project);

            return project.Id;
        }

        public void CreateComment(CreateCommentInputModel inputModel)
        {
            var comment = new ProjectComment(inputModel.content, inputModel.idProject
                , inputModel.idUser);
            _dbContext.comments.Add(comment);
        }

        public void Delete(int id)
        {
            var project = _dbContext.projects.SingleOrDefault(p => p.Id == id);
            project.cancel();
        }

        public void Finish(int id)
        {
            var project = _dbContext.projects.SingleOrDefault(p => p.Id == id);
            project.finish();
        }

        public List<ProjectViewModel> GetAll(string query)
        {
            var projects = _dbContext.projects;

            //Para cada projeto eu vou inicializar um ProjectViewModel
            var projectsViewModel = projects
                .Select(p => new ProjectViewModel(p.Id, p.title, p.createdAd)).ToList();              

            return projectsViewModel;
        
                }

        public ProjectDetailsViewModel GetById(int id)
        {
            var project = _dbContext.projects.SingleOrDefault(p => p.Id == id);

            if (project == null) 
            {
                return null;
            }
            var projectDetailViewModel = new ProjectDetailsViewModel(
                project.Id,
                project.title,
                project.description,
                project.totalCost,
                project.createdAd,
                project.finishedAt
                );

            return projectDetailViewModel;
        }

        public void Start(int id)
        {
            var project = _dbContext.projects.SingleOrDefault(p => p.Id == id);

            project.start();
        }

        public void Update(UpdateProjectInputModel inputModel)
        {
            var project = _dbContext.projects.SingleOrDefault(p => p.Id == inputModel.id);


        }
    }
}
