
namespace FestivalManager.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
	public class StageTests
    {
        private Performer performer;
        private Stage stage;
        private Song song;
        private List<Song> songs;

        [SetUp]
        public void SetUp()
        {
            performer = new Performer("Pesho", "Goshov", 19);
            stage = new Stage();
            song = new Song("Vetrove", new TimeSpan(0, 3, 30));
            songs = new List<Song>();
        }

        [Test]
        public void TestConstructor()
        {
            var stage1 = new Stage();

            Assert.AreEqual(0, stage1.Performers.Count);
        }
        [Test]
        public void AddPerformer_ThrowsExceotion_WhenAgeIsU18()
        {
            var invalidPerformer = new Performer("Ralitsa", "Hristova", 16);
            Assert.Throws<ArgumentException>(() => stage.AddPerformer(invalidPerformer));
        }
        [Test]
        public void AddPerformer_MethodShouldAddPerformerCorrectly()
        {
            stage.AddPerformer(performer);
            int count = 1;

            Assert.AreEqual(count, stage.Performers.Count);
        }
        [Test]
        public void AddSong_ThrowsEsxception_WhenDurationIsUnder1MIn()
        {
            var invalidSong = new Song("Pesen", new TimeSpan(0, 0, 30));
            Assert.Throws<ArgumentException>(() => stage.AddSong(invalidSong));
        }
        [Test]
        public void AddSong_MethodShouldAddSongCorrectly()
        {
            songs.Add(song);
            Assert.AreEqual(1, songs.Count);
        }
        [Test]
        public void Test_AddSongToPerformer()
        {
            stage.AddPerformer(performer);
            stage.AddSong(song);

            var message = stage.AddSongToPerformer(song.Name, performer.FullName);

            Assert.AreEqual($"{song} will be performed by {performer}", message);
        }
        [Test]
        public void Test_Play()
        {
            var performer2 = new Performer("Pepi", "Mekicov", 30);

            stage.AddPerformer(performer);
            stage.AddPerformer(performer2);

            var song2 = new Song("Burni Noshti", new TimeSpan(0, 2, 30));

            stage.AddSong(song);
            stage.AddSong(song2);

            stage.AddSongToPerformer(song.Name, performer.FullName);
            stage.AddSongToPerformer(song2.Name, performer2.FullName);

            var message = stage.Play();

            Assert.AreEqual("2 performers played 2 songs", message);

        }
        [Test]
        public void Test_GetPerformer_WithInvalidParameters()
        {
            var invalidPerformer = new Performer("Niki", "Nikov", 16);

            stage.AddPerformer(performer);
            stage.AddSong(song);


            var ex = Assert.Throws<ArgumentException>(() =>
            {
                stage.AddSongToPerformer(song.Name, invalidPerformer.FullName);
            }
             );

            Assert.AreEqual("There is no performer with this name.", ex.Message);
        }

        [Test]
        public void Test_GetSong_WithInvalidParameters()
        {
            var invalidSong = new Song("Panairi", new TimeSpan(0, 0, 30));

            stage.AddPerformer(performer);
            stage.AddSong(song);


            var ex = Assert.Throws<ArgumentException>(() =>
            {
                stage.AddSongToPerformer(invalidSong.Name, performer.FullName);
            }
             );

            Assert.AreEqual("There is no song with this name.", ex.Message);
        }

        [Test]
        public void Test_ValidateNullValueSong()
        {
            stage.AddPerformer(performer);

            var ex = Assert.Throws<ArgumentNullException>(() =>
            {
                stage.AddSong(null);
            }
             );

            Assert.AreEqual("Can not be null! (Parameter 'song')", ex.Message);
        }

        [Test]
        public void Test_ValidateNullValuePerformer()
        {
            stage.AddSong(song);

            var ex = Assert.Throws<ArgumentNullException>(() =>
            {
                stage.AddPerformer(null);
            }
             );

            Assert.AreEqual("Can not be null! (Parameter 'performer')", ex.Message);
        }




    }
}