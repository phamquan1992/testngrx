import { Component, OnInit } from '@angular/core';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { baidang } from '../models/baidang';
import { FECTH_BAIDANG, GET_BAIDANG_OBJ } from '../state/actions/baidang.action';
import { AppState } from '../state/app.state';

@Component({
  selector: 'app-baidang',
  templateUrl: './baidang.component.html',
  styleUrls: ['./baidang.component.css']
})
export class BaidangComponent implements OnInit {

  constructor(private store: Store<AppState>) { }
  listbaidang!: Observable<baidang[]>;
  obj_bd!: baidang;
  ngOnInit(): void {
    this.store.dispatch(FECTH_BAIDANG());
    this.listbaidang = this.store.select(store => store.baidang.list);
  }
  ShowObj(id: number) {
    var link = 'api/baidang/' + id;
    this.store.dispatch(GET_BAIDANG_OBJ({ url: link }));
    this.store.select(store => store.baidang.obj_baidang).subscribe((t: any) => this.obj_bd = t);
    console.log(this.obj_bd);
  }
}
