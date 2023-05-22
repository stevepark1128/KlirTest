import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from './order/models/Product';
import { Order } from './order/models/Order';
import { of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      'Access-Control-Allow-Headers': 'Content-Type',
      'Access-Control-Allow-Methods': 'POST',
      "Access-Control-Allow-Origin": "*"
    })
  };
  
  constructor(private httpClient: HttpClient) { }

  getProduct() {
    return this.httpClient.get<Product[]>(`http://localhost:5000/api/Product/ProductList`);
  }

  checkoutOrder(products: Product[]) {
    return this.httpClient.post<Order[]>(`http://localhost:5000/api/Order/OrderCheckoutList`, products, this.httpOptions);
  }
}
