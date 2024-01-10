using MiniChallenges5_7.Services.MiniChallenges;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMiniChallenge5Service, MiniChallenge5Service>();
builder.Services.AddScoped<IMiniChallenge6Service, MiniChallenge6Service>();
builder.Services.AddScoped<IAlphaNumericReverseItService, AlphaNumericReverseItService>();
builder.Services.AddScoped<INumericReverseItService, NumericReverseItService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
