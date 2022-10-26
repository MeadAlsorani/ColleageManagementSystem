export interface PaginationPayload {
  PageSize: number;
  PageIndex: number;
  Ascending: boolean;
  SortBy?: string;
  SearchStatement?: string;
}

export interface PaginationResponse {
  count: number;
  records: any[];
}
