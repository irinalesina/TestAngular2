import { Component } from '@angular/core';
import { Http } from '@angular/http';
import {ApiService} from "../../shared/api.service";
import {Genre} from "../genre.model";


@Component({
    selector: 'view-all',
    template: require('./genres.view-all.component.html')
})
export class GenresViewAllComponent {
    public genres: Genre[];

    constructor(private http: Http, private apiService: ApiService) {
        apiService.getAll('Genre/GetAll').subscribe(result => {
            this.genres = result.json();
        });
    }

    deleteGenre(genreId: number) {
        this.apiService.delete('Genre/Delete', genreId).subscribe(isDeleted => {
            if (isDeleted) {
                this.genres = this.genres.filter((item) => item.id !== genreId);
            }
        });
    }
}
