using Test.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Test.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(TestMongoDbModule),
        typeof(TestApplicationContractsModule)
        )]
    public class TestDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
