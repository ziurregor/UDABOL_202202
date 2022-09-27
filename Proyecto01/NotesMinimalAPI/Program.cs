using Microsoft.EntityFrameworkCore;
using Modelo;

//using Microsoft.EntityFrameworkCore; // place this line at the beginning of file.

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/Ope
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Connect to PostgreSQL Database
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Users>(options =>
    options.UseNpgsql(connectionString));


//... rest of the code omitted for brevity
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
//... rest of the code omitted for brevity


var app = builder.Build();
//... rest of the code omitted for brevity





// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => "Welcome to Notes API! ROger");

app.Run();

//record Note(int id)
//{
//    public string text { get; set; } = default!;
//    public bool done { get; set; } = default!;
//}



class NoteDb : DbContext
{
    public NoteDb(DbContextOptions<NoteDb> options) : base(options)
    {

    }
    public DbSet<Note> Notes => Set<Note>();
}