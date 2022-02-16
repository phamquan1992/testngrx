import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TrangchuComponent } from './trangchu/trangchu.component';
import { TheloaiComponent } from './theloai/theloai.component';
import { ChuyenmucComponent } from './chuyenmuc/chuyenmuc.component';
import { TaikhoanComponent } from './taikhoan/taikhoan.component';
import { LuotxemComponent } from './luotxem/luotxem.component';
import { BaidangComponent } from './baidang/baidang.component';
import { StoreModule } from '@ngrx/store';
import * as fromBaidang from 'src/app/state/reducers/baidang.reducer';
import { EffectsModule } from '@ngrx/effects';
import { BaidangEffect } from './state/effects/baidang.effect';
import {HttpClientModule} from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    TrangchuComponent,
    TheloaiComponent,
    ChuyenmucComponent,
    TaikhoanComponent,
    LuotxemComponent,
    BaidangComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    StoreModule.forRoot({baidang: fromBaidang.bdreducer}),
    EffectsModule.forRoot([BaidangEffect])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
