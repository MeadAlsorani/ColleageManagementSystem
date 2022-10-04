import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'DateParser',
})
export class DateParserPipe implements PipeTransform {
  transform(value: any): any {
    if (typeof value == 'string') {
      const val = new Date(value).toLocaleString();
      return val !== 'Invalid Date' ? val : value;
    } else {
      return value;
    }
  }
}
