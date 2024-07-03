using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace People.Models;
    [Table("people")]

    public class PZPerson
    {
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [System.ComponentModel.DataAnnotations.MaxLength(250), Unique]
    public string Name { get; set; }
}

