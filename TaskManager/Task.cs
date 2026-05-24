using System;

namespace TaskManager
{
    public enum TaskPriority
    {
        Низкий = 0,
        Средний = 1,
        Высокий = 2
    }

    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public TaskPriority Priority { get; set; }
        public bool IsCompleted { get; set; }

        public Task()
        {
            IsCompleted = false;
        }

        public bool IsOverdue()
        {
            return DueDate.Date < DateTime.Now.Date && !IsCompleted;
        }

        public override string ToString()
        {r
            if (IsCompleted)
            {
                return $"ВЫПОЛНЕНО - {Title} ({DueDate:dd.MM.yyyy}, {Priority})";
            }

            return $"{Title} ({DueDate:dd.MM.yyyy}, {Priority})";
        }
    }
}
