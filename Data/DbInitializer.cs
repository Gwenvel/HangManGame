

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
            if (!context.Hang.Any()) {
                AddImages(context);
            }
            if (!context.Letters.Any()) {
                AddLetters(context);
            }
            if (!context.Line.Any()) {
                AddLine(context);
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
        public static void AddImages(HangManContext context) {
            var images = new List<Hang> {            
                new Hang{HangId=1, HangMan="/images/start.png"},
                new Hang{HangId=2, HangMan="/images/one.png"},
                new Hang{HangId=3, HangMan="/images/two.png"},
                new Hang{HangId=4, HangMan="/images/three.png"},
                new Hang{HangId=5, HangMan="/images/four.png"},
                new Hang{HangId=6, HangMan="/images/five.png"},
                new Hang{HangId=7, HangMan="/images/lastChance.png"},
                new Hang{HangId=8, HangMan="/images/gameOver.png"}
            };

            foreach (var image in images)
            {
                context.Add(image);
            }
            context.SaveChanges();
        }
        public static void AddLetters(HangManContext context) {
            var letters = new List<Letters> {
                new Letters{LettersId=1, Letter="/images/a.png"},
                new Letters{LettersId=2, Letter="/images/b.png"},
                new Letters{LettersId=3, Letter="/images/c.png"},
                new Letters{LettersId=4, Letter="/images/d.png"},
                new Letters{LettersId=5, Letter="/images/e.png"},
                new Letters{LettersId=6, Letter="/images/f.png"},
                new Letters{LettersId=7, Letter="/images/g.png"},
                new Letters{LettersId=8, Letter="/images/h.png"},
                new Letters{LettersId=9, Letter="/images/i.png"},
                new Letters{LettersId=10, Letter="/images/j.png"},
                new Letters{LettersId=11, Letter="/images/k.png"},
                new Letters{LettersId=12, Letter="/images/l.png"},
                new Letters{LettersId=13, Letter="/images/m.png"},
                new Letters{LettersId=14, Letter="/images/n.png"},
                new Letters{LettersId=15, Letter="/images/o.png"},
                new Letters{LettersId=16, Letter="/images/p.png"},
                new Letters{LettersId=17, Letter="/images/q.png"},
                new Letters{LettersId=18, Letter="/images/r.png"},
                new Letters{LettersId=19, Letter="/images/s.png"},
                new Letters{LettersId=20, Letter="/images/t.png"},
                new Letters{LettersId=21, Letter="/images/u.png"},
                new Letters{LettersId=22, Letter="/images/v.png"},
                new Letters{LettersId=23, Letter="/images/w.png"},
                new Letters{LettersId=24, Letter="/images/x.png"},
                new Letters{LettersId=25, Letter="/images/y.png"},
                new Letters{LettersId=26, Letter="/images/z.png"}
            };
            foreach (var letter in letters)
            {
                context.Add(letter);
            }
            context.SaveChanges();
        }
        public static void AddLine(HangManContext context) {
            var line = new Line();
             

            line.LineId=1;
            line.Pic="/images/line.png";
            

            context.Add(line);

            context.SaveChanges();
        }
    }
    
}