import { Component, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { HttpErrorResponse, HttpHeaderResponse, HttpResponse } from '@angular/common/http';

import { JwtService } from 'src/app/JwtService';
import { ServiceDtodataService } from 'src/app/services/service-dtodata.service';
import { Subscription } from 'rxjs';
import { user } from 'src/app/Interfaces/user';

@Component({
  selector: 'app-logincomponent',
  templateUrl: './logincomponent.component.html',
  styleUrls: ['./logincomponent.component.css']
})
export class LogincomponentComponent implements OnInit,OnDestroy {


 isLoggedUser:string="false";
 subscription: Subscription = new Subscription;

 constructor(private jwtService:JwtService,private data:ServiceDtodataService) { }

 ngOnInit() {
 // this.subscription = this.data.getMessage().subscribe(message => this.isLoggedUser = message)
}

ngOnDestroy() {
  this.subscription.unsubscribe();
}

  isLoggedIn():void{
    this.isLoggedUser= "true";
    //this.data.updateMessage(this.isLoggedUser);
    const uuser = {
    username : "admin",
    password : "admin"
    }
    console.log(uuser);
    this.subscription = this.data.createToken(uuser).subscribe(
      response => console.log(this.jwtService.DecodeToken(response))
      );
  }

}
