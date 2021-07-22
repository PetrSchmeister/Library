import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { HttpClientModule } from "@angular/common/http";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { RouterModule } from "@angular/router";
import { ChangePropertyNamePipe } from "./pipes/change-property-name/change-property-name.pipe";
import { ChangeBookNamePipe } from './pipes/change-book-name/change-book-name.pipe';

@NgModule({
  declarations: [ChangePropertyNamePipe, ChangeBookNamePipe],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule,
    HttpClientModule,
  ],
  exports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule,
    HttpClientModule,
    ChangePropertyNamePipe,
  ],
})
export class SharedModule {}
