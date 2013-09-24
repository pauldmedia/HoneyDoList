using System;

namespace HoneyDoList.Domain.Entities
{
  public class Task
  {
    public virtual int Id { get; set; }
    public virtual string Name { get; set; }
    public virtual DateTime DueDate { get; set; }
    public virtual Priority Priority { get; set; }
    public virtual string Note { get; set; }
  }
}