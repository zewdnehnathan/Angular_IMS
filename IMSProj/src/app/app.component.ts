import { Component, Input, OnChanges, OnDestroy, OnInit, SimpleChanges } from '@angular/core';

import { Purchase } from './Interfaces/purchase';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit,OnDestroy{
  title = 'IMSProj';


  purchase!: Purchase;

  globalIsLoggedUser:string="false";

  constructor() {

  }

  isLoggedIn():void{
    this.globalIsLoggedUser="true";
  }

  ngOnInit() {
  }


  ngOnDestroy() {
  }

}
