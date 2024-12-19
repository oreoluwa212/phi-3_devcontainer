using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.AI.Phi;

class Program
{
    static async Task Main(string[] args)
    {
        var kernelBuilder = new KernelBuilder();

        // Configure Phi-3.5
        kernelBuilder.WithPhi35TextGeneration(new PhiConfig
        {
            ModelPath = "microsoft/phi-3.5"
        });

        var kernel = kernelBuilder.Build();

        // Test prompt
        var result = await kernel.RunAsync("Explain quantum computing in simple terms.");
        Console.WriteLine(result);
    }
}