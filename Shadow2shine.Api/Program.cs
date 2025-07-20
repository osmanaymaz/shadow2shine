using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shadow2shine.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// register services
builder.Services.AddScoped<IChatGptService, ChatGptService>();
builder.Services.AddScoped<IGoogleTtsService, GoogleTtsService>();
builder.Services.AddScoped<IFfmpegSegmentService, FfmpegSegmentService>();
builder.Services.AddScoped<IFfmpegMergeService, FfmpegMergeService>();
builder.Services.AddScoped<IShadowingOrchestrator, ShadowingOrchestrator>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
