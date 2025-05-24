using Scalar.AspNetCore;

namespace Forum.API.Extention;

public static class RegisterScalarExtension
{
    public static WebApplication RegisterScalar(this WebApplication app)
    {
        app.MapScalarApiReference(opt =>
        {
            opt.Title = "Forum v1";
            opt.Theme = ScalarTheme.DeepSpace;
            opt.DefaultHttpClient = new(ScalarTarget.Http, ScalarClient.Http11);
        });
        return app;
    }
    
}