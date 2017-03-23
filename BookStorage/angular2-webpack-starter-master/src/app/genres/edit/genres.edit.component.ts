import {Component} from "@angular/core";
import {Genre} from "../genre.model";
import {ApiService} from "../../shared/api.service";
import {ActivatedRoute, Router} from "@angular/router";


@Component({
    template: require('./genres.edit.component.html')
})
export class GenresEditComponent{
    public genre: Genre = new Genre();
    private genreId: number;
    public title: string;


    constructor(private apiService: ApiService, private route: ActivatedRoute, private router: Router) {
        this.genreId = route.snapshot.params['id'];
        console.log("genreId: ", this.genreId);
        if(this.genreId != undefined) {
            this.title = "Edit Genre";
            apiService.getById('Genre/GetById', this.genreId).subscribe(result => {
                this.genre = result.json();
            });
        }
        else{
            this.title = "Create Genre";
        }
    }


    public save(){
        if(this.genreId != undefined){
            this.apiService.update('Genre/Update', this.genre.id, this.genre).subscribe(result => {
                this.router.navigate(['./genres/view-all']);
            });
        }
        else{
            this.apiService.add('Genre/AddNew', this.genre).subscribe(result => {
                this.router.navigate(['./genres/view-all']);
            });
        }
    }
}