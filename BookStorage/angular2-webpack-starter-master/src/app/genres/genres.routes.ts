import {GenresControlPanelComponent} from "./control-panel/genres.control-panel.component";
import {GenresViewAllComponent} from "./view-all/genres.view-all.component";
import {GenresEditComponent} from "./edit/genres.edit.component";


export const routes = [
  {
      path: '', children: [
        { path: '', component: GenresControlPanelComponent },
        { path: 'view-all', component: GenresViewAllComponent },
        { path: 'edit/:id', component: GenresEditComponent }
  ]},
];
