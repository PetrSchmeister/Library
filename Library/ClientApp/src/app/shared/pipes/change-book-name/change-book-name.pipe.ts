import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'changeBookName'
})
export class ChangeBookNamePipe implements PipeTransform {

  transform(value: any, ...args: any[]): any {
    return null;
  }

}
