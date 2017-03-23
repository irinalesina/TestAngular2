import {GenresViewAllComponent} from "./view-all/genres.view-all.component";
import {GenresEditComponent} from "./edit/genres.edit.component";


export const routes = [
  {
      path: '', children: [
        { path: '', component: GenresViewAllComponent },
        { path: 'edit/:id', component: GenresEditComponent },
        { path: 'new', component: GenresEditComponent }
  ]},
];
