import { Component } from '@angular/core';
import {ApiService} from "../../shared/api.service";
import {ActivatedRoute, Router} from "@angular/router";
import {Book} from "../book.model";


@Component({
    template: require('./books.edit.component.html')
})
export class BooksEditComponent {
    public title: string;
    public book: Book;
    private bookId: number;


    constructor(private apiService: ApiService, private route: ActivatedRoute, private router: Router) {
        this.bookId = route.snapshot.params['id'];

        if(this.bookId != undefined) {
            this.title = "Edit Book";
            apiService.getById('Book/GetById', this.bookId).subscribe(result => {
                this.book = result.json();
            });
        }
        else{
            this.title = "Create Book";
        }
    }


    public save(){
        if(this.bookId != undefined){
            this.apiService.update('Book/Update', this.book.id, this.book).subscribe(result => {
                this.router.navigate(['./books/view-all']);
            });
        }
        else{
            this.apiService.add('Book/AddNew', this.book).subscribe(result => {
                this.router.navigate(['./books/view-all']);
            });
        }
    }
}
