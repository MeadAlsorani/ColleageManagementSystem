import { AddAnnouncementComponent } from './add-announcement/add-announcement.component';
import { Routes, RouterModule } from '@angular/router';
import { AnnouncementsListComponent } from './announcements-list/announcements-list.component';

const routes: Routes = [
  { path: '', redirectTo: 'list' },
  { path: 'list', component: AnnouncementsListComponent },
  { path: 'add', component: AddAnnouncementComponent },
];

export const AnnouncementRoutes = RouterModule.forChild(routes);
