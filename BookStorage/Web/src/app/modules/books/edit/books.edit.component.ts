import { Component } from '@angular/core';
import {ActivatedRoute, Router} from "@angular/router";
import {ApiService} from "../../../shared/api.service";
import {Book} from "../book.model";
import {Genre} from "../../genres/genre.model";


@Component({
    template: require('./books.edit.component.html')
})
export class BooksEditComponent {
    public title: string;
    public book: Book = new Book();
    private bookId: number;
    public genres: Genre[];


    constructor(private apiService: ApiService, private route: ActivatedRoute, private router: Router) {
    }

    ngOnInit() {
        this.bookId = this.route.snapshot.params['id'];

        if(this.bookId != undefined) {
            this.title = "Edit Book";
            this.apiService.getById('Book/GetById', this.bookId).subscribe(result => {
                this.book = result.json();
            });
        }
        else{
            this.title = "Create Book";
        }

        this.apiService.getAll('Genre/GetAll').subscribe(res => {
            this.genres = res.json();
            console.log("genres: ", this.genres);
        });
    }


    public save(){
        if(this.bookId != undefined){
            this.apiService.update('Book/Update', this.book.id, this.book).subscribe(result => {
                this.router.navigate(['./books']);
            });
        }
        else{
            this.apiService.add('Book/AddNew', this.book).subscribe(result => {
                this.router.navigate(['./books']);
            });
        }
    }
}
