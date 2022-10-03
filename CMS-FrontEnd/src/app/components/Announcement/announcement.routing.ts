import { Routes, RouterModule } from '@angular/router';
import { AnnouncementsListComponent } from './announcements-list/announcements-list.component';

const routes: Routes = [
  { path: '', redirectTo: 'list' },
  { path: 'list', component: AnnouncementsListComponent },
];

export const AnnouncementRoutes = RouterModule.forChild(routes);
