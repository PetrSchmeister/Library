import { Pipe, PipeTransform } from "@angular/core";
import { ChangedProperty } from "../../models/change";

@Pipe({
  name: "changePropertyName",
})
export class ChangePropertyNamePipe implements PipeTransform {
  transform(value: ChangedProperty, ...args: any[]): string {
    switch (value) {
      case ChangedProperty.title:
        return "Title";
      case ChangedProperty.description:
        return "Description";
      case ChangedProperty.publishedDate:
        return "Published Date";
      case ChangedProperty.authors:
        return "Authors";
    }
  }
}
