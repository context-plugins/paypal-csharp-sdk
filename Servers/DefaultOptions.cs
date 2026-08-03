using Paypal.Core.Models;

namespace Paypal.Servers;

public class DefaultOptions
{
    public ProductionOptions Production { get; set; } = new();
    public SandboxOptions Sandbox { get; set; } = new();

    internal UrlTemplate Resolve(ServerEnvironment environment, string path) =>
        environment.Match(() => new UrlTemplate(Production.BaseUrl, path, []),
            () => new UrlTemplate(Sandbox.BaseUrl, path, []));

    public class ProductionOptions
    {
        public string BaseUrl { get; set; } = "https://api-m.sandbox.paypal.com";
    }

    public class SandboxOptions
    {
        public string BaseUrl { get; set; } = "https://api-m.sandbox.paypal.com";
    }
}
