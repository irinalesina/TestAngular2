import { Component } from '@angular/core';
import { Http } from '@angular/http';
import {ApiService} from "../../shared/api.service";
import {Book} from "../book.model";


@Component({
    selector: 'view-all',
    template: require('./books.view-all.component.html')
})
export class BooksViewAllComponent {
    public books: Book[];

    constructor(private http: Http, private apiService: ApiService) {
      apiService.getAll('Book/GetAll').subscribe(result => {
            this.books = result.json();
        });
    }

    deleteBook(bookId: number) {
        this.apiService.delete('Book/Delete', bookId).subscribe(isDeleted => {
            if (isDeleted) {
                this.books = this.books.filter((item) => item.id !== bookId);
            }
        });
    }
}