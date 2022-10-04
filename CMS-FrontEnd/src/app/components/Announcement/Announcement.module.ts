import { AnnouncementsListComponent } from './announcements-list/announcements-list.component';
import { AnnouncementsService } from './shared/announcements.service';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AnnouncementRoutes } from './announcement.routing';
import { SharedModule } from 'src/app/shared/sharedModule.module';

@NgModule({
  imports: [CommonModule, AnnouncementRoutes,SharedModule],
  declarations: [AnnouncementsListComponent],
  providers: [AnnouncementsService],
})
export class AnnouncementModule {}
