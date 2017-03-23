import {Component} from "@angular/core";
import {Genre} from "../genre.model";
import {ActivatedRoute, Router} from "@angular/router";
import {ApiService} from "../../../shared/api.service";


@Component({
    template: require('./genres.edit.component.html')
})
export class GenresEditComponent {
    public genre: Genre = new Genre();
    private genreId: number;
    public title: string;


    constructor(private apiService: ApiService, private route: ActivatedRoute, private router: Router) {
    }

    ngOnInit() {
        this.genreId = this.route.snapshot.params['id'];
        if (this.genreId != undefined) {
            this.title = "Edit Genre";
            this.apiService.getById('Genre/GetById', this.genreId).subscribe(result => {
                this.genre = result.json();
            });
        }
        else {
            this.title = "Create Genre";
        }
    }


    public save() {
        if (this.genreId != undefined) {
            this.apiService.update('Genre/Update', this.genre.id, this.genre).subscribe(result => {
                this.router.navigate(['./genres']);
            });
        }
        else {
            this.apiService.add('Genre/AddNew', this.genre).subscribe(result => {
                this.router.navigate(['./genres']);
            });
        }
    }
}