using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsAnalysisTool.Common;

namespace StatisticsAnalysisTool.UnitTests
{
    [TestClass]
    public class DungeonControllerTests
    {
        [TestMethod]
        public void AddEntity_WithValidValues_EntityInList()
        {
            //var mainWindow = new MainWindow();

            //ITrackingController sut = new TrackingController(new MainWindowViewModel(mainWindow), mainWindow);
            //sut.EntityController.AddEntity(999, Guid.NewGuid(), "TestPlayer", GameObjectType.Player, GameObjectSubType.Player);

            //var entities = sut.EntityController.GetAllEntities();

            //var expected = new ConcurrentDictionary<Guid, PlayerGameObject>();

            //Assert.AreEqual(expected, entities);
        }

        [TestMethod]
        public void GetGoldPricesFromJsonAsync_WithValidValues_GoldResponse()
        {
            var result = ApiController.GetGoldPricesFromJsonAsync(
                null,
                1).GetAwaiter().GetResult();

            Assert.IsTrue(result.Count > 0);

            foreach (var goldResponse in result)
            {
                Assert.IsNotNull(goldResponse.Timestamp);
                Assert.IsNotNull(goldResponse.Price);
            }
        }
    }
}
