

using _26_SecondAPI.Services.Classes;
using _26_SecondAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddGrpcClient<Homework_gRPC.gRPC.gRPCClient>(options =>
{
    options.Address = new Uri(builder.Configuration["gRPC:Test"]);
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ITest, Test>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.MapControllers();
app.Run();