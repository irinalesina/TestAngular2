import {OnInit, Component} from "@angular/core";


@Component({
    selector: 'books',
    templateUrl: 'books.control-panel.component.html'
})
export class BooksControlPanelComponent implements OnInit {
    public title = 'Books manager';

    constructor() {}

    public ngOnInit() { }

}
