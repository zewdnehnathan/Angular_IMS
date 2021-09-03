import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LogincomponentComponent } from './login/logincomponent/logincomponent.component';
import { PurchasecomponentComponent } from './purchase/purchasecomponent/purchasecomponent.component';
import { SidenavComponent } from './sidenav/sidenav/sidenav.component';
import { RouterModule } from '@angular/router';
import { PurchaseDtcomponentComponent } from './purchase-dtcomponent/purchase-dtcomponent.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    LogincomponentComponent,
    PurchasecomponentComponent,
    SidenavComponent,
    PurchaseDtcomponentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule   
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
