import { Component, Input, OnChanges, OnDestroy, OnInit, SimpleChanges } from '@angular/core';
import { Subscription } from 'rxjs';
import { DataService } from './data.service';
import { Purchase } from './Interfaces/purchase';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit,OnDestroy{
  title = 'IMSProj';


  purchase!: Purchase;
  
  globalIsLoggedUser:string="false";

  constructor(private dataservice: DataService) { 
    
  }

  isLoggedIn():void{
    this.globalIsLoggedUser="true";
  }

  ngOnInit() {
    //this.onGetUsers();
  }

   onGetUsers(): void{
    this.dataservice.getUsers().subscribe(
      (response) => console.log(response),
      (error) => console.log(error),
      () => console.log('Done getting users')
    );
  }
  ngOnDestroy() {
  }

}
