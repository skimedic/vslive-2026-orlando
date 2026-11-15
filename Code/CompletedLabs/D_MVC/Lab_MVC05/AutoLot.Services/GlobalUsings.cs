// Copyright Information
// ==================================
// AutoLot - AutoLot.Services - GlobalUsings.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2026/11/08
// ==================================

global using AutoLot.Models.Exceptions;

global using AutoLot.Services.Logging.Interfaces;
global using AutoLot.Services.Logging.Settings;
global using AutoLot.Services.Simple.Interfaces;

global using Microsoft.AspNetCore.Builder;

global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;

global using Serilog;
global using Serilog.Context;
global using Serilog.Core.Enrichers;
global using Serilog.Events;
global using Serilog.Sinks.MSSqlServer;

global using System.ComponentModel.DataAnnotations;
global using System.Data;
global using System.Diagnostics;
global using System.Reflection;
global using System.Runtime.CompilerServices;