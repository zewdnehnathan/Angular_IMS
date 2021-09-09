import { APP_ID, Component, OnDestroy, OnInit } from '@angular/core';
import { Subscriber, Subscription, pipe } from 'rxjs';
import { map, toArray } from 'rxjs/operators';

import { APIDto } from '../Interfaces/apiDto';
import { Purchase } from '../Interfaces/purchase';
import { PurchaseDt } from '../Interfaces/purchaseDt';
import { ServiceDtodataService } from '../services/service-dtodata.service';

@Component({
  selector: 'app-purchase-dtcomponent',
  templateUrl: './purchase-dtcomponent.component.html',
  styleUrls: ['./purchase-dtcomponent.component.css']
})
export class PurchaseDtcomponentComponent implements OnInit,OnDestroy {

  res!: APIDto | null;
   subscription: Subscription = new Subscription;

  holdIt: string = "";
  //To Be Done Today
  dtoforPurchase: APIDto | undefined;

  usersForTable: Purchase[]=[];
  invoiceNumber : string ="Inv-00001";
  supplier: string ="Excellerent";
  otherRefNo : string= "OT-0001";
  refDate : string= "06/09/2021";
  store: string = "Gergi";
  item: string = "Raw Material 1";
  qty:number = 5;
  unitPrice:number = 500;
  newPurchase:Purchase;
  newPurchaseDt:PurchaseDt[];

  constructor(private dataservice:ServiceDtodataService/*DataService*/) {
    this.newPurchaseDt = [{
      createdBy: "stringFromAng",
      createdDate: "2021-09-07T13:27:54.858Z",
      createdWorkstation: "stringFromAng",
      modifiedBy: "stringFromAng",
      modifiedDate: "2021-09-07T13:27:54.858Z",
      modifiedWorkstation: "stringFromAng",
      id: 0,
      purchaseid: 0,
      storeCode: "stringFromAng",
      itemCode: "stringFromAng",
      qty: 0,
      unitPrice: 0,
      totalPrice: 0 }]

    this.newPurchase = { invoiceNo : this.invoiceNumber, supplier:this.supplier,otherRefNo:this.otherRefNo,refDate:this.refDate,
     modifiedBy: "",modifiedDate:"",modifiedWorkStation: "",id:0,
     purchaseDts: this.newPurchaseDt
    }

    this.dtoforPurchase = { data : [], message: "", isSuccess : false}
   }
  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }

  ngOnInit(): void {
    this.onGetPurchases();

  }

  onGetPurchases(): void{
    this.subscription = this.dataservice.getPurchases().subscribe(
      response=>this.fillItBae(response.data)

       );
  }

  fillItBae(data:any):void{
    console.log(data);
    this.usersForTable = data;

  }

  onSaveItem():void{

    this.newPurchaseDt = [{
      createdBy: "xxx",
      createdDate: "2021-09-07T13:27:54.858Z",
      createdWorkstation: "xxx",
      modifiedBy: "xxx",
      modifiedDate: "2021-09-07T13:27:54.858Z",
      modifiedWorkstation: "xxx",
      id: 0,
      purchaseid: 0,
      storeCode: this.store,
      itemCode: this.item,
      qty: this.qty,
      unitPrice: this.unitPrice,
      totalPrice: this.qty*this.unitPrice }]

    this.newPurchase = { id:0,invoiceNo : this.invoiceNumber, supplier:this.supplier,otherRefNo:this.otherRefNo,refDate:"2021-09-07T13:27:54.858Z",
      modifiedBy: "xxx",modifiedDate:"2021-09-07T13:27:54.858Z",modifiedWorkStation: "xxx",
      purchaseDts:this.newPurchaseDt

    }
    //console.log(this.newPurchase);
    this.dataservice.createPurchase(this.newPurchase).subscribe(
      (response) =>
      this.onGetPurchases(),
      (error) => console.log(error)

    );
  }

}
