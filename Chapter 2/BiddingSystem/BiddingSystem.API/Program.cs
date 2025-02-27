using BiddingSystem.Services;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IBidProcessor, BidCapture>();
builder.Services.AddScoped<IBidProcessor, BidAnalyzer>();
builder.Services.AddScoped<IBidProcessor, BidTracker>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
	app.MapOpenApi();
	app.MapScalarApiReference(opt => {
		opt.WithTitle("Bidding System API");
		opt.WithTheme(ScalarTheme.Saturn);
		opt.WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient);
	});
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
