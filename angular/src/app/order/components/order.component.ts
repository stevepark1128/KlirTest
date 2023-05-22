import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { Product } from '../models/Product';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { Order } from '../models/Order';
import { OrderService } from 'src/app/order.service';

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.scss']
})
export class OrderComponent implements AfterViewInit, OnInit {

  //Product list
  products: Product[] = [];
  //Order list on shopping cart
  orders: Product[] = [];
  //Checkout Order list after discount applied 
  checkoutOrders: any[] = [];

  displayedProductColumns: string[] = ['id', 'name', 'price', 'promotion', 'add'];
  displayedOrderColumns: string[] = ['id', 'name', 'price', 'quantity'];
  displayedCheckoutColumns: string[] = ['name', 'quantity' ,'price', 'total', 'promotion'];
  dataSource = new MatTableDataSource(this.products);
  dataSourceOrder = new MatTableDataSource(this.orders);
  dataSourceCheckout = new MatTableDataSource(this.checkoutOrders);
  @ViewChild(MatSort) sort: MatSort;
  
  constructor(
    private fb: FormBuilder,
    private router: Router,
    private orderService: OrderService
  ) {
  }
  
  ngOnInit(): void {
    this.orderService.getProduct().subscribe(x=> {
      this.products = x;
      this.dataSource = new MatTableDataSource(this.products);
    });
  }

  ngAfterViewInit(): void {
    this.dataSource.sort = this.sort;
  }

  //Add to shopping cart
  onAdd(id: number) {   
    let existOrder = this.orders.find(x=>x.id == id);
    if(existOrder && existOrder.quantity) {
      existOrder.quantity = existOrder.quantity + 1;
    } else {
      let newOrder = this.products.find(x=>x.id == id);
      if(newOrder) {
        newOrder.quantity = 1;
        this.orders.push(newOrder);
      }
    }

    this.dataSourceOrder.data = this.dataSourceOrder.data;
  }

  //Apply discount promotion and get the total 
  onCheckout() {
    this.orderService.checkoutOrder(this.orders).subscribe((x : any)=> {
      this.checkoutOrders = x;
      var total = 0;
      this.checkoutOrders.forEach(x=> total += x.total);
      this.checkoutOrders.push({name: 'Total', price: '', total: total, promotion: ''})
      this.dataSourceCheckout = new MatTableDataSource(this.checkoutOrders);
    });
  }

  //Clear shopping cart
  onDelete() {
    this.orders.splice(0);
    this.dataSourceOrder.data = this.dataSourceOrder.data;
  }
}
