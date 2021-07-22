export interface Change {
  id: number;
  bookId: number;
  property: ChangedProperty;
  value: string;
  timestamp: Date;
}

export enum ChangedProperty {
  title = 0,
  description,
  publishedDate,
  authors,
}
