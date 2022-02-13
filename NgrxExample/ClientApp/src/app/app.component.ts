import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  out_class: boolean = false;
  title = 'ClientApp';
  clickout() {
    this.out_class = false;
  }
  clickIn() {
    this.out_class = !this.out_class;
  }
}
