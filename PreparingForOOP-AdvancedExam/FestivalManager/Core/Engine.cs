
using System;
using System.Linq;
namespace FestivalManager.Core
{
    using System.Reflection;
    using Contracts;
    using Controllers;
    using Controllers.Contracts;
    using FestivalManager.Entities;
    using FestivalManager.Entities.Contracts;
    using FestivalManager.Entities.Factories.Contracts;
    using IO.Contracts;


    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IStage stage;
        private IInstrumentFactory instrumentFactory;
        private IPerformerFactory performerFactory;

        private IFestivalController festivalCоntroller;
        private ISetController setCоntroller;

        public Engine(IReader reader, IWriter writer, IStage stage,
            IFestivalController festivalControler, ISetController setControler,
            IInstrumentFactory instrumentFactory, IPerformerFactory performerFactory)
        {
            this.reader = reader;
            this.writer = writer;

            this.stage = stage;

            this.festivalCоntroller = festivalControler;
            this.setCоntroller = setControler;

            this.instrumentFactory = instrumentFactory;
            this.performerFactory = performerFactory;
        }


        public void Run()
        {
            while (true)
            {
                var input = reader.ReadLine();

                if (input == "END")
                {
                    break;
                }
                    

                try
                {
                    string.Intern(input);

                    var result = this.DoCommand(input);
                    this.writer.WriteLine(result);
                }
                catch (Exception ex)
                {
                    this.writer.WriteLine("ERROR: " + ex.InnerException.Message);
                }
            }
          
            var end = this.festivalCоntroller.ProduceReport();

            this.writer.WriteLine("Results:");
            this.writer.WriteLine(end);
        }


        private string DoCommand(string input)
        {
            var tokens = input.Split(" ".ToCharArray().First());

            var command = tokens.First();
            var commandArgs = tokens.Skip(1).ToArray();

            if (command == "LetsRock")
            {
                var sets = this.setCоntroller.PerformSets();
                return sets;
            }

            var festivalcontrolfunction = this.festivalCоntroller.GetType()
                .GetMethods()
                .FirstOrDefault(x => x.Name == command);

            string invoke = string.Empty;

            try
            {
                invoke = (string)festivalcontrolfunction.Invoke(this.festivalCоntroller, new object[] { commandArgs });
            }
            catch (TargetInvocationException ex)
            {
                throw ex;
            }

            return invoke;
        }
        

        public string ProcessCommand(string input)
        {
            return DoCommand(input);
        }
    }
}