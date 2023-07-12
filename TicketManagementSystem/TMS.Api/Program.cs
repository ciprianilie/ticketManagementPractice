using Microsoft.EntityFrameworkCore;
using TMS.Api.DbContext;
using TMS.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("TicketManagementConnectionString");

builder.Services.AddControllers()
            .AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TicketManagementDbContext>(options =>
            options.UseSqlServer(connectionString));

builder.Services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IEventRepository, EventRepository>();
builder.Services.AddScoped<IEventTypeRepository, EventTypeRepository>();
builder.Services.AddScoped<IVenueRepository, VenueRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<ITicketCategoryRepository, TicketCategoryRepository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
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
