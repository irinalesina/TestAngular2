import { BooksGridComponent } from './grid/books.grid.component';

export const routes = [
  { path: '', children: [
    { path: '', component: BooksGridComponent },
    // { path: 'child-detail', loadChildren: './+child-detail#ChildDetailModule' }
  ]},
];
