import {BooksViewAllComponent} from "./view-all/books.view-all.component";
import {BooksControlPanelComponent} from "./control-panel/books.control-panel.component";
import {BooksViewComponent} from "./view/books.view.component";


export const routes = [
  {
      path: '', children: [
          { path: '', component: BooksControlPanelComponent },
          { path: 'view-all', component: BooksViewAllComponent },
          { path: 'view/:id', component: BooksViewComponent }
  ]},
];
