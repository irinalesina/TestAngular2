import {CommonModule} from '@angular/common';
import {FormsModule} from '@angular/forms';
import {NgModule} from '@angular/core';
import {RouterModule} from '@angular/router';

import {routes} from './genres.routes';
import {ApiService} from "../shared/api.service";
import {GenresControlPanelComponent} from "./control-panel/genres.control-panel.component";
import {GenresViewAllComponent} from "./view-all/genres.view-all.component";
import {GenresEditComponent} from "./edit/genres.edit.component";


@NgModule({
    declarations: [
        GenresControlPanelComponent,
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
