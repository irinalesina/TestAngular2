import {OnInit, Component} from "@angular/core";


@Component({
    selector: 'genres',
    templateUrl: 'genres.control-panel.component.html'
})
export class GenresControlPanelComponent implements OnInit {
    public title = 'Genres manager';

    constructor() {}

    public ngOnInit() { }

}
