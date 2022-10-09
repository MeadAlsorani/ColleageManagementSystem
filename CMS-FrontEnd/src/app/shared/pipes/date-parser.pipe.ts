import { TranslateService } from '@ngx-translate/core';
import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'DateParser',
})
export class DateParserPipe implements PipeTransform {
  constructor(private translation: TranslateService) {}
  transform(value: any): any {
    if (typeof value == 'string') {
      const val = new Date(value).toLocaleString();
      return val !== 'Invalid Date' ? val : this.translation.instant(value);
    } else {
      return value;
    }
  }
}
