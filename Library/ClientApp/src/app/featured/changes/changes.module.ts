import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { ChangesRoutingModule } from "./changes-routing.module";
import { ChangesListComponent } from "./pages/changes-list/changes-list.component";
import { SharedModule } from "src/app/shared/shared.module";

@NgModule({
  declarations: [ChangesListComponent],
  imports: [SharedModule, ChangesRoutingModule],
})
export class ChangesModule {}
