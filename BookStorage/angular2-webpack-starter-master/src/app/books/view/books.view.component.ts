import { Component } from '@angular/core';
import {ApiService} from "../../shared/api.service";
import {ActivatedRoute, Params} from "@angular/router";
import {Book} from "../book.model";


@Component({
    selector: 'view',
    template: require('./books.view.component.html')
})
export class BooksViewComponent {
    public book: Book;
    private bookId: number;

    constructor(private apiService: ApiService, private route: ActivatedRoute) {
        this.bookId = route.snapshot.params['id'];
        apiService.getById('Book/GetById', this.bookId).subscribe(result => {
            this.book = result.json();
        });
    }
}
