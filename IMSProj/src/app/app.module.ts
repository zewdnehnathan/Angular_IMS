import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { JwtService } from './JwtService';
import { LogincomponentComponent } from './login/logincomponent/logincomponent.component';
import { NgModule } from '@angular/core';
import { PurchaseDtcomponentComponent } from './purchase-dtcomponent/purchase-dtcomponent.component';
import { RouterModule } from '@angular/router';
import { SidenavComponent } from './sidenav/sidenav/sidenav.component';

@NgModule({
  declarations: [
    AppComponent,
    LogincomponentComponent,
    SidenavComponent,
    PurchaseDtcomponentComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [JwtService],
  bootstrap: [AppComponent]
})
export class AppModule { }
