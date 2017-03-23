import {BooksViewAllComponent} from "./view-all/books.view-all.component";
import {BooksControlPanelComponent} from "./control-panel/books.control-panel.component";
import {BooksEditComponent} from "./edit/books.edit.component";


export const routes = [
  {
      path: '', children: [
          { path: '', component: BooksControlPanelComponent },
          { path: 'view-all', component: BooksViewAllComponent },
          { path: 'new', component: BooksEditComponent },
          { path: 'edit/:id', component: BooksEditComponent }
  ]},
];
