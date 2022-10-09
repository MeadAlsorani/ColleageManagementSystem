export interface AttendanceList {
  Date: Date;
  Type: string;
  Name: string;
}

export interface CreateAttendannce {
  Type: AttendanceType;
  Date: Date;
  StaffStudentId: number;
}

export enum AttendanceType {
  Student = 1,
  Staff,
}
