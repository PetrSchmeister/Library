import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { BooksRoutingModule } from "./books-routing.module";
import { BooksListComponent } from "./pages/books-list/books-list.component";
import { BookDetailComponent } from "./pages/book-detail/book-detail.component";
import { SharedModule } from "src/app/shared/shared.module";

@NgModule({
  declarations: [BooksListComponent, BookDetailComponent],
  imports: [SharedModule, BooksRoutingModule],
})
export class BooksModule {}
