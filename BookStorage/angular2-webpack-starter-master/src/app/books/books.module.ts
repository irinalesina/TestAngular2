import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { routes } from './books.routes';
import {ApiService} from "../shared/api.service";
import {BooksViewAllComponent} from "./view-all/books.view-all.component";
import {BooksControlPanelComponent} from "./control-panel/books.control-panel.component";
import {BooksViewComponent} from "./view/books.view.component";


@NgModule({
  declarations: [
      BooksControlPanelComponent,
      BooksViewAllComponent,
      BooksViewComponent
  ],
  imports: [
      CommonModule,
      FormsModule,
      RouterModule.forChild(routes),
  ],
  providers: [
      ApiService
  ]
})

export class BooksModule {
  public static routes = routes;
}
