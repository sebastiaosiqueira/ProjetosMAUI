
using AppjogoForca.Models;

namespace AppjogoForca.Repositories
{
    public class WordRepositories
    {
        private List<Word> _words;

        public WordRepositories() {
            _words = new List<Word>();
            _words.Add(new Word("Nome", "Maria".ToUpper()));
            _words.Add(new Word("Nome", "Aparecida".ToUpper()));
            _words.Add(new Word("Nome", "Emanuela".ToUpper()));
            _words.Add(new Word("Nome", "Kayon".ToUpper()));
            _words.Add(new Word("Fruta", "Maça".ToUpper()));
            _words.Add(new Word("Fruta", "Amora".ToUpper()));
            _words.Add(new Word("Fruta", "Abacate".ToUpper()));
            _words.Add(new Word("Fruta", "Abacaxi".ToUpper()));
            _words.Add(new Word("Vegetal", "Cenoura".ToUpper()));
            _words.Add(new Word("Vegetal", "Abobrinha".ToUpper()));
            _words.Add(new Word("Vegetal", "Salsinha".ToUpper()));
            _words.Add(new Word("Vegetal", "Alface".ToUpper()));
            _words.Add(new Word("Tempero", "Baiano".ToUpper()));
            _words.Add(new Word("Tempero", "Nordestino".ToUpper()));
            _words.Add(new Word("Tempero", "Carioca".ToUpper()));


        } 
        
        public Word GetWordRandom()
        {
            Random rand = new Random();
             var number =  rand.Next(0, _words.Count);

           return  _words[number];
        }
       
    }
}
