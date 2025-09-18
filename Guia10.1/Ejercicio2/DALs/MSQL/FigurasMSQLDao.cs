using Ejercicio2.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.DALs.MSQL
{
    public class FigurasMSQLDao : IFigurasDao
    {
        string connectionString = "Data Source=tini;Initial Catalog=Guia10_1_Ejercicio1_DB;Integrated Security=True;Pooling=False;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Name=vscode-mssql;Connect Retry Count=1;Connect Retry Interval=10;Command Timeout=30";

        async public Task<Figuras> Add(Figuras nuevo)
        {
            

        }

        async public Task<List<Figuras>> GetAll()
        {
            List<Figuras> figuras = new();


            string query = @"
SELECT f.Id,
	   CASE WHEN f.Tipo=1 THEN 'Rectangulo'
			WHEN f.Tipo=2 THEN 'Circulo'
	   ELSE 'Desconocido' END AS Tipo,
	   f.Area,
	   f.Ancho,
	   f.Largo,
	   f.Radio
FROM Figuras f
ORDER BY f.Area
";


            SqlConnection conn = new SqlConnection(connectionString);
            await conn.OpenAsync();

            using SqlCommand command = new SqlCommand(query, conn);

            using SqlDataReader dataReader = await command.ExecuteReaderAsync();

            Console.WriteLine($"{"Id",10}|{"Tipo",10}|{"Area",10}|{"Ancho",10}|{"Largo",10}|{"Radio",10}");
            while (await dataReader.ReadAsync())
            {
                int id = dataReader["Id"] != DBNull.Value ? Convert.ToInt32(dataReader["Id"]) : 0;
                string? tipo = dataReader["Tipo"] != DBNull.Value ? Convert.ToString(dataReader["Tipo"]) : null;
                double? area = Convert.ToInt32(dataReader["Area"] != DBNull.Value ? dataReader["Area"] : null);
                double? ancho = Convert.ToInt32(dataReader["Ancho"] != DBNull.Value ? dataReader["Ancho"] : null);
                double? largo = Convert.ToInt32(dataReader["Largo"] != DBNull.Value ? dataReader["Largo"] : null);
                double? radio = Convert.ToInt32(dataReader["Radio"] != DBNull.Value ? dataReader["Radio"] : null);

                Console.WriteLine($"{id,10}|{tipo,10}|{area,10:f2}|{ancho,10:f2}|{largo,10:f2}|{radio,10:f2}");

                if (tipo == 1)
                {
                    figuras.Add(new Rectangulo { ancho??0,  largo??0, area??0 });
                }

            }

            await conn.CloseAsync();

        }

        async public Task<Figuras> GetById(int idFigura)
        {
            throw new NotImplementedException();
        }

        async public Task<bool> Remove(int idFigura)
        {
            throw new NotImplementedException();
        }

        async public Task<bool> Save(Figuras entidad)
        {
            throw new NotImplementedException();
        }
    }
}
