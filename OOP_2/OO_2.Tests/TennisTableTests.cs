using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;

namespace OOP_2.Tests
{
    public class TennisTableTests
    {
        [Fact]
        public void getFinalResult_CallingGetSame_OneTime()
        {
            var tennisRules = new Mock<ITennisRules>();

            var tennisTable = new TennisTable(tennisRules.Object);
            tennisTable.PlayerStart("player1", "player2");
            tennisTable.WonPoint("player1");
            tennisTable.WonPoint("player2");

            tennisTable.getFinalResult();

            tennisRules.Verify(t => t.getSame(It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public void getFinalResult_CallingGetResult_OneTime()
        {
            var tennisRules = new Mock<ITennisRules>();

            var tennisTable = new TennisTable(tennisRules.Object);
            tennisTable.PlayerStart("player1", "player2");
            tennisTable.WonPoint("player1");
            tennisTable.WonPoint("player1");
            tennisTable.WonPoint("player1");
            tennisTable.WonPoint("player1");

            tennisTable.getFinalResult();

            tennisRules.Verify(t => t.getResult(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public void getFinalResult_CallingActualScore_OneTime()
        {
            var tennisRules = new Mock<ITennisRules>();

            var tennisTable = new TennisTable(tennisRules.Object);
            tennisTable.PlayerStart("player1", "player2");
            tennisTable.WonPoint("player1");
            tennisTable.WonPoint("player1");
            tennisTable.WonPoint("player1");

            tennisTable.getFinalResult();

            tennisRules.Verify(t => t.actualScore(It.IsAny<int>(),It.IsAny<int>()),Times.Once);
        }
    }
}
