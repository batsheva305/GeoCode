import { Injectable } from '@angular/core';
import {HttpClient, HttpParams} from '@angular/common/http'
import { Observable } from 'rxjs';

import { Address } from '../models/address';

@Injectable({
  providedIn: 'root'
})
export class AddressService {

  API = 'https://localhost:5001/api';
  ADDRESS_API=`${this.API}/address`;
  
  data: Address;

  constructor(private http:HttpClient) { }

  getCoordinates(address:string): Observable<Address>{
    let params = new HttpParams();
    params = params.append('address', address);
    return this.http.get<Address>(`${this.ADDRESS_API}/coordinates`, {params: params}).pipe();
  }

  getPopularSearch(numberOfPopularSearches:number): Observable<Address[]>{
    let params = new HttpParams();
    params = params.append('numberOfPopularSearches', numberOfPopularSearches.toString());
    return this.http.get<Address[]>(`${this.ADDRESS_API}/popular-search`, {params: params}).pipe();
  }
}
