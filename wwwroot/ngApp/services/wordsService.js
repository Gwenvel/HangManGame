class WordsService {
    constructor($resource) {
        this.gamewords = $resource("/api/words/:id");
    }
    getWords() {
        return this.gamewords.query();
    }
}