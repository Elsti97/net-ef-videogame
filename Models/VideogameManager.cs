using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace net_ef_videogame.Models;



public class VideogameManager
{
    VideogameContext context;

    public VideogameManager(VideogameContext context)
    {
        this.context = context;
    }

    public void InserisciVideogame(Videogame videogame)
    {
        context.Videogames.Add(videogame);
        context.SaveChanges();
    }

    public long InserisciSoftwareHouse(SoftwareHouse softwareHouse)
    {
        context.SoftwareHouses.Add(softwareHouse);
        context.SaveChanges();

        return softwareHouse.Id;
    }

    public Videogame? CercaVideogameId(long id)
    {
        return context.Videogames.Include(v => v.SoftwareHouse).First(v => v.Id == id);
    }

    public List<Videogame> CercaVideogameNome(string nome)
    {
        return context.Videogames.Where(v => v.Name != null && v.Name.Contains(nome)).ToList();
    }

    public void CancellaVideogame(long id)
    {
        var vg = context.Videogames.Find(id);

        if (vg is null) return;

        context.Videogames.Remove(vg);
        context.SaveChanges();
    }
}

