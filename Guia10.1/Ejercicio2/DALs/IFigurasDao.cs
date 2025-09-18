using Ejercicio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.DALs
{
    public  interface IFigurasDao
    {
        Task <List<Figuras>> GetAll();

        Task<Figuras> GetById(int idFigura);
        Task<Figuras> Add(Figuras nuevo);
        Task<bool> Save(Figuras entidad);
        Task<bool> Remove (int idFigura);




    }
}
