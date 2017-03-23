import {CommonModule} from '@angular/common';
import {FormsModule} from '@angular/forms';
import {NgModule} from '@angular/core';
import {RouterModule} from '@angular/router';

import {routes} from './genres.routes';
import {GenresViewAllComponent} from "./view-all/genres.view-all.component";
import {GenresEditComponent} from "./edit/genres.edit.component";
import {ApiService} from "../../shared/api.service";


@NgModule({
    declarations: [
        GenresViewAllComponent,
        GenresEditComponent
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
export class GenresModule {
    public static routes = routes;
}
