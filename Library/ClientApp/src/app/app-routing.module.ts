import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { HomeComponent } from "./home/home.component";

const routes: Routes = [
  { path: "", component: HomeComponent, pathMatch: "full" },
  {
    path: "books",
    loadChildren: () =>
      import("./featured/books/books.module").then((m) => m.BooksModule),
  },
  {
    path: "changes",
    loadChildren: () =>
      import("./featured/changes/changes.module").then((m) => m.ChangesModule),
  },
  // { path: '**', component: NotFoundComponent }, // Wildcard route for a 404 page
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, {
      onSameUrlNavigation: "reload",
      relativeLinkResolution: "legacy",
    }),
  ],
  exports: [RouterModule],
})
export class AppRoutingModule {}
