import { Injectable } from '@angular/core';
import {HttpClient} from  '@angular/common/http';

import { Observable} from 'rxjs';

import { Purchase } from './Interfaces/purchase';
import {APIDto} from './Interfaces/apiDto'

@Injectable({
  providedIn: 'root'
})
export class DataService {

  private apiUrl = "https://localhost:44302/api";

  constructor(private http: HttpClient) {

   }

getUsers(): Observable<Purchase[]>{
     return this.http.get<Purchase[]>(this.apiUrl+ '/Purchase');
     /*.pipe(
       map(purchases=>purchases.map(purchases=>({
         ...purchases,
         invoiceNo: purchases.invoiceNo,
         otherRefNo: purchases.otherRefNo,
         refDate:purchases.refDate,
         purchaseDts: purchases.purchaseDts
         // isAdmin: user.id === 10? true:false //trying add custome column not working for me
       })))
     );*/
   }

  getUser(): Observable<Purchase>{ 
    return this.http.get<Purchase>(this.apiUrl +'/Purchase/1');
  }

  createUser(purchase: Purchase): Observable<Purchase>{
    return this.http.post<Purchase>(this.apiUrl+'/Purchase',purchase);
  }

  updateUser(purchase: Purchase): Observable<Purchase>{
    return this.http.put<Purchase>(`${this.apiUrl}/Purchase/${purchase.id}`,purchase);
  }

  patchUser(purchase: Purchase): Observable<Purchase>{
    return this.http.patch<Purchase>(`${this.apiUrl}/Purchase/${purchase.id}`,purchase);
  }

  deleteUser(id: number): Observable<void>{
    return this.http.delete<void>(`${this.apiUrl}/Purchase/${id}`);
  }




}
