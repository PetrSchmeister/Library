import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { ChangesListComponent } from "./pages/changes-list/changes-list.component";

const routes: Routes = [
  {
    path: "",
    component: ChangesListComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ChangesRoutingModule {}
