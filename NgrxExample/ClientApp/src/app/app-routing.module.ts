import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BaidangComponent } from './baidang/baidang.component';
import { ChuyenmucComponent } from './chuyenmuc/chuyenmuc.component';
import { TaikhoanComponent } from './taikhoan/taikhoan.component';
import { TheloaiComponent } from './theloai/theloai.component';
import { TrangchuComponent } from './trangchu/trangchu.component';

const routes: Routes = [
  { path: 'home', component: TrangchuComponent },
  { path: 'the-loai', component: TheloaiComponent },
  { path: 'chuyen-muc', component: ChuyenmucComponent },
  { path: 'tai-khoan', component: TaikhoanComponent },
  { path: 'bai-dang', component: BaidangComponent },
  { path: '', redirectTo: 'home', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
