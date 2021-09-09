import { Injectable } from "@angular/core";
import { PurchaseDt } from "./purchaseDt";

export interface Purchase{


  modifiedBy: string
  modifiedDate: string
  modifiedWorkStation: string
  id: number
  refDate: string
  supplier: string
  invoiceNo: string
  otherRefNo: string
  purchaseDts: PurchaseDt[]
}
