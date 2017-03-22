import { Routes } from '@angular/router';
import { HomeComponent } from './home';
import { AboutComponent } from './about';
import { NoContentComponent } from './no-content';


export const ROUTES: Routes = [
  { path: '',      component: HomeComponent },
  { path: 'home',  component: HomeComponent },
  { path: 'about', component: AboutComponent },
  { path: 'books', loadChildren: './books#BooksModule'},
  { path: 'genres', loadChildren: './genres#GenresModule'},
  { path: '**',    component: NoContentComponent },
];
