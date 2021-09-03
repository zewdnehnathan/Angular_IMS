import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';
import { Purchase } from '../Interfaces/purchase';

@Component({
  selector: 'app-purchase-dtcomponent',
  templateUrl: './purchase-dtcomponent.component.html',
  styleUrls: ['./purchase-dtcomponent.component.css']
})
export class PurchaseDtcomponentComponent implements OnInit {

  usersForTable: Purchase[]=[];

  constructor(private dataservice:DataService) { }

  ngOnInit(): void {
    this.onGetUsers();
  }

  onGetUsers(): void{
    this.dataservice.getUsers().subscribe(
      (response) =>  this.usersForTable = response,
      (error) => console.log(error),
      () => this.fillItBae()
      
      
    );
  }
  fillItBae():void{
       console.log(" from fill it bae " +this.usersForTable.length);
  }

}
