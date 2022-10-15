import { TranslateService } from '@ngx-translate/core';
import { Pipe, PipeTransform } from '@angular/core';
import * as moment from 'moment';
@Pipe({
  name: 'DateParser',
})
export class DateParserPipe implements PipeTransform {
  constructor(private translation: TranslateService) {}
  transform(value: any): any {
    if (typeof value == 'string') {
      const isValid = moment(value, true).isValid();
      const date = moment(value);
      return isValid
        ? date.format('yyyy-MM-DD')
        : this.translation.instant(value);
    } else {
      return value;
    }
  }
}
