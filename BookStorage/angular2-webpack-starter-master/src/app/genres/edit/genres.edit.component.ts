import {Component} from "@angular/core";
import {Genre} from "../genre.model";
import {ApiService} from "../../shared/api.service";
import {ActivatedRoute, Router} from "@angular/router";


@Component({
    selector: 'edit',
    template: require('./genres.edit.component.html')
})
export class GenresEditComponent{
    public genre: Genre;
    private genreId: number;
    public title: string;

    constructor(private apiService: ApiService, private route: ActivatedRoute, private router: Router) {
        this.genreId = route.snapshot.params['id'];

        if(this.genreId != 0) {
            this.title = "Edit Genre";
            apiService.getById('Genre/GetById', this.genreId).subscribe(result => {
                this.genre = result.json();
            });
        }
        else{
            this.title = "Create Genre";
            this.genre = new Genre();
        }
    }

    public save(){
        if(this.genreId != 0){

        }
        else{
            this.apiService.add('Genre/AddNew', this.genre).subscribe(result => {
                this.router.navigate(['../view-all']);
            });
        }
    }
}