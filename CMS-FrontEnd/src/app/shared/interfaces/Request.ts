export interface PaginationPayload {
  PageSize: number;
  PageIndex: number;
  Ascending: boolean;
  SortBy?: string;
}

export interface PaginationResponse {
  count: number;
  records: any[];
}
