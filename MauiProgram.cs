using AssistenciaTecnicaAppNovo.Controllers;
using AssistenciaTecnicaAppNovo.DAO;
using AssistenciaTecnicaAppNovo.Database;
using AssistenciaTecnicaAppNovo.Services;
using AssistenciaTecnicaAppNovo.Views;
using Microsoft.Extensions.Logging;

namespace AssistenciaTecnicaAppNovo;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder.UseMauiApp<App>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<DatabaseConfig>();
        builder.Services.AddSingleton<MySqlConnectionFactory>();
        builder.Services.AddSingleton<SQLiteConnectionFactory>();
        builder.Services.AddSingleton<MongoConnectionFactory>();


        builder.Services.AddTransient<ClienteDao>();
        builder.Services.AddTransient<PecaDao>();
        builder.Services.AddTransient<TecnicoDao>();
        builder.Services.AddTransient<EquipamentoDao>();
        builder.Services.AddTransient<StatusOrdemServicoDao>();
        builder.Services.AddTransient<OrdemServicoDao>();
        builder.Services.AddTransient<EstoqueDao>();
        builder.Services.AddTransient<BackupDao>();
        builder.Services.AddTransient<MongoAnexoDao>();
        builder.Services.AddTransient<LocalCacheDao>();

        builder.Services.AddTransient<LoginService>();
        builder.Services.AddTransient<TecnicoService>();
        builder.Services.AddTransient<ClienteService>();
        builder.Services.AddTransient<EquipamentoService>();
        builder.Services.AddTransient<StatusOrdemServicoService>();
        builder.Services.AddTransient<OrdemServicoService>();
        builder.Services.AddTransient<PecaService>();
        builder.Services.AddTransient<EstoqueService>();
        builder.Services.AddTransient<JsonBackupService>();
        builder.Services.AddTransient<MongoAnexoService>();
        builder.Services.AddTransient<LocalCacheService>();

        builder.Services.AddTransient<AuthController>();
        builder.Services.AddTransient<ClienteController>();
        builder.Services.AddTransient<OrdemServicoController>();
        builder.Services.AddTransient<PecaController>();

        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<MainMenuPage>();
        builder.Services.AddTransient<ClientePage>();
        builder.Services.AddTransient<PecaPage>();
        builder.Services.AddTransient<OrdemServicoPage>();

        return builder.Build();
    }
}
