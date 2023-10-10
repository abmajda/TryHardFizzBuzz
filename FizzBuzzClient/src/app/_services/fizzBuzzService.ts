import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { FizzBuzzResponse } from "../_models/fizzBuzzResponse";
import { FizzBuzzConfiguration } from "../_models/fizzBuzzConfiguration";

@Injectable({
  providedIn: 'root'
})
export class FizzBuzzService {
  private url = 'https://localhost:7091/api/FizzBuzz';

  constructor(private http: HttpClient) { }

  getResult(configuration: FizzBuzzConfiguration) {
    return this.http.post<FizzBuzzResponse>(this.url, configuration);
  }
}
