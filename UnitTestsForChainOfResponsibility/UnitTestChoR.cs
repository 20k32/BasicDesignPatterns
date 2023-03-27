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
            string[] ukrainianServerSearchResultLower = ukrainianServer.SearchResults;

            Assert.AreEqual(ukrainianServerSearchResultLower.Length, ukrainianServerSearchResult.Length);

            for (int i = 0; i < ukrainianServerSearchResult.Length; i++)
            {
                Assert.AreEqual(ukrainianServerSearchResult[i], ukrainianServerSearchResultLower[i]);
            }
        }

        [TestMethod]
        public void DifferentInformationFromServers_Test()
        {
            AbstractServer ukrainianServer = new UkrainianServer(),
                           americanServer = new AmericanServer(),
                           russianServer = new RussianServer();

            string searchOption = "lorem ipsum";

            ukrainianServer.Search(searchOption);
            string[] ukrainianServerInformation = ukrainianServer.SearchResults;

            americanServer.Search(searchOption);
            string[] americanServerInformation = americanServer.SearchResults;

            russianServer.Search(searchOption);
            string[] russianServerInformation = russianServer.SearchResults;

            int currentLength = ukrainianServerInformation.Length;
            if (americanServerInformation.Length < currentLength)
            {
                currentLength = americanServerInformation.Length;
            }
            if (russianServerInformation.Length < currentLength)
            {
                currentLength = russianServerInformation.Length;
            }

            for (int i = 0; i < currentLength; i++)
            {
                Assert.AreNotEqual(americanServerInformation[i], russianServerInformation[i]);
                Assert.AreNotEqual(russianServerInformation[i], ukrainianServerInformation[i]);
                Assert.AreNotEqual(americanServerInformation[i], ukrainianServerInformation[i]);
            }

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

        [TestMethod]
        public void InformationNotFounded_Test()
        {
            AbstractServer ukrainianServer = new UkrainianServer(),
                           americanServer = new AmericanServer(),
                           russianServer = new RussianServer();   

            string searchOption = "2345";
            ukrainianServer.Search(searchOption);
            americanServer.Search(searchOption);
            russianServer.Search(searchOption);

            string[] ukrainianServerInformation = ukrainianServer.SearchResults;
            string[] americanServerInformation = americanServer.SearchResults;
            string[] russianServerInformation = russianServer.SearchResults;

            Assert.AreEqual(0, ukrainianServerInformation.Length);
            Assert.AreEqual(0, americanServerInformation.Length);
            Assert.AreEqual(0, russianServerInformation.Length);
        }
    }
}