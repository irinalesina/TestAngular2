import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { routes } from './books.routes';
import { BooksGridComponent } from './grid/books.grid.component';


@NgModule({
  declarations: [
    BooksGridComponent,
  ],
  imports: [
    CommonModule,
    FormsModule,
    RouterModule.forChild(routes),
  ],
})

export class BooksModule {
  public static routes = routes;
}
