using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Models
{
    public class ProjectWrapper
    {
        public Project project { get; set; }
        public DateTime DevsEndDate{ get; set; }
        public DateTime ProjectManagementEndDate { get; set; }

        public DateTime GetProjectEndDate {
            get
            {
                return DevsEndDate <= ProjectManagementEndDate ? DevsEndDate : ProjectManagementEndDate;
            }
        }

        public override string ToString()
        {
            return "Project : " + project.Name + " | DevsTimeEnd : " + DevsEndDate.ToShortDateString() + " | ProjectManagementEnd : " + ProjectManagementEndDate.ToShortDateString() + "\n";
        }

        public ProjectWrapper(Project project)
        {
            this.project = project;
        }

        public int GetProjectBiggestWorkLoad()
        {
            return this.project.GetWorkLoad(Type.Developer) < this.project.GetWorkLoad(Type.ProjectManager) ? this.project.GetWorkLoad(Type.Developer) : this.project.GetWorkLoad(Type.ProjectManager);
        }
    }
}
