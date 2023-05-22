import { Product } from "./Product";

export interface Order {
    productid:number;
    name: string;
    price: number;
    promotion?: string;
    quantity?: number;
    total:number;
}