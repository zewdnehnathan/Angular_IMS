import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PurchasecomponentComponent } from 'src/app/purchase/purchasecomponent/purchasecomponent.component';
import { SidenavComponent } from 'src/app/sidenav/sidenav/sidenav.component';
import { LogincomponentComponent } from '../logincomponent/logincomponent.component';

const routes: Routes = [
  {
    path:'',
    component:LogincomponentComponent
  },
  {
    path:'home',
    component:SidenavComponent
  } 

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LoginmoduleRoutingModule { }
