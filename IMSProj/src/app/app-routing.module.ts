import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { LogincomponentComponent } from './login/logincomponent/logincomponent.component';
import { NgModule } from '@angular/core';
import { PurchaseDtcomponentComponent } from './purchase-dtcomponent/purchase-dtcomponent.component';
import { SidenavComponent } from './sidenav/sidenav/sidenav.component';

const routes: Routes = [

  {
    path:'home',
    component:SidenavComponent
  },
  {
    path:'login',
    component:LogincomponentComponent
  },
  {
    path:'home',
    component:SidenavComponent
  },
  {
    path:'Purchase',
    component:PurchaseDtcomponentComponent
  }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes),
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
