/*
 * Angular 2 decorators and services
 */
import {
  Component,
  OnInit
} from '@angular/core';
import { AppState } from './app.service';


@Component({
  selector: 'app',
  styleUrls: [
    './app.component.css'
  ],
  templateUrl: './shared/layout/layout.component.html'
})
export class AppComponent implements OnInit {
  public name = 'Book storage';

  constructor(
    public appState: AppState
  ) {}

  public ngOnInit() { }

}
