import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from '../MODEL/product.model';
import { APP_SETTINGS, AppSettings } from '../Config/app-settings';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  private apiBaseUrl: string;

  constructor(
    private http: HttpClient,
    @Inject(APP_SETTINGS) private settings: AppSettings
  ) {
    this.apiBaseUrl = settings.apiBaseUrl;
  }

  // Get all products
  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(`${this.apiBaseUrl}products`);
  }
}
