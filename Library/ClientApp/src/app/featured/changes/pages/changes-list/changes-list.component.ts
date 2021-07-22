import { Component, OnInit } from "@angular/core";
import { ChangesService } from "src/app/core/services/changes/changes.service";

@Component({
  templateUrl: "./changes-list.component.html",
  styleUrls: ["./changes-list.component.css"],
})
export class ChangesListComponent implements OnInit {
  constructor(public changesService: ChangesService) {}

  ngOnInit() {
    this.changesService.loadChanges();
  }
}
