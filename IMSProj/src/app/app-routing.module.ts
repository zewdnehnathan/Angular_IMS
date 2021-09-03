import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path:'',
    loadChildren: () => import('./app.module').then(m => m.AppModule)
  },
  {
    path:'home',
    loadChildren: () => import('./app.module').then(m => m.AppModule)
  },
  { 
    path:'login',
    loadChildren: () => import('./login/loginmodule/loginmodule.module').then(m => m.LoginmoduleModule)
  },
  {
    path:'purchase',
    loadChildren: () => import('./purchase/purchasemodule/purchasemodule.module').then(m => m.PurchasemoduleModule)
  } 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
