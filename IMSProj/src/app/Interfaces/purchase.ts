import { PurchaseDt } from "./purchaseDt";

export interface Purchase{
    guid: number,
    createdBy: string,
    createdDate: string,
    createdWorkstation: string,
    modifiedBy: string,
    modifiedDate: string,
    modifiedWorkStation: string,
    id: 0,
    refDate: string,
    supplier: string,
    invoiceNo: string,
    otherRefNo: string,
    purchaseDts: PurchaseDt
}