using System;

namespace RepositoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // De class structuur van het project staat in Basic_Repository.mdj (StarUML diagram) [Folder ClassDiagrams]

            // Dit programma is slechts ter illustratie
            // hoe de structuur vaneen repository pattern eruit kan zien
            // Bekijk: FileController en doorloop vanaf daar de verschillende classes
            // in volgorde Repository/Interface context/Concrete Context
            File f = new File("An array of bytes that needs to be written to file...", "testFile");
            FileController fc = new FileController();
            
            // Zonder code aanpassingen kunnen we de context wijzigen, waardoor de repository ander gedrag
            // gaat vertonen. In dit geval een simpele output naar console output, die er anders uitziet            
            fc.changeContext(ContextType.USB);
            fc.addFile(f);

            // Nu voor netwerk, we activeren alleen een andere context via 'changeContext'
            fc.changeContext(ContextType.Netwerk);
            // De output op de console is nu anders
            fc.addFile(f);

            // Probeer nu zelf dit programma uit te breiden zodat de console output voor ContextType.Test en ContextType.SQL context 
            // actief wordt
            //fc.changeContext(ContextType.Test);
            //fc.addFile(f);
            // fc.changeContext(...)

            //BONUS: Kun je de Context classes zodanig aanpassen, zodat dubbele code in de classes (bijv. USBFileContext en NetwerkFileContext)
            // niet of nauwelijks meer voorkomt.
        }
    }
}
