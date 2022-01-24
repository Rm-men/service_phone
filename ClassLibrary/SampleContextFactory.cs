using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;
using Microsoft.EntityFrameworkCore.Design;

namespace CleaningDLL
{
    class SampleContextFactory:IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            return new ApplicationContext(ApplicationContext.GetDb());
        }
    }
}
