namespace HoneyDoList.Domain.Entities
{
  public class Priority
  {
    public virtual int Id { get; set; }
    public virtual int Level { get; set; }
    public virtual string Name { get; set; }
  }
}