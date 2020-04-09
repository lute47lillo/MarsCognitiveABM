using CognitiveABM.Perceptron;
using System;
using System.Collections.Generic;
using System.Linq;

public static class Program {
	public static void Main(string[] args) {
		//if (args != null && System.Linq.Enumerable.Any(args, s => s.Equals("-l")))
		//{
		//	Mars.Common.Logging.LoggerFactory.SetLogLevel(Mars.Common.Logging.Enums.LogLevel.Info);
		//	Mars.Common.Logging.LoggerFactory.ActivateConsoleLogging();
		//}
		//var description = new Mars.Core.ModelContainer.Entities.ModelDescription();
		//description.AddLayer<hillClimber.Terrain>();
		//description.AddAgent<hillClimber.Animal, hillClimber.Terrain>();
		//var task = Mars.Core.SimulationStarter.SimulationStarter.Start(description, args);
		//var loopResults = task.Run();
		//System.Console.WriteLine($"Simulation execution finished after {loopResults.Iterations} steps");
		PerceptronFactory perceptron = new PerceptronFactory(9, 9, 1, 9);
		double[] genomes = new double[486];
		genomes = CreateRandomArray(486).ToArray();
		double[] inputs = new double[] { 0.5,0.5,0.5,0.5,0.5,0.5,0.5,0.5,0.5 };
		perceptron.CalculatePerceptron(genomes, inputs);

			
	}
	private static List<double> CreateRandomArray(int length)
	{
		Random random = new Random();
		return Enumerable.Repeat(0, length).Select(i => random.NextDouble()).ToList();
	}
}
