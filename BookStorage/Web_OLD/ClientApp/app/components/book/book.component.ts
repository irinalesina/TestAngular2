import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'books',
    template: require('./book.component.html')
})
export class BookComponent {
    public books: Book[];
    public http: Http;

    constructor(http: Http) {
        this.http = http;
        http.get('/api/Book/GetAll').subscribe(result => {
            this.books = result.json();
        });
    }

    deleteBook(bookId: number) {
        this.http.delete('/api/Book/Delete/' + bookId).subscribe(isDeleted => {
            if (isDeleted) {
                this.books = this.books.filter((item) => item.id !== bookId);
            }
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
