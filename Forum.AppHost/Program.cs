var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Forum_API>("forum-api");

builder.AddProject<Projects.Forum_MVC>("forum-mvc");

builder.Build().Run();
