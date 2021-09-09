import { Component, Input, OnDestroy, OnInit, Output } from '@angular/core';

import { Subscription } from 'rxjs';

@Component({
  selector: 'app-logincomponent',
  templateUrl: './logincomponent.component.html',
  styleUrls: ['./logincomponent.component.css']
})
export class LogincomponentComponent implements OnInit,OnDestroy {


 isLoggedUser:string="false";
 //subscription: Subscription = new Subscription;

 constructor() { }

 ngOnInit() {
  //this.subscription = this.data.getMessage().subscribe(message => this.isLoggedUser = message)
}

ngOnDestroy() {
 // this.subscription.unsubscribe();
}

  isLoggedIn():void{
    this.isLoggedUser= "true";
    //this.data.updateMessage(this.isLoggedUser);
  }

}
