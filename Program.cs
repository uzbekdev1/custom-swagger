
public class Program
{ 
    public static void Main(string[] args)
    {   
        var app = builder.Build();

        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint($"/swagger/v{appSettings.Config.Version}/swagger.json", $"v{appSettings.Config.Version}");
            options.RoutePrefix = string.Empty;
            options.DocumentTitle = $"{appSettings.Config.Title} - {appSettings.Config.Description}";
            options.DocExpansion(DocExpansion.None);
            options.InjectStylesheet("/swagger-ui/custom.css");
            options.InjectJavascript("/swagger-ui/custom.js");
            options.DisplayRequestDuration();
            options.EnableTryItOutByDefault();
            options.DefaultModelsExpandDepth(-1);
        }); 
    }
}