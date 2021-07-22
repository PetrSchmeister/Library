import { Component, OnInit } from "@angular/core";
import { BooksService } from "src/app/core/services/books/books.service";

@Component({
  templateUrl: "./books-list.component.html",
  styleUrls: ["./books-list.component.css"],
})
export class BooksListComponent implements OnInit {
  constructor(public booksService: BooksService) {}

  ngOnInit() {
    this.booksService.loadBooks();
  }
}
