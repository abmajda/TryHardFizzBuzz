import { Component, OnInit } from '@angular/core';
import { FizzBuzzConfiguration } from '../../_models/fizzBuzzConfiguration';
import { FizzBuzzService } from '../../_services/fizzBuzzService';

@Component({
  selector: 'app-selection',
  templateUrl: './selection.component.html',
  styleUrls: ['./selection.component.css']
})

export class SelectionComponent implements OnInit {
  public list: string[] = [];

  constructor(private fizzBuzzService: FizzBuzzService) { }

  ngOnInit(): void {
    const config: FizzBuzzConfiguration = {
      numberOfLines: 100,
      lineConfigurations: [
        {
          lineNumber: 3,
          word: "Fizz"
        },
        {
          lineNumber: 5,
          word: "Buzz"
        }
      ]
    }

    this.getResult(config)
  }

  getResult(config: FizzBuzzConfiguration) {
    this.fizzBuzzService.getResult(config).subscribe({
      next: response => this.list = response.results,
      error: error => console.log(error),
      complete: () => console.log("finished")
    })
  }
}
