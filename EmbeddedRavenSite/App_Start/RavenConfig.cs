using Raven.Client;
using Raven.Client.Embedded;

namespace EmbeddedRavenSite.App_Start
{
    public static class RavenConfig
    {
        public static IDocumentStore Init()
        {
            return new EmbeddableDocumentStore
            {
                ConnectionStringName = "RavenDb",
                UseEmbeddedHttpServer = true
            }.Initialize();

        }
    }
}
