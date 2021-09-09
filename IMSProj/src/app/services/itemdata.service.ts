import { APIDto } from '../Interfaces/apiDto';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ItemdataService {

  private apiUrl = environment.APIPath;

  constructor(private http: HttpClient) { }


  getItems(): Observable<APIDto>{
    return this.http.get<APIDto>(this.apiUrl+ '/Item');

  }



}
