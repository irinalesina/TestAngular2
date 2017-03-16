import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'books/view',
    template: require('./books.view.component.html')
})
export class BooksViewComponent {
    public book: Book;
    public http: Http;

    constructor(http: Http) {
        this.http = http;
        http.get('/api/Book/').subscribe(result => {
            this.book = result.json();
        });
    }
}

interface Book {
    id: number;
    name: string;
    text: string;
    year: number;
    genres: string[];
}
