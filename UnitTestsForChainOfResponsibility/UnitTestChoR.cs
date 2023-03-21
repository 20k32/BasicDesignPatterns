using ChainOfResponsibility_Servers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Printing;

namespace UnitTestsForChainOfResponsibility
{
    [TestClass]
    public class UnitTestChor
    {
        [TestMethod]
        public void UpplerLowerCaseSearchInformation_Test()
        {
            AbstractServer ukrainianServer = new UkrainianServer();

            ukrainianServer.Search("Lorem ipsum");
            string[] ukrainianServerSearchResult = ukrainianServer.SearchResults;
            ukrainianServer.Search("lorem ipsum");
            string[] ukrainianServerSearchResultLower = ukrainianServerSearchResult;

            Assert.AreEqual(ukrainianServerSearchResultLower, ukrainianServerSearchResult);
        }

        [TestMethod]
        public void DifferentInformationFromServers_Test()
        {
            AbstractServer ukrainianServer = new UkrainianServer(),
                           americanServer = new AmericanServer();

            string searchOption = "lorem ipsum";

            ukrainianServer.Search(searchOption);
            string[] ukrainianServerInformation = ukrainianServer.SearchResults;

            americanServer.Search(searchOption);
            string[] americanServerInformation = americanServer.SearchResults;

            Assert.AreNotEqual(ukrainianServerInformation, americanServerInformation);
        }

        [TestMethod]
        public void ActualInformationFromServer_Test()
        {
            AbstractServer ukrainianServer = new UkrainianServer(),
                           americanServer = new AmericanServer();

            string searchOption = "simply dummy text";

            ukrainianServer.Search(searchOption);
            string[] ukrainianServerInformation = ukrainianServer.SearchResults;

            americanServer.Search(searchOption);
            string[] americanServerInformation = americanServer.SearchResults;

            Assert.AreEqual(0, ukrainianServerInformation.Length);
            Assert.AreEqual(1, americanServerInformation.Length);
        }

        [TestMethod]
        public void ActualInformationFromAllServers_Test()
        {
            AbstractServer ukrainianServer = new UkrainianServer(),
                           americanServer = new AmericanServer(),
                           russianServer = new RussianServer();

            ukrainianServer.SetSuccessor(americanServer);
            americanServer.SetSuccessor(russianServer);

            string searchOption = "рыб";
            ukrainianServer.Search(searchOption);


            string[] ukrainianServerInformation = ukrainianServer.SearchResults;
            string[] americanServerInformation = americanServer.SearchResults;
            string[] russianServerInformation = russianServer.SearchResults;

            Assert.AreEqual(0, ukrainianServerInformation.Length);
            Assert.AreEqual(0, americanServerInformation.Length);
            Assert.AreEqual(2, russianServerInformation.Length);
        }
    }
}