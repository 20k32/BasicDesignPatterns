using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibility_Servers
{
    public class RussianServer : AbstractServer
    {
        public RussianServer(AbstractServer successor = null!) : base(successor)
        {
            Information = new List<string>(new string[]
                {
                    "Lorem Ipsum - это текст-\"рыба\", часто используемый в печати и вэб-дизайне.",
                    "Lorem Ipsum является стандартной \"рыбой\" для текстов на латинице с начала XVI века.",
                    "В то время некий безымянный печатник создал большую коллекцию размеров и форм шрифтов, используя Lorem Ipsum для распечатки образцов.",
                    "Lorem Ipsum не только успешно пережил без заметных изменений пять веков, но и перешагнул в электронный дизайн.",
                    "Его популяризации в новое время послужили публикация листов Letraset с образцами Lorem Ipsum в 60-х годах и, в более недавнее время, программы электронной вёрстки типа Aldus PageMaker, в шаблонах которых используется Lorem Ipsum."
                });
        }
        public override void Search(string searchOptions)
        {
            SearchResults =
                Information.Where(x => x.ToLower().Contains(searchOptions.ToLower()))
                           .ToArray();

            if (successor != null && SearchResults.Length == 0)
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
