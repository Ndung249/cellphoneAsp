using System;
using C21TH1_TranNguyenNhatDung.Data;
using C21TH1_TranNguyenNhatDung.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(C21TH1_TranNguyenNhatDung.Areas.Identity.IdentityHostingStartup))]
namespace C21TH1_TranNguyenNhatDung.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}