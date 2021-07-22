import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { BookDetailComponent } from "./pages/book-detail/book-detail.component";
import { BooksListComponent } from "./pages/books-list/books-list.component";

const routes: Routes = [
  {
    path: "",
    component: BooksListComponent,
  },
  {
    path: "detail",
    component: BookDetailComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class BooksRoutingModule {}
