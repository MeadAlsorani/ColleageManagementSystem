export interface FormField {
  label: string;
  code: string;
  type: FormFieldType;
  required: boolean;
  options?: DropdownOption[];
}
export enum FormFieldType {
  string = 0,
  number,
  date,
  dropdown,
  text,
}
export interface DropdownOption {
  code: string | number;
  label: string;
}
