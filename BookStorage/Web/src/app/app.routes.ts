import { Routes } from '@angular/router';
import { NoContentComponent } from './no-content';
import {HomeComponent} from "./modules/home/home.component";
import {AboutComponent} from "./modules/about/about.component";


export const ROUTES: Routes = [
  { path: '',      component: HomeComponent },
  { path: 'home',  component: HomeComponent },
  { path: 'about', component: AboutComponent },
  { path: 'books', loadChildren: './modules/books#BooksModule'},
  { path: 'genres', loadChildren: './modules/genres#GenresModule'},
  { path: '**',    component: NoContentComponent },
];
