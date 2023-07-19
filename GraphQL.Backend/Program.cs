using GraphQL.Backend;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

var graphQlBuilder = services.AddGraphQLServer();

graphQlBuilder.AddGraphQLServer()
    .AddQueryType<Query>()
    .InitializeOnStartup();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");

app.MapGraphQL();

app.Run();
