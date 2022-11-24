namespace Utilities {
    public static class Input {
        /// <summary>
        /// Identico a Console.WriteLine, ma richiede un messaggio da mostrare allo stdout.
        /// </summary>
        /// <param name="messaggio">Messaggio mostrato sullo stdout</param>
        /// <returns></returns>
        public static string? InputConMessaggio(string messaggio) {
            Console.WriteLine(messaggio);
            string? input = Console.ReadLine();
            return input;
        }
        /// <summary>
        /// Simile a InputConMessaggio, però chiede anche una conferma all'utente
        /// </summary>
        /// <param name="messaggio"></param>
        /// <returns></returns>
        public static string? InputConConferma(string messaggio) {
            string? conferma;
            string? input;
            do {
                input = InputConMessaggio(messaggio);
                Console.WriteLine($"Hai inserito {input}, confermi? y/n: ");
                conferma = Console.ReadLine();
            } while (conferma != "y");
            return input;
        }

        /// <summary>
        /// Ritorna la scelta di un utente tra true e false, con messaggio
        /// </summary>
        /// <param name="messaggio">Messaggio da mostrare all'utente</param>
        /// <returns>"true" se l'utente ha detto si, altrimenti "false".</returns>
        public static bool ChiediConferma(string messaggio) {
            string? conferma;
            do {
                Console.WriteLine(messaggio);
                Console.WriteLine(@"Inserisci ""y"" o ""n"" per scegliere: ");
                conferma = Console.ReadLine()?.ToLower();
            } while (!(conferma == "y" || conferma == "n"));
            return conferma == "y";
        }
    }

    public static class ArrayExtensions {
        /// <summary>
        /// Stampa l'array di stringhe allo Standard Output
        /// </summary>
        /// <param name="arrayDiStringhe"></param>
        public static void Stampa(this string[] arrayDiStringhe) {
            Console.Write("[ ");
            for (int i = 0; i < arrayDiStringhe.Length; i++) {
                string stringa = arrayDiStringhe[i];
                if (i == arrayDiStringhe.Length - 1) {
                    Console.Write($"\"{stringa}\" ");
                }
                else {
                    Console.Write($"\"{stringa}\", ");
                }
            }
            Console.Write("]\n");
        }

        /// <summary>
        /// Stampa l'array di numeri allo Standard output
        /// </summary>
        /// <param name="arrayDiNumeri"></param>
        public static void StampaArrayInteri(this int[] arrayDiNumeri) {
            Console.Write("[ ");
            for (int i = 0; i < arrayDiNumeri.Length; i++) {
                int numero = arrayDiNumeri[i];
                if (i == arrayDiNumeri.Length - 1) {
                    Console.Write($"{numero} ");
                }
                else {
                    Console.Write($"{numero}, ");
                }
            }
            Console.Write("]\n");
        }

        public static int[] ElevaArrayAlQuadrato(this int[] arrayDiNumeri) {
            throw new NotImplementedException();
        }
    }
}
