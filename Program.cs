using Cocona;
using Microsoft.Extensions.DependencyInjection;
using wc_sharp;
using wc_sharp.ProgramLogic;

var builder = CoconaApp.CreateBuilder();

builder.Services.AddSingleton<ILogic, Logic>();

var app = builder.Build();

app.AddCommands<ProgramCommands>();

app.Run();