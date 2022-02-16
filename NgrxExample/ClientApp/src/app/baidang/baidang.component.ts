import { Component, OnInit } from '@angular/core';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { baidang } from '../models/baidang';
import { FECTH_BAIDANG } from '../state/actions/baidang.action';
import { AppState } from '../state/app.state';

@Component({
  selector: 'app-baidang',
  templateUrl: './baidang.component.html',
  styleUrls: ['./baidang.component.css']
})
export class BaidangComponent implements OnInit {

  constructor(private store: Store<AppState>) { }
  listbaidang!: Observable<baidang[]>;
  ngOnInit(): void {
    this.store.dispatch(FECTH_BAIDANG());
    this.listbaidang = this.store.select(store => store.baidang.list);
  }

}
