import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { OrderComponent } from './order/components/order.component';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { MzMaterialModule } from './material-module';
import { OrderService } from './order.service';

@NgModule({
  declarations: [
    AppComponent,
    OrderComponent
  ],
  imports: [
    CommonModule,
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MzMaterialModule
  ],
  providers: [OrderService],
  bootstrap: [AppComponent]
})
export class AppModule { }
