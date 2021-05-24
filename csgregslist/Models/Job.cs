using System;
using System.ComponentModel.DataAnnotations;

namespace csgregslist.Models
{
  public class Job
  {
    public Job(string id, string company, string title, string description, int hours, int rate)
    {
      this.Id = id;
      this.Company = company;
      this.Title = title;
      this.Description = description;
      this.Hours = hours;
      this.Rate = rate;

    }
    public Job(string id, string company, string title, string description, int hours, int rate)
    {
      this.Id = id;
      this.Company = company;
      this.Title = title;
      this.Description = description;
      this.Hours = hours;
      this.Rate = rate;

    }
    public string Id { get; set; }
    [Required]
    public string Company { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }
    public int Hours { get; set; }
    public int Rate { get; set; }
    public Job(string company, string title, string description, int hours, int rate)
    {
      Id = Guid.NewGuid().ToString();
      Company = company;
      Title = title;
      Description = description;
      Hours = hours;
      Rate = rate;
    }

  }
}