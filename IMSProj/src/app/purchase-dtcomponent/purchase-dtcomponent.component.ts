import { APP_ID, Component, Input, OnDestroy, OnInit } from '@angular/core';
import { Subscriber, Subscription, pipe } from 'rxjs';
import { map, toArray } from 'rxjs/operators';

import { APIDto } from '../Interfaces/apiDto';
import { FormControl } from '@angular/forms';
import { Purchase } from '../Interfaces/purchase';
import { PurchaseDt } from '../Interfaces/purchaseDt';
import { ServiceDtodataService } from '../services/service-dtodata.service';
import { items } from '../Interfaces/items';

@Component({
  selector: 'app-purchase-dtcomponent',
  templateUrl: './purchase-dtcomponent.component.html',
  styleUrls: ['./purchase-dtcomponent.component.css']
})
export class PurchaseDtcomponentComponent implements OnInit,OnDestroy {

   subscription: Subscription = new Subscription;

  //To Be Done Today
  dtoforPurchase: APIDto | undefined;
  itemsForCombo: items[]=[];
  purchasesForTable: Purchase[]=[];
  invoiceNumber : string ="";
  supplier: string ="";
  otherRefNo : string= "";
  refDate : string= "2021-09-07T13:27:54.858";
  store: string = "Gerji Store";
  item: string = "";
  qty:number = 0;
  unitPrice:number = 0;
  newPurchase!: Purchase;
  newPurchaseDt!: PurchaseDt[];

  constructor(private dataservice:ServiceDtodataService/*DataService*/) {

   }
  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }

  ngOnInit(): void {
    this.onGetPurchases();
    this.onGetItems();

  }

  onGetItems():void{
    this.subscription = this.dataservice.getItem().subscribe(
      response => this.fillItemsNow(response.data)

    );
  }

  onGetPurchases(): void{
    this.subscription = this.dataservice.getPurchases().subscribe(
      response=>this.fillItBae(response.data)
       );
  }

  fillItemsNow(data:items[]):void{
    console.log(data);
    this.itemsForCombo = data;
  }

  fillItBae(data:Purchase[]):void{
    console.log(data);
    this.purchasesForTable = data;

  }

  onSaveItem():void{

    this.newPurchaseDt = [{
      createdBy:"",
      createdDate: "2021-09-07T13:27:54.858",
      createdWorkstation: "",
      modifiedBy: "",
      modifiedDate: "2021-09-07T13:27:54.858",
      modifiedWorkstation: "",
      id: 0,
      purchaseid: 0,
      storeCode: this.store,
      itemCode: this.item,
      qty: this.qty,
      unitPrice: this.unitPrice,
      totalPrice: this.qty*this.unitPrice }]

    this.newPurchase = { id:0,invoiceNo : this.invoiceNumber, supplier:this.supplier,otherRefNo:this.otherRefNo,
      refDate:this.refDate,modifiedBy: "",modifiedDate: "2021-09-07T13:27:54.858",modifiedWorkStation: "",
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
