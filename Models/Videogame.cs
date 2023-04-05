using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace net_ef_videogame.Models;



public class Videogame
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Overview { get; set; }
    public DateTime ReleaseDate { get; set; }
    public long SoftwareHouseId { get; set; }

    public SoftwareHouse? SoftwareHouse { get; set; }
}
