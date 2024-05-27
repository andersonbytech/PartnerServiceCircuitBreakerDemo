namespace PartnerApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var builder = WebApplication.CreateBuilder(args);
            

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.MapGet("/test", () =>
            {
                var random = new Random();
                if (random.Next(1, 4) == 1) // Fail 1 out of 3 requests
                {
                    return Results.StatusCode(500);
                }
                return Results.Ok("Service is working");
            });

            app.UseAuthorization();


            app.MapControllers();





            app.Run();
        }
    }
}
