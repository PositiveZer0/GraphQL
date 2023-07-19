using GraphQL.Backend;
using GraphQL.Domain;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(@"Server=.;Database=GraphQL;Trusted_Connection=True;TrustServerCertificate=True");
});

var graphQlBuilder = services.AddGraphQLServer();

graphQlBuilder.AddGraphQLServer()
    .AddQueryType<Query>()
    .InitializeOnStartup();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");

app.MapGraphQL();
using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    var dbContext = serviceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.EnsureCreated();
}
app.Run();

