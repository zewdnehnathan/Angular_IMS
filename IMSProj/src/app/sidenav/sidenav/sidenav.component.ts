import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/data.service';
import { APIDto } from 'src/app/Interfaces/apiDto';
import { Purchase } from 'src/app/Interfaces/purchase';


@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.css']
})
export class SidenavComponent implements OnInit {

  isSelected = "Nothing";
  usersForTable: Purchase[]=[];
  
  constructor(private dataservice:DataService) { }

  ngOnInit(): void {
  
  }

  onMenuSelected(selectedVal:string):void{
  this.isSelected=selectedVal;
  if(selectedVal === "Purchase"){
   this.onGetUsers();
  }
}
  onGetUsers(): void{
    this.dataservice.getPurchases().subscribe(
      (response) =>  this.usersForTable = response,
      (error) => console.log(error),
      () => this.fillItBae()
      
      
    );
  }
  fillItBae():void{
       console.log(" from fill it bae " +this.usersForTable.length);
  }


}
