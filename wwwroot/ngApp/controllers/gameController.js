class GameController {
    constructor($wordsService) {
        this.service = $wordsService;
        this.pics = $wordsService.getPics();
        this.words = $wordsService.getWords();
        console.log(this.words);
        this.letters = $wordsService.getLetters();

        // $wordsService.getLine().$promise.then((line) => {
        //     let l = line.data;
        //     console.log("in promise: " + l);
        //     this.line = l;
        // });
        // console.log(this.line);
        // this.word = "";
        // this.num = 0;


        this.rand = Math.floor(Math.random() * 12) + 1;

        $wordsService.getWord(this.rand).$promise.then((word) => {
            let play = word;
            console.log(play.word);
            this.newWord = play.word;
            // return play.word;
        });
        console.log("newPlay: " + this.newWord);
        // this.theWord();
        this.input = "";

    }

    theWord(word) {
        // this.word = word.toString();
        console.log("Length: " + word.length);
        this.num = word.length;
        console.log("newPlay in theWord: " + this.newWord);
        console.log("line: " + this.line);

        this.lines = [];

        for (let index = 0; index < word.length; index++) {
            this.lines.push(this.line);

        }
    }

    check() {
        switch (this.input.toLowerCase()) {
            case "a":
            
                break;
            case "b":

                break;
            case "c":

                break;
            case "d":

                break;
            case "e":

                break;
            case "f":

                break;
            case "g":

                break;
            case "h":

                break;
            case "i":

                break;
            case "j":

                break;
            case "k":

                break;
            case "l":

                break;
            case "m":

                break;
            case "n":

                break;
            case "o":

                break;
            case "p":

                break;
            case "q":

                break;
            case "r":

                break;
            case "s":

                break;
            case "t":

                break;
            case "u":

                break;
            case "v":

                break;
            case "w":

                break;
            case "x":

                break;
            case "y":

                break;
            case "z":

                break;
            default:
                break;
        }
    }



}