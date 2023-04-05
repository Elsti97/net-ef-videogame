using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using net_ef_videogame.Models;



public class SoftwareHouse
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }

    public List<Videogame> Videogame { get; set; } = new List<Videogame>();
}
