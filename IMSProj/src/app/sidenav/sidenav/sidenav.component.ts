import { Component, OnInit } from '@angular/core';

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

  constructor() { }

  ngOnInit(): void {

  }

  onMenuSelected(selectedVal:string):void{
  this.isSelected=selectedVal;
  if(selectedVal === "Purchase"){

  }
}



}
