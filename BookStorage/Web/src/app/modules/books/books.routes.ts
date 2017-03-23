import {BooksViewAllComponent} from "./view-all/books.view-all.component";
import {BooksEditComponent} from "./edit/books.edit.component";


export const routes = [
  {
      path: '', children: [
          { path: '', component: BooksViewAllComponent },
          { path: 'new', component: BooksEditComponent },
          { path: 'edit/:id', component: BooksEditComponent }
  ]},
];
