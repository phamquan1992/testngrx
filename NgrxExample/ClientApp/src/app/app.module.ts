import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TrangchuComponent } from './trangchu/trangchu.component';
import { TheloaiComponent } from './theloai/theloai.component';
import { ChuyenmucComponent } from './chuyenmuc/chuyenmuc.component';
import { TaikhoanComponent } from './taikhoan/taikhoan.component';
import { LuotxemComponent } from './luotxem/luotxem.component';

@NgModule({
  declarations: [
    AppComponent,
    TrangchuComponent,
    TheloaiComponent,
    ChuyenmucComponent,
    TaikhoanComponent,
    LuotxemComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
