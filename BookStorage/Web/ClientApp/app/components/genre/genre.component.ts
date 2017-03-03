import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'genre',
    template: require('./genre.component.html')
})
export class GenreComponent {
    public genres: Genre[];
    public http: Http;

    constructor(http: Http) {
        this.http = http;
        http.get('/api/Genre/GetAll').subscribe(result => {
            this.genres = result.json();
        });
    }

    deleteGenre(genreId: number) {
        this.http.delete('/api/Genre/Delete/' + genreId).subscribe(isDeleted => {
            if (isDeleted) {
                this.genres = this.genres.filter((item) => item.id !== genreId);
            }
        });
    }
}

interface Genre {
    id: number;
    name: string;
}
