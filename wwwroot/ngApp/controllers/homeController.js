class HomeController {
    constructor($state) {
        this.message = 'Lets Play';
        this.state = $state;
    }
    play() {
        this.state.go('hangman');
    }
}
