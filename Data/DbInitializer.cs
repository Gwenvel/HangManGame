

using System.Collections.Generic;
using System.Linq;
using HangMan.Models;

namespace HangMan.Data{
    public static class DbInitializer {
        public static void Initialize(HangManContext context) {
            context.Database.EnsureCreated();

            if (!context.Words.Any()) {
                AddWords(context);
            }
        }

        public static void AddWords(HangManContext context) {
            var words = new List<Words> {
                new Words{WordsId=1, Word="funk"},
                new Words{WordsId=2, Word="pizza"},
                new Words{WordsId=3, Word="time"},
                new Words{WordsId=4, Word="waldo"},
                new Words{WordsId=5, Word="steampunk"},
                new Words{WordsId=6, Word="coffee"},
                new Words{WordsId=7, Word="tea"},
                new Words{WordsId=8, Word="banana"},
                new Words{WordsId=9, Word="brazil"},
                new Words{WordsId=10, Word="sudoku"},
                new Words{WordsId=11, Word="book"},
                new Words{WordsId=12, Word="surrender"}
            };

            foreach (var word in words)
            {
                context.Words.Add(word);
            }
            context.SaveChanges();
        }
    }
    
}