import {
  Component,
  OnInit
} from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'about',
  styles: [`
  `],
  template: `
    <h1>About</h1>
    <div>
      For hot module reloading run
      <pre>npm run start:hmr</pre>
    </div>
    <div>
    </div>
  `
})
export class AboutComponent implements OnInit {
  constructor(
    public route: ActivatedRoute
  ) {}

  public ngOnInit() { }
}
