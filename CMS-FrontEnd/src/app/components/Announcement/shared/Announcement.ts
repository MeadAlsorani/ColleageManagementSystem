export interface AnnouncementList {
  Title: string;
  Date: Date;
  Type: AnnouncementType;
}

export enum AnnouncementType {
  Notice = 1,
  Event,
  Holiday,
}
