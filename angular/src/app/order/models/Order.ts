// Shopping cart/Checkout Order interface
export interface Order {
    productid?:number;
    name: string;
    price: number|string;
    promotion?: string;
    quantity?: number;
    total:number;
}