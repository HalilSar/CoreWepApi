import { Injectable } from '@angular/core';
import { Sehir } from '../_Model/sehir';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

type NewType = string;

@Injectable({
  providedIn: 'root'
})
export class SehirService {
baseUrl: NewType = 'http://localhost:3624';


constructor(private http: HttpClient) { }
getSehirler(): Observable<Sehir[]> {

  return this.http.get<Sehir[]>( this.baseUrl + '/Sehir/GetSehirler');
}
}
