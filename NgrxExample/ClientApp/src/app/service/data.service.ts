import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  url!: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.url = baseUrl;
  }
  get(uri:string){
    return this.http.get(uri).pipe();
  }
  getbykey(uri:string){
    return this.http.get(uri).pipe();
  }
}
