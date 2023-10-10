export interface FizzBuzzConfiguration {
  numberOfLines: number,
  lineConfigurations: FizzBuzzLineConfiguration[]
}

export interface FizzBuzzLineConfiguration {
  lineNumber: number,
  word: string
}
