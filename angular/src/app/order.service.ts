import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from './order/models/Product';
import { Order } from './order/models/Order';
import { of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class OrderService {
  
  constructor(private httpClient: HttpClient) { }

  getProduct() {
    return this.httpClient.get<Product[]>(`http://localhost:5000/api/Product/ProductList`);
  }

}
