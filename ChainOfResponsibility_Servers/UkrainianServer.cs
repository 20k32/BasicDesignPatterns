using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibility_Servers
{
    public class UkrainianServer : AbstractServer
    {
        public UkrainianServer(AbstractServer Successor = null!) : base(Successor)
        {
            Information = new List<string>(new string[]
                {
                    "Lorem ipsum – назва класичного тексту-«риби».",
                    "«Риба» – слово з жаргону дизайнерів, що позначає умовний, часто безглуздий текст, що вставляється в макет сторінки.",
                    "Lorem ipsum являє собою спотворений уривок з філософського трактату Цицерона «Про межі добра і зла», написаного в 45 році до нашої ери латинською мовою.",
                    "Вперше цей текст був застосований для набору шрифтових зразків невідомим друкарем у XVI столітті."
                });
        }

        public override void Search(string searchOptions)
        {
            SearchResults =
                Information.Where(x => x.ToLower().Contains(searchOptions.ToLower()))
                           .ToArray();

            if (successor != null && SearchResults.Length ==  0)
            {
                successor.Search(searchOptions);
            }
        }

        public override void SetSuccessor(AbstractServer NewSuccessor)
        {
            successor = NewSuccessor;
        }
    }
}
