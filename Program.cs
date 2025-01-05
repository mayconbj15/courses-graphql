using Courses.GraphQL.Data.Context;
using Courses.GraphQL.Data.Repositories;
using Courses.GraphQL.Data.Repositories.Interfaces;
using Courses.GraphQL.GraphQL;
using Courses.GraphQL.GraphQL.Mutations;
using Courses.GraphQL.GraphQL.Queries;
using GraphQL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// GraphQLBuilderExtensions.AddGraphQL(builder.Services);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString =
    builder.Configuration.GetConnectionString("CourseDatabase")
        ?? throw new InvalidOperationException("Connection string"
        + "'CourseDatabase' not found.");

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql(connectionString));
builder.Services.AddScoped<ICourseRepository, CourseRepository>();

builder.Services.AddGraphQL(b => b.AddSystemTextJson());

builder.Services.AddScoped<CourseQuery>();
builder.Services.AddScoped<CourseMutation>();
builder.Services.AddScoped<AppSchema>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseGraphQL<AppSchema>();
app.UseGraphQLGraphiQL("/ui/graphql");

await app.RunAsync();

