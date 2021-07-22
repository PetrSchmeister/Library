import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { BehaviorSubject } from "rxjs";
import { Book } from "src/app/shared/models/book";

@Injectable({
  providedIn: "root",
})
export class BooksService {
  private booksSubject = new BehaviorSubject<Book[]>([]);

  public books$ = this.booksSubject.asObservable();

  constructor(
    private http: HttpClient,
    @Inject("BASE_URL") private baseUrl: string
  ) {}

  public loadBooks(): void {
    this.http.get<Book[]>(this.baseUrl + "api/books").subscribe(
      (result) => {
        this.booksSubject.next(result);
      },
      (error) => console.error(error)
    );
  }
}
