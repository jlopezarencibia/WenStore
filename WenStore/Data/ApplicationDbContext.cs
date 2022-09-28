using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using WenStore.Models.Application;
using WenStore.Models.Services;
using WenStore.Models.Shared;
using WenStore.Models.Store;

namespace WenStore.Data;

public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
{
    // DB-SET || Profile
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Saved> Saves { get; set; }
    public DbSet<Service> Services { get; set; }

    // DB-SET || Services
    public DbSet<Job> Jobs { get; set; }
    public DbSet<OpenForWork> Openings { get; set; }

    // DB-SET || Shared
    public DbSet<Comment> Comments { get; set; }
    public DbSet<ContactInformation> ContactInformations { get; set; }
    public DbSet<Rate> Rates { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SocialUrl> SocialUrls { get; set; }

    // DB-SET || Store
    public DbSet<AmazonProduct> AmazonProducts { get; set; }

    public DbSet<Category> Categories { get; set; }
    // public DbSet<Product> Products { get; set; }

    public DbSet<Product> Products { get; set; }

    public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
        : base(options, operationalStoreOptions)
    {
    }
}