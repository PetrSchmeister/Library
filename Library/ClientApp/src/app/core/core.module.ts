import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { SharedModule } from "../shared/shared.module";
import { NavMenuComponent } from "./components/nav-menu/nav-menu.component";

@NgModule({
  declarations: [NavMenuComponent],
  imports: [SharedModule],
  exports: [NavMenuComponent],
})
export class CoreModule {}
