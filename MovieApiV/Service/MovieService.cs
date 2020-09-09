using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MovieApiV.Model;

namespace MovieApiV.Services
{
    public partial class DataHandler
    {
       // public Utils Util { get; set; }
        public async Task<List<Movie>> MovieListGet()
        {
            var sql = "exec sp_movie_data 0, 1";

            //var dt = Util.Select(sql);
            var dt = Util.Select(sql);
            var list = new List<Movie>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Movie
                {
                    Genre = row["Genre"].ToString(),
                    ReleaseDate = (DateTime)row["ReleaseDate"],
                    Title = row["Genre"].ToString()
                });
            }
            return list;
        }
    }
}
