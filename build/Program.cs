using Cake.Common.Solution;
using Cake.Core;
using Cake.Frosting;

public static class Program
{
    public static int Main(string[] args)
    {
        return new CakeHost()
            .UseContext<BuildContext>()
            .Run(args);
    }
}

public class BuildContext : FrostingContext
{
    public BuildContext(ICakeContext context)
        : base(context)
    {
    }
}

[TaskName("SolutionBug")]
public sealed class SolutionTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.ParseSolution("cake-bug2.sln");
    }
}

[TaskName("Default")]
[IsDependentOn(typeof(SolutionTask))]
public class DefaultTask : FrostingTask
{
}