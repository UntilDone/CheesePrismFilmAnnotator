using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesePrismFilmAnnotator.Model
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsCompleted { get; set; }
        public TimeSpan Timer { get; set; }
        public TaskState TaskState { get; set; }
        public TaskCategory TaskCategory { get; set; } 
        public TaskImportance TaskImportance { get; set; }
    }

    public enum TaskState
    {
        /// <summary>
        /// The task is currently being worked on.
        /// </summary>
        InProgress,
        /// <summary>
        /// The task has been completed successfully.
        /// </summary>
        Completed,
        /// <summary>
        /// The task is pending and has not yet been started.
        /// </summary>
        NotStarted,
        /// <summary>
        /// The task is overdue and needs immediate attention.
        /// </summary>
        Late,
        /// <summary>
        /// The task has been paused temporarily.
        /// </summary>
        Archived,
        /// <summary>
        /// The task has been deleted and is no longer available.
        /// </summary>
        Deleted
    }

    public enum TaskCategory
    {
      Work,
      Personal,
      Home,
      HealthWelbeing,
      Finance,
      Shopping,
      SocialFamily,
      Education,
      Travel,
      Errands,
      HobbiesLeisure,
      VolunteeringCommunity,
      BirthdaysAnniversaries,
      Projects,
      LongTermGoals
    }

    public enum TaskImportance
    {
        Low,
        Medium,
        High,
        Critical
    }

    public void addTa(string a, string b)
    {
        switch ((a, b))
        {
            case ("Work", "Personal"):
                // Add logic for Work and Personal task
                break;
        }
    }
}
