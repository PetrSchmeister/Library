import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { BehaviorSubject } from "rxjs";
import { Change } from "src/app/shared/models/change";

@Injectable({
  providedIn: "root",
})
export class ChangesService {
  private changesSubject = new BehaviorSubject<Change[]>([]);

  public changes$ = this.changesSubject.asObservable();

  constructor(
    private http: HttpClient,
    @Inject("BASE_URL") private baseUrl: string
  ) {}

  public loadChanges(): void {
    this.http.get<Change[]>(this.baseUrl + "api/changes").subscribe(
      (result) => {
        this.changesSubject.next(result);
      },
      (error) => console.error(error)
    );
  }
}
