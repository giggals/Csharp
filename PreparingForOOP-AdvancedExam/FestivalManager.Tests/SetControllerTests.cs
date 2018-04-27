// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to your project (entities/controllers/etc)
namespace FestivalManager.Tests
{
    using FestivalManager.Core.Controllers;
    using FestivalManager.Entities;
    using FestivalManager.Entities.Contracts;
    using FestivalManager.Entities.Instruments;
    using FestivalManager.Entities.Sets;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SetControllerTests
    {
        [Test]
        public void TestIfCantPerform()
        {

            var instrument = new Guitar();
            var set = new Short("set1");
            var performer = new Performer("Gosho", 20);
            performer.AddInstrument(instrument);

            ISong song = new Song("name", new TimeSpan(0, 10, 0));

            IStage stage = new Stage();

            stage.AddSet(set);
            stage.AddPerformer(performer);
            stage.AddSong(song);

            var controller = new SetController(stage);
            var expected = "1. set1:" + Environment.NewLine + "-- Did not perform";

            Assert.That(expected, Is.EqualTo(controller.PerformSets()));

        }

        [Test]
        public void TestIfCanPerform()
        {
            var instrument = new Guitar();
            var set = new Short("set1");
            var performer = new Performer("Gosho", 20);
            performer.AddInstrument(instrument);

            ISong song = new Song("name", new TimeSpan(0, 10, 0));

            IStage stage = new Stage();
            set.AddSong(song);
            set.AddPerformer(performer);
            stage.AddSet(set);
            stage.AddPerformer(performer);
            stage.AddSong(song);

            var controller = new SetController(stage);
            var expected = "1. set1:" + Environment.NewLine + "-- 1. name (10:00)" + Environment.NewLine + "-- Set Successful";

            Assert.That(expected, Is.EqualTo(controller.PerformSets()));

        }

        [Test]
        public void ChekIWearLevelGoesDown()
        {
            IInstrument instrument = new Guitar();
            IStage stage = new Stage();
            IPerformer performer = new Performer("Gosho", 30);
            performer.AddInstrument(instrument);
            var song = new Song("name", new TimeSpan(0, 5, 0));
            SetController setController = new SetController(stage);
            ISet set = new Short("set1");
            set.AddPerformer(performer);
            set.AddSong(song);
            stage.AddPerformer(performer);
            stage.AddSet(set);

            for (int i = 0; i < 2; i++)
            {
                setController.PerformSets();
            }
            
            Assert.That(instrument.Wear, Is.EqualTo(0));
        }

    }
}