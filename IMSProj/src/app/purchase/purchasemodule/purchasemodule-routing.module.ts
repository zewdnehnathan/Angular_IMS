import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PurchasecomponentComponent } from '../purchasecomponent/purchasecomponent.component';

const routes: Routes = [
  {
    path:'',
    component:PurchasecomponentComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PurchasemoduleRoutingModule { }
