import { APIDto } from '../Interfaces/apiDto';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Purchase } from '../Interfaces/purchase';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ServiceDtodataService {

  private apiUrl = environment.APIPath;

  constructor(private http: HttpClient) { }


getPurchases(): Observable<APIDto>{
  return this.http.get<APIDto>(this.apiUrl+ '/Purchase');

}

getPurchase(): Observable<Purchase>{
 return this.http.get<Purchase>(this.apiUrl +'/Purchase/1');
}

createPurchase(purchase: Purchase): Observable<Purchase>{
 console.log(purchase);
 return this.http.post<Purchase>(this.apiUrl+'/Purchase',purchase);
}

updatePurchase(purchase: Purchase): Observable<Purchase>{
 return this.http.put<Purchase>(`${this.apiUrl}/Purchase/${purchase.id}`,purchase);
}

patchPurchase(purchase: Purchase): Observable<Purchase>{
 return this.http.patch<Purchase>(`${this.apiUrl}/Purchase/${purchase.id}`,purchase);
}

deletePurchase(id: number): Observable<void>{
 return this.http.delete<void>(`${this.apiUrl}/Purchase/${id}`);
}

/*private transformToICurrentWeather(data:APIDto): Purchase {



  return {




    modifiedBy: "",
    modifiedDate: "",
    modifiedWorkStation: "",
    id: 0,
    refDate: "",
    supplier: "",
    invoiceNo: "",
    otherRefNo: "",
    purchaseDts:

  }
}*/


}
