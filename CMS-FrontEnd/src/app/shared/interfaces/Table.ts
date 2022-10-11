export interface PaginationChangParams {
  previousPageIndex?: number;
  pageIndex: number;
  pageSize: number;
  length: number;
}
export interface Action {
  code: string;
  label: string;
  icon: string;
}
