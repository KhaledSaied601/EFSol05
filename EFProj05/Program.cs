using EFProj05.Models;
using Microsoft.EntityFrameworkCore;

namespace EFProj05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (MyNorthwindContext myNorthwindContext = new MyNorthwindContext(new Microsoft.EntityFrameworkCore.DbContextOptions<MyNorthwindContext>()))
            {


                myNorthwindContext.Categories.FromSqlInterpolated($"update Categories set CategoryName='Khaled' where CategoryID=8");




            }
        }
    }
}
