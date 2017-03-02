import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'books',
    template: require('./book.component.html')
})
export class BookComponent {
    public books: Book[];

    constructor(http: Http) {
        http.get('/api/Book/GetAll').subscribe(result => {
            this.books = result.json();
        });
    }
}

interface Book {
    id: number;
    name: string;
    text: string;
    year: number;
    genres: any[];
}
