using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{ 
    public class BolumBl: IDisposable
    {
        UniversiteDbContext ctx = new UniversiteDbContext();

        public void Dispose()
        {
            ((IDisposable)ctx).Dispose();
        }

        public bool Ekle(Bolum s)
        {
            ctx.Bolumler.Add(s);
            return ctx.SaveChanges() > 0;
        }


    }
}
