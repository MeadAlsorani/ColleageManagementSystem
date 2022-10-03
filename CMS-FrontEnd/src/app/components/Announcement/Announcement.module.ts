import { AnnouncementsService } from './shared/announcements.service';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AnnouncementRoutes } from './announcement.routing';

@NgModule({
  imports: [CommonModule, AnnouncementRoutes],
  declarations: [],
  providers: [AnnouncementsService],
})
export class AnnouncementModule {}
