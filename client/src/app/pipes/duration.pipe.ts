import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'duration'
})
export class DurationPipe implements PipeTransform {
  transform(duration: number, args?: any): any {
    const minutes = Math.floor(duration / 60);
    const seconds = duration - minutes * 60;
    return `${minutes}m ${seconds}s`;
  }
}
