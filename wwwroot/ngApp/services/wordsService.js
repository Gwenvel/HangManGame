class WordsService {
    constructor($resource) {
        this.gamewords = $resource("/api/words/:id");
        this.gamepics = $resource("/api/hang/:id");
        this.letters = $resource("/api/letters/:id");
        this.line = $resource("/api/line");

    }
    getWords() {
        return this.gamewords.query();
    }
    getWord(id) { 
        return this.gamewords.get({id: id});
    }
    getPics() {
        return this.gamepics.query();
    }
    getLetters() {
        return this.letters.query();
    }
    getLine() {
        return this.line.query();
    }
}