var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PortfolioWebsite>("portfoliowebsite");

builder.Build().Run();
