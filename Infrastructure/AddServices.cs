using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class AddServices
    {

        public static void AddDbContextService(IServiceCollection service)
        {
            service.AddDbContext<AppDbContext>(option => option.UseSqlServer(@"Data Source=THARWATEXAM\SQL2019STD;Initial Catalog=AlmahdiExam;Persist Security Info=True;User ID=sa;Password=Yemen@134"));
            service.AddScoped<IProductsRepo, ProductRepo>();
            service.AddScoped<IUserRepo, UserRepo>();
            service.AddScoped<ICategoriesRepo, CategoriesRepo>();


        }
    }
}
